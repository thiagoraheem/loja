using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
	public partial class relVendasNFE : DevExpress.XtraReports.UI.XtraReport
	{

		private DateTime _DatIni;
		private DateTime _DatFim;
		private int _CodProduto;
		private int _CodTipoVenda;


		public relVendasNFE()
		{
			InitializeComponent();
		}
		public void SU_SetParam(DateTime DatIni, DateTime DatFim, int CodProduto, int CodTipoVenda)
		{
			this._DatIni = DatIni;
			this._DatFim = DatFim;
			this._CodProduto = CodProduto;
			this._CodTipoVenda = CodTipoVenda;
		}

		private void relVendasNFE_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			tbl_SaidaTableAdapter.FillByPeriodo(relVendas1.tbl_Saida, _DatIni, _DatFim);
			//tbl_SaidaItensTableAdapter.Fill(relVendas1.tbl_SaidaItens);
		}
	}
}
