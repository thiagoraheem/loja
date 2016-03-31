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
using System.IO;
using System.Reflection;

using Loja.DAL.Models;
using NFe.Utils;
using NFe.Classes;
using NFe.Impressao.NFCe.FastReports;
using NFe.Impressao.NFCe;
using NFe.Impressao;


namespace Loja
{
	public partial class frmVenda : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis

		public String CodOrcamento;
		private ConfiguracaoApp _configuracoes;
		List<tbl_Cliente> clientes;
		tbl_Saida saida;
		#endregion

		public frmVenda(ConfiguracaoApp config)
		{
			InitializeComponent();

			_configuracoes = config;
		}

		private void frmVenda_Load(object sender, EventArgs e)
		{
			SU_CarregaTipoVenda();
			cmbTipoVenda.EditValue = cmbTipoVenda.Properties.GetDataSourceValue(cmbTipoVenda.Properties.ValueMember, 0);
			if (CodOrcamento == "") Close();

			SU_CarregaOrcamento(CodOrcamento);

			CarregaClientes();
		}

		#region Eventos

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

		private void btnAplicarDesconto_Click(object sender, EventArgs e)
		{
			var tipo = (cmbTipoDesconto.Text == "%") ? "P" : "R";
			Cadastros.DescontoVenda(CodOrcamento, (double)txtDesconto.Value, tipo);
			SU_CarregaOrcamento(CodOrcamento);
		}

		private void btnFinalizarVenda_Click(object sender, EventArgs e)
		{
			bool bApagar = false;
			int? codCliente = null;

			try
			{

				boxEnviando.Show();

				this.Refresh();
				this.ForceRefresh();

				if (cmbCliente.EditValue != null)
				{
					codCliente = (int)cmbCliente.EditValue;
				}
				else
				{
					if (!String.IsNullOrEmpty(txtNumCPF.Text))
					{
						var nomCliente = txtNome.Text;
						if (nomCliente == "") nomCliente = "CLIENTE NÃO IDENTIFICADO";

						var cCliente = Cadastros.GravaCliente(new tbl_Cliente() { NumCPF = txtNumCPF.Text, NomCliente = nomCliente });
						codCliente = cCliente;
						bApagar = true;

						this.Refresh();
						this.ForceRefresh();
					}
				}

				int tipoVenda = int.Parse(cmbTipoVenda.EditValue.ToString());
				var nfe = (chkNFE.Checked == true ? 1 : 0);

				var codVenda = Cadastros.FinalizaVenda(CodOrcamento, tipoVenda, codCliente, nfe);

				this.Refresh();
				this.ForceRefresh();

				saida = Consultas.ObterVenda(codVenda);

				this.Refresh();
				this.ForceRefresh();

				if (nfe == 1)
				{

					if (_configuracoes.CfgServico.tpEmis == NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teOffLine)
					{
						saida.FlgStatusNFE = "C";
					}

					var nota = new Modules.NFCE(_configuracoes, saida);

					if (!nota.EnviaNFCE())
					{
						Util.MsgBox("Nota fiscal não enviada, venda não realizada");

						Cadastros.EstornaVenda(codVenda, "Não enviada SEFAZ", true);

						if (bApagar && codCliente != null)
						{
							Cadastros.ExcluiCliente(codCliente.Value);
						}

						this.DialogResult = System.Windows.Forms.DialogResult.No;
						this.Close();
						return;

					}

					this.Refresh();
					this.ForceRefresh();

				}

				if (bApagar && codCliente != null)
				{
					Cadastros.ExcluiCliente(codCliente.Value);
				}

				if (chkApagarOrca.Checked)
				{
					Cadastros.ExcluiOrcamento(CodOrcamento);
				}

				this.DialogResult = System.Windows.Forms.DialogResult.Yes;

				if (chkEmitirRecibo.Checked)
				{
					using (frmRecibo f = new frmRecibo())
					{
						f.txtValor.Value = txtVlrFinal.Value;
						f.txtExtenso.Text = Util.toExtenso(txtVlrFinal.Value);
						f.txtNome.Text = txtNome.Text;
						if (saida != null)
						{
							f.txtReferente.Text = string.Format("VENDA DE MERCADORIA COM A NF: {0}", saida.CodVenda);
						}
						else
						{
							f.txtReferente.Text = "VENDA DE PEÇAS AUTOMOTIVAS";
						}
						f.ShowDialog();
					}
				}

			}
			catch (Exception ex)
			{
				if (bApagar && codCliente != null)
				{
					Cadastros.ExcluiCliente(codCliente.Value);
				}
				this.DialogResult = System.Windows.Forms.DialogResult.No;
				Util.MsgBox(ex.Message);
				boxEnviando.Hide();
			}

		}

		private void txtDinheiro_Validated(object sender, EventArgs e)
		{

			try
			{

				if (!txtDinheiro.Text.Equals(String.Empty) && !txtDinheiro.Text.Equals("0"))
				{
					decimal dinheiro = txtDinheiro.Value;
					decimal vlrtotal = txtVlrFinal.Value;

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

		private void btnCliente_Click(object sender, EventArgs e)
		{
			var f = new frmClientes();
			f.ShowDialog();

			CarregaClientes();
		}

		private void cmbCliente_EditValueChanged(object sender, EventArgs e)
		{
			if (cmbCliente.EditValue != null)
			{
				var cpf = clientes.FirstOrDefault(x => x.CodCliente == (int)cmbCliente.EditValue);

				if (!String.IsNullOrEmpty(cpf.NumCPF)) 
				{
					txtNumCPF.Text = cpf.NumCPF;
				}
				else
				{
					txtNumCPF.Text = cpf.NumCNPJ;
				}
				txtNome.Text = cmbCliente.Text;
			}
		}

		private void txtNumCPF_EditValueChanged(object sender, EventArgs e)
		{

			cmbCliente.EditValue = null;
			var cliente = clientes.FirstOrDefault(x => x.NumCNPJ == txtNumCPF.Text || x.NumCPF == txtNumCPF.Text);

			if (cliente != null)
			{
				cmbCliente.EditValue = cliente.CodCliente;
				txtNome.Text = cliente.NomCliente;
			}
		}

		#endregion

		#region Funções
		void SU_CarregaTipoVenda()
		{
			var TipoVenda = Consultas.ObterTipoVendaCombo();
			cmbTipoVenda.Properties.DataSource = TipoVenda;
		}

		void SU_CarregaOrcamento(String codOrca)
		{

			var orca = Consultas.ObterOrcamentos(codOrca);

			gridOrcamento.DataSource = orca.ToList();


			var final = orca.AsEnumerable().Sum(o => o.PF);

			txtVlrFinal.EditValue = final;

			var total = orca.AsEnumerable().Sum(o => o.VlrCusto * o.Quantidade);

			txtVlrTotal.EditValue = total;

			var desconto = orca.AsEnumerable().Sum(o => o.VlrDesconto);

			txtDesconto.EditValue = desconto;

		}

		int FU_PegaCodigoGrid()
		{
			int codigo = -1;

			int linha = gridViewOrcamento.GetSelectedRows()[0];
			codigo = (int)gridViewOrcamento.GetRowCellValue(linha, colCodigounico);

			return codigo;
		}

		void CarregaClientes()
		{

			clientes = Consultas.ObterClientes();
			cmbCliente.Properties.DataSource = clientes;

		}

		#endregion

	}
}