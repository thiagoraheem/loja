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
using Loja.DAL.DAO;
using Loja.DAL.Models;

namespace Loja
{
	public partial class frmEntradas : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis
		#endregion

		#region Form Events

		public frmEntradas()
		{
			InitializeComponent();
		}

		private void frmEntradas_Load(object sender, EventArgs e)
		{
			txtDatFim.DateTime = DateTime.Now;
			txtDatInicio.DateTime = DateTime.Now;

			SU_CarregaProdutos();

		}

		#endregion

		#region Botões
		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			/*using (Reports.relVendas relatorio = new Reports.relVendas())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				int codproduto = cmbProduto.EditValue == null ? 0 : (int)cmbProduto.EditValue;

				relatorio.SU_SetParam(txtDatInicio.DateTime, txtDatFim.DateTime, codproduto, codtipovenda);

				printTool.ShowRibbonPreviewDialog();
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}*/
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			SU_CarregaEntrada();
		}


		#endregion

		#region Funções
		void SU_CarregaProdutos()
		{
			var produtos = Consultas.ObterProdutosAtivos();
			cmbProduto.Properties.DataSource = produtos;

		}

		void SU_CarregaEntrada() {

			DateTime inicio = txtDatInicio.DateTime.AddDays(-1);
			DateTime fim = txtDatFim.DateTime;

			var entradas = Consultas.ObterEntrada(inicio, fim);
			grdDados.DataSource = entradas;

		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridDados.GetSelectedRows()[0];
			codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

			return codigo;
		}

		#endregion

	}
}