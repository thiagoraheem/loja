using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Objects;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraReports.UI;

namespace Loja
{
    public partial class frmPrincipal : RibbonForm
    {
        private bool _ModoEdicao = false;

        #region Form

        public frmPrincipal()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();
            InitComboOrca();

            gridViewProduto.Columns[colDesProduto.AbsoluteIndex].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                if (!gridViewProduto.ActiveFilter.IsEmpty) {
                    gridViewProduto.ClearColumnsFilter();
                }
                else if (cmbCodOrca.EditValue == null || !String.IsNullOrEmpty(cmbCodOrca.EditValue.ToString()))
                {
                    cmbCodOrca.EditValue = String.Empty;
                    InitGrid();
                    InitGridOrca();
                }
            }
        }
        #endregion

        #region Funções e Consultas

        void InitGrid()
        {
            try
            {
                DevExpress.Utils.WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Carregando os dados");
                wait.Show();
                LojaEntities Loja = new LojaEntities();
                if (this._ModoEdicao)
                {
                    gridProdutos.DataSource = (from produtos in Loja.tbl_Produtos
                                               select produtos).ToList();
                }
                else {
                    gridProdutos.DataSource = (from produtos in Loja.tbl_Produtos
                                               where produtos.QtdProduto > 0
                                               select produtos).ToList();
                }

                lblQtdProduto.Caption = "Qtd. Produtos: " + Loja.tbl_Produtos.Count().ToString();

                var qtditens = Loja.tbl_Produtos.AsEnumerable().Sum(o => o.QtdProduto);
                lblQtdItens.Caption = "Qtd. Itens: " + qtditens;

                wait.Close();
            }
            catch (Exception ex) { 
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
                LojaEntities orcamentos = new LojaEntities();
                var orca = from orcam in orcamentos.tbl_Orcamento
                           where orcam.CodOrca == CodOrca
                           select orcam;

                gridOrcamento.DataSource = orca.ToList();

                txtQtdItem.EditValue = orca.Count();

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
                
                LojaEntities orcamentos = new LojaEntities();

                var orca = from orcam in orcamentos.tbl_Orcamento
                           where orcam.FlgStatus == "O"
                           group orcam by orcam.CodOrca into grupo
                           select new
                           {
                               CodOrca = grupo.Key,
                               QtdItem = grupo.Count()
                           };

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
            if (cmbCodOrca.EditValue.ToString() != "")
            {
                frmVenda f = new frmVenda();
                f.CodOrcamento = cmbCodOrca.EditValue.ToString();
                f.ShowDialog();

                if (f.DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    InitGrid();
                    InitComboOrca();
                    cmbCodOrca.EditValue = "";
                    InitGridOrca();
                }
            }

        }

        String SU_AddOrca(String CodOrca)
        {
            try
            {
                int codproduto = FU_PegaCodigoGrid("P");

                LojaEntities orcamento = new LojaEntities();

                ObjectResult<string> codOrca = orcamento.FU_AddItemOrcamento(CodOrca, codproduto);

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
            LojaEntities loja = new LojaEntities();
            loja.FU_ApagarOrcamento(cmbCodOrca.EditValue.ToString());
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
            frmVenda f = new frmVenda();
            f.CodOrcamento = cmbCodOrca.EditValue.ToString();
            f.ShowDialog();

            if (f.DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                InitGrid();
                InitComboOrca();
                cmbCodOrca.EditValue = "";
                InitGridOrca();
            }
            else {
                LojaEntities loja = new LojaEntities();
                loja.FU_ApagarOrcamento(orca);
                InitGridOrca();
                InitComboOrca();
                btnImprimir.Enabled = false;
                btnFinalizarVenda.Enabled = false;
                btnExcluirOrca.Enabled = false;
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
            else if (e.KeyCode == Keys.Return) {
                int codproduto = FU_PegaCodigoGrid("P");;

                frmDetalhe f = new frmDetalhe();
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
            using (LojaEntities orcamento = new LojaEntities())
            {
                if (e.Column == colQuantidade)
                {
                    double quantidade;

                    if (e.Value != null)
                        quantidade = (double)e.Value;
                    else
                        quantidade = 0;


                    orcamento.FU_AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), quantidade, -1);
                }
                else
                    if (e.Column == colValor)
                    {
                        orcamento.FU_AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), -1, (double)e.Value);
                    }
            }
            InitGridOrca();
        }

        private void gridOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape) ) { return; }

            int linha = gridViewOrcamento.GetSelectedRows()[0];
            double valor = (double)gridViewOrcamento.GetRowCellValue(linha, colVlrOriginal);
            LojaEntities Loja = new LojaEntities();

            if (e.KeyCode.Equals(Keys.Delete))
            {
                using (LojaEntities orcamento = new LojaEntities())
                {
                    orcamento.FU_AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), 0, -1);
                }
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F1))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.92));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 92);
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F2))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.90));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 90);
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F3))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.88));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 88);
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F4))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.85));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 85);
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F5))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 95);
                InitGridOrca();
            }
            else if (e.KeyCode.Equals(Keys.F6))
            {
                //gridViewOrcamento.SetRowCellValue(linha, colValor, (valor * 0.95));
                Loja.FU_DescontoVenda(cmbCodOrca.EditValue.ToString(), 100);
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
        }

        private void btnFazerBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
             if (MessageBox.Show("Confirma copiar os dados a partir do DOS?", "Confirmar importação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Util.CopiarDoDbf();
            InitGrid();
        }

    }  
    #endregion

}