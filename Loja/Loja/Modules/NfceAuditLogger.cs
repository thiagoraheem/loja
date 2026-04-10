using System;
using System.IO;
using System.Reflection;

namespace Loja.Modules
{
	public static class NfceAuditLogger
	{
		private static readonly object Sync = new object();
		private static readonly string BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? AppDomain.CurrentDomain.BaseDirectory;
		private static readonly string LogDir = Path.Combine(BasePath, "Logs", "Nfce");

		public static void Info(string evento, string codVenda, string status, string detalhe)
		{
			Write("INFO", evento, codVenda, status, detalhe, null);
		}

		public static void Error(string evento, string codVenda, string status, Exception ex, string detalhe = null)
		{
			Write("ERROR", evento, codVenda, status, detalhe, ex);
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
