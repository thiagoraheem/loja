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
                MessageBox.Show("Escolha um produto");
                cmbProduto.Focus();
                return;
            }

            if (txtQuantidade.EditValue == null) {
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

                Loja.FU_AdicionarEntrada(txtDocEntrada.Text, (DateTime)txtDatEntrada.EditValue, (int)cmbCodProduto.EditValue,
                                            (double)txtQuantidade.Value, txtVlrUnitario.Value, CodTipoEntrada, (double)txtPercentual.Value, cmbFornecedor.Text);

            }
            catch (Exception ex) {
                Util.MsgBox(ex.Message);
            }
            SU_LimpaTela();
            if (chkContinuar.Checked) {
                Close();
            }

            SU_CarregaFornecedor();
            SU_CarregaEntrada();
        }

        #endregion

        #region Funções
        void SU_CarregaEntrada()
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
                               produto.DesProduto,
                               produto.codigounico
                           };
            grdDados.DataSource = entradas;

        }

        void SU_CarregaProdutos() {
            var produtos = from prod in Loja.tbl_Produtos
                       select prod;
            cmbProduto.Properties.DataSource = produtos;
            cmbCodProduto.Properties.DataSource = produtos;

        }

        void SU_CarregaFornecedor()
        {
            LojaEntities Loja = new LojaEntities();
            var fornecedores = from forn in Loja.tbl_Produtos
                               group forn by forn.DesFornecedor into gFornecedor
                               select new { Fornecedor = gFornecedor.Key };
            cmbFornecedor.Properties.DataSource = fornecedores;

        }

        void SU_CarregaTipoEntrada() {
            cmbTipoEntrada.Properties.DataSource = Loja.tbl_TipoEntrada;

        }

        void SU_LimpaTela() { 
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
                MessageBox.Show(ex.Message);
            }

        }

        void SU_ValorFinal()
        {

            try
            {
                if (txtPercentual.Value > 0 && txtVlrUnitario.Value > 0)
                {
                    txtVlrFinal.Value = ( 1+ (txtPercentual.Value / 100)) * txtVlrUnitario.Value;
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
                var produtos = (from prod in Loja.tbl_Produtos
                                where prod.QtdProduto > 0 && prod.codigounico == (int)cmbCodProduto.EditValue
                                select prod).FirstOrDefault();
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
                var produtos = (from prod in Loja.tbl_Produtos
                                where prod.QtdProduto > 0 && prod.codigounico == (int)cmbProduto.EditValue
                                select prod).FirstOrDefault();
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
            if (e.KeyCode.Equals(Keys.Delete)) {
                if (MessageBox.Show("Confirma apagar essa entrada?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int linha = gridDados.GetSelectedRows()[0];
                int codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

                if (txtDatEntrada.Text.Equals(String.Empty)) {
                    DateTime data = (DateTime)gridDados.GetRowCellValue(linha, colData);
                    txtDatEntrada.DateTime = data;
                }

                LojaEntities loja = new LojaEntities();
                loja.FU_AlterarEntrada(txtDocEntrada.Text, txtDatEntrada.DateTime, codigo, 0, 0);

                SU_CarregaEntrada();
            }
        }
        #endregion 

   }
}