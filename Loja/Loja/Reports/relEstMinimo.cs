using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
    public partial class relEstMinimo : DevExpress.XtraReports.UI.XtraReport
    {
        public relEstMinimo()
        {
            InitializeComponent();
        }

        private void relEstMinimo_BeforePrint(object sender, CancelEventArgs e)
        {
            lblTelefone.Text = "Telefone: " + Properties.Settings.Default.Telefone;
            lblEndereco.Text = Properties.Settings.Default.Endereco;
            lblEmpresa.Text = Properties.Settings.Default.NomeFantasia;
        }

    }
}
