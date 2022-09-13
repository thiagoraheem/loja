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
using Loja.DAL.Models;
using Loja.DAL.DAO;
using System.IO;
using System.Reflection;
using Loja.Modules;

namespace Loja
{
	public partial class frmVendas : DevExpress.XtraEditors.XtraForm
	{

		#region Variáveis
		private ConfiguracaoApp _configuracoes;
		#endregion

		#region Form Events

		public frmVendas(ConfiguracaoApp config)
		{
			InitializeComponent();
			_configuracoes = config;
		}

		private void frmVendas_Load(object sender, EventArgs e)
		{
			txtDatFim.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
			txtDatInicio.DateTime = txtDatFim.DateTime.AddDays(-DateTime.Now.Day).AddDays(1);

			if (relVendas.tbl_Saida.Any()) 
			{ 
				SU_CarregaVendas();
			}

		}

		#endregion

		#region Botões
		private void btnRetornar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			using (Reports.relVendasNFE relatorio = new Reports.relVendasNFE())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				int codproduto = -1;
				int codtipovenda = cmbStatusNFE.EditValue == null ? 0 : (int)cmbStatusNFE.EditValue;

				relatorio.SU_SetParam(txtDatInicio.DateTime, txtDatFim.DateTime, codproduto, codtipovenda);

