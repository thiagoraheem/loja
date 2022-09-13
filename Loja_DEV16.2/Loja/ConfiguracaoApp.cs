using System;
using System.IO;
using System.Net;
using DFe.Utils;
using Loja.Properties;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Danfe.Base;
using NFe.Danfe.Base.NFCe;
using NFe.Utils;
using NFe.Utils.Email;

namespace Loja
{
	public class ConfiguracaoApp
	{
		private ConfiguracaoServico _cfgServico;

		public ConfiguracaoApp()
		{
			CfgServico = ConfiguracaoServico.Instancia;
			#if Debug
			CfgServico.tpAmb = TipoAmbiente.taHomologacao;
			#else
			CfgServico.tpAmb = TipoAmbiente.taProducao;
			#endif
			CfgServico.tpEmis = TipoEmissao.teNormal;
			CfgServico.ProtocoloDeSeguranca = ServicePointManager.SecurityProtocol;
			Emitente = new emit { CPF = "", CRT = CRT.SimplesNacional };
			EnderecoEmitente = new enderEmit();
			ConfiguracaoEmail = new ConfiguracaoEmail("jasgif@gmail.com", "186186186", "Envio de NFE", Resources.MensagemHtml, "smtp.gmail.com", 587, true, true);
			ConfiguracaoCsc = new ConfiguracaoCsc("000001", CfgServico.tpAmb == TipoAmbiente.taHomologacao ? "6c15dd175e08d810" : "dbe71e1bd0bf7aba");
			ConfiguracaoDanfeNfce = new ConfiguracaoDanfeNfce(NfceDetalheVendaNormal.UmaLinha, NfceDetalheVendaContigencia.UmaLinha);
		}

		public ConfiguracaoServico CfgServico
		{
			get
			{
				ConfiguracaoServico.Instancia.CopiarPropriedades(_cfgServico);
				return _cfgServico;
			}
			set
			{
				_cfgServico = value;
				ConfiguracaoServico.Instancia.CopiarPropriedades(value);
			}
		}

		public emit Emitente { get; set; }
		public enderEmit EnderecoEmitente { get; set; }
		public ConfiguracaoEmail ConfiguracaoEmail { get; set; }
		public ConfiguracaoCsc ConfiguracaoCsc { get; set; }
		public ConfiguracaoDanfeNfce ConfiguracaoDanfeNfce { get; set; }

		/// <summary>
		///     Salva os dados de CfgServico em um arquivo XML
		/// </summary>
		/// <param name="arquivo">Arquivo XML onde será salvo os dados</param>
		public void SalvarParaAqruivo(string arquivo)
		{
			var camposEmBranco = CfgServico.ObterPropriedadesEmBranco();

			var propinfo = _cfgServico.ObterPropriedadeInfo(c => c.DiretorioSalvarXml);
			camposEmBranco.Remove(propinfo.Name);

			if (camposEmBranco.Count > 0)
				throw new Exception("Informe os dados abaixo antes de salvar as Configurações:" + Environment.NewLine + string.Join(", ", camposEmBranco.ToArray()));

			var dir = Path.GetDirectoryName(arquivo);
			if (dir != null && !Directory.Exists(dir))
			{
				throw new DirectoryNotFoundException("Diretório " + dir + " não encontrado!");
			}
			FuncoesXml.ClasseParaArquivoXml(this, arquivo);
		}
	}
}
