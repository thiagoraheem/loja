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
    public partial class frmVenda : DevExpress.XtraEditors.XtraForm
    {
        LojaEntities Loja = new LojaEntities();
        public String CodOrcamento;

        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            SU_CarregaTipoVenda();
            cmbTipoVenda.EditValue = cmbTipoVenda.Properties.GetDataSourceValue(cmbTipoVenda.Properties.ValueMember, 0);
            if (CodOrcamento == "") Close();

            SU_CarregaOrcamento(CodOrcamento);
        }

        void SU_CarregaTipoVenda() {
            var TipoVenda = from tipovenda in Loja.tbl_TipoVenda
                            where tipovenda.flgAtivo == true
                            select new { Codigo = tipovenda.CodTipoVenda, Descricao = tipovenda.DesTipoVenda};
            cmbTipoVenda.Properties.DataSource = TipoVenda.ToList();
        }

        void SU_CarregaOrcamento(String CodOrca) {
            LojaEntities Loja = new LojaEntities();
            var orca = from orcam in Loja.tbl_Orcamento
                       where orcam.CodOrca == CodOrca
                       select orcam;

            gridOrcamento.DataSource = orca.ToList();


            var total = orca.AsEnumerable().Sum(o => o.PF);

            txtVlrTotal.EditValue = total;
        }

        private void gridViewOrcamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantidade)
            {
                Loja.FU_AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), (double)e.Value, -1);
            }
            else if (e.Column == colValor)
            {
                Loja.FU_AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), -1, (double)e.Value);
            }
            SU_CarregaOrcamento(CodOrcamento);
        }

        int FU_PegaCodigoGrid()
        {
            int codigo = -1;

            int linha = gridViewOrcamento.GetSelectedRows()[0];
            codigo = (int)gridViewOrcamento.GetRowCellValue(linha, colCodigounico);

            return codigo;
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            Loja.FU_DescontoVenda(CodOrcamento, txtDesconto.Value);
            SU_CarregaOrcamento(CodOrcamento);
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                String flgApagarOrca;
                if (chkApagarOrca.Checked)
                {
                    flgApagarOrca = "S";
                }
                else
                {
                    flgApagarOrca = "N";
                }
                Loja.FU_FinalizaVenda(CodOrcamento, (int)cmbTipoVenda.EditValue, flgApagarOrca);
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;

                if (chkEmitirRecibo.Checked) {
                    using (frmRecibo f = new frmRecibo())
                    {
                        f.txtValor.Value = txtVlrTotal.Value;
                        f.txtExtenso.Text = Util.toExtenso(txtVlrTotal.Value);
                        f.ShowDialog();
                    }
                }

            }
            catch (Exception ex) {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                MessageBox.Show(ex.Message);
            }

        }

        private void txtDinheiro_Validated(object sender, EventArgs e)
        {

            try
            {

                if (!txtDinheiro.Text.Equals(String.Empty) && !txtDinheiro.Text.Equals("0"))
                {
                    decimal dinheiro = txtDinheiro.Value;
                    decimal vlrtotal = txtVlrTotal.Value;

                    if (dinheiro >= vlrtotal)
                    {
                        decimal troco = dinheiro - vlrtotal;
                        txtTroco.EditValue = troco;
                    }
                    else
                    {
                        txtDinheiro.Text = "";
                        txtDinheiro.Focus();
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

     }
}