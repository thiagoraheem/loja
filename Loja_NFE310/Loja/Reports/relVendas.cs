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
			
			// tbl_SaidaTableAdapter1.FillByPeriodo(relVendas1.tbl_Saida, _DatIni, _DatFim);
			//tbl_SaidaItensTableAdapter1.Fill(relVendas1.tbl_SaidaItens);

		}

		public void SU_SetParam(DateTime DatIni, DateTime DatFim, int CodProduto, int CodTipoVenda) {
			this._DatIni = DatIni;
			this._DatFim = DatFim;
			this._CodProduto = CodProduto;
			this._CodTipoVenda = CodTipoVenda;
		}

	}
}
