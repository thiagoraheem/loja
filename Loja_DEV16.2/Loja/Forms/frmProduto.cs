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
using System.Xml;
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
			InicializaDataBinding();
		}
		
		#endregion

		#region Funções
		void InicializaDataBinding()
		{
			txtCodProduto.DataBindings.Clear();
			txtDesProduto.DataBindings.Clear();
			txtDesLocal.DataBindings.Clear();
			txtFornecedor.DataBindings.Clear();
			txtQtdEstoque.DataBindings.Clear();
			txtVlrUnitario.DataBindings.Clear();
			txtCodRefAntiga.DataBindings.Clear();
			txtQtdEstMinimo.DataBindings.Clear();
			txtUltPreco.DataBindings.Clear();
			txtVlrCusto.DataBindings.Clear();
			txtVlrPercent.DataBindings.Clear();
			txtNCM.DataBindings.Clear();
			txtVlrICMSST.DataBindings.Clear();
			imgFoto.DataBindings.Clear();


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
			txtVlrICMSST.DataBindings.Add(new Binding("EditValue", produto, "VlrICMSST", true, DataSourceUpdateMode.OnValidation));
			imgFoto.DataBindings.Add(new Binding("Image", produto, "Imagem", true, DataSourceUpdateMode.OnValidation));

		}

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

			btnRemover.Enabled = true;
		}

		public void SU_NovoProduto() {
			
			this.produto = new Produtos();
			InicializaDataBinding();
			btnRemover.Enabled = false;
			btnRemoverImagem.Enabled = false;
		}

		void SU_Gravar() {

			try {
				var prod = new tbl_Produtos();

				if (produto.codigounico > 0){
					prod.codigounico = produto.codigounico;
				}
				prod.CodProduto = produto.CodProduto;
				prod.DesProduto = produto.DesProduto;
				prod.DesLocal = produto.DesLocal ?? "";
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
				prod.DatCadastro = produto.DatCadastro ?? DateTime.Now.ToShortDateString();
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
			if (imgFoto.Image != null) { 

				byte[] photo_aray = null;

				/*if (bitmap != null)
				{
				*/
					MemoryStream ms = new MemoryStream();
				
					imgFoto.Image.Save(ms, ImageFormat.Jpeg);
					photo_aray = new byte[ms.Length];
					ms.Position = 0;
					ms.Read(photo_aray, 0, photo_aray.Length);
				//}3 

				produto.Imagem = photo_aray;

			}
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