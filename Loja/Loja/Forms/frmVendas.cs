using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using Loja.DAL.Models;
using Loja.DAL.DAO;
using System.IO;
using System.Reflection;

namespace Loja
{
	public partial class frmVendas : DevExpress.XtraEditors.XtraForm
	{

		#region Variáveis
		#endregion

		#region Form Events

		public frmVendas()
		{
			InitializeComponent();
		}

		private void frmVendas_Load(object sender, EventArgs e)
		{
			txtDatFim.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
			txtDatInicio.DateTime = txtDatFim.DateTime.AddDays(-DateTime.Now.Day).AddDays(1);

			if (relVendas.tbl_Saida.Any()) 
			{ 
				SU_CarregaVendas();
			}

		}

		#endregion

		#region Botões
		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			using (Reports.relVendasNFE relatorio = new Reports.relVendasNFE())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				int codproduto = -1;
				int codtipovenda = cmbStatusNFE.EditValue == null ? 0 : (int)cmbStatusNFE.EditValue;

				relatorio.SU_SetParam(txtDatInicio.DateTime, txtDatFim.DateTime, codproduto, codtipovenda);

				printTool.ShowRibbonPreviewDialog();
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}
		}

		private void btnEstornar_Click(object sender, EventArgs e)
		{
			if (relVendas.tbl_Saida.Any())
			{

				if (MessageBox.Show("Confirma estornar essa venda?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				
				string codvenda = FU_PegaCodigoVenda();

				Cadastros.EstornaVenda(codvenda, "", false);


				MessageBox.Show("Item estornado com sucesso");


				SU_CarregaVendas();
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			SU_CarregaVendas();
		}

		private void btnReimprimir_Click(object sender, EventArgs e)
		{

			var caminho = "";
			var codvenda = FU_PegaCodigoVenda();

			caminho = String.Format("{0}\\XML\\{1}-env-lot.xml", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), codvenda);

			if (File.Exists(caminho))
			{
				NFe.Wsdl.Monitor.ImprimirDANFE(caminho, Properties.Settings.Default.ImpressoraNFE);
			}
			else { 
				Util.MsgBox("Erro ao tentar reimprimir DANFE, arquivo XML não encontrado");
			}

		}

		private void btnImprimirResumo_Click(object sender, EventArgs e)
		{
			using (Reports.relResumoVendas relatorio = new Reports.relResumoVendas())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				relatorio.Parameters["DatInicio"].Value = txtDatInicio.DateTime;
				relatorio.Parameters["DatFim"].Value = txtDatFim.DateTime;
				// Invoke the Ribbon Print Preview form modally, 
				// and load the report document into it.
				printTool.ShowRibbonPreviewDialog();

				// Invoke the Ribbon Print Preview form
				// with the specified look and feel setting.
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}
		}

		#endregion

		#region Funções
		public void SU_CarregaVendas()
		{

			DateTime inicio = DateTime.Parse(txtDatInicio.DateTime.ToShortDateString());
			DateTime fim = DateTime.Parse(txtDatFim.DateTime.ToShortDateString()).AddDays(1).AddMinutes(-1);

			if (String.IsNullOrEmpty(cmbStatusNFE.Text)) 
			{ 
				tbl_SaidaTableAdapter1.FillByPeriodo(relVendas.tbl_Saida, inicio, fim);
			}
			else 
			{
				tbl_SaidaTableAdapter1.FillByStatus(relVendas.tbl_Saida, cmbStatusNFE.Text.Substring(0,1), inicio, fim);
			}

			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

			if (relVendas.tbl_Saida.Any())
			{
				btnEstornar.Enabled = true;
			}
			else
			{
				btnEstornar.Enabled = false;
			}

		}

		public void SU_CarregaVendas(string tipo, DateTime datIni, DateTime datFim)
		{

			tbl_SaidaTableAdapter1.FillByStatus(relVendas.tbl_Saida, tipo, datIni, datFim);
			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

			if (relVendas.tbl_Saida.Any())
			{
				btnEstornar.Enabled = true;
			}
			else
			{
				btnEstornar.Enabled = false;
			}

		}

		public void SU_CarregaVendasContingencia()
		{

			tbl_SaidaTableAdapter1.FillByContingencia(relVendas.tbl_Saida);
			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

		}

		string FU_PegaCodigoVenda()
		{
			var codigo = "";

			int linha = gridDados.GetSelectedRows()[0];
			codigo = gridDados.GetRowCellValue(linha, colCodVenda).ToString();

			return codigo;
		}

		#endregion
		
	}
}