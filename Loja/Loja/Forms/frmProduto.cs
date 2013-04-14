using System;
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
    public partial class frmProduto : DevExpress.XtraEditors.XtraForm
    {
        private bool novo;
        Loja.DAO.tbl_Produtos produto;
        LojaEntities Loja = new LojaEntities();

        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SU_CarregaProduto(String CodProduto, String DesLocal)
        {
            this.produto = (from prod in Loja.tbl_Produtos
                             where prod.CodProduto == CodProduto && prod.DesLocal == DesLocal
                             select prod).First();
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

            if (produto.Imagem != null)
            {
                MemoryStream ms = new MemoryStream(this.produto.Imagem);

                ms.Write(this.produto.Imagem, 0, this.produto.Imagem.Length);
                imgFoto.Image = Image.FromStream(ms);

                btnRemoverImagem.Enabled = true;
            }

            this.novo = true;
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

            imgFoto.Image = null;

            this.novo = false;
            btnRemover.Enabled = false;
            btnRemoverImagem.Enabled = false;
        }

        void SU_Gravar() {

            try {
                String CodProduto = this.produto.CodProduto;
                if (CodProduto == String.Empty || CodProduto == null) CodProduto = txtCodProduto.Text;

                String DesProduto = this.produto.DesProduto; 
                if (DesProduto == String.Empty || DesProduto == null) DesProduto = txtDesProduto.Text;

                String DesLocal = this.produto.DesLocal;
                if (DesLocal == String.Empty || DesLocal == null) DesLocal = txtDesLocal.Text;

                Loja.FU_ManutProduto(CodProduto, DesProduto, DesLocal, (double)txtVlrUnitario.Value,
                    (double?)txtQtdEstoque.Value, (double?)txtVlrCusto.Value, (double?)txtVlrPercent.Value,
                    (double?)txtQtdEstMinimo.Value, txtFornecedor.Text, txtCodRefAntiga.Text, (double?)txtUltPreco.Value,
                    null, txtDesProduto.Text, txtDesLocal.Text);



                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            SU_Gravar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma excluir esse produto?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Loja.DeleteObject(produto);
            Loja.SaveChanges();

            MessageBox.Show("Registro excluído com sucesso.");

            Close();
        }
    }
}