using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAL.DAO;

namespace Loja.Forms
{
	public partial class frmOrcamento : DevExpress.XtraEditors.XtraForm
	{
		private List<Loja.DAL.Models.tbl_Orcamento> _Orca;
		private frmPrincipal principal;

		public frmOrcamento(string codOrca, List<Loja.DAL.Models.tbl_Orcamento> orcamento, frmPrincipal p)
		{
			InitializeComponent();

			_Orca = orcamento;
			gridOrcamento.DataSource = _Orca;

			txtCodOrca.Text = codOrca;

			principal = p;
		}

		private void frmOrcamento_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.F12))
			{
				this.Hide();
				principal.SU_FinalizarVenda();
				Close();
			}
			else
			{
				Close();
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}