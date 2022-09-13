using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Loja.Forms
{
    public partial class frmAuditorNF : DevExpress.XtraEditors.XtraForm
    {
        public frmAuditorNF()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnInutilizar_Click(object sender, EventArgs e)
        {

            string codvenda = FU_PegaCodigoVenda();

            if (MessageBox.Show("Confirma inutilizar esse número de NFE (" + codvenda + ")?", "Confirmar inutilização", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {

                Loja.DAL.DAO.Cadastros.InutilizarVenda(codvenda);

                var retorno = NFe.Wsdl.Monitor.InutilizarNFE(Util.SemFormatacao(Properties.Settings.Default.CNPJ), "Erro na emissao da nota", DateTime.Now.Year.ToString(), "65", "1", codvenda, codvenda);

                if (retorno.Status == true)
                {

                    Util.MsgBox("Número inutilizado com sucesso");
                }
                else
                {
                    Util.MsgBox(retorno.Resultado);
                }

                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        void Consultar()
        {
            var dados = Loja.DAL.DAO.Consultas.ObterNotasFaltantes();

            grdNotas.DataSource = dados;
            grdNotas.Refresh();

        }

        string FU_PegaCodigoVenda()
        {
            var codigo = "";

            int linha = gridViewNotas.GetSelectedRows()[0];
            codigo = gridViewNotas.GetRowCellValue(linha, colCodVenda).ToString();

            return codigo;
        }
    }
}