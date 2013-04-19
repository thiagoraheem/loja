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

        #region Form

        public frmPrincipal()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();
            InitComboOrca();

        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
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
                gridProdutos.DataSource = Loja.tbl_Produtos;

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

            if (cmbCodOrca.EditValue.ToString().Equals(String.Empty)) {
                btnImprimir.Enabled = false;
                btnFinalizarVenda.Enabled = false;
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

        String FU_PegaCodigoGrid(String origem)
        {
            String codigo = "";

            if (origem == "P")
            {
                int linha = gridViewProduto.GetSelectedRows()[0];
                codigo = gridViewProduto.GetRowCellValue(linha, colCodProduto).ToString();
            }
            else if (origem == "O")
            {
                int linha = gridViewOrcamento.GetSelectedRows()[0];
                codigo = gridViewOrcamento.GetRowCellValue(linha, colOrCodProduto).ToString();
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
        #endregion

        #region Eventos Grids
        private void gridProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                string codproduto = FU_PegaCodigoGrid("P");

                LojaEntities orcamento = new LojaEntities();
                ObjectResult<string> codOrca = orcamento.FU_AddItemOrcamento(cmbCodOrca.EditValue.ToString(), codproduto);

                cmbCodOrca.EditValue = codOrca.FirstOrDefault();

                InitGridOrca();
            }
            else if (e.KeyCode == Keys.Return) {
                string codproduto = FU_PegaCodigoGrid("P");;
                string deslocal = FU_PegaLocalGrid();

                frmDetalhe f = new frmDetalhe();
                f.SU_CarregaProduto(codproduto, deslocal);
                f.ShowDialog();
            }
        }

        private void gridViewOrcamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            LojaEntities orcamento = new LojaEntities();

            if (e.Column == colQuantidade) {
                double quantidade = 0;
                if (!e.Value.Equals(String.Empty))
                {
                    quantidade = (double)e.Value;
                }
                orcamento.FU_AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), quantidade, -1);
            }
            else if (e.Column == colValor) {
                orcamento.FU_AlterarOrcamento(cmbCodOrca.EditValue.ToString(), FU_PegaCodigoGrid("O"), -1, (double)e.Value);
            }
            InitGridOrca();
        }

        private void gridProdutos_DoubleClick(object sender, EventArgs e)
        {
            string codproduto = FU_PegaCodigoGrid("P"); ;
            string deslocal = FU_PegaLocalGrid();

            frmProduto f = new frmProduto();
            f.SU_CarregaProduto(codproduto, deslocal);
            f.ShowDialog();

            InitGrid();
        }

        #endregion

        #region Botões NavBar
        private void btnVender_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SU_FinalizarVenda();
        }

        private void btnCadastrar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmProduto f = new frmProduto();
            f.SU_NovoProduto();
            f.ShowDialog();

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
        }
        #endregion

    }
}