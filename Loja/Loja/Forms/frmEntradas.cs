using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Data.Objects;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;


namespace Loja
{
    public partial class frmEntradas : DevExpress.XtraEditors.XtraForm
    {
        #region Variáveis
        LojaEntities Loja = new LojaEntities();

        #endregion

        #region Form Events

        public frmEntradas()
        {
            InitializeComponent();
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            txtDatFim.DateTime = DateTime.Now;
            txtDatInicio.DateTime = DateTime.Now;

            SU_CarregaProdutos();

        }

        #endregion

        #region Botões
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*using (Reports.relVendas relatorio = new Reports.relVendas())
            {

                ReportPrintTool printTool = new ReportPrintTool(relatorio);

                int codproduto = cmbProduto.EditValue == null ? 0 : (int)cmbProduto.EditValue;

                relatorio.SU_SetParam(txtDatInicio.DateTime, txtDatFim.DateTime, codproduto, codtipovenda);

                printTool.ShowRibbonPreviewDialog();
                printTool.ShowRibbonPreview(UserLookAndFeel.Default);
            }*/
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SU_CarregaEntrada();
        }


        #endregion

        #region Funções
        void SU_CarregaProdutos()
        {
            var produtos = from prod in Loja.tbl_Produtos
                           where prod.QtdProduto > 0
                           select prod;
            cmbProduto.Properties.DataSource = produtos;

        }

        void SU_CarregaEntrada() {

            DateTime inicio = txtDatInicio.DateTime.AddDays(-1);
            DateTime fim = txtDatFim.DateTime;

            var entradas = from entrada in Loja.tbl_Entrada
                           join produto in Loja.tbl_Produtos on entrada.codigounico equals produto.codigounico
                           where entrada.DatEntrada >= inicio && entrada.DatEntrada <= fim
                           select new { entrada.DatEntrada, entrada.DocEntrada, entrada.Percentual, 
                               entrada.QtdProduto, entrada.VlrTotal, entrada.VlrUnitario, produto.CodProduto, produto.DesProduto };
            grdDados.DataSource = entradas;

        }

        int FU_PegaCodigoGrid()
        {
            int codigo = -1;

            int linha = gridDados.GetSelectedRows()[0];
            codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

            return codigo;
        }

#endregion

    }
}