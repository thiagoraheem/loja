using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
	public partial class relResumoVendas : DevExpress.XtraReports.UI.XtraReport
	{
		public relResumoVendas()
		{
			InitializeComponent();
		}

		private void relResumoVendas_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			//XtraReport1.Parameters["DatInicio"].Value = _datIni;
		}

	}
}
