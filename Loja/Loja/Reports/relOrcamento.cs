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
            lblTelefone.Text = "Telefone: " + Properties.Settings.Default.Telefone;
            lblEndereco.Text = Properties.Settings.Default.Endereco;
            lblEmpresa.Text = Properties.Settings.Default.NomeFantasia;
        }

    }
}
