using System;
using System.Collections.Generic;
using System.Linq;
using DFe.Classes.Flags;
using DFe.Classes.Entidades;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes;
using NFeZeus = NFe.Classes.NFe;
using NFe.Servicos;
using NFe.Classes.Servicos.Tipos;
using NFe.Classes.Informacoes;
using NFe.Utils.NFe;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Destinatario;
using NFe.Classes.Informacoes.Transporte;
using NFe.Classes.Informacoes.Pagamento;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Total;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using Loja.DAL.DAO;
using Loja.DAL.Models;
using System.Reflection;
using System.IO;
using DFe.Utils;
using NFe.Utils;
using NFe.Classes.Informacoes.Cobranca;
using NFe.Classes.Informacoes.Observacoes;
using DFe.Classes.Extensoes;
using NFe.Utils.InformacoesSuplementares;
using NFe.Utils.Tributacao.Estadual;
using NFe.Utils.Tributacao.Federal;
using NFe.Danfe.Nativo.NFCe;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Concurrent;

namespace Loja.Modules
{
	public class NFCE
	{
		private static readonly ConcurrentDictionary<string, object> LocksPorVenda = new ConcurrentDictionary<string, object>();

		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		private NFe.Classes.NFe _nfe;
		private ConfiguracaoApp _configuracoes;
		private tbl_Saida _saida;
		private tbl_Cliente _cliente;

		public NFCE(ConfiguracaoApp conf, tbl_Saida saida)
		{
			_configuracoes = conf;
			_saida = saida;

			if (saida != null && saida.CodCliente != null)
			{
				_cliente = Consultas.ObterCliente(saida.CodCliente.Value);
			}
		}

		public NFCE(ConfiguracaoApp conf, string numNF)
		{
			_configuracoes = conf;

			var saida = Consultas.ObterVenda(numNF);
			if (saida != null)
			{
				if (saida.CodCliente != null)
				{
					_cliente = Consultas.ObterCliente(saida.CodCliente.Value);
				}
				_saida = saida;
			}

		}

		public Retorno EnviaNFCE(bool gerarPDF = false)
		{
			try
			{
				if (_saida == null)
				{
					return new Retorno(false, "Venda não localizada para emissão.");
				}

				NfceAuditLogger.Info("emissao.inicio", _saida.CodVenda, _saida.FlgStatusNFE, "Iniciando emissão de NFC-e.");

				var lockVenda = ObterLockVenda(_saida.CodVenda);
				lock (lockVenda)
				{

					if (_saida.FlgStatusNFE == "A" && !string.IsNullOrWhiteSpace(_saida.NumProtocolo))
					{
						NfceAuditLogger.Info("emissao.skip_autorizada", _saida.CodVenda, _saida.FlgStatusNFE, "Nota já autorizada com protocolo local.");
						return new Retorno(true, "NFC-e já autorizada anteriormente. Nenhum reenvio foi realizado.");
					}

					var conciliacaoPendente = ConciliarAutorizacaoPelaChave();
					if (conciliacaoPendente != null)
					{
						NfceAuditLogger.Info("emissao.conciliada", _saida.CodVenda, _saida.FlgStatusNFE, conciliacaoPendente.Mensagem);
						return conciliacaoPendente;
					}

				var recibo = "";
				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var nomArquivoXML = "";

				#region Cria e Envia NFe

				var numero = _saida.CodVenda;
				if (string.IsNullOrEmpty(numero)) return new Retorno(false, "O Número deve ser informado!");

				var lote = numero;
				if (string.IsNullOrEmpty(lote)) return new Retorno(false, "A Id do lote deve ser informada!");

				_nfe = GetNf(Convert.ToInt32(numero), _configuracoes.CfgServico.ModeloDocumento,
					_configuracoes.CfgServico.VersaoNFeAutorizacao);

				if (_nfe.infNFe.infRespTec == null)
				{
					_nfe.infNFe.infRespTec = new Shared.NFe.Classes.Informacoes.InfRespTec.infRespTec();
				}
				_nfe.infNFe.infRespTec.CNPJ = "24409668000155";
				_nfe.infNFe.infRespTec.email = "tisimplessolucoes@gmail.com";
				_nfe.infNFe.infRespTec.fone = "92992002858";
				_nfe.infNFe.infRespTec.xContato = "Thiago Raheem";

				_nfe.Assina(); //não precisa validar aqui, pois o lote será validado em ServicosNFe.NFeAutorizacao

				if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
				{
					_nfe.infNFeSupl = new infNFeSupl();
					if (_configuracoes.CfgServico.VersaoNFeAutorizacao == VersaoServico.Versao400)
						_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrlConsulta(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode);
					_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
				}
				/*if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
				{
					//A URL do QR-Code deve ser gerada em um objeto nfe já assinado, pois na URL vai o DigestValue que é gerado por ocasião da assinatura
					if (_nfe.infNFeSupl == null)
					{
						_nfe.infNFeSupl = new infNFeSupl
						{
							qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc)
						};
					}
					else
					{
						_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
					}

				}*/

				#endregion

				// Operação Normal
				if (_configuracoes.CfgServico.tpEmis.Equals(TipoEmissao.teNormal))
				{
					#region Autorização
					var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { _nfe }, false);

					if (retornoEnvio.Retorno.cStat != 103)
						return new Retorno(false, $"Erro na emissão da NFe: Código: {retornoEnvio.Retorno.cStat} - Mensagem: {retornoEnvio.Retorno.xMotivo}");

					recibo = retornoEnvio.Retorno.infRec.nRec;
					#endregion

					#region Consulta Recibo de lote

					if (string.IsNullOrEmpty(recibo)) return new Retorno(false, "O número do recibo não foi localizado!");
					var bTestar = false; // testa o retorno do recibo, caso seja 105, tenta 3 vezes
					var numTentativas = 0;

					do
					{
						bTestar = false;
						numTentativas++;

						var retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);

						if (retornoRecibo.Retorno.cStat == 105 && numTentativas <= 3)
						{
							retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);
							bTestar = true;
							AguardarRetry(numTentativas);
						}
						else
						{
							if (retornoRecibo.Retorno.cStat != 104)
							{
								return new Retorno(false, $"Erro ao processar o lote. Código: {retornoRecibo.Retorno.cStat} - Mensagem: {retornoRecibo.Retorno.xMotivo}");
							}

							var retornoLote = retornoRecibo.Retorno.protNFe.FirstOrDefault();

							if (retornoLote != null && retornoLote.infProt.cStat != 100)
							{
								if (retornoLote.infProt.cStat == 204)
								{
									var conciliacaoDuplicidade = ConciliarAutorizacaoPelaChave(ExtrairChaveSemPrefixo(_nfe.infNFe.Id), "NFC-e duplicada detectada na SEFAZ e conciliada como autorizada.");
									if (conciliacaoDuplicidade != null)
									{
										return conciliacaoDuplicidade;
									}
								}

								return new Retorno(false, $"Erro ao validar a nota. Código: {retornoLote.infProt.cStat} - Mensagem: {retornoLote.infProt.xMotivo}");
							}
						}
					} while (bTestar);
					#endregion

					#region Gerar XML
					nomArquivoXML = $"{_configuracoes.CfgServico.DiretorioSalvarXml}\\{_nfe.infNFe.Id.Substring(3)}.xml";
					_nfe.SalvarArquivoXml(nomArquivoXML);
					#endregion

					#region Adicionar PROC
					var chave = _nfe.infNFe.Id.Substring(3);

					if (string.IsNullOrEmpty(chave)) return new Retorno(false, "A Chave da NFe não foi encontrada no arquivo!");
					if (chave.Length != 44) return new Retorno(false, "Chave deve conter 44 caracteres!");

					var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);
					var infProt = retornoConsulta?.Retorno?.protNFe?.infProt;
					if (infProt == null)
						return new Retorno(false, "Consulta de protocolo não retornou infProt.");
					if (infProt.cStat != 100)
						return new Retorno(false, $"Consulta de protocolo retornou {infProt.cStat} - {infProt.xMotivo}");

