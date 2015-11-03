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

namespace Loja
{
	public partial class frmEntrada : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis
		#endregion

		#region Form Events

		public frmEntrada()
		{
			InitializeComponent();

			SU_CarregaProdutos();
			SU_CarregaTipoEntrada();
		}

		private void frmEntrada_Load(object sender, EventArgs e)
		{
			SU_CarregaFornecedor();
		}
		#endregion

		#region Botões
		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{

			int CodTipoEntrada;

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

				Cadastros.AdicionarEntrada(txtDocEntrada.Text, (DateTime)txtDatEntrada.EditValue, (int)cmbCodProduto.EditValue,
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
			SU_CarregaEntrada();
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

				if (txtDatEntrada.Text.Equals(String.Empty))
				{
					DateTime data = (DateTime)gridDados.GetRowCellValue(linha, colData);
					txtDatEntrada.DateTime = data;
				}

				Cadastros.AlterarEntrada(txtDocEntrada.Text, txtDatEntrada.DateTime, codigo, 0, 0);

				SU_CarregaEntrada();
			}
		}
		#endregion

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
			try
			{
				if (!String.IsNullOrEmpty(txtArquivoXML.Text))
				{
					var nf = new NFe.Classes.NFe().CarregarDeArquivoXml(txtArquivoXML.Text);
					txtDocEntrada.Text = nf.infNFe.ide.nNF.ToString();
				}
			}
			catch (Exception ex)
			{
				
				Util.MsgBox(ex.InnerException != null ? ex.Message : ex.InnerException.Message);
			}

		}

		private void txtArquivoXML_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			txtArquivoXML.Text = Util.BuscarArquivo("Selecione o arquivo XML", ".xml", "Arquivo XML (.xml)|*.xml");
		}

	}
}