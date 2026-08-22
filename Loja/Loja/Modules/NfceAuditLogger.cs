using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Loja.Modules
{
    public class NfceAuditLogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string Event { get; set; }
        public string SaleId { get; set; }
        public string Status { get; set; }
        public string Detail { get; set; }
        public string Exception { get; set; }
    }

	public static class NfceAuditLogger
	{
		private static readonly object Sync = new object();
		private static readonly string BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? AppDomain.CurrentDomain.BaseDirectory;
		internal static readonly string LogDir = Path.Combine(BasePath, "Logs", "Nfce");

		public static void Info(string evento, string codVenda, string status, string detalhe)
		{
			Write("INFO", evento, codVenda, status, detalhe, null);
		}

		public static void Error(string evento, string codVenda, string status, Exception ex, string detalhe = null)
		{
			Write("ERROR", evento, codVenda, status, detalhe, ex);
		}

        public static List<NfceAuditLogEntry> LerLogs(int dias = 7)
        {
            var result = new List<NfceAuditLogEntry>();
            try
            {
                lock (Sync)
                {
                    if (!Directory.Exists(LogDir))
                        return result;

                    var corte = DateTime.UtcNow.Date.AddDays(-dias + 1);
                    var arquivos = Directory.GetFiles(LogDir, "nfce-audit-*.log")
                        .Where(f =>
                        {
                            try
                            {
                                return File.GetLastWriteTimeUtc(f).Date >= corte;
                            }
                            catch { return false; }
                        })
                        .OrderByDescending(f => f)
                        .ToList();

                    foreach (var arq in arquivos)
                    {
                        foreach (var linha in LerLinhasSeguro(arq))
                        {
                            var entry = ParseLinhaJson(linha);
                            if (entry != null)
                                result.Add(entry);
                        }
                    }

                    return result.OrderByDescending(e => e.Timestamp).ToList();
                }
            }
            catch
            {
                return result;
            }
        }

        public static int LimparLogs(int manterDias = 7)
        {
            lock (Sync)
            {
                try
                {
                    if (!Directory.Exists(LogDir))
                        return 0;

                    var removidos = 0;
                    var corte = DateTime.UtcNow.Date.AddDays(-manterDias);

                    foreach (var arq in Directory.GetFiles(LogDir, "nfce-audit-*.log"))
                    {
                        try
                        {
                            if (File.GetLastWriteTimeUtc(arq).Date <= corte)
                            {
                                File.Delete(arq);
                                removidos++;
                            }
                        }
                        catch { }
                    }

                    return removidos;
                }
                catch
                {
                    return 0;
                }
            }
        }

        private static IEnumerable<string> LerLinhasSeguro(string caminho)
        {
            try
            {
                var linhas = new List<string>();
                using (var fs = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                        if (!string.IsNullOrWhiteSpace(linha))
                            linhas.Add(linha);
                }
                return linhas;
            }
            catch
            {
                return Enumerable.Empty<string>();
            }
        }

        private static NfceAuditLogEntry ParseLinhaJson(string linha)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(linha)) return null;
                var campos = ExtrairCamposPlanos(linha);
                var entry = new NfceAuditLogEntry
                {
                    Level = TryGet(campos, "level"),
                    Event = TryGet(campos, "event"),
                    SaleId = TryGet(campos, "saleId"),
                    Status = TryGet(campos, "status"),
                    Detail = TryGet(campos, "detail"),
                    Exception = TryGet(campos, "exception")
                };

                var ts = TryGet(campos, "timestamp");
                DateTime dt;
                if (!string.IsNullOrWhiteSpace(ts) && DateTime.TryParse(ts, out dt))
                    entry.Timestamp = dt.ToLocalTime();
                else
                    entry.Timestamp = DateTime.MinValue;

                return entry;
            }
            catch
            {
                return null;
            }
        }

        private static string TryGet(Dictionary<string, string> d, string k)
        {
            return d != null && d.TryGetValue(k, out var v) ? v ?? string.Empty : string.Empty;
        }

        private static Dictionary<string, string> ExtrairCamposPlanos(string json)
        {
            var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (string.IsNullOrWhiteSpace(json)) return dic;

            var i = 0;
            while (i < json.Length && char.IsWhiteSpace(json[i])) i++;
            if (i >= json.Length || json[i] != '{') return dic;
            i++;

            while (i < json.Length)
            {
                while (i < json.Length && (char.IsWhiteSpace(json[i]) || json[i] == ',')) i++;
                if (i >= json.Length || json[i] == '}') break;

                if (json[i] != '"') return dic;
                i++;
                var chave = ReadString(json, ref i);
                if (chave == null) return dic;

                while (i < json.Length && char.IsWhiteSpace(json[i])) i++;
                if (i >= json.Length || json[i] != ':') return dic;
                i++;
                while (i < json.Length && char.IsWhiteSpace(json[i])) i++;

                var valor = string.Empty;
                if (i < json.Length && json[i] == '"')
                {
                    i++;
                    valor = ReadString(json, ref i) ?? string.Empty;
                }
                else
                {
                    var sb = new StringBuilder();
                    while (i < json.Length && json[i] != ',' && json[i] != '}')
                    {
                        sb.Append(json[i]);
                        i++;
                    }
                    valor = sb.ToString().Trim();
                }

                dic[chave] = valor;
            }

            return dic;
        }

        private static string ReadString(string s, ref int i)
        {
            var sb = new StringBuilder();
            while (i < s.Length)
            {
                var c = s[i];
                if (c == '\\' && i + 1 < s.Length)
                {
                    var prox = s[i + 1];
                    switch (prox)
                    {
                        case '"': sb.Append('"'); break;
                        case '\\': sb.Append('\\'); break;
                        case '/': sb.Append('/'); break;
                        case 'n': sb.Append('\n'); break;
                        case 'r': sb.Append('\r'); break;
                        case 't': sb.Append('\t'); break;
                        default: sb.Append(prox); break;
                    }
                    i += 2;
                    continue;
                }
                if (c == '"')
                {
                    i++;
                    return sb.ToString();
                }
                sb.Append(c);
                i++;
            }
            return null;
        }

		private static void Write(string nivel, string evento, string codVenda, string status, string detalhe, Exception ex)
		{
			try
			{
				lock (Sync)
				{
					Directory.CreateDirectory(LogDir);
					var arquivo = Path.Combine(LogDir, $"nfce-audit-{DateTime.UtcNow:yyyyMMdd}.log");
					var linha = "{" +
						$"\"timestamp\":\"{DateTime.UtcNow:O}\"," +
						$"\"level\":\"{Escape(nivel)}\"," +
						$"\"event\":\"{Escape(evento)}\"," +
						$"\"saleId\":\"{Escape(codVenda)}\"," +
						$"\"status\":\"{Escape(status)}\"," +
						$"\"detail\":\"{Escape(detalhe)}\"," +
						$"\"exception\":\"{Escape(ex?.ToString())}\"" +
						"}";

					File.AppendAllText(arquivo, linha + Environment.NewLine);
				}
			}
			catch
			{
				// nunca interromper fluxo fiscal por falha de log
			}
		}

		private static string Escape(string value)
		{
			if (string.IsNullOrEmpty(value)) return string.Empty;
			return value.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", " ").Replace("\n", " ");
		}
	}
}
