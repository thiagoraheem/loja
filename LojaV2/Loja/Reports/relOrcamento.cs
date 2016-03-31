using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
    public partial class relOrcamento : DevExpress.XtraReports.UI.XtraReport
    {
        public relOrcamento()
        {
            InitializeComponent();
        }

        private void relOrcamento_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblEmpresa.Text = Properties.Settings.Default.NomeFantasia;
        }

    }
}
