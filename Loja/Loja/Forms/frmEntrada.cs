using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Data.Objects;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;

namespace Loja
{
    public partial class frmEntrada : DevExpress.XtraEditors.XtraForm
    {
        #region Variáveis
        LojaEntities Loja = new LojaEntities();

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

            if (cmbProduto.EditValue == null) {
                Util.MsgBox("Escolha um produto");
                cmbProduto.Focus();
                return;
            }

            if (txtQuantidade.EditValue == null) {
                Util.MsgBox("Informe a quantidade");
                txtQuantidade.Focus();
                return;
            }

            if (txtVlrUnitario.EditValue == null)
            {
                Util.MsgBox("Informe o valor unitário");
                txtVlrUnitario.Focus();
                return;
            }

            try
            {

                Loja.FU_AdicionarEntrada(txtDocEntrada.Text, (DateTime)txtDatEntrada.EditValue, (int)cmbCodProduto.EditValue,
                                            (double)txtQuantidade.Value, txtVlrTotal.Value, CodTipoEntrada, (double)txtPercentual.Value,
                                            cmbFornecedor.Text);

            }
            catch (Exception ex) {
                Util.MsgBox(ex.InnerException.Message);
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
            try
            {

                var entradas = from entrada in Loja.tbl_Entrada
                               join produto in Loja.tbl_Produtos on entrada.codigounico equals produto.codigounico
                               where entrada.DocEntrada == txtDocEntrada.Text
                               select new
                               {
                                   entrada.DatEntrada,
                                   entrada.DocEntrada,
                                   entrada.Percentual,
                                   entrada.QtdProduto,
                                   entrada.VlrTotal,
                                   entrada.VlrUnitario,
                                   produto.CodProduto,
                                   produto.DesProduto
                               };
                grdDados.DataSource = entradas;
            }
            catch (Exception ex) {
                Util.MsgBox(ex.Message);
            }

        }
    
        void SU_CarregaProdutos() {
            try
            {

                var produtos = from prod in Loja.tbl_Produtos
                               where prod.QtdProduto > 0
                               select prod;
                cmbProduto.Properties.DataSource = produtos;
                cmbCodProduto.Properties.DataSource = produtos;
            }
            catch (Exception ex) {
                Util.MsgBox(ex.Message);
            }


        }

        void SU_CarregaFornecedor()
        {
            try
            {
                LojaEntities Loja = new LojaEntities();
                var fornecedores = from forn in Loja.tbl_Produtos
                                   group forn by forn.DesFornecedor into gFornecedor
                                   select new { Fornecedor = gFornecedor.Key };
                cmbFornecedor.Properties.DataSource = fornecedores;
            }
            catch (Exception ex) {
                Util.MsgBox(ex.Message);
            }

        }

        void SU_CarregaTipoEntrada() {
            cmbTipoEntrada.Properties.DataSource = Loja.tbl_TipoEntrada;

        }

        void SU_LimpaTela() { 
            txtVlrTotal.Text = String.Empty;
            txtVlrUnitario.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            cmbProduto.EditValue = null;
            cmbCodProduto.EditValue = null;
            cmbFornecedor.EditValue = null;
            cmbCodProduto.Focus();
        }

        void SU_ValorTotal() {

            try
            {
                if (txtQuantidade.Value > 0 && txtVlrUnitario.Value > 0)
                {
                    txtVlrTotal.Value = txtVlrUnitario.Value * txtQuantidade.Value;
                }
            }
            catch (Exception ex)
            {
                Util.MsgBox(ex.Message);
            }

        }

        void SU_ValorFinal()
        {

            try
            {
                if (txtPercentual.Value > 0 && txtVlrUnitario.Value > 0)
                {
                    txtVlrFinal.Value = (txtPercentual.Value / 100) * txtVlrUnitario.Value;
                }
            }
            catch (Exception ex)
            {
                Util.MsgBox(ex.Message);
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
                var produtos = (from prod in Loja.tbl_Produtos
                                where prod.QtdProduto > 0 && prod.codigounico == (int)cmbCodProduto.EditValue
                                select prod).FirstOrDefault();
                cmbProduto.Text = produtos.DesProduto;
                cmbProduto.EditValue = produtos.codigounico;
                cmbProduto.ClosePopup();
                cmbFornecedor.Text = produtos.DesFornecedor;
                cmbFornecedor.EditValue = produtos.DesFornecedor;
                cmbFornecedor.ClosePopup();
            }
        }

        private void cmbProduto_Validated(object sender, EventArgs e)
        {
            if (cmbProduto.EditValue != null)
            {
                var produtos = (from prod in Loja.tbl_Produtos
                                where prod.QtdProduto > 0 && prod.codigounico == (int)cmbProduto.EditValue
                                select prod).FirstOrDefault();
                cmbCodProduto.Text = produtos.CodProduto;
                cmbCodProduto.EditValue = produtos.codigounico;
                cmbFornecedor.Text = produtos.DesFornecedor;
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

        #endregion



                

   }
}