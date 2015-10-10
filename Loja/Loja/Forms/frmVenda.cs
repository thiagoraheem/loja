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
	public partial class frmVenda : DevExpress.XtraEditors.XtraForm
	{
		public String CodOrcamento;

		public frmVenda()
		{
			InitializeComponent();
		}

		private void frmVenda_Load(object sender, EventArgs e)
		{
			SU_CarregaTipoVenda();
			cmbTipoVenda.EditValue = cmbTipoVenda.Properties.GetDataSourceValue(cmbTipoVenda.Properties.ValueMember, 0);
			if (CodOrcamento == "") Close();

			SU_CarregaOrcamento(CodOrcamento);
		}

		void SU_CarregaTipoVenda()
		{
			var TipoVenda = Consultas.ObterTipoVendaCombo();
			cmbTipoVenda.Properties.DataSource = TipoVenda;
		}

		void SU_CarregaOrcamento(String codOrca)
		{

			var orca = Consultas.ObterOrcamentos(codOrca);

			gridOrcamento.DataSource = orca.ToList();


			var total = orca.AsEnumerable().Sum(o => o.PF);

			txtVlrTotal.EditValue = total;
		}

		private void gridViewOrcamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			try
			{
				if (e.Column == colQuantidade)
				{
					double quantidade;

					if (e.Value != null)
						quantidade = (double)e.Value;
					else
						quantidade = 0;

					Cadastros.AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), quantidade, -1);
				}
				else
					if (e.Column == colValor)
					{
						Cadastros.AlterarOrcamento(CodOrcamento, FU_PegaCodigoGrid(), -1, (double)e.Value);
					}
			}
			catch (Exception ex)
			{
				Util.MsgBox("Erro na alteração: " + ex.InnerException.Message);
			}
			SU_CarregaOrcamento(CodOrcamento);
		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridViewOrcamento.GetSelectedRows()[0];
			codigo = (int)gridViewOrcamento.GetRowCellValue(linha, colCodigounico);

			return codigo;
		}

		private void btnAplicarDesconto_Click(object sender, EventArgs e)
		{
			Cadastros.DescontoVenda(CodOrcamento, (double)txtDesconto.Value);
			SU_CarregaOrcamento(CodOrcamento);
		}

		private void btnFinalizarVenda_Click(object sender, EventArgs e)
		{
			try
			{
				String flgApagarOrca;
				if (chkApagarOrca.Checked)
				{
					flgApagarOrca = "S";
				}
				else
				{
					flgApagarOrca = "N";
				}
				Cadastros.FinalizaVenda(CodOrcamento, (int)cmbTipoVenda.EditValue, flgApagarOrca);
				this.DialogResult = System.Windows.Forms.DialogResult.Yes;

				if (chkEmitirRecibo.Checked)
				{
					using (frmRecibo f = new frmRecibo())
					{
						f.txtValor.Value = txtVlrTotal.Value;
						f.txtExtenso.Text = Util.toExtenso(txtVlrTotal.Value);
						f.ShowDialog();
					}
				}

			}
			catch (Exception ex)
			{
				this.DialogResult = System.Windows.Forms.DialogResult.No;
				MessageBox.Show(ex.Message);
			}

		}

		private void txtDinheiro_Validated(object sender, EventArgs e)
		{

			try
			{

				if (!txtDinheiro.Text.Equals(String.Empty) && !txtDinheiro.Text.Equals("0"))
				{
					decimal dinheiro = txtDinheiro.Value;
					decimal vlrtotal = txtVlrTotal.Value;

					if (dinheiro >= vlrtotal)
					{
						decimal troco = dinheiro - vlrtotal;
						txtTroco.EditValue = troco;
					}
					else
					{
						txtDinheiro.Text = "";
						txtDinheiro.Focus();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.No;
			Close();
		}

	}
}