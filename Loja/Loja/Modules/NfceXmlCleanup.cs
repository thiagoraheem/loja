using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Loja.Modules
{
    public static class NfceXmlCleanup
    {
        public const string PastaComunicacao = "_comunicacao_sefaz";
        public const int DiasManterComunicacao = 30;
        private static readonly TimeSpan MinIntervaloEntreExecucoes = TimeSpan.FromHours(1);
        private static readonly object Sync = new object();

        private static readonly HashSet<string> SufixosComunicacao = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "-ped-sta.xml",
            "-sta.xml",
            "-ped-sit.xml",
            "-sit.xml",
            "-ped-inu.xml",
            "-inu.xml",
            "-ped-eve.xml",
            "-eve.xml",
            "-ped-cad.xml",
            "-cad.xml",
            "-ped-distdfeint.xml",
            "-distdfeint.xml",
            "-env-lot.xml",
            "-rec.xml",
            "-ped-rec.xml",
            "-pro-rec.xml",
            "-ped-down.xml",
            "-down.xml",
            "-adm-csc.xml",
            "-ret-adm-csc.xml"
        };

        private static readonly HashSet<string> SufixosManterSempre = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "-procnfe.xml",
            "-proceventonfe.xml",
            "-cont.xml"
        };

        public static int ExecutarRotina(string diretorioXml, int manterDias = DiasManterComunicacao, bool ignorarThrottle = false)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml) || !Directory.Exists(diretorioXml))
                return 0;

            lock (Sync)
            {
                try
                {
                    if (!ignorarThrottle && !PodeExecutarAgora(diretorioXml))
                        return 0;

                    var movidos = MoverComunicacaoParaPasta(diretorioXml);
                    var apagados = LimparComunicacaoAntiga(diretorioXml, manterDias);

                    RegistarUltimaExecucao(diretorioXml);
                    NfceAuditLogger.Info("xmlcleanup.rotina", null, null, $"Movidos={movidos}; ApagadosAntigos={apagados}; ManterDias={manterDias}");

                    return movidos + apagados;
                }
                catch (Exception ex)
                {
                    try
                    {
                        NfceAuditLogger.Error("xmlcleanup.erro", null, null, ex, "Falha na rotina de limpeza de XMLs de comunicação.");
                    }
                    catch { }
                    return 0;
                }
            }
        }

        public static int MoverComunicacaoParaPasta(string diretorioXml)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml) || !Directory.Exists(diretorioXml))
                return 0;

            var movidos = 0;
            var pastaBaseComunicacao = Path.Combine(diretorioXml, PastaComunicacao);

            string[] arquivos;
            try
            {
                arquivos = Directory.GetFiles(diretorioXml, "*.xml", SearchOption.TopDirectoryOnly);
            }
            catch
            {
                return 0;
            }

            foreach (var arquivo in arquivos)
            {
                try
                {
                    if (EArquivoParaAuditoria(arquivo))
                        continue;

                    if (!EArquivoComunicacaoIntermediaria(arquivo))
                        continue;

                    DateTime dataRef;
                    try { dataRef = File.GetLastWriteTime(arquivo); }
                    catch { dataRef = DateTime.Today; }

                    var subdir = Path.Combine(pastaBaseComunicacao, $"{dataRef:yyyyMMdd}");
                    Directory.CreateDirectory(subdir);

                    var nome = Path.GetFileName(arquivo);
                    var destino = Path.Combine(subdir, nome);
                    if (File.Exists(destino))
                    {
                        var baseNome = Path.GetFileNameWithoutExtension(nome);
                        var ext = Path.GetExtension(nome);
                        destino = Path.Combine(subdir, $"{baseNome}-{Guid.NewGuid():N}{ext}");
                    }

                    try
                    {
                        File.Move(arquivo, destino);
                        movidos++;
                    }
                    catch { }
                }
                catch { }
            }

            return movidos;
        }

        public static int LimparComunicacaoAntiga(string diretorioXml, int manterDias = DiasManterComunicacao)
        {
            if (string.IsNullOrWhiteSpace(diretorioXml))
                return 0;

            var pastaBaseComunicacao = Path.Combine(diretorioXml, PastaComunicacao);
            if (!Directory.Exists(pastaBaseComunicacao))
                return 0;

            var corte = DateTime.Today.AddDays(-Math.Abs(manterDias));
            var apagados = 0;

            try
            {
                var pastas = Directory.GetDirectories(pastaBaseComunicacao, "*", SearchOption.TopDirectoryOnly);
                foreach (var p in pastas)
                {
                    var nome = Path.GetFileName(p);
                    if (nome != null && nome.Length == 8 && nome.All(char.IsDigit) && int.TryParse(nome, out var dataNum))
                    {
                        try
                        {
                            var ano = dataNum / 10000;
                            var mes = (dataNum % 10000) / 100;
                            var dia = dataNum % 100;
                            var dataPasta = new DateTime(ano, mes, dia);
                            if (dataPasta <= corte)
                            {
                                try
                                {
                                    var qtd = Directory.GetFiles(p, "*", SearchOption.AllDirectories).Length;
                                    Directory.Delete(p, true);
                                    apagados += qtd;
                                    continue;
                                }
                                catch { }
                            }
                        }
                        catch { }
                    }

                    try
                    {
                        var arquivosRestantes = Directory.GetFiles(p, "*.xml", SearchOption.AllDirectories);
                        foreach (var a in arquivosRestantes)
                        {
                            try
                            {
                                if (File.GetLastWriteTime(a) <= corte)
                                {
                                    File.Delete(a);
                                    apagados++;
                                }
                            }
                            catch { }
                        }

                        try
                        {
                            if (!Directory.EnumerateFileSystemEntries(p).Any())
                                Directory.Delete(p, true);
                        }
                        catch { }
                    }
                    catch { }
                }
            }
            catch { }

            return apagados;
        }

        public static bool EArquivoComunicacaoIntermediaria(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                return false;

            var nome = Path.GetFileName(caminho) ?? string.Empty;
            var lower = nome.ToLowerInvariant();

            foreach (var suf in SufixosComunicacao)
            {
                if (lower.EndsWith(suf, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        public static bool EArquivoParaAuditoria(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                return false;

            var nome = Path.GetFileName(caminho) ?? string.Empty;
            var lower = nome.ToLowerInvariant();

            foreach (var suf in SufixosManterSempre)
            {
                if (lower.EndsWith(suf, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            var baseNome = Path.GetFileNameWithoutExtension(nome) ?? string.Empty;
            if (baseNome.Length == 44 && baseNome.All(char.IsDigit))
                return true;

            return false;
        }

        private static bool PodeExecutarAgora(string diretorioXml)
        {
            try
            {
                var statePath = ObterCaminhoEstado(diretorioXml);
                if (!File.Exists(statePath))
                    return true;

                var conteudo = File.ReadAllText(statePath)?.Trim();
                if (string.IsNullOrWhiteSpace(conteudo))
                    return true;

                if (long.TryParse(conteudo, out var ticks))
                {
                    var ultima = new DateTime(ticks, DateTimeKind.Utc);
                    return (DateTime.UtcNow - ultima) >= MinIntervaloEntreExecucoes;
                }

                return true;
            }
            catch
            {
                return true;
            }
        }

        private static void RegistarUltimaExecucao(string diretorioXml)
        {
            try
            {
                var statePath = ObterCaminhoEstado(diretorioXml);
                var dir = Path.GetDirectoryName(statePath);
                if (!string.IsNullOrWhiteSpace(dir))
                    Directory.CreateDirectory(dir);
                File.WriteAllText(statePath, DateTime.UtcNow.Ticks.ToString());
            }
            catch { }
        }

        private static string ObterCaminhoEstado(string diretorioXml)
        {
            try
            {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var logDir = Path.Combine(baseDir, "Logs", "Nfce");
                Directory.CreateDirectory(logDir);
                return Path.Combine(logDir, "xmlcleanup-state.txt");
            }
            catch
            {
                return Path.Combine(diretorioXml ?? string.Empty, "xmlcleanup-state.txt");
            }
        }
    }
}
