using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using Loja.DAL.Models;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmClientes : DevExpress.XtraEditors.XtraForm
	{
		List<tbl_Cliente> clientes;

		public frmClientes()
		{
			InitializeComponent();

			CarregaClientes();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			var f = new frmCadCliente();
			f.ShowDialog();

			CarregaClientes();

		}

		void CarregaClientes()
		{

			clientes = Consultas.ObterClientes();
			grdClientes.DataSource = clientes;
		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = grdViewDados.GetSelectedRows()[0];
			codigo = (int)grdViewDados.GetRowCellValue(linha, colCodigo);


			return codigo;
		}

		private void grdViewDados_DoubleClick(object sender, EventArgs e)
		{
			int codigo = FU_PegaCodigoGrid();
			
			var f = new frmCadCliente(codigo);
			f.ShowDialog();

			CarregaClientes();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Confirma excluir esse registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			int codigo = FU_PegaCodigoGrid();
			Cadastros.ExcluiCliente(codigo);

			CarregaClientes();

			MessageBox.Show("Registro excluído com sucesso.");

		}
	}
}