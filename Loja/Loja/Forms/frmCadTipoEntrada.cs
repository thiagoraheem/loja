using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAL.Models;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmCadTipoEntrada : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis
		tbl_TipoEntrada TipoEntrada;

		#endregion

		#region Eventos Form
		public frmCadTipoEntrada()
		{
			InitializeComponent();
		}

		private void frmCadTipoEntrada_Load(object sender, EventArgs e)
		{
			SU_CarregaGrid();
		}

		#endregion

		#region Funções
		void SU_CarregaGrid() {
			var tipoentrada = Consultas.ObterTipoEntradas();

			grdDados.DataSource = tipoentrada.ToList();
		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridDados.GetSelectedRows()[0];
			codigo = (int)gridDados.GetRowCellValue(linha, colCodigo);


			return codigo;
		}

		void SU_LimpaCampos() {
			txtDescricao.Text = string.Empty;
			chkMovimenta.Checked = false;
			this.TipoEntrada = null;
			btnExcluir.Enabled = false;
		}

		#endregion

		#region Botões
		private void btnNovo_Click(object sender, EventArgs e)
		{
			SU_LimpaCampos();
		}

		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Confirma excluir esse registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			Cadastros.ExcluiTipoEntrada(TipoEntrada.CodTipoEntrada);

			SU_CarregaGrid();
			SU_LimpaCampos();

			MessageBox.Show("Registro excluído com sucesso.");
		}
		
		private void btnGravar_Click(object sender, EventArgs e)
		{
			if (TipoEntrada == null)
			{
				TipoEntrada = new tbl_TipoEntrada() { DesTipoEntrada = txtDescricao.Text, flgMovimentaEstoque = chkMovimenta.Checked };
			}
			else
			{
				TipoEntrada.DesTipoEntrada = txtDescricao.Text;
				TipoEntrada.flgMovimentaEstoque = chkMovimenta.Checked;
			}

			Cadastros.GravaTipoEntrada(TipoEntrada);

			SU_CarregaGrid();
			SU_LimpaCampos();
		}
		#endregion

		#region Eventos Grid
		private void gridDados_DoubleClick(object sender, EventArgs e)
		{
			int codigo = FU_PegaCodigoGrid();
			this.TipoEntrada = Consultas.ObterTipoEntrada(codigo);

			txtDescricao.Text = TipoEntrada.DesTipoEntrada;
			chkMovimenta.Checked = TipoEntrada.flgMovimentaEstoque;

			btnExcluir.Enabled = true;
		}

		#endregion


	}
}