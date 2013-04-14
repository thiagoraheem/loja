﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAO;
using System.IO;

namespace Loja
{
    public partial class frmDetalhe : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalhe()
        {
            InitializeComponent();
        }

        private void frmDetalhe_KeyDown(object sender, KeyEventArgs e)
        {
            double VlrUnitario = 0;

            if (e.KeyCode.Equals(Keys.Escape)) {
                Close();
            } else if(e.KeyCode.Equals(Keys.F1)) {
                VlrUnitario = Convert.ToDouble(txtVlrUnitario.Value);
                txtDesconto.EditValue = VlrUnitario * 0.92;
            } else if (e.KeyCode.Equals(Keys.F2)) {
                VlrUnitario = Convert.ToDouble(txtVlrUnitario.Value);
                txtDesconto.EditValue = VlrUnitario * 0.90;
            } else if (e.KeyCode.Equals(Keys.F3)) {
                VlrUnitario = Convert.ToDouble(txtVlrUnitario.Value);
                txtDesconto.EditValue = VlrUnitario * 0.88;
            } else if (e.KeyCode.Equals(Keys.F4)) {
                VlrUnitario = Convert.ToDouble(txtVlrUnitario.Value);
                txtDesconto.EditValue = VlrUnitario * 0.85;
            }
        }

        public void SU_CarregaProduto(String CodProduto, String DesLocal) {
            LojaEntities Loja = new LojaEntities();

            var produto = (from prod in Loja.tbl_Produtos
                          where prod.CodProduto == CodProduto && prod.DesLocal == DesLocal
                          select prod).First();
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