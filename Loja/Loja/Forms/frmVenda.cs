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


namespace Loja
{
	public partial class frmVenda : DevExpress.XtraEditors.XtraForm
	{
		#region Variáveis

		public String CodOrcamento;
		private ConfiguracaoApp _configuracoes;
		private const string ArquivoConfiguracao = @"\configuracao.xml";
		private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		List<tbl_Cliente> clientes;
		tbl_Saida saida;

		#endregion


		public frmVenda()
		{
			InitializeComponent();
			CarregarConfiguracao();
			//CarregaCertificado();
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

				int? codCliente = null;
				if (cmbCliente.EditValue != null)
				{
					codCliente = (int)cmbCliente.EditValue;
				}

				int tipoVenda = int.Parse(cmbTipoVenda.EditValue.ToString());

				int codVenda = Cadastros.FinalizaVenda(CodOrcamento, tipoVenda, flgApagarOrca, codCliente);

				saida = Consultas.ObterVenda(codVenda);

				if (chkNFE.Checked == true)
				{
					var nota = new Modules.NFCE(_configuracoes, saida);

					if (!nota.EnviaNFCE())
					{
						Util.MsgBox("Nota fiscal não enviada, venda não realizada");

						Cadastros.EstornaVenda(codVenda, "Não enviada SEFAZ");

						return;
					}
				}

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
				Util.MsgBox(ex.Message);
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

		private void btnCliente_Click(object sender, EventArgs e)
		{
			var f = new frmClientes();
			f.ShowDialog();

			CarregaClientes();
		}

		private void cmbCliente_EditValueChanged(object sender, EventArgs e)
		{
			if (cmbCliente.EditValue != null && txtNumCPF.Text != cmbCliente.EditValue.ToString())
			{
				var cpf = clientes.FirstOrDefault(x => x.CodCliente == (int)cmbCliente.EditValue);

				txtNumCPF.Text = cpf.NumCPF ?? cpf.NumCNPJ;
			}
		}

		private void txtNumCPF_EditValueChanged(object sender, EventArgs e)
		{


			cmbCliente.EditValue = null;
			var cliente = clientes.FirstOrDefault(x => x.NumCNPJ == txtNumCPF.Text || x.NumCPF == txtNumCPF.Text);

			if (cliente != null)
			{
				cmbCliente.EditValue = cliente.CodCliente;
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


			var total = orca.AsEnumerable().Sum(o => o.PF);

			txtVlrTotal.EditValue = total;
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

		private void CarregarConfiguracao()
		{
			var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			try
			{
				_configuracoes = !File.Exists(path + ArquivoConfiguracao)
					? new ConfiguracaoApp()
					: FuncoesXml.ArquivoXmlParaClasse<ConfiguracaoApp>(path + ArquivoConfiguracao);
				if (_configuracoes.CfgServico.TimeOut == 0)
					_configuracoes.CfgServico.TimeOut = 100; //mínimo

				#region Carrega a logo no controle logoEmitente

				/*if (_configuracoes.ConfiguracaoDanfeNfce.Logomarca != null && _configuracoes.ConfiguracaoDanfeNfce.Logomarca.Length > 0)
					using (var stream = new MemoryStream(_configuracoes.ConfiguracaoDanfeNfce.Logomarca))
					{
						LogoEmitente.Source = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
					}*/

				#endregion



			}
			catch (Exception ex)
			{
				if (!string.IsNullOrEmpty(ex.Message))
					Util.MsgBox(ex.Message);
			}
		}

		#endregion




	}
}