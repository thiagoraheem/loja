using NFe.Servicos;
using System;
using System.Windows.Forms;

namespace Loja.Forms
{
	public partial class frmAuditorNF : DevExpress.XtraEditors.XtraForm
    {
		private ConfiguracaoApp _configuracoes;

		public frmAuditorNF(ConfiguracaoApp config)
        {
            InitializeComponent();

			_configuracoes = config;
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

				#region Inutiliza Numeração

				var ano = DateTime.Now.Year.ToString().Substring(2);

				var modelostr = "65"; 
                var modelo = (DFe.Classes.Flags.ModeloDocumento)Convert.ToInt16(modelostr);

				var serie = "1";
				var numeroInicial = codvenda;
				var numeroFinal = codvenda;

				var justificativa = "Erro na emissao da nota";


				var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
                var retornoConsulta = servicoNFe.NfeInutilizacao(_configuracoes.Emitente.CNPJ, Convert.ToInt16(ano),
                    modelo, Convert.ToInt16(serie), Convert.ToInt32(numeroInicial),
                    Convert.ToInt32(numeroFinal), justificativa);

                if (retornoConsulta.Retorno.infInut.cStat == 102){
					Util.MsgBox("Número inutilizado com sucesso");
				}
				else{
					Util.MsgBox($"Erro ao inutilizar: {retornoConsulta.Retorno.infInut.cStat} - {retornoConsulta.Retorno.infInut.xMotivo}");
				}

                #endregion

                Consultar();
            }
            catch (Exception ex)
            {
                Util.MsgBox(ex.Message);
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
 