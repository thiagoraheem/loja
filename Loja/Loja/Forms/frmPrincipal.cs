using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraReports.UI;
using Loja.DAL.DAO;
using Loja.DAL.Models;
using System.Threading;
using System.IO;
using System.Reflection;
using NFe.Utils;

namespace Loja
{
	public partial class frmPrincipal : RibbonForm
	{

		#region Variáveis e Configurações
		public ConfiguracaoApp _configuracoes;
		private const string ArquivoConfiguracao = @"\configuracao.xml";
		private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		private bool _ModoEdicao = false;
		private List<tbl_Produtos> produtos = new List<tbl_Produtos>();
		private List<tbl_Orcamento> orcamento = new List<tbl_Orcamento>();
		Thread t = null;
		Thread c = null;
		int contAviso = 0;
		int contAvisoInt = 0;
		private int QtdContingencia = 0;

		#endregion

		#region Form

		public frmPrincipal()
		{
			InitializeComponent();
			InitSkinGallery();
			InitGrid();
			InitComboOrca();

			gridProdutos.DataSource = produtos;
			gridViewProduto.Columns[colDesProduto.AbsoluteIndex].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

			gridOrcamento.DataSource = orcamento;

			t = new Thread(VerificaStatus) { IsBackground = true };
			t.Start();

			c = new Thread(VerificaContingencia) { IsBackground = true };
			c.Start();

			CarregarConfiguracao();

		}

		void InitSkinGallery()
		{
			SkinHelper.InitSkinGallery(rgbiSkins, true);
		}

