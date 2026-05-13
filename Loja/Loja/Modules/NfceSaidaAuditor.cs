using System;
using System.IO;
using System.Linq;
using System.Text;
using Loja.DAL.DAO;
using NFe.Classes;

namespace Loja.Modules
{
	public static class NfceSaidaAuditor
	{
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

			var corrigidas = 0;
			var erros = 0;

			foreach (var arquivo in arquivos)
			{
				try
				{
					var proc = new nfeProc().CarregarDeArquivoXml(arquivo);
					if (proc?.NFe?.infNFe?.ide == null || proc.protNFe?.infProt == null)
						continue;

					var codVenda = proc.NFe.infNFe.ide.nNF.ToString();
					var chave = "NFe" + proc.protNFe.infProt.chNFe;
					var protocolo = proc.protNFe.infProt.nProt;
					var qtdItens = proc.NFe.infNFe.det != null ? proc.NFe.infNFe.det.Count : 0;
					var valorTotal = proc.NFe.infNFe.total?.ICMSTot?.vNF ?? 0m;
					var data = proc.NFe.infNFe.ide.dhEmi.DateTime;

					Cadastros.GarantirSaidaAutorizada(codVenda, data, valorTotal, qtdItens, chave, protocolo);
					corrigidas++;
				}
				catch (Exception ex)
				{
					erros++;
					NfceAuditLogger.Error("auditoria.procxml_erro", Path.GetFileNameWithoutExtension(arquivo), null, ex, "Falha ao reconciliar PROC XML.");
				}
			}

			if (corrigidas == 0 && erros == 0)
				return string.Empty;

			var sb = new StringBuilder();
			if (corrigidas > 0)
				sb.AppendLine($"Auditoria NFC-e: {corrigidas} PROC XML reconciliado(s) com tbl_Saida.");
			if (erros > 0)
				sb.AppendLine($"Auditoria NFC-e: {erros} erro(s) ao ler PROC XML. Verifique os logs fiscais.");

			return sb.ToString().Trim();
		}
	}
}