					_saida.NumProtocolo = infProt.nProt;
					AtualizarStatusNfe("A", _nfe.infNFe.Id, _saida.NumProtocolo, "emissao.autorizada");
					_saida.ChaveSefaz = _nfe.infNFe.Id;
					Cadastros.GravaVenda(_saida);
					NfceRetryQueue.Dequeue(_saida.CodVenda);

					#endregion
					try
					{
						var nfeproc = new nfeProc
						{
							NFe = _nfe,
							protNFe = retornoConsulta.Retorno.protNFe,
							versao = retornoConsulta.Retorno.versao
						};
						var novoArquivo = Path.GetDirectoryName(nomArquivoXML) + @"\" + infProt.chNFe + "-procNfe.xml";
						FuncoesXml.ClasseParaArquivoXml(nfeproc, novoArquivo);

						var arquivoPDF = gerarPDF ? nomArquivoXML.Replace("xml", "pdf") : "";
						ImprimirDanfe(novoArquivo, arquivoPDF);
					}
					catch (Exception ex)
					{
						NfceAuditLogger.Error("emissao.posprocessamento_erro", _saida.CodVenda, _saida.FlgStatusNFE, ex, "NFC-e autorizada, mas houve falha em pós-processamento (proc/impressão).");
						return new Retorno(true, $"NFC-e autorizada (protocolo {infProt.nProt}), mas houve erro ao finalizar pós-processamento: {ex.Message}");
					}

				}
				// Impressão em Contingência
				else
				{
					AtualizarStatusNfe("C", _nfe.infNFe.Id, _saida.NumProtocolo, "emissao.contingencia");

					_nfe.Valida();

					nomArquivoXML = $"{_configuracoes.CfgServico.DiretorioSalvarXml}\\{_nfe.infNFe.Id.Substring(3)}-cont.xml";
					_nfe.SalvarArquivoXml(nomArquivoXML);

					ImprimirDanfe(nomArquivoXML);
				}

