using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using DFe.Utils.Assinatura;
using NFe.Classes;
using NFe.Classes.Informacoes;
using NFe.Classes.Informacoes.Cobranca;
using NFe.Classes.Informacoes.Destinatario;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Informacoes.Observacoes;
using NFe.Classes.Informacoes.Pagamento;
using NFe.Classes.Informacoes.Total;
using NFe.Classes.Informacoes.Transporte;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Servicos.Retorno;
using NFe.Utils;
using NFe.Utils.InformacoesSuplementares;
using NFe.Utils.NFe;
using NFe.Utils.Tributacao.Estadual;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using DFe.Classes.Extensoes;
using NFe.Danfe.Nativo.NFCe;
using NFe.Utils.Excecoes;
using NFeZeus = NFe.Classes.NFe;
using NFe.Utils.Tributacao.Federal;
using DevExpress.XtraRichEdit;
using Loja.DAL.DAO;

namespace Loja.Forms
{
	public partial class frmParametros : DevExpress.XtraEditors.XtraForm
	{

		private const string ArquivoConfiguracao = @"\configuracao.xml";

		private const string TituloErro = "Erro";
		private ConfiguracaoApp _configuracoes;
		private NFe.Classes.NFe _nfe;
		private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		private Loja.DAL.Models.tbl_Parametros parametros = new DAL.Models.tbl_Parametros();

		public frmParametros()
		{
			ServicePointManager.ServerCertificateValidationCallback = delegate { return true; }; // não precisa de cadeia de certificado digital 
			InitializeComponent();
			CarregarConfiguracao();
		}

		#region Funções Gerais

