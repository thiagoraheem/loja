using System;
using System.IO;
using System.Linq;
using System.Text;
using Loja.DAL.DAO;
using Loja.DAL.Models;
using NFe.Servicos;
using NFe.Classes;

namespace Loja.Modules
{
	public static class NfceSaidaAuditor
	{
		private static readonly object Sync = new object();
		private static readonly TimeSpan MinIntervaloAviso = TimeSpan.FromHours(4);
		private const int MaxAvisosPorDia = 2;

		public static string ReconciliarProcXmls(ConfiguracaoApp configuracoes)
		{
			if (configuracoes?.CfgServico == null)
				return string.Empty;

			var dir = configuracoes.CfgServico.DiretorioSalvarXml;
			if (string.IsNullOrWhiteSpace(dir) || !Directory.Exists(dir))
				return string.Empty;

			var arquivos = Directory.GetFiles(dir, "*-procNfe.xml", SearchOption.TopDirectoryOnly);
			if (arquivos.Length == 0)
				return string.Empty;

			var reconciliadas = 0;
			var arquivadas = 0;
			var erros = 0;
			var problemas = new StringBuilder();

			foreach (var arquivo in arquivos)
			{
				try
				{
					var proc = new nfeProc().CarregarDeArquivoXml(arquivo);
					if (proc?.NFe?.infNFe?.ide == null || proc.protNFe?.infProt == null)
						continue;

					var codVenda = proc.NFe.infNFe.ide.nNF.ToString();
					var chaveSefaz44 = proc.protNFe.infProt.chNFe;
					var chave = "NFe" + chaveSefaz44;
					var protocolo = proc.protNFe.infProt.nProt;
					var qtdItens = proc.NFe.infNFe.det != null ? proc.NFe.infNFe.det.Count : 0;
					var valorTotal = proc.NFe.infNFe.total?.ICMSTot?.vNF ?? 0m;
					var data = proc.NFe.infNFe.ide.dhEmi.DateTime;

					if (SaidaJaEstaCorreta(codVenda, chave, protocolo))
					{
						if (ArquivarProcXml(dir, arquivo, codVenda))
							arquivadas++;
						continue;
					}

					Cadastros.GarantirSaidaAutorizada(codVenda, data, valorTotal, qtdItens, chave, protocolo);
					reconciliadas++;

					if (ArquivarProcXml(dir, arquivo, codVenda))
						arquivadas++;
				}
				catch (Exception ex)
				{
					var chave = ExtrairChaveDoNomeArquivo(arquivo);
					if (!string.IsNullOrWhiteSpace(chave) && SaidaAutorizadaExistePorChave(chave))
					{
						if (ArquivarProcXml(dir, arquivo, chave))
							arquivadas++;
						continue;
					}

					if (!string.IsNullOrWhiteSpace(chave) && PodeConsultarSefaz(chave))
					{
						try
						{
							using (var servicoNFe = new ServicosNFe(configuracoes.CfgServico))
							{
								var ret = servicoNFe.NfeConsultaProtocolo(chave);
								var infProt = ret?.Retorno?.protNFe?.infProt;
								if (infProt != null && infProt.cStat == 100 && !string.IsNullOrWhiteSpace(infProt.nProt))
								{
									var codVenda = ExtrairNumeroDaChave(chave);
									if (!string.IsNullOrWhiteSpace(codVenda))
									{
										Cadastros.GarantirSaidaAutorizada(codVenda, DateTime.Now, 0m, 0, "NFe" + chave, infProt.nProt);
										if (ArquivarProcXml(dir, arquivo, codVenda))
											arquivadas++;
										NfceAuditLogger.Info("auditoria.sefaz_conciliada", codVenda, "A", "Conciliada por consulta SEFAZ após falha de leitura do PROC XML.");
										continue;
									}
								}
							}
						}
						catch (Exception exSefaz)
						{
							NfceAuditLogger.Error("auditoria.sefaz_erro", chave, null, exSefaz, "Falha ao consultar SEFAZ durante auditoria de PROC XML.");
						}
					}

					erros++;
					NfceAuditLogger.Error("auditoria.procxml_erro", Path.GetFileNameWithoutExtension(arquivo), null, ex, "Falha ao reconciliar PROC XML.");
					problemas.AppendLine($"- Erro ao reconciliar: {Path.GetFileName(arquivo)}");
				}
			}

			if (reconciliadas > 0)
				NfceAuditLogger.Info("auditoria.procxml_reconciliada", null, null, $"Reconciliadas={reconciliadas}; Arquivadas={arquivadas}; Erros={erros}");

			if (erros == 0)
				return string.Empty;

			if (!PodeNotificar("procxml-audit"))
				return string.Empty;

			var sb = new StringBuilder();
			sb.AppendLine($"Auditoria NFC-e: {erros} erro(s) ao reconciliar PROC XML.");
			sb.AppendLine("Verifique os logs fiscais e o diretório de XML.");
			sb.Append(problemas.ToString().Trim());

			return sb.ToString().Trim();
		}

		private static bool SaidaJaEstaCorreta(string codVenda, string chave, string protocolo)
		{
			if (string.IsNullOrWhiteSpace(codVenda))
				return false;

			using (var banco = new LojaContext())
			{
				var saida = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == codVenda);
				if (saida == null)
					return false;

				if (saida.FlgStatusNFE != "A")
					return false;

				if (string.IsNullOrWhiteSpace(saida.NumProtocolo))
					return false;

				if (!string.IsNullOrWhiteSpace(protocolo) && !string.Equals(saida.NumProtocolo, protocolo, StringComparison.OrdinalIgnoreCase))
					return false;

				if (!string.IsNullOrWhiteSpace(chave))
				{
					if (string.IsNullOrWhiteSpace(saida.ChaveSefaz))
						return false;

					if (!string.Equals(saida.ChaveSefaz, chave, StringComparison.OrdinalIgnoreCase) &&
						!saida.ChaveSefaz.EndsWith(chave.Substring(3), StringComparison.OrdinalIgnoreCase))
						return false;
				}

				return true;
			}
		}

