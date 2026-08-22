using System;
using System.Linq;
using System.Windows.Forms;
using Loja.Modules;

namespace Loja.Forms
{
    public partial class frmHistoricoNfceAuditoria : DevExpress.XtraEditors.XtraForm
    {
        public frmHistoricoNfceAuditoria()
        {
            InitializeComponent();
        }

        private void frmHistoricoNfceAuditoria_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnLimparLogs_Click(object sender, EventArgs e)
        {
            var dias = (int)numDias.Value;
            if (MessageBox.Show(
                $"Confirma apagar os arquivos de log de auditoria NFC-e com mais de {dias} dias?{Environment.NewLine}{Environment.NewLine}(Os alertas de hoje NÃO serão apagados. Apenas os arquivos de log antigos serão removidos.)",
                "Confirmar limpeza de logs",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                var removidos = NfceAuditLogger.LimparLogs(dias);
                CarregarDados();
                Util.MsgBox($"Foram apagado(s) {removidos} arquivo(s) de log antigo(s).");
            }
            catch (Exception ex)
            {
                Util.MsgBox($"Erro ao limpar logs: {ex.Message}");
            }
        }

        private void btnLimparAlertas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                $"Confirma zerar os alertas silenciados de hoje?{Environment.NewLine}{Environment.NewLine}Isso permitirá que a próxima ocorrência volte a ser exibida por MsgBox (até o limite diário).",
                "Confirmar reset de alertas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                NfceNotificador.LimparPendentes();
                CarregarDados();
                Util.MsgBox("Alertas silenciados do dia foram zerados.");
            }
            catch (Exception ex)
            {
                Util.MsgBox($"Erro ao resetar alertas: {ex.Message}");
            }
        }

        private void gridViewLogs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var entry = gridViewLogs.GetRow(e.RowHandle) as NfceAuditLogEntry;
                if (entry == null)
                {
                    txtDetalhe.Clear();
                    return;
                }

                txtDetalhe.Clear();
                txtDetalhe.AppendText("Horário: " + entry.Timestamp.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine);
                txtDetalhe.AppendText("Nível: " + entry.Level + Environment.NewLine);
                txtDetalhe.AppendText("Evento: " + entry.Event + Environment.NewLine);
                txtDetalhe.AppendText("Venda (saleId): " + entry.SaleId + Environment.NewLine);
                txtDetalhe.AppendText("Status NF: " + entry.Status + Environment.NewLine);
                txtDetalhe.AppendText(Environment.NewLine + "-- Detalhe --" + Environment.NewLine);
                txtDetalhe.AppendText(string.IsNullOrWhiteSpace(entry.Detail) ? "(sem detalhe)" : entry.Detail);
                if (!string.IsNullOrWhiteSpace(entry.Exception))
                {
                    txtDetalhe.AppendText(Environment.NewLine + Environment.NewLine + "-- Exceção --" + Environment.NewLine);
                    txtDetalhe.AppendText(entry.Exception);
                }
                txtDetalhe.SelectionStart = 0;
                txtDetalhe.SelectionLength = 0;
            }
            catch
            {
                // ignore
            }
        }

        private void CarregarDados()
        {
            try
            {
                var dias = (int)numDias.Value;
                var logs = NfceAuditLogger.LerLogs(dias);
                grdLogs.DataSource = logs.OrderByDescending(x => x.Timestamp).ToList();
                grdLogs.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Util.MsgBox($"Erro ao carregar logs: {ex.Message}");
            }

            try
            {
                var total = NfceNotificador.ObterPendentesTotal();
                lblPendentes.Text = $"Alertas silenciados hoje: {total}";
                if (total == 0)
                {
                    lblPendentes.ForeColor = System.Drawing.Color.DarkGreen;
                    lblPendentes.Font = new System.Drawing.Font(lblPendentes.Font, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    lblPendentes.ForeColor = System.Drawing.Color.Maroon;
                    lblPendentes.Font = new System.Drawing.Font(lblPendentes.Font, System.Drawing.FontStyle.Bold);
                }
            }
            catch
            {
                // ignore label errors
            }
        }
    }
}
