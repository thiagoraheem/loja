using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Loja.Modules
{
    public static class NfceNotificador
    {
        private static readonly object Sync = new object();
        private static readonly string BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string LogDir = Path.Combine(BasePath, "Logs", "Nfce");
        private static readonly string EstadoPath = Path.Combine(LogDir, "notificador-state.txt");
        private static readonly string PendentesPath = Path.Combine(LogDir, "notificador-pendentes.txt");

        private static Dictionary<string, int> _contadoresDia;
        private static Dictionary<string, DateTime> _primeiroAviso;

        public const string ChaveAuditoriaProcXml = "auditoria.procxml";
        public const string ChaveContingencia = "contingencia.reprocessamento";

        static NfceNotificador()
        {
            CarregarEstado();
        }

        public static bool DeveMostrarMessageBox(string chave)
        {
            lock (Sync)
            {
                if (!_primeiroAviso.ContainsKey(chave))
                    return true;

                var hoje = DateTime.Today;
                return _primeiroAviso[chave].Date != hoje;
            }
        }

        public static int ObterPendentes(string chave = null)
        {
            lock (Sync)
            {
                return string.IsNullOrWhiteSpace(chave)
                    ? _contadoresDia.Values.Sum()
                    : _contadoresDia.TryGetValue(chave, out var c) ? c : 0;
            }
        }

        public static int ObterPendentesTotal()
        {
            return ObterPendentes(null);
        }

        public static string ResumoPendentes()
        {
            lock (Sync)
            {
                var sb = new StringBuilder();
                var total = 0;
                foreach (var kv in _contadoresDia)
                {
                    if (kv.Value <= 0) continue;
                    total += kv.Value;
                    sb.AppendLine($"- {RotuloChave(kv.Key)}: {kv.Value} ocorrência(s)");
                }

                if (total == 0)
                    return "Nenhum alerta pendente de auditoria NFC-e.";

                var header = $"Há {total} alerta(s) silenciado(s) de auditoria NFC-e hoje:";
                return header + Environment.NewLine + sb.ToString().Trim();
            }
        }

        public static void RegistrarOcorrencia(string chave, string detalhe)
        {
            lock (Sync)
            {
                var agora = DateTime.Now;
                var hoje = DateTime.Today;

                if (_primeiroAviso.TryGetValue(chave, out var ultimoPrim) && ultimoPrim.Date != hoje)
                {
                    _primeiroAviso.Remove(chave);
                    if (_contadoresDia.ContainsKey(chave))
                        _contadoresDia[chave] = 0;
                }

                if (_contadoresDia.ContainsKey(chave))
                    _contadoresDia[chave]++;
                else
                    _contadoresDia[chave] = 1;

                SalvarPendente(chave, detalhe, agora);
                SalvarEstado();
            }
        }

        public static void ConfirmarAvisoExibido(string chave)
        {
            lock (Sync)
            {
                _primeiroAviso[chave] = DateTime.Now;
                SalvarEstado();
            }
        }

        public static void Resetar(string chave = null)
        {
            lock (Sync)
            {
                if (string.IsNullOrWhiteSpace(chave))
                {
                    _contadoresDia.Clear();
                    _primeiroAviso.Clear();
                    try { File.Delete(PendentesPath); } catch { }
                }
                else
                {
                    if (_contadoresDia.ContainsKey(chave))
                        _contadoresDia[chave] = 0;
                    _primeiroAviso.Remove(chave);
                }

                SalvarEstado();
            }
        }

        private static void CarregarEstado()
        {
            _contadoresDia = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            _primeiroAviso = new Dictionary<string, DateTime>(StringComparer.OrdinalIgnoreCase);

            try
            {
                Directory.CreateDirectory(LogDir);
                if (!File.Exists(EstadoPath))
                    return;

                var hoje = DateTime.Today.ToString("yyyyMMdd");
                foreach (var linha in File.ReadAllLines(EstadoPath))
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;
                    var parts = linha.Split('|');
                    if (parts.Length < 3) continue;

                    var chave = parts[0];
                    var data = parts[1];
                    if (data != hoje) continue;

                    if (int.TryParse(parts[2], out var cnt))
                        _contadoresDia[chave] = cnt;

                    if (parts.Length >= 4 && long.TryParse(parts[3], out var ticks))
                        _primeiroAviso[chave] = new DateTime(ticks, DateTimeKind.Local);
                }
            }
            catch
            {
                // não quebrar por estado corrompido
            }
        }

        private static void SalvarEstado()
        {
            try
            {
                Directory.CreateDirectory(LogDir);
                var hoje = DateTime.Today.ToString("yyyyMMdd");
                var linhas = new List<string>();

                foreach (var kv in _contadoresDia)
                {
                    var ticks = _primeiroAviso.TryGetValue(kv.Key, out var dt) ? dt.Ticks.ToString() : "0";
                    linhas.Add($"{kv.Key}|{hoje}|{kv.Value}|{ticks}");
                }

                var tmp = EstadoPath + ".tmp";
                File.WriteAllLines(tmp, linhas);
                if (File.Exists(EstadoPath))
                    File.Replace(tmp, EstadoPath, null);
                else
                    File.Move(tmp, EstadoPath);
            }
            catch
            {
                // nunca quebrar por log
            }
        }

        private static void SalvarPendente(string chave, string detalhe, DateTime agora)
        {
            try
            {
                Directory.CreateDirectory(LogDir);
                var linha = $"{agora:yyyy-MM-dd HH:mm:ss}|{chave}|{Escape(detalhe)}";
                File.AppendAllText(PendentesPath, linha + Environment.NewLine);
            }
            catch
            {
                // não quebrar
            }
        }

        public static List<(DateTime Hora, string Chave, string Detalhe)> LerPendentes()
        {
            var lista = new List<(DateTime Hora, string Chave, string Detalhe)>();
            lock (Sync)
            {
                try
                {
                    if (!File.Exists(PendentesPath))
                        return lista;

                    foreach (var linha in File.ReadAllLines(PendentesPath))
                    {
                        if (string.IsNullOrWhiteSpace(linha)) continue;
                        var parts = linha.Split(new[] { '|' }, 3);
                        if (parts.Length < 3) continue;

                        if (DateTime.TryParse(parts[0], out var dt))
                            lista.Add((dt, parts[1], Unescape(parts[2])));
                    }
                }
                catch
                {
                    // retorna lista vazia
                }
            }

            return lista.OrderByDescending(x => x.Hora).ToList();
        }

        public static void LimparPendentes()
        {
            lock (Sync)
            {
                try { File.Delete(PendentesPath); } catch { }
                Resetar();
            }
        }

        private static string Escape(string v)
        {
            if (string.IsNullOrEmpty(v)) return string.Empty;
            return v.Replace("\\", "\\\\").Replace("|", "\\p");
        }

        private static string Unescape(string v)
        {
            if (string.IsNullOrEmpty(v)) return string.Empty;
            return v.Replace("\\p", "|").Replace("\\\\", "\\");
        }

        private static string RotuloChave(string chave)
        {
            switch (chave?.ToLowerInvariant())
            {
                case "auditoria.procxml": return "Auditoria PROC XML (NFC-e)";
                case "contingencia.reprocessamento": return "Reprocessamento contingência";
                default: return chave ?? "Geral";
            }
        }
    }
}
