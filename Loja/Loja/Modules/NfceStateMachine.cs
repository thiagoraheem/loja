using System;
using System.Collections.Generic;

namespace Loja.Modules
{
	public static class NfceStateMachine
	{
		private static readonly Dictionary<string, HashSet<string>> AllowedTransitions = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase)
		{
			{ "", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "P", "C", "A", "R", "I", "X", "E" } },
			{ "P", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "P", "C", "A", "R", "I", "X", "E" } },
			{ "C", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "C", "P", "A", "R", "X", "E" } },
			{ "R", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "R", "P", "A", "C", "E" } },
			{ "E", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "E", "P", "R", "C", "A", "X" } },
			{ "A", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "A", "X" } },
			{ "X", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "X" } },
			{ "I", new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "I" } }
		};

		public static bool CanTransition(string from, string to)
		{
			var estadoOrigem = (from ?? string.Empty).Trim();
			var estadoDestino = (to ?? string.Empty).Trim();

			if (string.IsNullOrEmpty(estadoDestino))
			{
				return false;
			}

			if (!AllowedTransitions.TryGetValue(estadoOrigem, out var destinosPermitidos))
			{
				return false;
			}

			return destinosPermitidos.Contains(estadoDestino);
		}

		public static void EnsureTransition(string from, string to, string codVenda)
		{
			if (!CanTransition(from, to))
			{
				throw new InvalidOperationException($"Transição de estado NFC-e inválida para venda {codVenda}: '{from}' -> '{to}'.");
			}
		}
	}
}