		private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Escape))
			{
				if (!gridViewProduto.ActiveFilter.IsEmpty)
				{
					gridViewProduto.ClearColumnsFilter();
				}
				else if (cmbCodOrca.EditValue == null || !String.IsNullOrEmpty(cmbCodOrca.EditValue.ToString()))
				{
					cmbCodOrca.EditValue = String.Empty;
					InitGrid();
					InitGridOrca();
					InitComboOrca();
				}
				else
				{
					InitComboOrca();
				}
			}
			else if (e.KeyCode.Equals(Keys.F2))
			{
				gridViewProduto.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
				gridViewProduto.FocusedColumn = colDesProduto;
				gridViewProduto.ShowEditor();
			}
		}

		#endregion

		#region Funções e Consultas

		void VerificaStatus()
		{

			while (true)
			{

				if (VerificaInternet())
				{
					if (VerificaSefaz())
					{
						ModoContingencia(false);

						if (QtdContingencia > 0)
						{
							var cont = new Modules.NFCE(_configuracoes, null);
							cont.EnviarContingencia();
							Util.MsgBox(String.Format("Havia{0} {1} nota{2} em contingência que foram enviadas após cessarem os problemas de conexão!", QtdContingencia > 1 ? "m" : "", QtdContingencia, QtdContingencia > 1 ? "s" : ""));
						}

					}
				}
				Thread.Sleep(10000);

			}

		}

		private bool VerificaInternet()
		{

			var retorno = Util.PingHost("www.google.com.br");

			chkInternet.Checked = retorno;

			if (!retorno)
			{
				chkInternet.ItemAppearance.Normal.BackColor = System.Drawing.Color.Red;
				chkInternet.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;

				chkStatusSefaz.Checked = retorno;

				if (contAvisoInt == 0)
				{
					Util.MsgBox("ATENÇÃO! Internet indisponível, <b>entrando em modo de contingência</b>");
					ModoContingencia(true);
					contAvisoInt++;
				}
			}
			else
			{
				chkInternet.ItemAppearance.Normal.Options.UseBackColor = false;
				chkInternet.ItemAppearance.Normal.Options.UseForeColor = false;

				if (contAvisoInt > 0)
				{
					contAvisoInt = 0;
				}
			}

			return retorno;
		}

		private bool VerificaSefaz()
		{
			var retornoS = NFe.Wsdl.Monitor.StatusServico();

			chkStatusSefaz.Checked = retornoS.Status;

			if (!retornoS.Status)
			{
				chkStatusSefaz.ItemAppearance.Normal.BackColor = System.Drawing.Color.Red;
				chkStatusSefaz.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;

				if (contAviso == 0)
				{
					Util.MsgBox("Serviço SEFAZ indisponível ou internet fora do ar, <b>entrando em modo de contingência</b>");
					ModoContingencia(true);
					contAviso++;
				}
			}
			else
			{
				chkStatusSefaz.ItemAppearance.Normal.Options.UseBackColor = false;
				chkStatusSefaz.ItemAppearance.Normal.Options.UseForeColor = false;

				if (contAviso > 0)
				{
					contAviso = 0;
				}
			}

			return retornoS.Status;
		}

		void VerificaContingencia()
		{
			while (true)
			{

				QtdContingencia = Consultas.ObterQtdContingencia();
				btnQtdContingencia.Caption = String.Format("Notas em Contingência: <b>{0}</b>", QtdContingencia.ToString() ?? "0");

				Thread.Sleep(25000);

			}
		}

		void ModoContingencia(bool tipo)
		{
			if (tipo)
			{
				btnContingencia.Checked = true;
				_configuracoes.CfgServico.tpEmis = NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teOffLine;
			}
			else
			{
				btnContingencia.Checked = false;
				_configuracoes.CfgServico.tpEmis = NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teNormal;
			}
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

		void InitGrid()
		{
			try
			{
				DevExpress.Utils.WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Carregando os dados");
				wait.Show();

				if (this._ModoEdicao)
				{
					produtos = Consultas.ObterProdutos();
				}
				else
				{
					produtos = Consultas.ObterProdutosAtivos();
				}

				lblQtdProduto.Caption = "Qtd. Produtos: " + Consultas.ObterQtdeProdutos().ToString();

				var qtditens = Consultas.ObterQtdeItens().ToString();
				lblQtdItens.Caption = "Qtd. Itens: " + qtditens;

				gridProdutos.DataSource = produtos;
				gridProdutos.RefreshDataSource();

				wait.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
			}
		}

		void InitGridOrca()
		{

			if (cmbCodOrca.EditValue == null || String.IsNullOrEmpty(cmbCodOrca.EditValue.ToString()))
			{
				btnImprimir.Enabled = false;
				btnFinalizarVenda.Enabled = false;
				btnExcluirOrca.Enabled = false;
				txtQtdItem.EditValue = "";
				gridOrcamento.DataSource = null;
				return;
			}

			try
			{
				DevExpress.Utils.WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Carregando os dados");
				wait.Show();
				String CodOrca = cmbCodOrca.EditValue.ToString();

				orcamento = Consultas.ObterOrcamentos(CodOrca);

				gridOrcamento.DataSource = orcamento;

				txtQtdItem.EditValue = orcamento.Count();

				InitComboOrca();

				btnFinalizarVenda.Enabled = true;
				btnImprimir.Enabled = true;
				btnExcluirOrca.Enabled = true;

				wait.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
			}

		}

		void InitComboOrca()
		{
			try
			{

				var orca = Consultas.ObterOrcamentosCombo();

				repCodOrca.DataSource = orca;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
			}

		}

		int FU_PegaCodigoGrid(String origem)
		{

			int codigo = -1;

			try
			{

				if (origem == "P")
				{
					int linha = gridViewProduto.GetSelectedRows()[0];
					codigo = (int)gridViewProduto.GetRowCellValue(linha, colCodigounico);
				}
				else if (origem == "O")
				{
					int linha = gridViewOrcamento.GetSelectedRows()[0];
					codigo = (int)gridViewOrcamento.GetRowCellValue(linha, colOrcodigounico);
				}

			}
			catch (Exception ex)
			{
				Util.MsgBox(ex.Message);
			}

			return codigo;
		}

		String FU_PegaLocalGrid()
		{
			String codigo = "";

			int linha = gridViewProduto.GetSelectedRows()[0];
			codigo = gridViewProduto.GetRowCellValue(linha, colLocal).ToString();


			return codigo;
		}

		void SU_FinalizarVenda()
		{

			if (chkStatusSefaz.Checked == false && btnContingencia.Checked == false)
			{
				if (MessageBox.Show(this, "Deseja entrar em modo Contingência?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					btnContingencia.Checked = true;
				}

			}

			if (cmbCodOrca.EditValue.ToString() != "")
			{
				using (frmVenda f = new frmVenda(_configuracoes))
				{
					f.CodOrcamento = cmbCodOrca.EditValue.ToString();
					f.ShowDialog();

					if (f.DialogResult != System.Windows.Forms.DialogResult.Cancel)
					{
						InitGrid();
						InitComboOrca();
						cmbCodOrca.EditValue = "";
						InitGridOrca();
					}
				}
			}

		}

		String SU_AddOrca(String CodOrca)
		{
			try
			{
				int codproduto = FU_PegaCodigoGrid("P");

				var codOrca = Cadastros.AdicionarOrcamento(CodOrca, codproduto);

				cmbCodOrca.EditValue = codOrca.FirstOrDefault();

				InitGridOrca();
				return cmbCodOrca.EditValue.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat("Erro ao adicionar item: ", ex.Message));
				return "";
			}
		}
		#endregion

		#region Botões RibbonBar
		private void iExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			Application.Exit();
		}

		private void btnRecarregarDados_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitGrid();
		}

		private void cmbCodOrca_EditValueChanged(object sender, EventArgs e)
		{
			InitGridOrca();
		}

		private void repCodOrca_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (e.Button.Index == 1)
			{
				cmbCodOrca.EditValue = "";
			}
		}

		private void btnFinalizarVenda_ItemClick(object sender, ItemClickEventArgs e)
		{
			SU_FinalizarVenda();
		}

		private void rgbiSkins_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
		{
			Properties.Settings.Default.Estilo = e.Item.Caption;
			Properties.Settings.Default.Save();
		}

		private void btnExcluirOrca_ItemClick(object sender, ItemClickEventArgs e)
		{

			Cadastros.ApagarOrcamento(cmbCodOrca.EditValue.ToString());
			InitGrid();
			InitGridOrca();
			InitComboOrca();
			btnImprimir.Enabled = false;
			btnFinalizarVenda.Enabled = false;
			btnExcluirOrca.Enabled = false;
		}

		private void btnVendaRapida_ItemClick(object sender, ItemClickEventArgs e)
		{
			String orca = SU_AddOrca("");
			frmVenda f = new frmVenda(_configuracoes);
			f.CodOrcamento = cmbCodOrca.EditValue.ToString();
			f.ShowDialog();

			if (f.DialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				InitGrid();
				InitComboOrca();
				cmbCodOrca.EditValue = "";
				InitGridOrca();
			}
			else
			{
				Cadastros.ApagarOrcamento(orca);
				InitGridOrca();
				InitComboOrca();
				btnImprimir.Enabled = false;
				btnFinalizarVenda.Enabled = false;
				btnExcluirOrca.Enabled = false;
			}
		}

		private void btnQtdContingencia_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (var f = new frmVendas())
			{
				f.SU_CarregaVendasContingencia();
				f.ShowDialog();
			}
		}

		private void btnStatus_ItemClick(object sender, ItemClickEventArgs e)
		{
			Util.MsgBox(Util.ComandoACBR("NFE.StatusServico"));
		}

		private void btnFazerBackup_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (MessageBox.Show("Confirma copiar os dados a partir do DOS?", "Confirmar importação", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			Util.CopiarDoDbf();
			InitGrid();
		}

		private void btnContingencia_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			if (btnContingencia.Checked)
			{
				_configuracoes.CfgServico.tpEmis = NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teOffLine;
			}
			else
			{
				_configuracoes.CfgServico.tpEmis = NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teNormal;
			}
		}

		#endregion

		#region Eventos Grids
		private void gridProdutos_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				String Orca;
				if (cmbCodOrca.EditValue == null)
				{
					Orca = "";
				}
				else
				{
					Orca = cmbCodOrca.EditValue.ToString();
				}
				SU_AddOrca(Orca);
			}
			else if (e.KeyCode == Keys.Return)
			{
				int codproduto = FU_PegaCodigoGrid("P"); ;

				frmDetalhe f = new frmDetalhe(this);
				f.SU_CarregaProduto(codproduto);
				f.ShowDialog();
			}
		}

		private void gridProdutos_DoubleClick(object sender, EventArgs e)
		{
			if (_ModoEdicao)
			{
				int codproduto = FU_PegaCodigoGrid("P"); ;
				string deslocal = FU_PegaLocalGrid();

				using (frmProduto f = new frmProduto())
				{
					f.SU_CarregaProduto(codproduto);
					f.ShowDialog();
				}

				InitGrid();
			}
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

					Cadastros.AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), quantidade, -1.0);
				}
				else
					if (e.Column == colValor)
					{
						Cadastros.AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), -1.0, (double)e.Value);
					}
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					Util.MsgBox("Erro na alteração: " + ex.InnerException.Message);
				}
				else
				{
					Util.MsgBox("Erro na alteração: " + ex.Message);
				}
			}
			InitGridOrca();
		}

		private void gridOrcamento_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Escape)) { return; }

			int linha = (gridViewOrcamento.SelectedRowsCount > 0) ? gridViewOrcamento.GetSelectedRows()[0] : 0;
			double valor = (double)gridViewOrcamento.GetRowCellValue(linha, colVlrOriginal);

			if (e.KeyCode.Equals(Keys.Delete))
			{
				Cadastros.AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), 0, -1);

				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F1))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.92));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 8, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F7))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.90));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 10, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F3))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.88));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 12, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F4))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.85));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 15, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F5))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 5, "P");
				InitGridOrca();
			}
			else if (e.KeyCode.Equals(Keys.F6))
			{
				//gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
				Cadastros.DescontoVenda(cmbCodOrca.EditValue.ToString(), 0, "P");
				InitGridOrca();
			}
		}

		#endregion

		#region Botões NavBar
		private void btnVender_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			SU_FinalizarVenda();
		}

		private void btnCadastrar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmProduto f = new frmProduto())
			{
				f.SU_NovoProduto();
				f.ShowDialog();
			}

			InitGrid();
		}

		private void btnImprimir_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (cmbCodOrca.EditValue.ToString() != "")
			{
				using (Reports.relOrcamento relatorio = new Reports.relOrcamento())
				{

					ReportPrintTool printTool = new ReportPrintTool(relatorio);

					relatorio.Parameters["CodOrca"].Value = cmbCodOrca.EditValue.ToString();
					// Invoke the Ribbon Print Preview form modally, 
					// and load the report document into it.
					printTool.ShowRibbonPreviewDialog();

					// Invoke the Ribbon Print Preview form
					// with the specified look and feel setting.
					printTool.ShowRibbonPreview(UserLookAndFeel.Default);
				}

			}
		}

		private void btnReajustar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmReajuste f = new frmReajuste())
			{
				f.ShowDialog();
			}

			InitGrid();

		}

		private void btnRecibo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmRecibo f = new frmRecibo())
			{
				f.ShowDialog();
			}
		}

		private void btnEstMinimo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (Reports.relEstMinimo relatorio = new Reports.relEstMinimo())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				printTool.ShowRibbonPreviewDialog();
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}
		}

		private void btnCadTipoVenda_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmCadTipoVenda f = new frmCadTipoVenda())
			{
				f.ShowDialog();

			}
		}

		private void btnCadTipoEntrada_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmCadTipoEntrada f = new frmCadTipoEntrada())
			{
				f.ShowDialog();

			}
		}

		private void btnEntrada_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmEntrada f = new frmEntrada())
			{
				f.ShowDialog();

			}
			InitGrid();
		}

		private void btnRelVendas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmVendas f = new frmVendas())
			{
				f.ShowDialog();

			}
			InitGrid();
		}

		private void btnRelEntradas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			using (frmEntradas f = new frmEntradas())
			{
				f.ShowDialog();

			}
		}

		private void btnModoEdicao_ItemClick(object sender, ItemClickEventArgs e)
		{
			this._ModoEdicao = btnModoEdicao.Down;
			InitGrid();

			if (_ModoEdicao)
			{
				UserLookAndFeel.Default.SetSkinStyle("Sharp");
			}
			else
			{
				UserLookAndFeel.Default.SetSkinStyle("Money Twins");
			}

		}

		private void btnCadCliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			var f = new frmClientes();
			f.ShowDialog();
		}

	}
		#endregion

}