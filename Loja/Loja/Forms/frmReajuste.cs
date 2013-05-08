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

namespace Loja
{
    public partial class frmReajuste : DevExpress.XtraEditors.XtraForm
    {
        public frmReajuste()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPercentual.Text.Equals(String.Empty) ) {return; }
            if (txtPercentual.Value <= 0) { return; }

            if (MessageBox.Show("Confirma reajustar os preços desses produtos?", "Confirmar reajuste", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (LojaEntities Loja = new LojaEntities())
            {
                Loja.FU_Reajuste((decimal?)txtPercentual.Value, cmbFornecedor.EditValue.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SU_CarregaFornecedor() {
            LojaEntities Loja = new LojaEntities();
            var fornecedores = from forn in Loja.tbl_Produtos
                               group forn by forn.DesFornecedor into gFornecedor
                               select new {Fornecedor = gFornecedor.Key} ;
            cmbFornecedor.Properties.DataSource = fornecedores;

        }

        private void frmReajuste_Load(object sender, EventArgs e)
        {
            SU_CarregaFornecedor();
        }
    }
}