		private static bool ArquivarProcXml(string dirXml, string arquivo, string codVenda)
		{
			try
			{
				var data = File.GetLastWriteTime(arquivo);
				var subdir = Path.Combine(dirXml, "_procNfe_processado", $"{data:yyyyMMdd}");
				Directory.CreateDirectory(subdir);

				var nome = Path.GetFileName(arquivo);
				var destino = Path.Combine(subdir, nome);
				if (File.Exists(destino))
				{
					var baseNome = Path.GetFileNameWithoutExtension(nome);
					var ext = Path.GetExtension(nome);
					destino = Path.Combine(subdir, $"{baseNome}-{codVenda}-{Guid.NewGuid():N}{ext}");
				}

				File.Move(arquivo, destino);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private static bool PodeNotificar(string chave)
		{
			lock (Sync)
			{
				try
				{
					var basePath = AppDomain.CurrentDomain.BaseDirectory;
					var logDir = Path.Combine(basePath, "Logs", "Nfce");
					Directory.CreateDirectory(logDir);
					var statePath = Path.Combine(logDir, "procxml-audit-state.txt");

					var hoje = DateTime.UtcNow.ToString("yyyyMMdd");
					var agora = DateTime.UtcNow;

					var linhas = File.Exists(statePath) ? File.ReadAllLines(statePath) : Array.Empty<string>();
					var novaLinhas = linhas.Where(l => !l.StartsWith(chave + "|", StringComparison.OrdinalIgnoreCase)).ToList();

					var existente = linhas.FirstOrDefault(l => l.StartsWith(chave + "|", StringComparison.OrdinalIgnoreCase));
					var count = 0;
					DateTime ultimo = DateTime.MinValue;

					if (!string.IsNullOrWhiteSpace(existente))
					{
						var parts = existente.Split('|');
						if (parts.Length >= 4)
						{
							var data = parts[1];
							if (data == hoje)
								int.TryParse(parts[2], out count);
							long ticks;
							if (long.TryParse(parts[3], out ticks))
								ultimo = new DateTime(ticks, DateTimeKind.Utc);
						}
					}

					if (count >= MaxAvisosPorDia)
						return false;

					if (ultimo != DateTime.MinValue && (agora - ultimo) < MinIntervaloAviso)
						return false;

					count++;
					novaLinhas.Add($"{chave}|{hoje}|{count}|{agora.Ticks}");

					var tmp = statePath + ".tmp";
					File.WriteAllLines(tmp, novaLinhas);
					File.Copy(tmp, statePath, true);
					File.Delete(tmp);

					return true;
				}
				catch
				{
					return true;
				}
			}
		}

		private static bool PodeConsultarSefaz(string chave44)
		{
			lock (Sync)
			{
				try
				{
					var basePath = AppDomain.CurrentDomain.BaseDirectory;
					var logDir = Path.Combine(basePath, "Logs", "Nfce");
					Directory.CreateDirectory(logDir);
					var statePath = Path.Combine(logDir, "procxml-sefazcheck-state.txt");

					var hoje = DateTime.UtcNow.ToString("yyyyMMdd");
					var key = "sefaz|" + chave44;
					var linhas = File.Exists(statePath) ? File.ReadAllLines(statePath) : Array.Empty<string>();
					var existente = linhas.FirstOrDefault(l => l.StartsWith(key + "|", StringComparison.OrdinalIgnoreCase));

					if (!string.IsNullOrWhiteSpace(existente))
					{
						var parts = existente.Split('|');
						if (parts.Length >= 2 && parts[1] == hoje)
							return false;
					}

					var novaLinhas = linhas.Where(l => !l.StartsWith(key + "|", StringComparison.OrdinalIgnoreCase)).ToList();
					novaLinhas.Add($"{key}|{hoje}");
					File.WriteAllLines(statePath, novaLinhas);
					return true;
				}
				catch
				{
					return false;
				}
			}
		}

		private static string ExtrairNumeroDaChave(string chave44)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(chave44) || chave44.Length != 44)
					return null;

				var nnf = chave44.Substring(25, 9);
				return int.Parse(nnf).ToString();
			}
			catch
			{
				return null;
			}
		}

		private static string ExtrairChaveDoNomeArquivo(string caminho)
		{
			try
			{
				var nome = Path.GetFileNameWithoutExtension(caminho);
				if (string.IsNullOrWhiteSpace(nome))
					return null;

				var idx = nome.IndexOf("-procNfe", StringComparison.OrdinalIgnoreCase);
				if (idx <= 0)
					return null;

				var chave = nome.Substring(0, idx);
				if (chave.Length != 44)
					return null;

				return chave.All(char.IsDigit) ? chave : null;
			}
			catch
			{
				return null;
			}
		}

		private static bool SaidaAutorizadaExistePorChave(string chave44)
		{
			using (var banco = new LojaContext())
			{
				var prefixada = "NFe" + chave44;
				return banco.tbl_Saida.Any(x =>
					x.FlgStatusNFE == "A" &&
					!string.IsNullOrEmpty(x.NumProtocolo) &&
					(x.ChaveSefaz == prefixada || (x.ChaveSefaz != null && x.ChaveSefaz.EndsWith(chave44))));
			}
		}
	}
}
