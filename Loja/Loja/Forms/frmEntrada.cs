using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using Loja.DAL.Models;
using Loja.DAL.DAO;

using NFe.Classes;
using NFe.Utils;
using NFe.Utils.NFe;
using NFe.Wsdl;
using System.Data.Entity;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;

namespace Loja
{
	public partial class frmEntrada : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis
		List<tbl_EntradaItens> itens;
		tbl_Entrada capa;

		#endregion

		#region Form Events

		public frmEntrada()
		{
			InitializeComponent();

			SU_CarregaProdutos();
			SU_CarregaTipoEntrada();

			grdDados.DataSource = itens;

			capa = new tbl_Entrada();
			capa.CodEntrada = -1;

			txtDocEntrada.DataBindings.Add(new Binding("EditValue", capa, "DocEntrada"));
			txtDatEmissao.DataBindings.Add(new Binding("EditValue", capa, "DatEmissao"));
			txtNome.DataBindings.Add(new Binding("EditValue", capa, "Nome"));
			txtNumCNPJ.DataBindings.Add(new Binding("EditValue", capa, "CNPJ"));
			txtSerieNota.DataBindings.Add(new Binding("EditValue", capa, "SerieNota"));
			cmbTipoEntrada.DataBindings.Add(new Binding("EditValue", capa, "CodTipoEntrada"));

			itens = new List<tbl_EntradaItens>();
		}

		private void frmEntrada_Load(object sender, EventArgs e)
		{

		}
		#endregion

		#region Botões
		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{

			if (capa == null) return;
			if (!itens.Any()) return;

			Cadastros.GravaEntrada(capa);


			#region Depreciado
			/*int CodTipoEntrada;

			if (cmbTipoEntrada.EditValue == null)
			{
				CodTipoEntrada = -1;
			}
			else
			{
				CodTipoEntrada = (int)cmbTipoEntrada.EditValue;
			}

			if (cmbProduto.EditValue == null)
			{
				MessageBox.Show("Escolha um produto");
				cmbProduto.Focus();
				return;
			}

			if (txtQuantidade.EditValue == null)
			{
				MessageBox.Show("Informe a quantidade");
				txtQuantidade.Focus();
				return;
			}

			if (txtVlrUnitario.EditValue == null)
			{
				MessageBox.Show("Informe o valor unitário");
				txtVlrUnitario.Focus();
				return;
			}

			try
			{

				Cadastros.AdicionarEntrada(txtDocEntrada.Text, (DateTime)txtDatEmissao.EditValue, (int)cmbCodProduto.EditValue,
											(double)txtQuantidade.Value, txtVlrUnitario.Value, CodTipoEntrada, (double)txtPercentual.Value, cmbFornecedor.Text);

			}
			catch (Exception ex)
			{
				Util.MsgBox(ex.Message);
			}
			SU_LimpaTela();
			if (chkContinuar.Checked)
			{
				Close();
			}

			SU_CarregaFornecedor();
			SU_CarregaEntrada();*/
			#endregion
		}

		private void btnCarregarNF_Click(object sender, EventArgs e)
		{

			if (!String.IsNullOrEmpty(txtNumChave.Text))
			{
				var cnpj = Util.SemFormatacao(Properties.Settings.Default.CNPJ.ToString());
				var nfe = Monitor.DownloadNFe(cnpj, txtNumChave.Text);

				var arquivoXml = "";

				var nf = new NFe.Classes.NFe().CarregarDeArquivoXml(arquivoXml);
			}
			else
			{
				Util.MsgBox("Informe a chave de acesso da NF de Entrada");

				txtNumChave.Focus();
			}

		}

