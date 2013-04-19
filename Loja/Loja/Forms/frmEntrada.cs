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
            SU_CarregaTipoVenda();
        }

        #endregion

        #region Botões
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
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

        void SU_CarregaTipoVenda() {
            cmbTipoEntrada.Properties.DataSource = Loja.tbl_TipoEntrada;

        }
        #endregion


    }
}