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
            
            Loja.FU_AdicionarEntrada(txtDocEntrada.Text, (DateTime)txtDatEntrada.EditValue, (int)cmbProduto.EditValue, 
                                        (double)txtQuantidade.Value, txtVlrTotal.Value, CodTipoEntrada);

            SU_LimpaTela();
            if (chkContinuar.Checked) {
                Close();
            }
        }

        #endregion

        #region Funções
        void SU_CarregaProdutos() {
            var produtos = from prod in Loja.tbl_Produtos
                       where prod.QtdProduto > 0
                       select prod;
            cmbProduto.Properties.DataSource = produtos;

        }

        void SU_CarregaTipoEntrada() {
            cmbTipoEntrada.Properties.DataSource = Loja.tbl_TipoEntrada;

        }

        void SU_LimpaTela() { 
            txtVlrTotal.Text = String.Empty;
            txtVlrUnitario.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            cmbProduto.EditValue = null;
            cmbProduto.Focus();
        }

        void SU_ValorTotal() {

            try
            {
                if (txtQuantidade.Value != null && txtVlrUnitario.Value != null)
                {
                    txtVlrTotal.Value = txtVlrUnitario.Value * txtQuantidade.Value;
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
        }

        private void txtQuantidade_EditValueChanged(object sender, EventArgs e)
        {
            SU_ValorTotal();
        }
 
        #endregion
   }
}