using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Loja.Modules
{
    public static class NfceXmlLocator
    {
        public const string PastaArquivados = "_procNfe_processado";
        public const string SufixoProcNfe = "-procNfe.xml";
        public const string SufixoContingencia = "-cont.xml";
        public const string SufixoNfeBase = ".xml";

        public static string LocalizarProcNfe(string diretorioXml, string chaveSefaz)
        {
            var chave44 = ExtrairChave44(chaveSefaz);
            if (string.IsNullOrWhiteSpace(chave44))
                return null;

            var nomeAlvo = chave44 + SufixoProcNfe;
            var candidatos = new[]
            {
                CombineSafe(diretorioXml, nomeAlvo)
            };

            foreach (var c in candidatos)
                if (File.Exists(c))
                    return c;

            return BuscarEmPastasDeArquivo(diretorioXml, nomeAlvo);
        }

        public static string LocalizarProcNfeComReenvio(string diretorioXml, string chaveSefaz, string codVenda)
        {
            var primario = LocalizarProcNfe(diretorioXml, chaveSefaz);
            if (!string.IsNullOrWhiteSpace(primario))
                return primario;

            if (string.IsNullOrWhiteSpace(diretorioXml) || !Directory.Exists(diretorioXml))
                return null;

            var chave44 = ExtrairChave44(chaveSefaz);

            var padroes = new List<string>();
            if (!string.IsNullOrWhiteSpace(chave44))
            {
                padroes.Add($"*{chave44}*-procNfe.xml");
                padroes.Add($"{chave44}*.xml");
            }
            if (!string.IsNullOrWhiteSpace(codVenda))
            {
                padroes.Add($"*{codVenda}*-procNfe.xml");
            }

            foreach (var p in padroes.Distinct())
            {
                foreach (var subDir in ObterPastasBusca(diretorioXml))
                {
                    try
                    {
                        var encontrados = Directory.GetFiles(subDir, p, SearchOption.TopDirectoryOnly);
                        if (encontrados.Length > 0)
                        {
                            return encontrados
                                .OrderByDescending(f =>
                                {
                                    try { return File.GetLastWriteTimeUtc(f); }
                                    catch { return DateTime.MinValue; }
                                })
                                .First();
                        }
                    }
                    catch { }
                }
            }

            return null;
        }

        public static string LocalizarContingencia(string diretorioXml, string chaveSefaz)
        {
            var chave44 = ExtrairChave44(chaveSefaz);
            if (string.IsNullOrWhiteSpace(chave44))
                return null;

            var nomeAlvo = chave44 + SufixoContingencia;
            var caminho = CombineSafe(diretorioXml, nomeAlvo);
            if (File.Exists(caminho))
                return caminho;

            return BuscarEmPastasDeArquivo(diretorioXml, nomeAlvo);
        }

        public static string LocalizarNfeBase(string diretorioXml, string chaveSefaz)
        {
            var chave44 = ExtrairChave44(chaveSefaz);
            if (string.IsNullOrWhiteSpace(chave44))
                return null;

            var nomeAlvo = chave44 + SufixoNfeBase;
            var caminho = CombineSafe(diretorioXml, nomeAlvo);
            if (File.Exists(caminho))
                return caminho;

            return BuscarEmPastasDeArquivo(diretorioXml, nomeAlvo);
        }

        public static string ObterPastaArquivados(string diretorioXml, DateTime referencia)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml))
                return null;
            return CombineSafe(diretorioXml, PastaArquivados, $"{referencia:yyyyMMdd}");
        }

        public static string ArquivarProcNfe(string diretorioXml, string caminhoArquivo, string codVenda, DateTime? referencia = null)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml))
                return null;
            if (!File.Exists(caminhoArquivo))
                return null;

            var data = referencia ?? File.GetLastWriteTime(caminhoArquivo);
            var subdir = ObterPastaArquivados(diretorioXml, data);
            Directory.CreateDirectory(subdir);

            var nome = Path.GetFileName(caminhoArquivo);
            var destino = Path.Combine(subdir, nome);
            if (File.Exists(destino))
            {
                var baseNome = Path.GetFileNameWithoutExtension(nome);
                var ext = Path.GetExtension(nome);
                destino = Path.Combine(subdir, $"{baseNome}-{codVenda}-{Guid.NewGuid():N}{ext}");
            }

            try
            {
                File.Move(caminhoArquivo, destino);
                return destino;
            }
            catch
            {
                return null;
            }
        }

        public static bool ArquivoEProcNfe(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                return false;
            return caminho.EndsWith(SufixoProcNfe, StringComparison.OrdinalIgnoreCase);
        }

        private static string BuscarEmPastasDeArquivo(string diretorioXml, string nomeArquivo)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml) || !Directory.Exists(diretorioXml))
                return null;

            foreach (var subDir in ObterPastasBusca(diretorioXml))
            {
                try
                {
                    var caminho = CombineSafe(subDir, nomeArquivo);
                    if (File.Exists(caminho))
                        return caminho;
                }
                catch { }
            }

            var nomeBusca = "*" + nomeArquivo;
            foreach (var subDir in ObterPastasBusca(diretorioXml))
            {
                try
                {
                    var arquivos = Directory.GetFiles(subDir, nomeBusca, SearchOption.TopDirectoryOnly);
                    if (arquivos.Length > 0)
                        return arquivos[0];
                }
                catch { }
            }

            return null;
        }

        private static IEnumerable<string> ObterPastasBusca(string diretorioXml)
        {
            var raiz = diretorioXml;
            if (string.IsNullOrWhiteSpace(raiz))
                yield break;

            yield return raiz;

            var arquivados = CombineSafe(raiz, PastaArquivados);
            if (!Directory.Exists(arquivados))
                yield break;

            List<string> pastasDiarias = null;
            try
            {
                pastasDiarias = Directory.GetDirectories(arquivados, "*", SearchOption.TopDirectoryOnly)
                    .OrderByDescending(p =>
                    {
                        var nome = Path.GetFileName(p);
                        if (nome != null && nome.Length == 8 && nome.All(char.IsDigit))
                        {
                            if (int.TryParse(nome, out var num))
                                return num;
                        }
                        return 0;
                    })
                    .ToList();
            }
            catch
            {
                pastasDiarias = new List<string>();
            }

            foreach (var p in pastasDiarias)
                yield return p;
        }

        private static string ExtrairChave44(string chaveSefaz)
        {
            if (string.IsNullOrWhiteSpace(chaveSefaz))
                return null;

            var chave = chaveSefaz.Trim();
            if (chave.StartsWith("NFe", StringComparison.OrdinalIgnoreCase))
                chave = chave.Substring(3);

            chave = new string(chave.Where(char.IsDigit).ToArray());
            return chave.Length == 44 ? chave : null;
        }

        private static string CombineSafe(string p1, string p2)
        {
            try { return Path.Combine(p1 ?? string.Empty, p2 ?? string.Empty); }
            catch { return null; }
        }

        private static string CombineSafe(string p1, string p2, string p3)
        {
            try { return Path.Combine(p1 ?? string.Empty, p2 ?? string.Empty, p3 ?? string.Empty); }
            catch { return null; }
        }
    }
}
