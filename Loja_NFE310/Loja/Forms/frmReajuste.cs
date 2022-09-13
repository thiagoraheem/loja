using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmReajuste : DevExpress.XtraEditors.XtraForm
	{
		public frmReajuste()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (txtPercentual.Text.Equals(String.Empty)) { return; }
			if (txtPercentual.Value <= 0) { return; }

			if (MessageBox.Show("Confirma reajustar os preços desses produtos?", "Confirmar reajuste", MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			try
			{
				var fornecedor = cmbFornecedor.EditValue != null ? cmbFornecedor.EditValue.ToString() : "";

				Cadastros.Reajuste((decimal)txtPercentual.Value, fornecedor);
			}
			catch (Exception ex)
			{
				if (ex.InnerException == null)
				{
					Util.MsgBox(ex.Message);
				}
				else
				{
					Util.MsgBox(ex.InnerException.Message);
				}
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		void SU_CarregaFornecedor()
		{
			var fornecedores = Consultas.ObterFornecedores();

			cmbFornecedor.Properties.DataSource = fornecedores;

		}

		private void frmReajuste_Load(object sender, EventArgs e)
		{
			SU_CarregaFornecedor();
		}


	}
}