		private void AtualizaTela()
		{
			if (_configuracoes == null)
			{
				_configuracoes = new ConfiguracaoApp();
			}
			radTipoCertificado.DataBindings.Add("EditValue", _configuracoes.CfgServico.Certificado, "TipoCertificado");
			txtArquivoCertificado.DataBindings.Add("EditValue", _configuracoes.CfgServico.Certificado, "Arquivo");
			txtCertificado.DataBindings.Add("EditValue", _configuracoes.CfgServico.Certificado, "Serial");
			txtSenhaCertificado.DataBindings.Add("EditValue", _configuracoes.CfgServico.Certificado, "Senha");
			chkManterDadosCert.DataBindings.Add("EditValue", _configuracoes.CfgServico.Certificado, "ManterDadosEmCache");

			radFormaEmissao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "tpEmis");
			radTipoDocumento.DataBindings.Add("EditValue", _configuracoes.CfgServico, "ModeloDocumento");
			radVersaoQRCode.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoDanfeNfce, "VersaoQrCode");
			txtIdentificadorCSC.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoCsc, "CIdToken");
			txtNumCSC.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoCsc, "Csc");
			txtDiretorioSchema.DataBindings.Add("EditValue", _configuracoes.CfgServico, "DiretorioSchemas");
			txtDiretorioXML.DataBindings.Add("EditValue", _configuracoes.CfgServico, "DiretorioSalvarXml");
			chkSalvarXML.DataBindings.Add("EditValue", _configuracoes.CfgServico, "SalvarXmlServicos");

			cmbUF_Destino.DataBindings.Add("EditValue", _configuracoes.CfgServico, "cUF");
			radAmbiente.DataBindings.Add("EditValue", _configuracoes.CfgServico, "tpAmb");
			radVersao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoLayout");
			radSeguranca.DataBindings.Add("EditValue", _configuracoes.CfgServico, "ProtocoloDeSeguranca");
			txtTimeOut.DataBindings.Add("EditValue", _configuracoes.CfgServico, "TimeOut");
			chkValidarServidor.DataBindings.Add("EditValue", _configuracoes.CfgServico, "ValidarCertificadoDoServidor");
			chkVersaoAutomatica.DataBindings.Add("EditValue", _configuracoes.CfgServico, "DefineVersaoServicosAutomaticamente");

			radRecepcaoEventoCceCancelamento.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoRecepcaoEventoCceCancelamento");
			radRecepcaoEventoEpec.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoRecepcaoEventoEpec");
			radRecepcaoEventoManifestacaoDestinatario.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoRecepcaoEventoManifestacaoDestinatario");
			radNfeRecepcao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeRecepcao");
			radNfeRetRecepcao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeRetRecepcao");
			radNfeConsultaCadastro.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeConsultaCadastro");
			radNfeInutilizacao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeInutilizacao");
			radNfeConsultaProtocolo.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeConsultaProtocolo");
			radNfeStatusServico.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeStatusServico");
			radNFeAutorizacao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNFeAutorizacao");
			radNFeRetAutorizacao.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNFeRetAutorizacao");
			radNFeDistribuicaoDFe.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNFeDistribuicaoDFe");
			radNfeConsultaDest.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeConsultaDest");
			radNfeDownloadNF.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfeDownloadNF");
			radadmCscNFCe.DataBindings.Add("EditValue", _configuracoes.CfgServico, "VersaoNfceAministracaoCSC");


			TxtEmitCnpj.DataBindings.Add("EditValue", _configuracoes.Emitente, "CNPJ");
			TxtEmitIe.DataBindings.Add("EditValue", _configuracoes.Emitente, "IE");
			TxtEmitRazao.DataBindings.Add("EditValue", _configuracoes.Emitente, "xNome");
			TxtEmitFantasia.DataBindings.Add("EditValue", _configuracoes.Emitente, "xFant");
			TxtEmitFone.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "fone");
			TxtEmitCep.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "CEP");
			TxtEmitLogradouro.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "xLgr");
			TxtEmitNumero.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "nro");
			TxtEmitComplemento.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "xCpl");
			TxtEmitBairro.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "xBairro");
			txtEmitCodCidade.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "cMun");
			txtEmitCidade.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "xMun");
			cmbEmitUF.DataBindings.Add("EditValue", _configuracoes.EnderecoEmitente, "UF");
			cmbCRT.DataBindings.Add("EditValue", _configuracoes.Emitente, "CRT");

			txtSMTP.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "ServidorSmtp");
			TxtPorta.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Porta");
			txtUsuario.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Email");
			txtSenha.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Senha");
			txtAssunto.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Assunto");
			txtTimeOutEmail.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Timeout");
			chkAssincrono.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Assincrono");
			chkEnviarHTML.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "MensagemEmHtml");
			chkConexaoSegura.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Ssl");
			memMensagem.DataBindings.Add("EditValue", _configuracoes.ConfiguracaoEmail, "Mensagem");

			cmbImpressoraPadrao.DataBindings.Add("EditValue", _configuracoes, "ImpressoraPadrao");
		}

		public void CarregaParametros()
		{
			txtEmpresaNome.EditValue = parametros.EmpresaNome;
			txtEmpresaEndereco.EditValue = parametros.EmpresaEndereco;
			txtEmpresaTelefone.EditValue = parametros.EmpresaTelefone;
			txtEmpresaEmail.EditValue = parametros.EmpresaEmail;
			txtEmpresaWebSite.EditValue = parametros.EmpresaWebSite;
			txtEmpresaSlogan.EditValue = parametros.EmpresaSlogan;
			txtEmpresaCNPJ.EditValue = parametros.EmpresaCNPJ;
			txtEmpresaInscEstadual.EditValue = parametros.EmpresaInscEstadual;

			txtSisCodVenda.EditValue = parametros.SisCodVenda;
			txtSisNumNF.EditValue = parametros.SisNumNF;

		}

		public void AtualizaParametros()
		{
			parametros.EmpresaNome = txtEmpresaNome.EditValue.ToString();
			parametros.EmpresaEndereco = txtEmpresaEndereco.EditValue.ToString();
			parametros.EmpresaTelefone = txtEmpresaTelefone.EditValue.ToString();
			parametros.EmpresaEmail = txtEmpresaEmail.EditValue.ToString();
			parametros.EmpresaWebSite = txtEmpresaWebSite.EditValue.ToString();
			parametros.EmpresaSlogan = txtEmpresaSlogan.EditValue.ToString();
			parametros.EmpresaCNPJ = txtEmpresaCNPJ.EditValue.ToString();
			parametros.EmpresaInscEstadual = txtEmpresaInscEstadual.EditValue.ToString();

			parametros.SisCodVenda = (int)txtSisCodVenda.EditValue;
			parametros.SisNumNF = int.Parse(txtSisNumNF.EditValue.ToString());

		}

		private void CarregaDadosCertificado()
		{
			try
			{
				//var cert = CertificadoDigital.ListareObterDoRepositorio();
				var cert = CertificadoDigital.ObterCertificado(_configuracoes.CfgServico.Certificado);
				_configuracoes.CfgServico.Certificado.Serial = cert.SerialNumber;
				txtCertificado.Text = cert.SerialNumber;
				//TxtValidade.Text = "Validade: " + cert.GetExpirationDateString();
			}
			catch (Exception ex)
			{
				Funcoes.Mensagem(ex.Message, TituloErro, MessageBoxButtons.OK);
			}
		}

		private void CarregarConfiguracao()
		{
			var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			try
			{
				_configuracoes = !File.Exists(path + ArquivoConfiguracao)
					? new ConfiguracaoApp()
					: FuncoesXml.ArquivoXmlParaClasse<ConfiguracaoApp>(path + ArquivoConfiguracao);
				if (_configuracoes.CfgServico.TimeOut == 0)
					_configuracoes.CfgServico.TimeOut = 3000; //mínimo

				#region Carrega a logo no controle logoEmitente

				if (_configuracoes.ConfiguracaoDanfeNfce.Logomarca != null && _configuracoes.ConfiguracaoDanfeNfce.Logomarca.Length > 0)
					using (var stream = new MemoryStream(_configuracoes.ConfiguracaoDanfeNfce.Logomarca))
					{
						//var logo = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
						LogoEmitente.Image = Image.FromStream(stream); //BitmapFromSource(logo);
					}

				#endregion
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void SalvarConfiguracao()
		{
			try
			{
				_configuracoes.SalvarParaAqruivo($"{_path}{ArquivoConfiguracao}");
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem($"{ex.Message} \n\nDetalhes: {ex.InnerException}", "Erro", MessageBoxButtons.OK);
			}
		}

		private void TrataRetorno(RetornoBasico retornoBasico)
		{
			EnvioStr(RtbEnvioStr, retornoBasico.EnvioStr);
			RetornoStr(RtbRetornoStr, retornoBasico.RetornoStr);
			RetornoXml(WebXmlRetorno, retornoBasico.RetornoStr);
			RetornoCompletoStr(RtbRetornoCompletoStr, retornoBasico.RetornoCompletoStr);
			RetornoDados(retornoBasico.Retorno, RtbDadosRetorno);
		}

		private void CarregarImpressoras()
		{
			try
			{
				cmbImpressoraPadrao.Properties.Items.Clear();

				foreach (var item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
				{
					cmbImpressoraPadrao.Properties.Items.Add(item.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		#endregion
		#region Tratamento de retornos dos Serviços

		internal void RetornoDados<T>(T objeto, RichEditControl richTextBox) where T : class
		{
			richTextBox.CreateNewDocument();

			foreach (var atributos in objeto.LerPropriedades())
			{
				richTextBox.Document.AppendText(atributos.Key + " = " + atributos.Value + "\r");
			}
		}

		internal void RetornoCompletoStr(RichEditControl richTextBox, string retornoCompletoStr)
		{
			richTextBox.CreateNewDocument();
			richTextBox.Document.AppendText(retornoCompletoStr);
		}

		internal void EnvioStr(RichEditControl richTextBox, string envioStr)
		{
			richTextBox.CreateNewDocument();
			richTextBox.Document.AppendText(envioStr);
		}

		internal void RetornoXml(System.Windows.Forms.WebBrowser webBrowser, string retornoXmlString)
		{
			var stw = new StreamWriter(_path + @"\tmp.xml");
			stw.WriteLine(retornoXmlString);
			stw.Close();
			webBrowser.Navigate(_path + @"\tmp.xml");
		}

		internal void RetornoStr(RichEditControl richTextBox, string retornoXmlString)
		{
			richTextBox.CreateNewDocument();
			richTextBox.Document.AppendText(retornoXmlString);
		}

		#endregion

		#region Criar NFe

		protected virtual NFe.Classes.NFe GetNf(int numero, ModeloDocumento modelo, VersaoServico versao)
		{
			var nf = new NFe.Classes.NFe { infNFe = GetInf(numero, modelo, versao) };
			return nf;
		}

		protected virtual infNFe GetInf(int numero, ModeloDocumento modelo, VersaoServico versao)
		{
			var infNFe = new infNFe
			{
				versao = versao.VersaoServicoParaString(),
				ide = GetIdentificacao(numero, modelo, versao),
				emit = GetEmitente(),
				dest = GetDestinatario(versao, modelo),
				transp = GetTransporte()
			};

			for (var i = 0; i < 5; i++)
			{
				infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo));
			}

			infNFe.total = GetTotal(versao, infNFe.det);

			if (infNFe.ide.mod == ModeloDocumento.NFe & (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400))
				infNFe.cobr = GetCobranca(infNFe.total.ICMSTot); //V3.00 e 4.00 Somente
			if (infNFe.ide.mod == ModeloDocumento.NFCe || (infNFe.ide.mod == ModeloDocumento.NFe & versao == VersaoServico.Versao400))
				infNFe.pag = GetPagamento(infNFe.total.ICMSTot, versao); //NFCe Somente  

			if (infNFe.ide.mod == ModeloDocumento.NFCe & versao != VersaoServico.Versao400)
				infNFe.infAdic = new infAdic() { infCpl = "Troco: 10,00" }; //Susgestão para impressão do troco em NFCe

			return infNFe;
		}

		protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao)
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
				cNF = "1234",
				tpAmb = _configuracoes.CfgServico.tpAmb,
				finNFe = FinalidadeNFe.fnNormal,
				verProc = "3.000"
			};

			if (ide.tpEmis != TipoEmissao.teNormal)
			{
				ide.dhCont = DateTime.Now;
				ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
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
			var dest = new dest(versao)
			{
				CNPJ = "99999999000191",
				//CPF = "99999999999",
			};
			if (modelo == ModeloDocumento.NFe)
			{
				dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"; //Obrigatório para NFe e opcional para NFCe
				dest.enderDest = GetEnderecoDestinatario(); //Obrigatório para NFe e opcional para NFCe
			}

			//if (versao == VersaoServico.ve200)
			//    dest.IE = "ISENTO";
			if (versao == VersaoServico.Versao200) return dest;

			dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
			dest.email = "teste@gmail.com"; //V3.00 Somente
			return dest;
		}

		protected virtual enderDest GetEnderecoDestinatario()
		{
			var enderDest = new enderDest
			{
				xLgr = "RUA ...",
				nro = "S/N",
				xBairro = "CENTRO",
				cMun = 2802908,
				xMun = "ITABAIANA",
				UF = "SE",
				CEP = "49500000",
				cPais = 1058,
				xPais = "BRASIL"
			};
			return enderDest;
		}

		protected virtual det GetDetalhe(int i, CRT crt, ModeloDocumento modelo)
		{
			var det = new det
			{
				nItem = i + 1,
				prod = GetProduto(i + 1),
				imposto = new imposto
				{
					vTotTrib = 0.17m,

					ICMS = new ICMS
					{
						//Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do ICMS
						//TipoICMS = ObterIcmsBasico(crt),

						//Caso você resolva utilizar método ObterIcmsBasico(), comente esta proxima linha
						TipoICMS =
							crt == CRT.SimplesNacional
								? InformarCSOSN(Csosnicms.Csosn102)
								: InformarICMS(Csticms.Cst00, VersaoServico.Versao310)
					},

					//ICMSUFDest = new ICMSUFDest()
					//{
					//    pFCPUFDest = 0,
					//    pICMSInter = 12,
					//    pICMSInterPart = 0,
					//    pICMSUFDest = 0,
					//    vBCUFDest = 0,
					//    vFCPUFDest = 0,
					//    vICMSUFDest = 0,
					//    vICMSUFRemet = 0
					//},

					COFINS = new COFINS
					{
						//Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do COFINS
						//TipoCOFINS = ObterCofinsBasico(),

						//Caso você resolva utilizar método ObterCofinsBasico(), comente esta proxima linha
						TipoCOFINS = new COFINSOutr { CST = CSTCOFINS.cofins99, pCOFINS = 0, vBC = 0, vCOFINS = 0 }
					},

					PIS = new PIS
					{
						//Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do PIS
						//TipoPIS = ObterPisBasico(),

						//Caso você resolva utilizar método ObterPisBasico(), comente esta proxima linha
						TipoPIS = new PISOutr { CST = CSTPIS.pis99, pPIS = 0, vBC = 0, vPIS = 0 }
					}
				}
			};

			if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
			{
				det.imposto.IPI = new IPI()
				{
					cEnq = 999,

					//Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do IPI
					//TipoIPI = ObterIPIBasico(),

					//Caso você resolva utilizar método ObterIPIBasico(), comente esta proxima linha
					TipoIPI = new IPITrib() { CST = CSTIPI.ipi00, pIPI = 5, vBC = 1, vIPI = 0.05m }
				};
			}

			//det.impostoDevol = new impostoDevol() { IPI = new IPIDevolvido() { vIPIDevol = 10 }, pDevol = 100 };

			return det;
		}

		protected virtual prod GetProduto(int i)
		{
			var p = new prod
			{
				cProd = i.ToString().PadLeft(5, '0'),
				cEAN = "7770000000012",
				xProd = i == 1 ? "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL" : "ABRACADEIRA NYLON 6.6 BRANCA 91X92 " + i,
				NCM = "84159090",
				CFOP = 5102,
				uCom = "UNID",
				qCom = 1,
				vUnCom = 1.1m,
				vProd = 1.1m,
				vDesc = 0.10m,
				cEANTrib = "7770000000012",
				uTrib = "UNID",
				qTrib = 1,
				vUnTrib = 1.1m,
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
				//Outros casos aqui
				default:
					return new ICMSSN201();
			}
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
			var c = new cobr
			{
				fat = new fat { nFat = "12345678910", vLiq = icmsTot.vNF, vOrig = icmsTot.vNF, vDesc = 0m },
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
			var valorPagto = Valor.Arredondar(icmsTot.vNF / 2, 2);

			if (versao != VersaoServico.Versao400) // difernte de versão 4 retorna isso
			{
				var p = new List<pag>
				{
					new pag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto},
					new pag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}
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
						new detPag {tPag = FormaPagamento.fpDuplicataMercantil, vPag = valorPagto},
						new detPag {tPag = FormaPagamento.fpDuplicataMercantil, vPag = icmsTot.vNF - valorPagto}
					}
				}
			};


			return p4;
		}

		private void GeranNfe(VersaoServico versaoServico, ModeloDocumento modelo, string numero)
		{
			try
			{
				#region Gerar NFe

				//var numero = Funcoes.InpuBox("Criar e Enviar NFe", "Número da Nota:");
				if (string.IsNullOrEmpty(numero)) throw new Exception("O Número deve ser informado!");

				_nfe = GetNf(Convert.ToInt32(numero), modelo, versaoServico);

				_nfe.Assina();

				if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
				{
					_nfe.infNFeSupl = new infNFeSupl();
					if (versaoServico == VersaoServico.Versao400)
						_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrlConsulta(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode);
					_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
				}


				/*if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe &&
					_configuracoes.CfgServico.VersaoNFeAutorizacao == VersaoServico.ve400)
				{
					_nfe.infNFeSupl = new infNFeSupl();
					_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrl(_configuracoes.CfgServico.tpAmb, _configuracoes.CfgServico.cUF, TipoUrlConsultaPublica.UrlQrCode, VersaoServico.ve400, TipoUrlConsultaPublica.UrlQrCode);
				}
				if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
				{
					if (_nfe.infNFeSupl == null)
					{
						_nfe.infNFeSupl = new infNFeSupl();
					}
					_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
				}*/

				_nfe.Valida();

				#endregion

				ExibeNfe();

				var dlg = new SaveFileDialog
				{
					FileName = _nfe.infNFe.Id.Substring(3),
					DefaultExt = ".xml",
					Filter = "Arquivo XML (.xml)|*.xml"
				};
				var result = dlg.ShowDialog();
				if (result != true) return;
				var arquivoXml = dlg.FileName;
				_nfe.SalvarArquivoXml(arquivoXml);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void ExibeNfe()
		{
			_nfe.SalvarArquivoXml(_path + @"\tmp.xml");
			WebXmlNfe.Navigate(_path + @"\tmp.xml");
			tabStatusNFE.Select();
		}

		#endregion

		#region Eventos
		private void frmParametros_Load(object sender, EventArgs e)
		{
			var estados = Enum.GetValues(typeof(Estado)).Cast<Estado>().ToList().OrderBy(x => x.GetSiglaUfString());
			cmbUF_Destino.Properties.DataSource = estados;

			var novoUF = Enum.GetValues(typeof(Estado)).Cast<Estado>().ToList().OrderBy(x => x.GetSiglaUfString());
			cmbEmitUF.Properties.DataSource = novoUF.Select(x => x.GetSiglaUfString());

			var crts = Enum.GetValues(typeof(CRT)).Cast<CRT>().ToList();
			cmbCRT.Properties.DataSource = crts;

			parametros = Consultas.ObterParametros();

			CarregarImpressoras();

			AtualizaTela();
			CarregaParametros();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			SalvarConfiguracao();
			AtualizaParametros();
			Cadastros.GravaParametros(parametros);

		}

		private void txtCertificado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			CarregaDadosCertificado();
		}

		private void txtArquivoCertificado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (_configuracoes.CfgServico.Certificado.TipoCertificado == TipoCertificado.A1ByteArray)
			{
				var caminhoArquivo = Funcoes.BuscarArquivoCertificado();
				if (!string.IsNullOrWhiteSpace(caminhoArquivo))
				{
					_configuracoes.CfgServico.Certificado.ArrayBytesArquivo = File.ReadAllBytes(caminhoArquivo);
					_configuracoes.CfgServico.Certificado.Arquivo = null;
				}
				txtArquivoCertificado.Text = caminhoArquivo;
			}
			else if (_configuracoes.CfgServico.Certificado.TipoCertificado == TipoCertificado.A1Arquivo)
			{
				_configuracoes.CfgServico.Certificado.Arquivo = Funcoes.BuscarArquivoCertificado();
				txtArquivoCertificado.Text = _configuracoes.CfgServico.Certificado.Arquivo;
			}
		}

		private void btnImagem_Click(object sender, EventArgs e)
		{
			var arquivo = Funcoes.BuscarImagem();
			if (string.IsNullOrEmpty(arquivo)) return;
			var imagem = Image.FromFile(arquivo);
			//LogoEmitente.Image = Image.FromStream((new BitmapImage(new Uri(arquivo))).StreamSource);

			_configuracoes.ConfiguracaoDanfeNfce.Logomarca = new byte[0];
			using (var stream = new MemoryStream())
			{
				imagem.Save(stream, ImageFormat.Png);
				LogoEmitente.Image = Image.FromStream(stream);
				stream.Close();
				_configuracoes.ConfiguracaoDanfeNfce.Logomarca = stream.ToArray();
			}
		}

		private void btnRemoverImagem_Click(object sender, EventArgs e)
		{
			LogoEmitente.Image = null;
			_configuracoes.ConfiguracaoDanfeNfce.Logomarca = null;
		}

		private void btnStatus_Click(object sender, EventArgs e)
		{
			try
			{
				#region Status do serviço
				//Exemplo com using para chamar o método Dispose da classe.
				//Usar dessa forma, especialmente, quando for usar certificado A3 com a senha salva.
				// se usar cache você pode por um id no certificado e salvar mais de um certificado digital também na memoria com o zeus
				//_configuracoes.CfgServico.Certificado.CacheId = "1";
				using (var servicoNFe = new ServicosNFe(_configuracoes.CfgServico))
				{
					var retornoStatus = servicoNFe.NfeStatusServico();
					TrataRetorno(retornoStatus);
				}

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnInutilizar_Click(object sender, EventArgs e)
		{
			try
			{
				#region Inutiliza Numeração

				var ano = Funcoes.InpuBox("Inutilizar Numeração", "Ano - dois dígitos somente. Ex: 17");
				if (string.IsNullOrEmpty(ano)) throw new Exception("O Ano deve ser informado!");
				if (ano.Length > 2) throw new Exception("O Ano deve ter dois números apenas!");

				var modelostr = Funcoes.InpuBox("Inutilizar Numeração", "Modelo");
				if (string.IsNullOrEmpty(modelostr)) throw new Exception("O Modelo deve ser informado!");

				var modelo = (ModeloDocumento)Convert.ToInt16(modelostr);

				var serie = Funcoes.InpuBox("Inutilizar Numeração", "Série");
				if (string.IsNullOrEmpty(serie)) throw new Exception("A série deve ser informada!");

				var numeroInicial = Funcoes.InpuBox("Inutilizar Numeração", "Número Inicial");
				if (string.IsNullOrEmpty(numeroInicial)) throw new Exception("O Número Inicial deve ser informado!");

				var numeroFinal = Funcoes.InpuBox("Inutilizar Numeração", "Número Final");
				if (string.IsNullOrEmpty(numeroFinal)) throw new Exception("O Número Final deve ser informado!");

				var justificativa = Funcoes.InpuBox("Inutilizar Numeração", "Justificativa");
				if (string.IsNullOrEmpty(justificativa)) throw new Exception("A Justificativa deve ser informada!");

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoConsulta = servicoNFe.NfeInutilizacao(_configuracoes.Emitente.CNPJ, Convert.ToInt16(ano),
					modelo, Convert.ToInt16(serie), Convert.ToInt32(numeroInicial),
					Convert.ToInt32(numeroFinal), justificativa);

				TrataRetorno(retornoConsulta);

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnCriarEnviar_Click(object sender, EventArgs e)
		{
			try
			{
				#region Cria e Envia NFe

				var numero = Funcoes.InpuBox("Criar e Enviar NFe", "Número da Nota:");
				if (string.IsNullOrEmpty(numero)) throw new Exception("O Número deve ser informado!");

				var lote = Funcoes.InpuBox("Criar e Enviar NFe", "Id do Lote:");
				if (string.IsNullOrEmpty(lote)) throw new Exception("A Id do lote deve ser informada!");

				_nfe = GetNf(Convert.ToInt32(numero), _configuracoes.CfgServico.ModeloDocumento,
					_configuracoes.CfgServico.VersaoNFeAutorizacao);

				/*if (_nfe.infNFe.ide.mod == ModeloDocumento.NFCe &&
					_configuracoes.CfgServico.VersaoNFeAutorizacao == VersaoServico.ve400)
				{
					_nfe.infNFeSupl = new infNFeSupl();
					_nfe.infNFeSupl.urlChave = _nfe.infNFeSupl.ObterUrl(_configuracoes.CfgServico.tpAmb, _configuracoes.CfgServico.cUF, TipoUrlConsultaPublica.UrlConsulta);
				}*/

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
							//qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc)
						};
					}
					else
					{
						//_nfe.infNFeSupl.qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc);
					}

				}*/

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { _nfe }, true/*Envia a mensagem compactada para a SEFAZ*/);
				//Para consumir o serviço de forma síncrona, use a linha abaixo:
				//var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Sincrono, new List<Classes.NFe> { _nfe }, true/*Envia a mensagem compactada para a SEFAZ*/);

				TrataRetorno(retornoEnvio);

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				//Faça o tratamento de contingência OffLine aqui.
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnImprimirDANFE_Click(object sender, EventArgs e)
		{
			string arquivoXml = Funcoes.BuscarArquivoXml();
			try
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
					nfe = new NFe.Classes.NFe().CarregarDeArquivoXml(arquivoXml);
					arquivo = nfe.ObterXmlString();
				}



				DanfeNativoNfce impr = new DanfeNativoNfce(arquivo,
					_configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode,
					_configuracoes.ConfiguracaoDanfeNfce.Logomarca,
					_configuracoes.ConfiguracaoCsc.CIdToken,
					_configuracoes.ConfiguracaoCsc.Csc,
					0 /*troco*//*, "Arial Black"*/);
				/*
				SaveFileDialog fileDialog = new SaveFileDialog();

				fileDialog.ShowDialog();

				if (string.IsNullOrEmpty(fileDialog.FileName))
					throw new ArgumentException("Não foi selecionado nem uma pasta");

				//impr.Imprimir(salvarArquivoPdfEm: fileDialog.FileName.Replace(".pdf", "") + ".pdf");*/
				var caminho = chkPDF.Checked ? arquivoXml.Replace(".xml", ".pdf") : "";
				impr.Imprimir(_configuracoes.ImpressoraPadrao, salvarArquivoPdfEm: caminho);

				//impr.GerarJPEG(fileDialog.FileName.Replace(".jpeg", "") + ".jpeg");

			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
				{
					Funcoes.Mensagem(ex.Message, TituloErro, MessageBoxButtons.OK);
				}
			}
		}

		private void btnConsultaRecibo_Click(object sender, EventArgs e)
		{
			try
			{
				#region Consulta Recibo de lote

				var recibo = Funcoes.InpuBox("Consultar processamento de lote de NF-e", "Número do recibo:");
				if (string.IsNullOrEmpty(recibo)) throw new Exception("O número do recibo deve ser informado!");
				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);

				TrataRetorno(retornoRecibo);

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnAddProc_Click(object sender, EventArgs e)
		{
			try
			{
				var arquivoXml = Funcoes.BuscarArquivoXml();

				if (string.IsNullOrWhiteSpace(arquivoXml))
					return;

				var nfe = new NFe.Classes.NFe().CarregarDeArquivoXml(arquivoXml);
				var chave = nfe.infNFe.Id.Substring(3);

				if (string.IsNullOrEmpty(chave)) throw new Exception("A Chave da NFe não foi encontrada no arquivo!");
				if (chave.Length != 44) throw new Exception("Chave deve conter 44 caracteres!");

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);
				TrataRetorno(retornoConsulta);

				var nfeproc = new nfeProc
				{
					NFe = nfe,
					protNFe = retornoConsulta.Retorno.protNFe,
					versao = retornoConsulta.Retorno.versao
				};
				if (nfeproc.protNFe != null)
				{
					var novoArquivo = Path.GetDirectoryName(arquivoXml) + @"\" + nfeproc.protNFe.infProt.chNFe +
									  "-procNfe.xml";
					FuncoesXml.ClasseParaArquivoXml(nfeproc, novoArquivo);
					Funcoes.Mensagem("Arquivo salvo em " + novoArquivo, "Atenção", MessageBoxButtons.OK);
				}
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnGerarNFe_Click(object sender, EventArgs e)
		{
			var numero = Funcoes.InpuBox("Criar e Enviar NFe", "Número da Nota:");
			GeranNfe(_configuracoes.CfgServico.VersaoNFeAutorizacao, _configuracoes.CfgServico.ModeloDocumento, numero);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			try
			{
				#region Cancelar NFe

				var idlote = Funcoes.InpuBox("Cancelar NFe", "Identificador de controle do Lote de envio:");
				if (string.IsNullOrEmpty(idlote)) throw new Exception("A Id do Lote deve ser informada!");

				var sequenciaEvento = Funcoes.InpuBox("Cancelar NFe", "Número sequencial do evento:");
				if (string.IsNullOrEmpty(sequenciaEvento))
					throw new Exception("O número sequencial deve ser informado!");

				var protocolo = Funcoes.InpuBox("Cancelar NFe", "Protocolo de Autorização da NFe:");
				if (string.IsNullOrEmpty(protocolo)) throw new Exception("O protocolo deve ser informado!");

				var chave = Funcoes.InpuBox("Cancelar NFe", "Chave da NFe:");
				if (string.IsNullOrEmpty(chave)) throw new Exception("A Chave deve ser informada!");
				if (chave.Length != 44) throw new Exception("Chave deve conter 44 caracteres!");

				var justificativa = Funcoes.InpuBox("Cancelar NFe", "Justificativa");
				if (string.IsNullOrEmpty(justificativa)) throw new Exception("A justificativa deve ser informada!");

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var cpfcnpj = string.IsNullOrEmpty(_configuracoes.Emitente.CNPJ)
					? _configuracoes.Emitente.CPF
					: _configuracoes.Emitente.CNPJ;
				var retornoCancelamento = servicoNFe.RecepcaoEventoCancelamento(Convert.ToInt32(idlote),
					Convert.ToInt16(sequenciaEvento), protocolo, chave, justificativa, cpfcnpj);
				TrataRetorno(retornoCancelamento);

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		#endregion

		private void btnConsultarNF_Click(object sender, EventArgs e)
		{
			try
			{
				#region Consulta Situação NFe

				var chave = Funcoes.InpuBox("Consultar NFe pela Chave", "Chave da NFe:");
				if (string.IsNullOrEmpty(chave)) throw new Exception("A Chave deve ser informada!");
				if (chave.Length != 44) throw new Exception("Chave deve conter 44 caracteres!");

				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoConsulta = servicoNFe.NfeConsultaProtocolo(chave);
				TrataRetorno(retornoConsulta);

				#endregion
			}
			catch (ComunicacaoException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (ValidacaoSchemaException ex)
			{
				Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}
	}
}