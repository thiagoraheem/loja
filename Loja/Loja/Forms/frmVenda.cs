using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAL.DAO;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes;
using NFe.Servicos;
using NFe.Classes.Servicos.Tipos;
using System.IO;
using System.Reflection;
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


namespace Loja
{
	public partial class frmVenda : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis

		public String CodOrcamento;
		private ConfiguracaoApp _configuracoes;
		private const string ArquivoConfiguracao = @"\configuracao.xml";
		private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		private NFe.Classes.NFe _nfe;
		private string certificado = "";

		#endregion

		public frmVenda()
		{
			InitializeComponent();
			//CarregaCertificado();
		}
		
		private void frmVenda_Load(object sender, EventArgs e)
		{
			SU_CarregaTipoVenda();
			cmbTipoVenda.EditValue = cmbTipoVenda.Properties.GetDataSourceValue(cmbTipoVenda.Properties.ValueMember, 0);
			if (CodOrcamento == "") Close();

			SU_CarregaOrcamento(CodOrcamento);
		}

		private void gridViewOrcamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			try
			{
				if (e.Column == colQuantidade)
				{
					double quantidade;

					if (e.Value != null)
						quantidade = (double)e.Value;
					else
						quantidade = 0;

					Cadastros.AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), quantidade, -1);
				}
				else
					if (e.Column == colValor)
					{
						Cadastros.AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), -1, (double)e.Value);
					}
			}
			catch (Exception ex)
			{
				Util.MsgBox("Erro na alteração: " + ex.InnerException.Message);
			}
			SU_CarregaOrcamento(CodOrcamento);
		}

		private void btnAplicarDesconto_Click(object sender, EventArgs e)
		{
			Cadastros.DescontoVenda(CodOrcamento, (double)txtDesconto.Value);
			SU_CarregaOrcamento(CodOrcamento);
		}

		private void btnFinalizarVenda_Click(object sender, EventArgs e)
		{
			try
			{
				String flgApagarOrca;
				if (chkApagarOrca.Checked)
				{
					flgApagarOrca = "S";
				}
				else
				{
					flgApagarOrca = "N";
				}
				Cadastros.FinalizaVenda(CodOrcamento, (int)cmbTipoVenda.EditValue, flgApagarOrca);
				this.DialogResult = System.Windows.Forms.DialogResult.Yes;

				if (chkEmitirRecibo.Checked)
				{
					using (frmRecibo f = new frmRecibo())
					{
						f.txtValor.Value = txtVlrTotal.Value;
						f.txtExtenso.Text = Util.toExtenso(txtVlrTotal.Value);
						f.ShowDialog();
					}
				}

			}
			catch (Exception ex)
			{
				this.DialogResult = System.Windows.Forms.DialogResult.No;
				MessageBox.Show(ex.Message);
			}

		}

		private void txtDinheiro_Validated(object sender, EventArgs e)
		{

			try
			{

				if (!txtDinheiro.Text.Equals(String.Empty) && !txtDinheiro.Text.Equals("0"))
				{
					decimal dinheiro = txtDinheiro.Value;
					decimal vlrtotal = txtVlrTotal.Value;

					if (dinheiro >= vlrtotal)
					{
						decimal troco = dinheiro - vlrtotal;
						txtTroco.EditValue = troco;
					}
					else
					{
						txtDinheiro.Text = "";
						txtDinheiro.Focus();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.No;
			Close();
		}

		#region Funções
		void CarregaCertificado()
		{
			try
			{
				var cert = new CertificadoDigital();
				certificado = cert.Serial;
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

		void SU_CarregaTipoVenda()
		{
			var TipoVenda = Consultas.ObterTipoVendaCombo();
			cmbTipoVenda.Properties.DataSource = TipoVenda;
		}

		void SU_CarregaOrcamento(String codOrca)
		{

			var orca = Consultas.ObterOrcamentos(codOrca);

			gridOrcamento.DataSource = orca.ToList();


			var total = orca.AsEnumerable().Sum(o => o.PF);

			txtVlrTotal.EditValue = total;
		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridViewOrcamento.GetSelectedRows()[0];
			codigo = (int)gridViewOrcamento.GetRowCellValue(linha, colCodigounico);

			return codigo;
		}

		void EnviaNFCE(int numVenda, int numLote) {

			try
			{
				#region Cria e Envia NFe

				//var numero = Funcoes.InpuBox(this, "Criar e Enviar NFCe", "Número da NFCe:");
				//if (string.IsNullOrEmpty(numero)) throw new Exception("O Número deve ser informado!");

				//var lote = Funcoes.InpuBox(this, "Criar e Enviar NFCe", "Id do Lote:");
				//if (string.IsNullOrEmpty(lote)) throw new Exception("A Id do lote deve ser informada!");

				_nfe = GetNf(Convert.ToInt32(numVenda), ModeloDocumento.NFCe,
					_configuracoes.CfgServico.VersaoNFeAutorizacao);
				_nfe.Assina(); //não precisa validar aqui, pois o lote será validado em ServicosNFe.NFeAutorizacao
				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
				var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(numLote), IndicadorSincronizacao.Assincrono,
					new List<NFe.Classes.NFe> { _nfe });

				TrataRetorno(retornoEnvio);

				#endregion
			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Util.MsgBox(ex.Message);
			}
		}

		protected virtual NFe.Classes.NFe GetNf(int numero, ModeloDocumento modelo, VersaoServico versao)
		{
			var nf = new NFe.Classes.NFe { infNFe = GetInf(numero, modelo, versao) };
			return nf;
		}

		protected virtual infNFe GetInf(int numero, ModeloDocumento modelo, VersaoServico versao)
		{
			var infNFe = new infNFe
			{
				versao = Auxiliar.VersaoServicoParaString(versao),
				ide = GetIdentificacao(numero, modelo, versao),
				emit = GetEmitente(),
				dest = GetDestinatario(versao),
				transp = GetTransporte()
			};

			if (infNFe.ide.mod == ModeloDocumento.NFCe)
				infNFe.pag = GetPagamento(); //NFCe Somente               

			for (var i = 0; i < 1; i++)
			{
				infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo));
			}
			infNFe.total = GetTotal(versao, infNFe.det);

			return infNFe;
		}

		protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao)
		{
			var ide = new ide
			{
				cUF = Estado.AM,
				natOp = "VENDA",
				indPag = IndicadorPagamento.ipVista,
				mod = modelo,
				serie = 1,
				nNF = numero,
				tpNF = TipoNFe.tnSaida,
				cMunFG = 1302603,
				tpEmis = _configuracoes.CfgServico.tpEmis,
				tpImp = TipoImpressao.tiRetrato,
				cNF = "1234",
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
			var dest = new dest(versao)
			{
				CNPJ = "99999999000191",
				//CPF = "99999999999",
				xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
				enderDest = GetEnderecoDestinatario()
			};

			//if (versao == VersaoServico.ve200)
			//    dest.IE = "ISENTO";
			if (versao != VersaoServico.ve310) return dest;
			dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
			dest.email = "teste@gmail.com"; //V3.00 Somente
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
				new pag {tPag = FormaPagamento.fpDinheiro, vPag = 0.45m},
				new pag {tPag = FormaPagamento.fpCheque, vPag = 0.45m}
			};
			return p;
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
						TipoICMS =
							crt == CRT.SimplesNacional
								? InformarCSOSN(Csosnicms.Csosn102)
								: InformarICMS(Csticms.Cst00, VersaoServico.ve310)
					},
					COFINS =
						new COFINS
						{
							TipoCOFINS = new COFINSOutr { CST = CSTCOFINS.cofins99, pCOFINS = 0, vBC = 0, vCOFINS = 0 }
						},
					PIS = new PIS { TipoPIS = new PISOutr { CST = CSTPIS.pis99, pPIS = 0, vBC = 0, vPIS = 0 } }
				}
			};

			if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
				det.imposto.IPI = new IPI()
				{
					cEnq = "999",
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

		protected virtual prod GetProduto(int i)
		{
			var p = new prod
			{
				cProd = i.ToString().PadLeft(5, '0'),
				cEAN = "7770000000012",
				xProd = "ABRACADEIRA NYLON 6.6 BRANCA 91X92 " + i,
				NCM = "73269000",
				CFOP = 5102,
				uCom = "UNID",
				qCom = 1,
				vUnCom = 1,
				vProd = 1,
				vDesc = 0.10m,
				cEANTrib = "7770000000012",
				uTrib = "UNID",
				qTrib = 1,
				vUnTrib = 1,
				indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,

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