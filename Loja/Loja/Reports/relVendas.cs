using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
    public partial class relVendas : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime _DatIni;
        private DateTime _DatFim;
        private int _CodProduto;
        private int _CodTipoVenda;

        private void relVendas_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTelefone.Text = "Telefone: " + Properties.Settings.Default.Telefone;
            lblEndereco.Text = Properties.Settings.Default.Endereco;
            lblEmpresa.Text = Properties.Settings.Default.NomeFantasia;
        }

    }
}
