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

namespace Loja
{
    public partial class frmVendas : DevExpress.XtraEditors.XtraForm
    {

        #region Variáveis
        LojaEntities Loja = new LojaEntities();

        #endregion

        #region Form Events

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            txtDatFim.DateTime = DateTime.Now;
            txtDatInicio.DateTime = DateTime.Now;

            SU_CarregaProdutos();
            SU_CarregaTipoVenda();

        }

        #endregion

        #region Botões
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SU_CarregaVendas();
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

        void SU_CarregaTipoVenda()
        {
            var TipoVenda = from tipovenda in Loja.tbl_TipoVenda
                            where tipovenda.flgAtivo == true
                            select new { Codigo = tipovenda.CodTipoVenda, Descricao = tipovenda.DesTipoVenda };
            cmbTipoVenda.Properties.DataSource = TipoVenda.ToList();
        }

        void SU_CarregaVendas() {

            DateTime inicio = txtDatInicio.DateTime.AddDays(-1);
            DateTime fim = txtDatFim.DateTime;

            var saidas = from saida in Loja.tbl_Saidas
                         where saida.DatSaida >= inicio && saida.DatSaida <= fim
                         select saida;
            grdDados.DataSource = saidas;

        }

#endregion


    }
}