using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Loja.Modules
{
	public static class NfceRetryQueue
	{
		private static readonly object Sync = new object();
		private static readonly string BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? AppDomain.CurrentDomain.BaseDirectory;
		private static readonly string QueueDir = Path.Combine(BasePath, "Logs", "Nfce");
		private static readonly string QueueFile = Path.Combine(QueueDir, "retry-queue.txt");

		public static void Enqueue(string codVenda)
		{
			if (string.IsNullOrWhiteSpace(codVenda)) return;
			lock (Sync)
			{
				Directory.CreateDirectory(QueueDir);
				var itens = LoadInternal();
				if (!itens.Contains(codVenda))
				{
					itens.Add(codVenda);
					SaveInternal(itens);
				}
			}
		}

		public static void Dequeue(string codVenda)
		{
			if (string.IsNullOrWhiteSpace(codVenda)) return;
			lock (Sync)
			{
				var itens = LoadInternal();
				if (itens.RemoveAll(x => x == codVenda) > 0)
				{
					SaveInternal(itens);
				}
			}
		}

		public static List<string> Load()
		{
			lock (Sync)
			{
				return LoadInternal();
			}
		}

		private static List<string> LoadInternal()
		{
			if (!File.Exists(QueueFile)) return new List<string>();
			return File.ReadAllLines(QueueFile)
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Select(x => x.Trim())
				.Distinct(StringComparer.OrdinalIgnoreCase)
				.ToList();
		}

		private static void SaveInternal(List<string> itens)
		{
			Directory.CreateDirectory(QueueDir);
			File.WriteAllLines(QueueFile, itens.Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(x => x).ToList());
		}
	}
}
