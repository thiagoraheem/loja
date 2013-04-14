using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;

namespace Loja
{
    public partial class frmRecibo : DevExpress.XtraEditors.XtraForm
    {
        public frmRecibo()
        {
            InitializeComponent();
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            txtExtenso.Text = Extenso.toExtenso(txtValor.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (Reports.relRecibo relatorio = new Reports.relRecibo())
            {

                ReportPrintTool printTool = new ReportPrintTool(relatorio);

                relatorio.Parameters["Nome"].Value = txtNome.Text;
                relatorio.Parameters["VlrTotal"].Value = txtValor.Value;
                relatorio.Parameters["Extenso"].Value = txtExtenso.Text;
                relatorio.Parameters["Referente"].Value = txtReferente.Text;

                printTool.ShowRibbonPreviewDialog();
                printTool.ShowRibbonPreview(UserLookAndFeel.Default);
            }
            Close();
        }
    }
}