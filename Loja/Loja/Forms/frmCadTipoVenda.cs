﻿using System;
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
    public partial class frmCadTipoVenda : DevExpress.XtraEditors.XtraForm
    {
        #region Variáveis
        LojaEntities Loja = new LojaEntities();
        tbl_TipoVenda TipoVenda;

        #endregion

        #region Eventos Form
        public frmCadTipoVenda()
        {
            InitializeComponent();
        }

        private void frmCadTipoVenda_Load(object sender, EventArgs e)
        {
            SU_CarregaGrid();
        }

        #endregion

        #region Funções
        void SU_CarregaGrid() {
            LojaEntities Loja = new LojaEntities();
            var tipovenda = from tipo in Loja.tbl_TipoVenda
                            select tipo;

            grdDados.DataSource = tipovenda.ToList();
        }

        int FU_PegaCodigoGrid()
        {
            int codigo = -1;

            int linha = gridDados.GetSelectedRows()[0];
            codigo = (int)gridDados.GetRowCellValue(linha, colCodigo);


            return codigo;
        }

        void SU_LimpaCampos() {
            txtDescricao.Text = String.Empty;
            txtQtdDias.Text = String.Empty;
            chkAtivo.Checked = false;
            chkAvista.Checked = false;
            this.TipoVenda = null;
            btnExcluir.Enabled = false;
        }
        #endregion

        #region Botões
        private void btnNovo_Click(object sender, EventArgs e)
        {
            SU_LimpaCampos();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma excluir esse registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Loja.DeleteObject(TipoVenda);
            Loja.SaveChanges();

            SU_CarregaGrid();
            SU_LimpaCampos();
            MessageBox.Show("Registro excluído com sucesso.");
        }
        
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (TipoVenda == null)
            {
                TipoVenda = new tbl_TipoVenda() { DesTipoVenda = txtDescricao.Text, QtdDias = txtQtdDias.Value, flgAVista = chkAvista.Checked, flgAtivo = chkAtivo.Checked };
                Loja.tbl_TipoVenda.AddObject(TipoVenda);
            }
            else
            {
                TipoVenda.DesTipoVenda = txtDescricao.Text;
                TipoVenda.QtdDias = txtQtdDias.Value;
                TipoVenda.flgAVista = chkAvista.Checked;
                TipoVenda.flgAtivo = chkAtivo.Checked;
            }

            Loja.SaveChanges();
            SU_CarregaGrid();
            SU_LimpaCampos();
        }
        #endregion

        #region Eventos Grid
        private void gridDados_DoubleClick(object sender, EventArgs e)
        {
            int codigo = FU_PegaCodigoGrid();
            this.TipoVenda = (from tipo in Loja.tbl_TipoVenda
                             where tipo.CodTipoVenda == codigo
                             select tipo).First();

            txtDescricao.Text = TipoVenda.DesTipoVenda;
            txtQtdDias.Text = TipoVenda.QtdDias.ToString();
            chkAtivo.Checked = TipoVenda.flgAtivo.Value;
            chkAvista.Checked = TipoVenda.flgAVista.Value;

            btnExcluir.Enabled = true;
        }

        #endregion

    }
}