				printTool.ShowRibbonPreviewDialog();
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}
		}

		private void btnEstornar_Click(object sender, EventArgs e)
		{
			if (relVendas.tbl_Saida.Any())
			{
				string codvenda = FU_PegaCodigoVenda();
				int cvenda;

				if (int.TryParse(codvenda, out cvenda))
				{
					Util.MsgBox("Venda é NFE e não pode ser estornada.");
					return;
				}

				if (MessageBox.Show("Confirma estornar essa venda?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
			

				Cadastros.EstornaVenda(codvenda, "", false);


				MessageBox.Show("Venda estornada com sucesso");


				SU_CarregaVendas();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (relVendas.tbl_Saida.Any())
			{
				string codvenda = FU_PegaCodigoVenda();
				int cvenda;

				if (!int.TryParse(codvenda, out cvenda))
				{
					Util.MsgBox("Venda não é NFE para ser cancelada.");
					return;
				}

				var saida = Consultas.ObterVenda(codvenda);

				if (saida.FlgStatusNFE.Trim() == "X")
				{
					Util.MsgBox("NFE já cancelada.");
					return;
				}

				if (DateTime.Now.Subtract(saida.Data).Days > 1)
				{
					Util.MsgBox("NFE emitida há mais de 24 horas, não é permitido fazer o cancelamento da mesma");
					return;
				}

				if (MessageBox.Show("Confirma cancelar essa NFE?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
					return;

				//var retorno = NFe.Wsdl.Monitor.CancelarNFE(saida.ChaveSefaz.Replace("NFe", ""), "Erro na emissao da nota", Util.SemFormatacao(Properties.Settings.Default.CNPJ), saida.CodVenda);
				var nfe = new Modules.NFCE(_configuracoes, saida);
				var retorno = nfe.CancelarNFe(1, "Erro na emissão da nota");

				if (retorno.Resultado == true) { 
					Cadastros.CancelarVenda(codvenda);
					Util.MsgBox("NFC-e cancelada com sucesso");
				}
				else
				{
					Util.MsgBox(retorno.Mensagem);
				}

				SU_CarregaVendas();
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			SU_CarregaVendas();
		}

		private void btnReimprimir_Click(object sender, EventArgs e)
		{

			var caminho = "";
			var codvenda = FU_PegaCodigoVenda();

			var venda = Consultas.ObterVenda(codvenda);

			caminho = $"{_configuracoes.CfgServico.DiretorioSalvarXml}\\{venda.ChaveSefaz.Replace("NFe", "")}-procNfe.xml";

			if (File.Exists(caminho))
			{
				//NFe.Wsdl.Monitor.ImprimirDANFE(caminho, Properties.Settings.Default.ImpressoraNFE);
				var nfce = new NFCE(_configuracoes, "");
				nfce.ImprimirDanfe(caminho);
			}
			else {
				//var nfe = new NFCE(_configuracoes, codvenda);
				//var xml = nfe.ObterXMLSefaz(venda.ChaveSefaz.Replace("NFe", ""));

				Util.MsgBox("Erro ao tentar reimprimir DANFE, arquivo XML não encontrado");
			}

		}  

		private void btnGerarPDF_Click(object sender, EventArgs e)
		{
			var caminho = "";
			var codvenda = FU_PegaCodigoVenda();

			var venda = Consultas.ObterVenda(codvenda);

			caminho = String.Format($"{_configuracoes.CfgServico.DiretorioSalvarXml}\\{venda.ChaveSefaz.Replace("NFe", "")}-procNfe.xml");

			if (File.Exists(caminho))
			{
				var nfce = new Modules.NFCE(_configuracoes, "");

				SaveFileDialog fileDialog = new SaveFileDialog();

				fileDialog.ShowDialog();

				if (string.IsNullOrEmpty(fileDialog.FileName))
					throw new ArgumentException("Não foi selecionado nem uma pasta");

				//impr.Imprimir(salvarArquivoPdfEm: fileDialog.FileName.Replace(".pdf", "") + ".pdf");

				nfce.ImprimirDanfe(caminho, fileDialog.FileName);
			}
			else
			{
				Util.MsgBox("Erro ao tentar reimprimir DANFE, arquivo XML não encontrado");
			}
		}

		private void btnImprimirResumo_Click(object sender, EventArgs e)
		{
			using (Reports.relResumoVendas relatorio = new Reports.relResumoVendas())
			{

				ReportPrintTool printTool = new ReportPrintTool(relatorio);

				relatorio.Parameters["DatInicio"].Value = txtDatInicio.DateTime;
				relatorio.Parameters["DatFim"].Value = txtDatFim.DateTime;
				// Invoke the Ribbon Print Preview form modally, 
				// and load the report document into it.
				printTool.ShowRibbonPreviewDialog();

				// Invoke the Ribbon Print Preview form
				// with the specified look and feel setting.
				printTool.ShowRibbonPreview(UserLookAndFeel.Default);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (relVendas.tbl_Saida.Any())
				{
					string codvenda = FU_PegaCodigoVenda();
					int cvenda;

					if (int.TryParse(codvenda, out cvenda))
					{
						Util.MsgBox("Venda é NFE e não pode ser excluída.");
						return;
					}

					if (MessageBox.Show("Confirma cancelar essa Venda?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
						return;

					Cadastros.ExcluirVenda(codvenda);

					Util.MsgBox("Venda excluída com sucesso");


					SU_CarregaVendas();
				}
			}
			catch (Exception ex)
			{
				Util.MsgBox("Erro ao excluir nota: " + ex.Message);
				return;
			}

		}

		#endregion

		#region Funções
		public void SU_CarregaVendas()
		{

			DateTime inicio = DateTime.Parse(txtDatInicio.DateTime.ToShortDateString());
			DateTime fim = DateTime.Parse(txtDatFim.DateTime.ToShortDateString()).AddDays(1).AddMinutes(-1);

			if (String.IsNullOrEmpty(cmbStatusNFE.Text)) 
			{ 
				tbl_SaidaTableAdapter1.FillByPeriodo(relVendas.tbl_Saida, inicio, fim);
			}
			else 
			{
				tbl_SaidaTableAdapter1.FillByStatus(relVendas.tbl_Saida, cmbStatusNFE.Text.Substring(0,1), inicio, fim);
			}

			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

			if (relVendas.tbl_Saida.Any())
			{
				btnEstornar.Enabled = true;
				btnCancelar.Enabled = true;
				btnExcluir.Enabled = true;
			}
			else
			{
				btnEstornar.Enabled = false;
				btnCancelar.Enabled = false;
				btnExcluir.Enabled = false;
			}

		}

		public void SU_CarregaVendas(string tipo, DateTime datIni, DateTime datFim)
		{

			tbl_SaidaTableAdapter1.FillByStatus(relVendas.tbl_Saida, tipo, datIni, datFim);
			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

			if (relVendas.tbl_Saida.Any())
			{
				btnEstornar.Enabled = true;
				btnCancelar.Enabled = true;
				btnExcluir.Enabled = true;
			}
			else
			{
				btnEstornar.Enabled = false;
				btnCancelar.Enabled = false;
				btnExcluir.Enabled = false;
			}

		}

		public void SU_CarregaVendasContingencia()
		{

			tbl_SaidaTableAdapter1.FillByContingencia(relVendas.tbl_Saida);
			tbl_SaidaItensTableAdapter1.Fill(relVendas.tbl_SaidaItens);

			grdDados.RefreshDataSource();

		}

		string FU_PegaCodigoVenda()
		{
			var codigo = "";

			int linha = gridDados.GetSelectedRows()[0];
			codigo = gridDados.GetRowCellValue(linha, colCodVenda).ToString();

			return codigo;
		}

		#endregion

	}
}