		private void btnImportarXML_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtArquivoXML.Text))
			{
				var nf = new NFe.Classes.NFe().CarregarDeArquivoXml(txtArquivoXML.Text);
				SU_ImportarNF(nf);
			}

		}

		private void btnIncluir_Click(object sender, EventArgs e)
		{

			if (cmbCodProduto.EditValue != null)
			{

				if (!itens.Any(x => x.codigounico == (int)cmbCodProduto.EditValue))
				{


					var item = new tbl_EntradaItens()
					{
						CodEntrada = capa.CodEntrada,
						codigounico = (int)cmbCodProduto.EditValue,
						CodProduto = cmbCodProduto.Text,//Consultas.ObterCodProduto((int)cmbCodProduto.EditValue),
						DesProduto = cmbProduto.Text,
						NumOrdem = int.Parse(txtNumOrdem.Text),
						NCM = txtNCM.Text,
						Unidade = txtUnidade.Text,
						Quantidade = txtQuantidade.Value,
						VlrUnitario = txtVlrUnitario.Value,
						VlrTotal = txtVlrTotal.Value,
						Percentual = txtPercentual.Value,
						VlrFinal = txtVlrFinal.Value,
						VlrBaseICMS = txtVlrBaseICMS.Value,
						VlrPercICMS = txtVlrPercICMS.Value,
						VlrICMS = txtVlrICMS.Value,
						VlrBaseICMSST = txtVlrBaseICMSST.Value,
						VlrPercICMSST = txtVlrPercICMSST.Value,
						VlrICMSST = txtVlrICMSST.Value,
						VlrBasePIS = txtVlrBasePIS.Value,
						VlrPercPIS = txtVlrPercPIS.Value,
						VlrPIS = txtVlrPIS.Value,
						VlrBaseCOFINS = txtVlrBaseCOFINS.Value,
						VlrPercCOFINS = txtVlrPercCOFINS.Value,
						VlrCOFINS = txtVlrCOFINS.Value
					};

					itens.Add(item);
				}
				grdDados.DataSource = itens;
				grdDados.RefreshDataSource();
			}
		}

		private void btnExcluirItem_Click(object sender, EventArgs e)
		{
			var codigo = FU_PegaCodigoGrid();

			var registro = itens.FirstOrDefault(x => x.codigounico == codigo);

			itens.Remove(registro);

			grdDados.DataSource = itens;
			grdDados.RefreshDataSource();

		}

		#endregion

		#region Funções
		void SU_CarregaEntrada()
		{

			var entradas = Consultas.ObterEntrada(txtDocEntrada.Text);
			grdDados.DataSource = entradas;

		}

		void SU_CarregaProdutos()
		{
			var produtos = Consultas.ObterProdutos();
			cmbProduto.Properties.DataSource = produtos;
			cmbCodProduto.Properties.DataSource = produtos;
			lueProdutos.DataSource = produtos;

		}

		void SU_CarregaFornecedor()
		{
			var fornecedores = Consultas.ObterFornecedores();
			cmbFornecedor.Properties.DataSource = fornecedores;

		}

		void SU_CarregaTipoEntrada()
		{
			cmbTipoEntrada.Properties.DataSource = Consultas.ObterTipoEntradaCombo();

		}

		void SU_LimpaTela()
		{
			txtVlrTotal.Text = String.Empty;
			txtVlrUnitario.Text = String.Empty;
			txtQuantidade.Text = String.Empty;
			txtPercentual.Text = String.Empty;
			txtVlrFinal.Text = String.Empty;
			cmbCodProduto.EditValue = null;
			cmbProduto.EditValue = null;
			cmbFornecedor.EditValue = null;

			cmbCodProduto.Focus();
		}

		void SU_ValorTotal()
		{

			try
			{
				if (txtQuantidade.Value > 0 && txtVlrUnitario.Value > 0)
				{
					txtVlrTotal.Value = txtVlrUnitario.Value * txtQuantidade.Value;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		void SU_ValorFinal()
		{

			try
			{
				if (txtPercentual.Value > 0 && txtVlrUnitario.Value > 0)
				{
					txtVlrFinal.Value = (1 + (txtPercentual.Value / 100)) * txtVlrUnitario.Value;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridDados.GetSelectedRows()[0];
			codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

			return codigo;
		}

		void SU_ImportarNF(NFe.Classes.NFe nf)
		{
			try
			{
				if (nf != null)
				{
					capa.DocEntrada = nf.infNFe.ide.nNF.ToString();
					capa.SerieNota = nf.infNFe.ide.serie.ToString();
					capa.DatEmissao = DateTime.Parse(nf.infNFe.ide.dhEmi);
					capa.Nome = nf.infNFe.emit.xNome;
					capa.CNPJ = nf.infNFe.emit.CNPJ;
					capa.CPF = nf.infNFe.emit.CPF;

					itens = new List<tbl_EntradaItens>();

					foreach (var produto in nf.infNFe.det)
					{

						var item = new tbl_EntradaItens();

						var codigo = produto.prod.cProd;
						codigo = codigo.Replace("/", "-").Replace(" ", "");
						if (codigo.EndsWith("-"))
						{
							codigo = codigo.Substring(0, codigo.Length - 1);
						}

						item.CodProduto = codigo;
						var prod = Consultas.ObterProduto(codigo);
						if (prod != null)
						{
							item.codigounico = prod.codigounico;
							item.DesProduto = prod.DesProduto;
						}
						else
						{
							item.DesProduto = produto.prod.xProd;
							item.codigounico = -1;
						}

						item.CodOriginal = produto.prod.cProd;
						item.DesOriginal = produto.prod.xProd;

						item.NCM = produto.prod.NCM;
						item.NumOrdem = produto.prod.nItemPed;
						item.Quantidade = produto.prod.qCom;
						item.Unidade = produto.prod.uCom;
						item.VlrUnitario = produto.prod.vUnCom;
						item.VlrFinal = produto.prod.vProd;

						if (produto.imposto.ICMS.TipoICMS != null && (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS10)))
						{
							item.VlrICMSST = ((ICMS10)produto.imposto.ICMS.TipoICMS).vICMSST;
							item.VlrBaseICMSST = ((ICMS10)produto.imposto.ICMS.TipoICMS).vBCST;
							item.VlrPercICMSST = ((ICMS10)produto.imposto.ICMS.TipoICMS).pICMSST;

							item.VlrICMS = ((ICMS10)produto.imposto.ICMS.TipoICMS).vICMS;
							item.VlrBaseICMS = ((ICMS10)produto.imposto.ICMS.TipoICMS).vBC;
							item.VlrPercICMS = ((ICMS10)produto.imposto.ICMS.TipoICMS).pICMS;
						}
						else if (produto.imposto.ICMS.TipoICMS != null && (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS00)))
						{
							item.VlrICMS = ((ICMS00)produto.imposto.ICMS.TipoICMS).vICMS;
							item.VlrBaseICMS = ((ICMS00)produto.imposto.ICMS.TipoICMS).vBC;
							item.VlrPercICMS = ((ICMS00)produto.imposto.ICMS.TipoICMS).pICMS;
						}

						if (produto.imposto.PIS.TipoPIS != null && (produto.imposto.PIS.TipoPIS.GetType() == typeof(PISAliq)))
						{
							item.VlrPIS = ((PISAliq)produto.imposto.PIS.TipoPIS).vPIS;
							item.VlrBasePIS = ((PISAliq)produto.imposto.PIS.TipoPIS).vBC;
							item.VlrPercPIS = ((PISAliq)produto.imposto.PIS.TipoPIS).pPIS;
						}

						if (produto.imposto.COFINS.TipoCOFINS != null && (produto.imposto.COFINS.TipoCOFINS.GetType() == typeof(COFINSAliq)))
						{
							item.VlrCOFINS = ((COFINSAliq)produto.imposto.COFINS.TipoCOFINS).vCOFINS;
							item.VlrBaseCOFINS = ((COFINSAliq)produto.imposto.COFINS.TipoCOFINS).vBC;
							item.VlrPercCOFINS = ((COFINSAliq)produto.imposto.COFINS.TipoCOFINS).pCOFINS;
						}


						itens.Add(item);

					}

					grdDados.DataSource = itens;
					grdDados.RefreshDataSource();

					var entNF = Consultas.ObterEntrada(capa.DocEntrada, capa.SerieNota, capa.CNPJ);

					if (entNF != null)
					{
						Util.MsgBox("Nota Fiscal já feita entrada");
						btnGravar.Enabled = false;
					}
					else
					{
						btnGravar.Enabled = true;
					}

				}
			}
			catch (Exception ex)
			{

				Util.MsgBox(ex.InnerException != null ? ex.Message : ex.InnerException.Message);
			}

		}
		#endregion

		#region Outros eventos

		private void txtVlrUnitario_EditValueChanged(object sender, EventArgs e)
		{
			SU_ValorTotal();
			SU_ValorFinal();
		}

		private void txtQuantidade_EditValueChanged(object sender, EventArgs e)
		{
			SU_ValorTotal();
		}

		private void cmbCodProduto_Validated(object sender, EventArgs e)
		{
			if (cmbCodProduto.EditValue != null)
			{
				var produtos = Consultas.ObterProduto((int)cmbCodProduto.EditValue);
				cmbProduto.Text = produtos.DesProduto;
				cmbProduto.EditValue = produtos.codigounico;
				cmbFornecedor.EditValue = produtos.DesFornecedor;
				cmbFornecedor.ClosePopup();
				cmbProduto.ClosePopup();
			}
		}

		private void cmbProduto_Validated(object sender, EventArgs e)
		{
			if (cmbProduto.EditValue != null)
			{
				var produtos = Consultas.ObterProduto((int)cmbProduto.EditValue);
				cmbCodProduto.Text = produtos.CodProduto;
				cmbCodProduto.EditValue = produtos.codigounico;
				cmbFornecedor.EditValue = produtos.DesFornecedor;
				cmbFornecedor.ClosePopup();
			}
		}

		private void txtPercentual_Validated(object sender, EventArgs e)
		{
			SU_ValorFinal();
		}

		private void txtDocEntrada_Validated(object sender, EventArgs e)
		{
			SU_CarregaEntrada();
		}

		private void grdDados_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Delete))
			{
				if (MessageBox.Show("Confirma apagar essa entrada?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
					return;

				int linha = gridDados.GetSelectedRows()[0];
				int codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

				if (txtDatEmissao.Text.Equals(String.Empty))
				{
					//DateTime data = (DateTime)gridDados.GetRowCellValue(linha, colCodEntrada);
					//txtDatEmissao.DateTime = data;
				}

				//Cadastros.AlterarEntrada(txtDocEntrada.Text, txtDatEmissao.DateTime, codigo, 0, 0);

				//SU_CarregaEntrada();
			}
		}

		private void txtArquivoXML_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			txtArquivoXML.Text = Util.BuscarArquivo("Selecione o arquivo XML", ".xml", "Arquivo XML (.xml)|*.xml");
		}

		private void gridDados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			try
			{
				if (e.Column == colCodigounico)
				{
					double quantidade;

					if (e.Value != null)
						quantidade = (double)e.Value;
					else
						quantidade = 0;

					//var registro = itens.Where()
				}
				else
					if (e.Column == colDesProduto)
					{
						//Cadastros.AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), -1.0, (double)e.Value);
					}
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					Util.MsgBox("Erro na alteração: " + ex.InnerException.Message);
				}
				else
				{
					Util.MsgBox("Erro na alteração: " + ex.Message);
				}
			}
		}
		#endregion
	}
}