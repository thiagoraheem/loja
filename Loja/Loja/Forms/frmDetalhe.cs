﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmDetalhe : DevExpress.XtraEditors.XtraForm
	{
		int codproduto;

		public frmDetalhe()
		{
			InitializeComponent();
		}

		private void frmDetalhe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Escape) || e.KeyCode.Equals(Keys.Return))
			{
				Close();
			} else if(e.KeyCode.Equals(Keys.F1)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal) (n * 0.92);
			} else if (e.KeyCode.Equals(Keys.F7)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal) (n * 0.90);
			} else if (e.KeyCode.Equals(Keys.F3)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal) (n * 0.88);
			} else if (e.KeyCode.Equals(Keys.F4)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal) (n * 0.85);
			} else if (e.KeyCode.Equals(Keys.F5)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal)(n * 0.95);
			} else if (e.KeyCode.Equals(Keys.F6)) {
				double n = double.Parse(txtVlrUnitario.EditValue.ToString());
				txtDesconto.Value = (decimal)(n * 1);
			}
			else if (e.KeyCode.Equals(Keys.F11)) {
			
				var orca = Cadastros.AdicionarOrcamento("", codproduto);
				frmVenda f = new frmVenda();

				f.CodOrcamento = orca.FirstOrDefault();
				f.ShowDialog();

				if (! (f.DialogResult == System.Windows.Forms.DialogResult.Yes))
				{
					Cadastros.ApagarOrcamento(orca.FirstOrDefault());
					
				}
				Close();
			}
		}

		public void SU_CarregaProduto(int codProduto) {

			var produto = Consultas.ObterProduto(codProduto);

			codproduto = produto.codigounico;
			txtCodProduto.Text = produto.CodProduto;
			txtDesProduto.Text = produto.DesProduto;
			txtDesLocal.Text = produto.DesLocal;
			txtFornecedor.Text = produto.DesFornecedor;
			txtQtdEstoque.Text = produto.QtdProduto.ToString();
			txtVlrUnitario.Text = produto.VlrUnitario.ToString();

			if (produto.Imagem != null)
			{
				MemoryStream ms = new MemoryStream(produto.Imagem);

				ms.Write(produto.Imagem, 0, produto.Imagem.Length);
				imgFoto.Image = Image.FromStream(ms);
			}
		}

	}
}