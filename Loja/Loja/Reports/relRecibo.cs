using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace Loja.Reports
{
    public partial class relRecibo : DevExpress.XtraReports.UI.XtraReport
    {
        public relRecibo()
        {
            InitializeComponent();
        }

        private void relRecibo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblEmpresa.Text = Properties.Settings.Default.NomeFantasia;
            lblTelefone.Text = Properties.Settings.Default.Telefone;
            lblEndereco.Text = Properties.Settings.Default.Endereco;
            if (!String.IsNullOrEmpty(Properties.Settings.Default.CNPJ))
                lblCnpj.Text = "CNPJ: " + Properties.Settings.Default.CNPJ;
            if (!String.IsNullOrEmpty(Properties.Settings.Default.InscEstadual))
            lblInscEstadual.Text = "INSC. ESTADUAL: " + Properties.Settings.Default.InscEstadual;
            lblEmpresaAssinatura.Text = Properties.Settings.Default.NomeFantasia;

            String data = DateTime.Now.ToLongDateString();


            lblData.Text = "Manaus, " + data;
                /*"Manaus, " + DateTime.Now.Day.ToString() +
                            " de " + DateTime.Now.Month.ToString() + 
                            " de " + DateTime.Now.Year.ToString();*/
        }

    }
}