				NfceAuditLogger.Info("emissao.sucesso", _saida.CodVenda, _saida.FlgStatusNFE, "Fluxo de emissão finalizado com sucesso.");
				return new Retorno(true, "Nota Fiscal emitida com sucesso");
				}
			}
			catch (Exception ex)
			{
				if (_saida != null)
				{
					NfceRetryQueue.Enqueue(_saida.CodVenda);
					NfceAuditLogger.Error("emissao.erro", _saida.CodVenda, _saida.FlgStatusNFE, ex, "Falha durante emissão.");
				}
				if (_saida != null && _saida.FlgStatusNFE == "A" && !string.IsNullOrWhiteSpace(_saida.NumProtocolo))
				{
					return new Retorno(true, $"NFC-e consta como autorizada localmente (protocolo {_saida.NumProtocolo}), mas houve erro após autorização: {ex.Message}");
				}
				return new Retorno(false, $"Erro ao enviar a NFe: {ex.Message}");
			}
		}

		public void ImprimirDanfe(string arquivoXml, string arquivoPDF = null)
		{
			nfeProc proc = null;
			NFeZeus nfe = null;
			string arquivo = string.Empty;

			try
			{
				proc = new nfeProc().CarregarDeArquivoXml(arquivoXml);
				arquivo = proc.ObterXmlString();
			}
			catch (Exception)
			{
				nfe = new NFeZeus().CarregarDeArquivoXml(arquivoXml);
				arquivo = nfe.ObterXmlString();
			}

			var impr = new NFe.Danfe.Nativo.NFCe.DanfeNativoNfce(
				arquivo,
				_configuracoes.ConfiguracaoDanfeNfce,
				_configuracoes.ConfiguracaoCsc.CIdToken,
				_configuracoes.ConfiguracaoCsc.Csc,
				0m);

			impr.Imprimir(_configuracoes.ImpressoraPadrao, salvarArquivoPdfEm: arquivoPDF);
			//impr.Imprimir(salvarArquivoPdfEm: arquivoXml.Replace(".xml", "") + ".pdf");
			//impr.GerarJPEG(fileDialog.FileName.Replace(".jpeg", "") + ".jpeg");

		}

		#region para contingência
		public string EnviarContingencia()
		{
			string resultado = "";
			var notas = Consultas.ObterVendasContingencia().Select(x => x.CodVenda).ToList();
			var filaRetry = NfceRetryQueue.Load();
			var todos = notas.Union(filaRetry).Distinct().ToList();

			foreach (var codVenda in todos)
			{
				var ret = EnviaNFCE(codVenda);
				resultado += $"[{codVenda}] {ret.Mensagem}\n";
			}

			return resultado;
		}

		public Retorno EnviaNFCE(string notaContingencia)
		{

			try
			{

				if (notaContingencia != null && notaContingencia != "")
				{
					var recibo = "";
					var nomArquivoXML = "";

					using (var servicoNFe = new ServicosNFe(_configuracoes.CfgServico))
					{
						_saida = Consultas.ObterVenda(notaContingencia);
						if (_saida == null)
						{
							return new Retorno(false, $"Venda {notaContingencia} não encontrada para retransmissão.");
						}

						NfceAuditLogger.Info("contingencia.reenvio_inicio", _saida.CodVenda, _saida.FlgStatusNFE, "Iniciando retransmissão de contingência.");
						var lockVenda = ObterLockVenda(_saida.CodVenda);
						lock (lockVenda)
						{

						if (_saida.FlgStatusNFE == "A" && !string.IsNullOrWhiteSpace(_saida.NumProtocolo))
						{
							NfceRetryQueue.Dequeue(_saida.CodVenda);
							return new Retorno(true, "NFC-e de contingência já autorizada anteriormente. Nenhum reenvio foi realizado.");
						}

						var conciliacaoPendente = ConciliarAutorizacaoPelaChave();
						if (conciliacaoPendente != null)
						{
							return conciliacaoPendente;
						}

						var chaveSemPrefixo = ExtrairChaveSemPrefixo(_saida.ChaveSefaz);
						var cnf = chaveSemPrefixo.Length >= 44 ? chaveSemPrefixo.Substring(35, 8) : null;

						_nfe = GetNf(Convert.ToInt32(notaContingencia), _configuracoes.CfgServico.ModeloDocumento,
										_configuracoes.CfgServico.VersaoNFeAutorizacao, cnf);

						/*if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe && _configuracoes.CfgServico.VersaoNFeAutorizacao == VersaoServico.ve400)
						{
							_nfe.infNFeSupl = new infNFeSupl();
							_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrl(_configuracoes.CfgServico.tpAmb, _configuracoes.CfgServico.cUF, TipoUrlConsultaPublica.UrlConsulta);
						}*/
						if (_nfe.infNFe.infRespTec == null){
							_nfe.infNFe.infRespTec = new Shared.NFe.Classes.Informacoes.InfRespTec.infRespTec();
						}
						_nfe.infNFe.infRespTec.CNPJ = "24409668000155";
						_nfe.infNFe.infRespTec.email = "tisimplessolucoes@gmail.com";
						_nfe.infNFe.infRespTec.fone = "92981524505";
						_nfe.infNFe.infRespTec.xContato = "Thiago Raheem";

						_nfe.Assina(); //não precisa validar aqui, pois o lote será validado em ServicosNFe.NFeAutorizacao

						if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
						{
							_nfe.infNFeSupl = new infNFeSupl();
							if (_configuracoes.CfgServico.VersaoNFeAutorizacao == VersaoServico.Versao400)
								_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrlConsulta(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode);
							_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
						}

						/*if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
						{
							//A URL do QR-Code deve ser gerada em um objeto nfe já assinado, pois na URL vai o DigestValue que é gerado por ocasião da assinatura
							if (_nfe.infNFeSupl == null)
							{
								_nfe.infNFeSupl = new infNFeSupl
								{
									qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc)
								};
							}
							else
							{
								_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
							}

						}*/

						var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(notaContingencia), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { _nfe }, false);

						if (retornoEnvio.Retorno.cStat != 103)
							return new Retorno(false, $"Erro na emissão da NFe: Código: {retornoEnvio.Retorno.cStat} - Mensagem: {retornoEnvio.Retorno.xMotivo}");

						recibo = retornoEnvio.Retorno.infRec.nRec;

						#region Consulta Recibo de lote

						if (string.IsNullOrEmpty(recibo)) return new Retorno(false, "O número do recibo não foi localizado!");
						var bTestar = false; // testa o retorno do recibo, caso seja 105, tenta 3 vezes
						var numTentativas = 0;

						do
						{
							bTestar = false;
							numTentativas++;

							var retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);

							if (retornoRecibo.Retorno.cStat == 105 && numTentativas <= 3)
							{
								retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);
								bTestar = true;
								AguardarRetry(numTentativas);
							}
							else
							{
								if (retornoRecibo.Retorno.cStat != 104)
								{
									return new Retorno(false, $"Erro ao processar o lote. Código: {retornoRecibo.Retorno.cStat} - Mensagem: {retornoRecibo.Retorno.xMotivo}");
								}

								var retornoLote = retornoRecibo.Retorno.protNFe.FirstOrDefault();

								if (retornoLote != null && retornoLote.infProt.cStat != 100)
								{
									if (retornoLote.infProt.cStat == 204)
									{
										var conciliacaoDuplicidade = ConciliarAutorizacaoPelaChave(ExtrairChaveSemPrefixo(_nfe.infNFe.Id), "NFC-e de contingência duplicada detectada e conciliada como autorizada.");
										if (conciliacaoDuplicidade != null)
										{
											return conciliacaoDuplicidade;
										}
									}

									return new Retorno(false, $"Erro ao validar a nota. Código: {retornoLote.infProt.cStat} - Mensagem: {retornoLote.infProt.xMotivo}");
								}
							}
						} while (bTestar);
						#endregion

						#region Gerar XML
						nomArquivoXML = $"{_configuracoes.CfgServico.DiretorioSalvarXml}\\{_nfe.infNFe.Id.Substring(3)}.xml";
						_nfe.SalvarArquivoXml(nomArquivoXML);
						#endregion

						#region Adicionar PROC
						var chave = _nfe.infNFe.Id.Substring(3);

						if (string.IsNullOrEmpty(chave)) return new Retorno(false, "A Chave da NFe não foi encontrada no arquivo!");
						if (chave.Length != 44) return new Retorno(false, "Chave deve conter 44 caracteres!");

						var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);

						var nfeproc = new nfeProc
						{
							NFe = _nfe,
							protNFe = retornoConsulta.Retorno.protNFe,
							versao = retornoConsulta.Retorno.versao
						};
						if (nfeproc.protNFe != null)
						{
							_saida.NumProtocolo = nfeproc.protNFe.infProt.nProt;

							var novoArquivo = Path.GetDirectoryName(nomArquivoXML) + @"\" + nfeproc.protNFe.infProt.chNFe +
											  "-procNfe.xml";
							FuncoesXml.ClasseParaArquivoXml(nfeproc, novoArquivo);

							ImprimirDanfe(novoArquivo);
						}

						#endregion

						var xmlEnvio = _nfe.ObterXmlString();

						SalvarArquivoXml(notaContingencia + "-env-lot-c.xml", xmlEnvio);

						var caminhodoarquivo = String.Format("{0}\\XML\\{1}-env-lot-c.xml", path, notaContingencia);
						}

					}
				}

				AtualizarStatusNfe("A", _nfe.infNFe.Id, _saida.NumProtocolo, "contingencia.autorizada");
				NfceRetryQueue.Dequeue(notaContingencia);
				NfceAuditLogger.Info("contingencia.reenvio_sucesso", notaContingencia, "A", "Retransmissão finalizada com sucesso.");

				return new Retorno(true, "Nota Fiscal enviada com sucesso!");
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException ex)
			{
				NfceRetryQueue.Enqueue(notaContingencia);
				NfceAuditLogger.Error("contingencia.reenvio_erro_validacao", notaContingencia, _saida?.FlgStatusNFE, ex, "Erro de validação durante retransmissão.");
				return new Retorno(false, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
			catch (Exception ex)
			{
				NfceRetryQueue.Enqueue(notaContingencia);
				NfceAuditLogger.Error("contingencia.reenvio_erro", notaContingencia, _saida?.FlgStatusNFE, ex, "Erro na retransmissão de contingência.");
				return new Retorno(false, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
		}

		private string CarregarXML(string numNF)
		{
			try
			{
				var caminho = String.Format("{0}\\XML\\{1}-env-lot.xml", path, numNF);

				return !File.Exists(caminho)
					? ""
					: //FuncoesXml.ArquivoXmlParaString(caminho);
					FuncoesXml.ArquivoXmlParaClasse<NFe.Classes.NFe>(caminho).ObterXmlString();

			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Util.MsgBox(ex.Message);
				return "";
			}
		}

		private void SalvarArquivoXml(string nomeArquivo, string xmlString)
		{
			var dir = path + "\\XML\\";
			var stw = new StreamWriter(dir + @"\" + nomeArquivo);
			stw.WriteLine(xmlString);
			stw.Close();
		}
		#endregion

		#region Criar NFe

		protected virtual NFeZeus GetNf(int numero, ModeloDocumento modelo, VersaoServico versao, string cNF = null)
		{
			var nf = new NFeZeus { infNFe = GetInf(numero, modelo, versao, cNF) };
			return nf;
		}

		protected virtual infNFe GetInf(int numero, ModeloDocumento modelo, VersaoServico versao, string cNF = null)
		{
			var infNFe = new infNFe
			{
				versao = versao.VersaoServicoParaString(),
				ide = GetIdentificacao(numero, modelo, versao, cNF),
				emit = GetEmitente(),
				transp = GetTransporte()
			};
			if (_cliente != null)
			{
				infNFe.dest = GetDestinatario(versao, modelo);
			}

			var itens = _saida.tbl_SaidaItens;
			var i = 0;
			foreach (var item in itens)
			{
				infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo, item));
				i++;
			}

			infNFe.total = GetTotal(versao, infNFe.det);

			if (infNFe.ide.mod == ModeloDocumento.NFe & (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400))
				infNFe.cobr = GetCobranca(infNFe.total.ICMSTot); //V3.00 e 4.00 Somente
			if (infNFe.ide.mod == ModeloDocumento.NFCe || (infNFe.ide.mod == ModeloDocumento.NFe & versao == VersaoServico.Versao400))
				infNFe.pag = GetPagamento(infNFe.total.ICMSTot, versao); //NFCe Somente  

			if (infNFe.ide.mod == ModeloDocumento.NFCe & versao != VersaoServico.Versao400)
				infNFe.infAdic = new infAdic() { infCpl = "" }; //Susgestão para impressão do troco em NFCe

			return infNFe;
		}

		protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao, string cNF = null)
		{
			var ide = new ide
			{
				cUF = _configuracoes.EnderecoEmitente.UF,
				natOp = "VENDA",
				mod = modelo,
				serie = 1,
				nNF = numero,
				tpNF = TipoNFe.tnSaida,
				cMunFG = _configuracoes.EnderecoEmitente.cMun,
				tpEmis = _configuracoes.CfgServico.tpEmis,
				tpImp = TipoImpressao.tiRetrato,
				cNF = cNF ?? GerarCodigoNumericoDeterministico(_saida != null ? _saida.CodVenda : numero.ToString()),
				tpAmb = _configuracoes.CfgServico.tpAmb,
				finNFe = FinalidadeNFe.fnNormal,
				verProc = "3.000"
			};

			if (ide.tpEmis != TipoEmissao.teNormal)
			{
				ide.dhCont = DateTime.Now;
				ide.xJust = "FALHA DE COMUNICAÇÃO COM SEFAZ";
			}

			#region V2.00

			if (versao == VersaoServico.Versao200)
			{
				ide.dEmi = DateTime.Today; //Mude aqui para enviar a nfe vinculada ao EPEC, V2.00
				ide.dSaiEnt = DateTime.Today;
			}

			#endregion

			#region V3.00

			if (versao == VersaoServico.Versao200) return ide;

			if (versao == VersaoServico.Versao310)
			{
				ide.indPag = IndicadorPagamento.ipVista;
			}

			ide.idDest = DestinoOperacao.doInterna;
			ide.dhEmi = DateTime.Now;
			//Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
			if (ide.mod == ModeloDocumento.NFe)
				ide.dhSaiEnt = DateTime.Now;
			else
				ide.tpImp = TipoImpressao.tiNFCe;
			ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
			ide.indFinal = ConsumidorFinal.cfConsumidorFinal; //NFCe: Tem que ser consumidor Final
			ide.indPres = PresencaComprador.pcPresencial; //NFCe: deve ser 1 ou 4

			#endregion

			return ide;
		}

		private string GerarCodigoNumericoDeterministico(string origem)
		{
			if (string.IsNullOrWhiteSpace(origem))
			{
				origem = DateTime.UtcNow.Ticks.ToString();
			}

			using (var sha = SHA256.Create())
			{
				var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(origem));
				var valor = BitConverter.ToUInt32(hash, 0) % 100000000;
				return valor.ToString("D8");
			}
		}

		private string ExtrairChaveSemPrefixo(string chave)
		{
			if (string.IsNullOrWhiteSpace(chave))
			{
				return string.Empty;
			}

			var chaveNormalizada = chave.Trim();
			if (chaveNormalizada.StartsWith("NFe", StringComparison.OrdinalIgnoreCase))
			{
				chaveNormalizada = chaveNormalizada.Substring(3);
			}

			return chaveNormalizada;
		}

		private Retorno ConciliarAutorizacaoPelaChave(string chaveConsulta = null, string mensagemSucesso = null)
		{
			var chave = !string.IsNullOrWhiteSpace(chaveConsulta)
				? chaveConsulta
				: ExtrairChaveSemPrefixo(_saida != null ? _saida.ChaveSefaz : null);

			if (string.IsNullOrWhiteSpace(chave) || chave.Length != 44)
			{
				return null;
			}

			using (var servicoNFe = new ServicosNFe(_configuracoes.CfgServico))
			{
				var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);
				var protocolo = retornoConsulta.Retorno.protNFe;
				var infProt = protocolo != null ? protocolo.infProt : null;

				if (infProt != null && infProt.cStat == 100)
				{
					AtualizarStatusNfe("A", "NFe" + infProt.chNFe, infProt.nProt, "sefaz.conciliacao");

					return new Retorno(true, mensagemSucesso ?? "NFC-e já constava como autorizada na SEFAZ e foi conciliada com o banco.");
				}
			}

			return null;
		}

		private object ObterLockVenda(string codVenda)
		{
			var chave = string.IsNullOrWhiteSpace(codVenda) ? "_SEM_CODIGO_" : codVenda.Trim();
			return LocksPorVenda.GetOrAdd(chave, _ => new object());
		}

		private void AtualizarStatusNfe(string novoStatus, string chave, string protocolo, string contexto)
		{
			if (_saida == null)
			{
				return;
			}

			NfceStateMachine.EnsureTransition(_saida.FlgStatusNFE, novoStatus, _saida.CodVenda);
			Cadastros.AtualizaStatusNFE(_saida.CodVenda, novoStatus, chave, protocolo);
			_saida.FlgStatusNFE = novoStatus;

			if (!string.IsNullOrWhiteSpace(chave))
			{
				_saida.ChaveSefaz = chave;
			}

			if (!string.IsNullOrWhiteSpace(protocolo))
			{
				_saida.NumProtocolo = protocolo;
			}

			NfceAuditLogger.Info(contexto, _saida.CodVenda, novoStatus, $"Status atualizado para {novoStatus}.");
		}

		private void AguardarRetry(int tentativa)
		{
			var tentativaNormalizada = tentativa <= 0 ? 1 : tentativa;
			var jitter = new Random(Guid.NewGuid().GetHashCode()).Next(100, 400);
			var atraso = (int)Math.Min(5000, (Math.Pow(2, tentativaNormalizada) * 200) + jitter);
			Thread.Sleep(atraso);
		}

		protected virtual emit GetEmitente()
		{
			var emit = _configuracoes.Emitente; // new emit
												//{
												//    //CPF = "80365027553",
												//    CNPJ = "32876302000114",
												//    xNome = "FIOLUX COMERCIAL LTDA",
												//    xFant = "FIOLUX COMERCIAL LTDA",
												//    IE = "270844821",
												//};
			emit.enderEmit = GetEnderecoEmitente();
			return emit;
		}

		protected virtual enderEmit GetEnderecoEmitente()
		{
			var enderEmit = _configuracoes.EnderecoEmitente; // new enderEmit
															 //{
															 //    xLgr = "RUA COMENDADOR FRANCISCO JOSE DA CUNHA",
															 //    nro = "171",
															 //    xCpl = "1 ANDAR",
															 //    xBairro = "CENTRO",
															 //    cMun = 2802908,
															 //    xMun = "ITABAIANA",
															 //    UF = "SE",
															 //    CEP = 49500000,
															 //    fone = 7934313234
															 //};
			enderEmit.cPais = 1058;
			enderEmit.xPais = "BRASIL";
			return enderEmit;
		}

		protected virtual dest GetDestinatario(VersaoServico versao, ModeloDocumento modelo)
		{
			var dest = new dest(versao);

			if (_cliente != null)
			{
				if (_configuracoes.CfgServico.tpAmb.Equals(TipoAmbiente.Homologacao))
				{
					dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
				}
				else
				{
					dest.xNome = _cliente.NomCliente ?? "CLIENTE NÃO IDENTIFICADO";
				}
				if (!String.IsNullOrEmpty(_cliente.NumCNPJ))
				{
					dest.CNPJ = _cliente.NumCNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
				}
				else
				{
					if (!String.IsNullOrEmpty(_cliente.NumCPF))
					{
						dest.CPF = _cliente.NumCPF.Replace(".", "").Replace("-", "");
					}
				}
				// verifica se os dados de endereço existem
				if (!String.IsNullOrEmpty(_cliente.Endereco) && !String.IsNullOrEmpty(_cliente.Numero) && !String.IsNullOrEmpty(_cliente.Bairro) &&
					!String.IsNullOrEmpty(_cliente.CEP) && !String.IsNullOrEmpty(_cliente.Cidade) && !String.IsNullOrEmpty(_cliente.Estado)
					)
				{
					dest.enderDest = GetEnderecoDestinatario();
				}

				// verifica se tem email cadastrado
				if (!string.IsNullOrEmpty(_cliente.Email))
				{
					dest.email = _cliente.Email;
				}

			}
			else
			{
				dest.xNome = "CLIENTE NÃO IDENTIFICADO";
			}


			//if (versao == VersaoServico.ve200)
			//    dest.IE = "ISENTO";
			if (versao == VersaoServico.Versao200) return dest;

			dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
			return dest;
		}

		protected virtual enderDest GetEnderecoDestinatario()
		{
			var enderDest = new enderDest
			{
				xLgr = _cliente.Endereco ?? "",
				nro = _cliente.Numero ?? "",
				xBairro = _cliente.Bairro ?? "",
				cMun = 1302603,
				xMun = _cliente.Cidade ?? "MANAUS",
				UF = _cliente.Estado ?? "AM",
				CEP = _cliente.CEP ?? "",
				cPais = 1058,
				xPais = "BRASIL"
			};
			return enderDest;
		}

		protected virtual det GetDetalhe(int i, CRT crt, ModeloDocumento modelo, tbl_SaidaItens item)
		{
			var det = new det
			{
				nItem = i + 1,
				prod = GetProduto(i + 1, item, crt),
				imposto = new imposto
				{
					vTotTrib = item.VlrImposto ?? 0,//0.17m,

					ICMS = new ICMS
					{
						TipoICMS =
							crt == CRT.SimplesNacional
								? InformarCSOSN(Csosnicms.Csosn500)
								: InformarICMS(Csticms.Cst00, VersaoServico.Versao310)
					},

					COFINS = new COFINS { TipoCOFINS = new COFINSNT { CST = CSTCOFINS.cofins08 } },

					PIS = new PIS { TipoPIS = new PISNT { CST = CSTPIS.pis08 } }
				}
			};

			if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
			{
				det.imposto.IPI = new IPI()
				{
					cEnq = 999,
					TipoIPI = new IPITrib() { CST = CSTIPI.ipi00, pIPI = 5, vBC = 1, vIPI = 0.05m }
				};
			}

			return det;
		}

		protected virtual prod GetProduto(int i, tbl_SaidaItens item, CRT crt)
		{
			var p = new prod
			{
				cProd = item.CodProduto,
				xProd = _configuracoes.CfgServico.tpAmb.Equals(TipoAmbiente.Homologacao) && i == 1 ? "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL" : item.tbl_Produtos.DesProduto,
				NCM = item.tbl_Produtos.NCM ?? "99999999",
				CFOP = crt == CRT.SimplesNacional ? 5405 : 5102,
				uCom = "UNID",
				qCom = item.Quantidade,
				vUnCom = item.VlrUnitario,
				vProd = (item.VlrUnitario * item.Quantidade),
				vDesc = item.VlrDesconto,
				cEAN = "SEM GTIN",
				cEANTrib = "SEM GTIN",
				uTrib = "UNID",
				qTrib = item.Quantidade,
				vUnTrib = item.VlrUnitario,
				indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,
				//NVE = {"AA0001", "AB0002", "AC0002"},
				//CEST = ?

				//ProdutoEspecifico = new arma
				//{
				//    tpArma = TipoArma.UsoPermitido,
				//    nSerie = "123456",
				//    nCano = "123456",
				//    descr = "TESTE DE ARMA"
				//}
			};
			return p;
		}

		protected virtual total GetTotal(VersaoServico versao, List<det> produtos)
		{
			var icmsTot = new ICMSTot
			{
				vProd = produtos.Sum(p => p.prod.vProd),
				vDesc = produtos.Sum(p => p.prod.vDesc ?? 0),
				vTotTrib = produtos.Sum(p => p.imposto.vTotTrib ?? 0),
			};

			if (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400)
				icmsTot.vICMSDeson = 0;

			if (versao == VersaoServico.Versao400)
			{
				icmsTot.vFCPUFDest = 0;
				icmsTot.vICMSUFDest = 0;
				icmsTot.vICMSUFRemet = 0;
				icmsTot.vFCP = 0;
				icmsTot.vFCPST = 0;
				icmsTot.vFCPSTRet = 0;
				icmsTot.vIPIDevol = 0;
			}

			foreach (var produto in produtos)
			{
				if (produto.imposto.IPI != null && produto.imposto.IPI.TipoIPI.GetType() == typeof(IPITrib))
					icmsTot.vIPI = icmsTot.vIPI + ((IPITrib)produto.imposto.IPI.TipoIPI).vIPI ?? 0;
				if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS00))
				{
					icmsTot.vBC = icmsTot.vBC + ((ICMS00)produto.imposto.ICMS.TipoICMS).vBC;
					icmsTot.vICMS = icmsTot.vICMS + ((ICMS00)produto.imposto.ICMS.TipoICMS).vICMS;
				}
				if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS20))
				{
					icmsTot.vBC = icmsTot.vBC + ((ICMS20)produto.imposto.ICMS.TipoICMS).vBC;
					icmsTot.vICMS = icmsTot.vICMS + ((ICMS20)produto.imposto.ICMS.TipoICMS).vICMS;
				}
				//Outros Ifs aqui, caso vá usar as classes ICMS00, ICMS10 para totalizar
			}

			//** Regra de validação W16-10 que rege sobre o Total da NF **//
			icmsTot.vNF = Convert.ToDecimal(icmsTot.vProd - icmsTot.vDesc - icmsTot.vICMSDeson + icmsTot.vST + icmsTot.vFCPST + icmsTot.vFrete + icmsTot.vSeg + icmsTot.vOutro + icmsTot.vII + icmsTot.vIPI + icmsTot.vIPIDevol);

			var t = new total { ICMSTot = icmsTot };
			return t;
		}

		protected virtual transp GetTransporte()
		{
			//var volumes = new List<vol> {GetVolume(), GetVolume()};

			var t = new transp
			{
				modFrete = ModalidadeFrete.mfSemFrete //NFCe: Não pode ter frete
													  //vol = volumes 
			};

			return t;
		}

		protected virtual vol GetVolume()
		{
			var v = new vol
			{
				esp = "teste de especia",
				lacres = new List<lacres> { new lacres { nLacre = "123456" } }
			};

			return v;
		}

		protected virtual cobr GetCobranca(ICMSTot icmsTot)
		{
			var valorParcela = Valor.Arredondar(icmsTot.vNF / 2, 2);

			var fat = new Random().Next(99999).ToString("{0000000000:0}");
			var c = new cobr
			{
				fat = new fat { nFat = fat, vLiq = icmsTot.vNF, vOrig = icmsTot.vNF, vDesc = 0m },
				dup = new List<dup>
				{
					new dup {nDup = "001", dVenc = DateTime.Now.AddDays(30), vDup = valorParcela},
					new dup {nDup = "002", dVenc = DateTime.Now.AddDays(60), vDup = icmsTot.vNF - valorParcela}
				}
			};

			return c;
		}

		protected virtual List<pag> GetPagamento(ICMSTot icmsTot, VersaoServico versao)
		{
			var valorPagto = _saida.ValorTotal.Value;//Valor.Arredondar(icmsTot.vNF / 2, 2);

			if (versao != VersaoServico.Versao400) // difernte de versão 4 retorna isso
			{
				var p = new List<pag>
				{
					new pag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto}//,
					//new pag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}
				};
				return p;
			}

			// igual a versão 4 retorna isso
			var p4 = new List<pag>
			{
				//new pag {detPag = new detPag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto}},
				//new pag {detPag = new detPag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}}
				new pag
				{
					detPag = new List<detPag>
					{
						new detPag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto},
						//new detPag {tPag = FormaPagamento.fpDuplicataMercantil, vPag = valorPagto},
						//new detPag {tPag = FormaPagamento.fpDuplicataMercantil, vPag = icmsTot.vNF - valorPagto}
					}
				}
			};

			return p4;
		}

		protected virtual ICMSBasico InformarICMS(Csticms CST, VersaoServico versao)
		{
			var icms20 = new ICMS20
			{
				orig = OrigemMercadoria.OmNacional,
				CST = Csticms.Cst20,
				modBC = DeterminacaoBaseIcms.DbiValorOperacao,
				vBC = 1.1m,
				pICMS = 18,
				vICMS = 0.20m,
				motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
			};
			if (versao == VersaoServico.Versao310)
				icms20.vICMSDeson = 0.10m; //V3.00 ou maior Somente

			switch (CST)
			{
				case Csticms.Cst00:
					return new ICMS00
					{
						CST = Csticms.Cst00,
						modBC = DeterminacaoBaseIcms.DbiValorOperacao,
						orig = OrigemMercadoria.OmNacional,
						pICMS = 18,
						vBC = 1.1m,
						vICMS = 0.20m
					};
				case Csticms.Cst20:
					return icms20;
					//Outros casos aqui
			}

			return new ICMS10();
		}

		protected virtual ICMSBasico InformarCSOSN(Csosnicms CST)
		{
			switch (CST)
			{
				case Csosnicms.Csosn101:
					return new ICMSSN101
					{
						CSOSN = Csosnicms.Csosn101,
						orig = OrigemMercadoria.OmNacional
					};
				case Csosnicms.Csosn102:
					return new ICMSSN102
					{
						CSOSN = Csosnicms.Csosn102,
						orig = OrigemMercadoria.OmNacional
					};
				case Csosnicms.Csosn500:
					return new ICMSSN500()
					{
						CSOSN = Csosnicms.Csosn500,
						orig = OrigemMercadoria.OmNacional
					};
				//Outros casos aqui
				default:
					return new ICMSSN201();
			}
		}

		protected virtual ICMSBasico ObterIcmsBasico(CRT crt)
		{
			//Leia os dados de seu banco de dados e em seguida alimente o objeto ICMSGeral, como no exemplo abaixo.
			var icmsGeral = new ICMSGeral
			{
				orig = OrigemMercadoria.OmNacional,
				CST = Csticms.Cst00,
				modBC = DeterminacaoBaseIcms.DbiValorOperacao,
				vBC = 1.1m,
				pICMS = 18,
				vICMS = 0.20m,
				motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
			};
			return icmsGeral.ObterICMSBasico(crt);
		}

		private PISBasico ObterPisBasico()
		{
			//Leia os dados de seu banco de dados e em seguida alimente o objeto PISGeral, como no exemplo abaixo.
			var pisGeral = new PISGeral()
			{
				CST = CSTPIS.pis01,
				vBC = 1.1m,
				pPIS = 1.65m,
				vPIS = 0.01m,
				vAliqProd = 0
			};

			return pisGeral.ObterPISBasico();
		}

		private COFINSBasico ObterCofinsBasico()
		{
			//Leia os dados de seu banco de dados e em seguida alimente o objeto COFINSGeral, como no exemplo abaixo.
			var cofinsGeral = new COFINSGeral()
			{
				CST = CSTCOFINS.cofins01,
				vBC = 1.1m,
				pCOFINS = 1.65m,
				vCOFINS = 0.01m,
				vAliqProd = 0
			};

			return cofinsGeral.ObterCOFINSBasico();
		}

		private IPIBasico ObterIPIBasico()
		{
			//Leia os dados de seu banco de dados e em seguida alimente o objeto IPIGeral, como no exemplo abaixo.
			var ipiGeral = new IPIGeral()
			{
				CST = CSTIPI.ipi01,
				vBC = 1.1m,
				pIPI = 5m,
				vIPI = 0.05m
			};

			return ipiGeral.ObterIPIBasico();
		}

		#endregion

		#region Cancelar NFe
		/// <summary>
		/// Rotina para fazer o cancelamento de nota fiscal
		/// </summary>
		/// <param name="sequenciaEvento">Número sequencial do evento</param>
		/// <param name="justificativa">Justificativa para o cancelamento</param>
		/// <returns>Retorna um objeto condendo o status e uma mensagem</returns>
		public Retorno CancelarNFe(int sequenciaEvento, string justificativa)
		{
			try
			{
				var idlote = _saida.CodVenda;
				var protocolo = _saida.NumProtocolo;
				var chave = _saida.ChaveSefaz.Substring(3);

				if (string.IsNullOrEmpty(chave)) return new Retorno(false, "A Chave deve ser informada!");
				if (chave.Length != 44) return new Retorno(false, "Chave deve conter 44 caracteres!");

				if (string.IsNullOrEmpty(justificativa)) return new Retorno(false, "A justificativa deve ser informada!");

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var cpfcnpj = string.IsNullOrEmpty(_configuracoes.Emitente.CNPJ)
					? _configuracoes.Emitente.CPF
					: _configuracoes.Emitente.CNPJ;
				var retornoCancelamento = servicoNFe.RecepcaoEventoCancelamento(Convert.ToInt32(idlote),
					Convert.ToInt16(sequenciaEvento), protocolo, chave, justificativa, cpfcnpj);

				//TrataRetorno(retornoCancelamento);
				if (retornoCancelamento.Retorno.cStat != 101 && retornoCancelamento.Retorno.cStat != 135)
				{
					var retorno = retornoCancelamento.Retorno.retEvento.FirstOrDefault();
					if (retorno != null && retorno.infEvento.cStat != 135){
						return new Retorno(false, $"Erro ao tentar cancelar: {retornoCancelamento.Retorno.cStat} - {retornoCancelamento.Retorno.xMotivo}\n{retorno.infEvento.cStat} - {retorno.infEvento.xMotivo}");
					}
					else
					{
						return new Retorno(true, "");
					}
					//return new Retorno(false, $"Erro ao tentar cancelar: {retornoCancelamento.Retorno.cStat} - {retornoCancelamento.Retorno.xMotivo}");
				}
				else
				{
					return new Retorno(true, "");
				}
			}
			catch (Exception ex)
			{

				return new Retorno(false, $"Erro ao cancelar: {ex.Message}");
			}
		}
		#endregion

		public string ObterXMLSefaz(string chave){

			var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
			var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);

			return retornoConsulta.RetornoCompletoStr;

		}
	}

	public class Retorno
	{
		public Retorno(bool resultado, string mensagem)
		{
			Resultado = resultado;
			Mensagem = mensagem;
		}

		public bool Resultado { get; set; }
		public string Mensagem { get; set; }
	}
}
