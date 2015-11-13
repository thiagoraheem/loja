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
using Loja.DAL.VO;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmProduto : DevExpress.XtraEditors.XtraForm
	{

		#region Variáveis
		Produtos produto = new Produtos();
		#endregion
	
		#region Form Events

		public frmProduto()
		{
			InitializeComponent();

			txtCodProduto.DataBindings.Add(new Binding("EditValue", produto, "CodProduto", true, DataSourceUpdateMode.OnValidation));
			txtDesProduto.DataBindings.Add(new Binding("EditValue", produto, "DesProduto", true, DataSourceUpdateMode.OnValidation));
			txtDesLocal.DataBindings.Add(new Binding("EditValue", produto, "DesLocal", true, DataSourceUpdateMode.OnValidation));
			txtFornecedor.DataBindings.Add(new Binding("EditValue", produto, "DesFornecedor", true, DataSourceUpdateMode.OnValidation));
			txtQtdEstoque.DataBindings.Add(new Binding("EditValue", produto, "QtdProduto", true, DataSourceUpdateMode.OnValidation));
			txtVlrUnitario.DataBindings.Add(new Binding("EditValue", produto, "VlrUnitario", true, DataSourceUpdateMode.OnValidation));
			txtCodRefAntiga.DataBindings.Add(new Binding("EditValue", produto, "CodRefAntiga", true, DataSourceUpdateMode.OnValidation));
			txtQtdEstMinimo.DataBindings.Add(new Binding("EditValue", produto, "EstMinimo", true, DataSourceUpdateMode.OnValidation));
			txtUltPreco.DataBindings.Add(new Binding("EditValue", produto, "VlrUltPreco", true, DataSourceUpdateMode.OnValidation));
			txtVlrCusto.DataBindings.Add(new Binding("EditValue", produto, "VlrCusto", true, DataSourceUpdateMode.OnValidation));
			txtVlrPercent.DataBindings.Add(new Binding("EditValue", produto, "VlrPercent", true, DataSourceUpdateMode.OnValidation));
			txtNCM.DataBindings.Add(new Binding("EditValue", produto, "NCM", true, DataSourceUpdateMode.OnValidation));
			imgFoto.DataBindings.Add(new Binding("Image", produto, "Imagem", true, DataSourceUpdateMode.OnValidation));

		}

		#endregion

		#region Funções

		public void SU_CarregaProduto(int CodProduto)
		{
			var prod = Consultas.ObterProduto(CodProduto);

			produto.codigounico = prod.codigounico;
			produto.CodProduto = prod.CodProduto;
			produto.DesProduto = prod.DesProduto;
			produto.DesLocal = prod.DesLocal;
			produto.DesFornecedor = prod.DesFornecedor;
			produto.QtdProduto = prod.QtdProduto;
			produto.VlrUnitario = prod.VlrUnitario;
			produto.CodRefAntiga = prod.CodRefAntiga;
			produto.EstMinimo = prod.EstMinimo;
			produto.VlrUltPreco = prod.VlrUltPreco;
			produto.VlrCusto = prod.VlrCusto;
			produto.VlrPercent = prod.VlrPercent;
			produto.NCM = prod.NCM;
			produto.VlrICMSST = prod.VlrICMSST;
			produto.DatCadastro = prod.DatCadastro;
			produto.DesFaz = prod.DesFaz;
			produto.Imagem = prod.Imagem;

			/*if (produto.Imagem != null)
			{
				MemoryStream ms = new MemoryStream(this.produto.Imagem);

				ms.Write(this.produto.Imagem, 0, this.produto.Imagem.Length);

				imgFoto.Image = Image.FromStream(ms);

				btnRemoverImagem.Enabled = true;
			}*/

			btnRemover.Enabled = true;
		}

		public void SU_NovoProduto() {
			
			this.produto = new Produtos();

			/*txtCodProduto.Text = String.Empty;
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

			imgFoto.Image = null;*/

			btnRemover.Enabled = false;
			btnRemoverImagem.Enabled = false;
		}

		void SU_Gravar() {

			try {
				/*byte[] photo_aray = null;

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
					photo_aray, txtNCM.Text);*/
				var prod = new tbl_Produtos();

				prod.codigounico = produto.codigounico;
				prod.CodProduto = produto.CodProduto;
				prod.DesProduto = produto.DesProduto;
				prod.DesLocal = produto.DesLocal;
				prod.DesFornecedor = produto.DesFornecedor;
				prod.QtdProduto = produto.QtdProduto;
				prod.VlrUnitario = produto.VlrUnitario;
				prod.CodRefAntiga = produto.CodRefAntiga;
				prod.EstMinimo = produto.EstMinimo;
				prod.VlrUltPreco = produto.VlrUltPreco;
				prod.VlrCusto = produto.VlrCusto;
				prod.VlrPercent = produto.VlrPercent;
				prod.NCM = produto.NCM;
				prod.VlrICMSST = produto.VlrICMSST;
				prod.DatCadastro = produto.DatCadastro;
				prod.DesFaz = produto.DesFaz;
				prod.Imagem = produto.Imagem;

				Cadastros.GravaProduto(prod);

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
			imgFoto.LoadImage();
			
			//produto.Imagem = imgFoto.Image;
			/*
			diagAbrir.ShowDialog();

			Bitmap bitmap = new Bitmap(diagAbrir.FileName);
			*/
			byte[] photo_aray = null;

			/*if (bitmap != null)
			{
			*/
				MemoryStream ms = new MemoryStream();
				
				imgFoto.Image.Save(ms, ImageFormat.Jpeg);
				photo_aray = new byte[ms.Length];
				ms.Position = 0;
				ms.Read(photo_aray, 0, photo_aray.Length);
			//}

			produto.Imagem = photo_aray;


		}

		#endregion

		#region Eventos gerais

		private void txtVlrPercent_Validated(object sender, EventArgs e)
		{
			if (txtVlrPercent.Text != String.Empty && txtVlrCusto.Value > 0)
			{
				var valornovo = decimal.Parse(txtVlrCusto.Text) * (1 + (decimal.Parse(txtVlrPercent.Text) / 100m));
				txtVlrUnitario.Value = valornovo;

			}
		}
		
		#endregion
	}
}