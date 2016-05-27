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
			else if (e.KeyCode.Equals(Keys.F1))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.92));
				Cadastros.DescontoVenda(txtCodOrca.Text, 8, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F7))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.90));
				Cadastros.DescontoVenda(txtCodOrca.Text, 10, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F3))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.88));
				Cadastros.DescontoVenda(txtCodOrca.Text, 12, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F4))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.85));
				Cadastros.DescontoVenda(txtCodOrca.Text, 15, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F5))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
				Cadastros.DescontoVenda(txtCodOrca.Text, 5, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F6))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
				Cadastros.DescontoVenda(txtCodOrca.Text, 0, "P");
				InitGridOrca();
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

		void InitGridOrca()
		{

			try
			{
				DevExpress.Utils.WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Carregando os dados");
				wait.Show();
				String CodOrca = txtCodOrca.Text;

				var orcamento = Consultas.ObterOrcamentos(CodOrca);

				gridOrcamento.DataSource = orcamento;
				
				wait.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
			}

		}

	}
}