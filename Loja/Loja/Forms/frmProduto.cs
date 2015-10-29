using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;
using Loja.DAL.Models;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmProduto : DevExpress.XtraEditors.XtraForm
	{

		#region Variáveis
		tbl_Produtos produto;
		#endregion
	
		#region Form Events

		public frmProduto()
		{
			InitializeComponent();
		}

		#endregion

		#region Funções

		public void SU_CarregaProduto(int CodProduto)
		{
			this.produto = Consultas.ObterProduto(CodProduto);

			txtCodProduto.Text = this.produto.CodProduto;
			txtDesProduto.Text = this.produto.DesProduto;
			txtDesLocal.Text = this.produto.DesLocal;
			txtFornecedor.Text = this.produto.DesFornecedor;
			txtQtdEstoque.Text = this.produto.QtdProduto.ToString();
			txtVlrUnitario.Text = this.produto.VlrUnitario.ToString();
			txtCodRefAntiga.Text = this.produto.CodRefAntiga;
			txtQtdEstMinimo.Text = this.produto.EstMinimo.ToString();
			txtUltPreco.Text = this.produto.VlrUltPreco.ToString();
			txtVlrCusto.Text = this.produto.VlrCusto.ToString();
			txtVlrPercent.Text = this.produto.VlrPercent.ToString();
			txtNCM.Text = this.produto.NCM;

			if (produto.Imagem != null)
			{
				MemoryStream ms = new MemoryStream(this.produto.Imagem);

				ms.Write(this.produto.Imagem, 0, this.produto.Imagem.Length);

				imgFoto.Image = Image.FromStream(ms);

				btnRemoverImagem.Enabled = true;
			}

			btnRemover.Enabled = true;
		}

		public void SU_NovoProduto() {
			this.produto = new tbl_Produtos();

			txtCodProduto.Text = String.Empty;
			txtDesProduto.Text = String.Empty;
			txtDesLocal.Text = String.Empty;
			txtFornecedor.Text = String.Empty;
			txtQtdEstoque.Text = String.Empty;
			txtVlrUnitario.Text = String.Empty;
			txtCodRefAntiga.Text = String.Empty;
			txtQtdEstMinimo.Text = String.Empty;
			txtUltPreco.Text = String.Empty;
			txtVlrCusto.Text = String.Empty;
			txtVlrPercent.Text = String.Empty;
			txtNCM.Text = String.Empty;

			imgFoto.Image = null;

			btnRemover.Enabled = false;
			btnRemoverImagem.Enabled = false;
		}

		void SU_Gravar() {

			try {
				byte[] photo_aray = null;

				if (imgFoto.Image != null) { 

					MemoryStream ms = new MemoryStream();
					imgFoto.Image.Save(ms, ImageFormat.Jpeg);
					photo_aray = new byte[ms.Length];
					ms.Position = 0;
					ms.Read(photo_aray, 0, photo_aray.Length);
				}

				Double ultPreco = 0;
				Double vlrCusto = 0;
				Double vlrUnitario = 0;
				Double qtdEstoque = 0;
				Double vlrPercent = 0;
				Double qtdEstMinimo = 0;

				if (txtUltPreco.EditValue.ToString() != "") ultPreco = Convert.ToDouble(txtUltPreco.EditValue);
				if (txtQtdEstMinimo.EditValue.ToString() != "") qtdEstMinimo = Convert.ToDouble(txtQtdEstMinimo.EditValue);
				if (txtVlrCusto.EditValue.ToString() != "") vlrCusto = Convert.ToDouble(txtVlrCusto.EditValue);
				if (txtVlrUnitario.EditValue.ToString() != "") vlrUnitario = Convert.ToDouble(txtVlrUnitario.EditValue);
				if (txtQtdEstoque.EditValue.ToString() != "") qtdEstoque = Convert.ToDouble(txtQtdEstoque.EditValue);
				if (txtVlrPercent.EditValue.ToString() != "") vlrPercent = Convert.ToDouble(txtVlrPercent.EditValue);

				Cadastros.ManutProduto(produto.codigounico, txtCodProduto.Text, txtDesProduto.Text, txtDesLocal.Text, vlrUnitario,
					qtdEstoque, vlrCusto, vlrPercent, qtdEstMinimo, txtFornecedor.Text, txtCodRefAntiga.Text, ultPreco,
					photo_aray, txtNCM.Text);

				Close();
			}
			catch (Exception ex) {
				Util.MsgBox(ex.Message);
			}
		}
		#endregion

		#region Botões

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdGravar_Click(object sender, EventArgs e)
		{
			SU_Gravar();
		}

		private void btnRemover_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Confirma excluir esse produto?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			Cadastros.ExcluiProduto(produto.codigounico);

			MessageBox.Show("Registro excluído com sucesso.");

			Close();
		}

		private void btnImagem_Click(object sender, EventArgs e)
		{
			
			diagAbrir.ShowDialog();

			Bitmap bitmap = new Bitmap(diagAbrir.FileName);

			imgFoto.Image = bitmap;


		}

		#endregion
	}
}