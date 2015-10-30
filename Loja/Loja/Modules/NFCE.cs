using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes;
using NFe.Servicos;
using NFe.Classes.Servicos.Tipos;
using NFe.Utils.Assinatura;
using NFe.Classes.Informacoes;
using NFe.Utils;
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
using NFe.Servicos.Retorno;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using Loja.DAL.DAO;
using Loja.DAL.Models;

namespace Loja.Modules
{
	public class NFCE
	{
		private string certificado;
		private NFe.Classes.NFe _nfe;
		private ConfiguracaoApp _configuracoes;
		private tbl_Saida _saida;
		private tbl_Cliente _cliente;

		public NFCE(ConfiguracaoApp conf, tbl_Saida saida)
		{
			_configuracoes = conf;
			_saida = saida;

			if (saida.CodCliente != null)
			{
				_cliente = Consultas.ObterCliente(saida.CodCliente.Value);
			}

		}

		#region NFCE
		void CarregaCertificado()
		{
			try
			{
				certificado = CertificadoDigital.ObterDoRepositorio().SerialNumber;
			}
			catch (Exception ex)
			{
				if (ex.InnerException == null)
				{
					Util.MsgBox("Erro ao carregar o certificado digital: " + ex.Message);
				}
				else
				{
					Util.MsgBox("Erro ao carregar o certificado digital: " + ex.InnerException.Message);
				}
			}

		}

		public bool EnviaNFCE()
		{

			try
			{
				_nfe = GetNf();
				_nfe.Assina(); //não precisa validar aqui, pois o lote será validado em ServicosNFe.NFeAutorizacao

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);

				var retornoEnvio = servicoNFe.NFeAutorizacao(
					Convert.ToInt32(_saida.CodVenda),
					IndicadorSincronizacao.Assincrono,
					new List<NFe.Classes.NFe> { _nfe }
				);

				//Util.MsgBox("Arquivo gerado: " + retornoEnvio.EnvioStr);

				if (retornoEnvio.EnvioStr != null)
				{
					var valida = NFe.Wsdl.Monitor.ValidarNFE(retornoEnvio.EnvioStr);

					if (valida.Status)
					{
						valida = NFe.Wsdl.Monitor.EnviaNFE(retornoEnvio.EnvioStr, _saida.CodVenda, 0, 0);
						if (!valida.Status)
						{
							throw new Exception("Erro ao enviar NFC-e");
						}
						else
						{
							NFe.Wsdl.Monitor.ImprimirDANFE(retornoEnvio.EnvioStr);
				
						}
					}
					else
					{
						throw new Exception("Erro ao enviar NFC-e: \n" + valida.Resultado);
					}


					//NFe.Wsdl.Monitor.ImprimirDANFE(retornoEnvio.EnvioStr);
				}
				//_saida.FlgStatusNFE = retornoEnvio.Retorno.cStat.ToString();

				//TrataRetorno(retornoEnvio);

				return true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					Util.MsgBox(ex.InnerException.Message);

				}
				else {
					if (!string.IsNullOrEmpty(ex.Message))
						Util.MsgBox(ex.Message);
				}
				return false;
			}
		}

		protected virtual NFe.Classes.NFe GetNf()
		{
			var nf = new NFe.Classes.NFe { infNFe = GetInf(ModeloDocumento.NFCe, _configuracoes.CfgServico.VersaoNFeAutorizacao) };
			return nf;
		}

		protected virtual infNFe GetInf(ModeloDocumento modelo, VersaoServico versao)
		{
			var infNFe = new infNFe();

			infNFe.versao = Auxiliar.VersaoServicoParaString(versao);
			infNFe.ide = GetIdentificacao(modelo, versao);
			infNFe.emit = GetEmitente();
			if (_cliente != null)
			{
				infNFe.dest = GetDestinatario(versao);
			}
			infNFe.transp = GetTransporte();


			if (infNFe.ide.mod == ModeloDocumento.NFCe)
				infNFe.pag = GetPagamento(); //NFCe Somente               

			var itens = _saida.tbl_SaidaItens; //Consultas.ObterVendaItens(_saida.CodVenda);
			var i = 0;
			foreach (var item in itens)
			{
				infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo, item));
				i++;
			}

			infNFe.total = GetTotal(versao, infNFe.det);

			return infNFe;
		}

		protected virtual ide GetIdentificacao(ModeloDocumento modelo, VersaoServico versao)
		{
			var cnf = new Random();

			var ide = new ide
			{
				cUF = Estado.AM,
				natOp = "VENDA",
				indPag = IndicadorPagamento.ipVista,
				mod = modelo,
				serie = 1,
				nNF = _saida.CodVenda,
				tpNF = TipoNFe.tnSaida,
				cMunFG = 1302603,
				tpEmis = _configuracoes.CfgServico.tpEmis,
				tpImp = TipoImpressao.tiRetrato,
				cNF = cnf.Next(9999).ToString(),//"1234", // informar o código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e para evitar acessos indevidos da NF-e.
				tpAmb = _configuracoes.CfgServico.tpAmb,
				finNFe = FinalidadeNFe.fnNormal,
				verProc = "3.000"
			};

			if (ide.tpEmis != TipoEmissao.teNormal)
			{
				ide.dhCont =
					DateTime.Now.ToString(versao == VersaoServico.ve310
						? "yyyy-MM-ddTHH:mm:sszzz"
						: "yyyy-MM-ddTHH:mm:ss");
				ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
			}

			#region V2.00

			if (versao == VersaoServico.ve200)
			{
				ide.dEmi = DateTime.Today.ToString("yyyy-MM-dd"); //Mude aqui para enviar a nfe vinculada ao EPEC, V2.00
				ide.dSaiEnt = DateTime.Today.ToString("yyyy-MM-dd");
			}

			#endregion

			#region V3.00

			if (versao != VersaoServico.ve310) return ide;
			ide.idDest = DestinoOperacao.doInterna;
			ide.dhEmi = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
			//Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
			if (ide.mod == ModeloDocumento.NFe)
				ide.dhSaiEnt = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
			else
				ide.tpImp = TipoImpressao.tiNFCe;
			ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
			ide.indFinal = ConsumidorFinal.cfConsumidorFinal; //NFCe: Tem que ser consumidor Final
			ide.indPres = PresencaComprador.pcPresencial; //NFCe: deve ser 1 ou 4

			#endregion

			return ide;
		}

		protected virtual emit GetEmitente()
		{
			var emit = _configuracoes.Emitente;
			emit.enderEmit = GetEnderecoEmitente();
			return emit;
		}

		protected virtual dest GetDestinatario(VersaoServico versao)
		{

			var dest = new dest(versao);
			if (_cliente != null)
			{
				if (!String.IsNullOrEmpty(_cliente.NumCNPJ))
				{
					dest.CNPJ = _cliente.NumCNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
					dest.xNome = _cliente.NomCliente ?? "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
					dest.enderDest = GetEnderecoDestinatario();
					if (!String.IsNullOrEmpty(_cliente.Email))
						dest.email = _cliente.Email;
				}
				else
				{
					if (!String.IsNullOrEmpty(_cliente.NumCPF))
					{
						dest.CPF = _cliente.NumCPF.Replace(".", "").Replace("-", "");
						dest.xNome = _cliente.NomCliente ?? "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
						dest.enderDest = GetEnderecoDestinatario();
						if (!String.IsNullOrEmpty(_cliente.Email))
							dest.email = _cliente.Email;
					}
				}
			}
			else
			{
				dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
			}

			//if (versao == VersaoServico.ve200)
			//    dest.IE = "ISENTO";
			if (versao != VersaoServico.ve310) return dest;
			dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
			//dest.email = "teste@gmail.com"; //V3.00 Somente
			return dest;
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

		protected virtual List<pag> GetPagamento()
		{
			var p = new List<pag>
			{
				new pag {tPag = FormaPagamento.fpDinheiro, vPag = _saida.ValorTotal.Value}//,
				//new pag {tPag = FormaPagamento.fpCheque, vPag = 0.45m}
			};
			return p;
		}

		protected virtual det GetDetalhe(int i, CRT crt, ModeloDocumento modelo, tbl_SaidaItens item)
		{
			var det = new det
			{
				nItem = i + 1,
				prod = GetProduto(i + 1, item),
				imposto = new imposto
				{
					vTotTrib = 0,
					ICMS = new ICMS
					{
						TipoICMS =
							crt == CRT.SimplesNacional
								? InformarCSOSN(Csosnicms.Csosn500)
								: InformarICMS(Csticms.Cst50, VersaoServico.ve310)
					},
					COFINS =
						new COFINS
						{
							TipoCOFINS = new COFINSNT { CST = CSTCOFINS.cofins08 }
						},
					PIS = new PIS { TipoPIS = new PISNT { CST = CSTPIS.pis08 } }
				}
			};

			if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
				det.imposto.IPI = new IPI()
				{
					cEnq = 999,
					TipoIPI = new IPITrib() { CST = CSTIPI.ipi00, pIPI = 5, vBC = 1, vIPI = 0.05m }
				};
			//det.impostoDevol = new impostoDevol() { IPI = new IPIDevolvido() { vIPIDevol = 10 }, pDevol = 100 };

			return det;
		}

		protected virtual total GetTotal(VersaoServico versao, List<det> produtos)
		{
			var icmsTot = new ICMSTot
			{
				vProd = produtos.Sum(p => p.prod.vProd),
				vNF = produtos.Sum(p => p.prod.vProd) - produtos.Sum(p => p.prod.vDesc ?? 0),
				vDesc = produtos.Sum(p => p.prod.vDesc ?? 0),
				vTotTrib = produtos.Sum(p => p.imposto.vTotTrib ?? 0),
			};
			if (versao == VersaoServico.ve310)
				icmsTot.vICMSDeson = 0;

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

			var t = new total { ICMSTot = icmsTot };
			return t;
		}

		protected virtual enderEmit GetEnderecoEmitente()
		{
			var enderEmit = _configuracoes.EnderecoEmitente;
			enderEmit.cPais = 1058;
			enderEmit.xPais = "BRASIL";
			return enderEmit;
		}

		protected virtual enderDest GetEnderecoDestinatario()
		{

			enderDest enderDest;

			if(!String.IsNullOrEmpty(_cliente.Endereco) && !String.IsNullOrEmpty(_cliente.Numero) && !String.IsNullOrEmpty(_cliente.Bairro) &&
			!String.IsNullOrEmpty(_cliente.CEP) && !String.IsNullOrEmpty(_cliente.Cidade) && !String.IsNullOrEmpty(_cliente.Estado)
			)
			{
				enderDest = new enderDest();

				enderDest.cMun = 1302603;
				enderDest.cPais = 1058;
				enderDest.xPais = "BRASIL";
				enderDest.xMun = "MANAUS";

				enderDest.xLgr = _cliente.Endereco;

				enderDest.nro = _cliente.Numero;

				enderDest.xBairro = _cliente.Bairro;

				enderDest.CEP = _cliente.CEP;

				enderDest.UF = _cliente.Estado;
			}
			else
			{
				enderDest = null;
			}

			return enderDest;
		}

		protected virtual prod GetProduto(int i, tbl_SaidaItens item)
		{
			var p = new prod
			{
				cProd = i.ToString().PadLeft(5, '0'),
				cEAN = "",
				xProd = item.tbl_Produtos.DesProduto,
				NCM = item.tbl_Produtos.NCM ?? "99999999",
				CFOP = 5101,
				uCom = "Unidad",
				qCom = item.Quantidade,
				vUnCom = item.VlrUnitario,
				vProd = (item.VlrUnitario * item.Quantidade),
				vDesc = item.VlrDesconto,
				cEANTrib = "",
				uTrib = "Unidad",
				qTrib = item.Quantidade,
				vUnTrib = item.VlrUnitario,
				indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,
			};
			return p;
		}

		protected virtual ICMSBasico InformarICMS(Csticms CST, VersaoServico versao)
		{
			var icms20 = new ICMS20
			{
				orig = OrigemMercadoria.OmNacional,
				CST = Csticms.Cst20,
				modBC = DeterminacaoBaseIcms.DbiValorOperacao,
				vBC = 1,
				pICMS = 17,
				vICMS = 0.17m,
				motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
			};
			if (versao == VersaoServico.ve310)
				icms20.vICMSDeson = 0.10m; //V3.00 ou maior Somente

			switch (CST)
			{
				case Csticms.Cst00:
					return new ICMS00
					{
						CST = Csticms.Cst00,
						modBC = DeterminacaoBaseIcms.DbiValorOperacao,
						orig = OrigemMercadoria.OmNacional,
						pICMS = 17,
						vBC = 1,
						vICMS = 0.17m
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
					return new ICMSSN500
					{
						CSOSN = Csosnicms.Csosn500,
						orig = OrigemMercadoria.OmNacional
					};

				//Outros casos aqui
				default:
					return new ICMSSN201();
			}
		}

		private void TrataRetorno(RetornoBasico retornoBasico)
		{
			/*EnvioStr(RtbEnvioStr, retornoBasico.EnvioStr);
			RetornoStr(RtbRetornoStr, retornoBasico.RetornoStr);
			RetornoXml(WebXmlRetorno, retornoBasico.RetornoStr);
			RetornoCompletoStr(RtbRetornoCompletoStr, retornoBasico.RetornoCompletoStr);
			RetornoDados(retornoBasico.Retorno, RtbDadosRetorno);*/
		}

		#endregion

	}
}
