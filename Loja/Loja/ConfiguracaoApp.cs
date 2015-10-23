using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Impressao;
using NFe.Impressao.NFCe;
using NFe.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
	public class ConfiguracaoApp
	{

		private ConfiguracaoServico _cfgServico;

		public ConfiguracaoApp()
		{
			CfgServico = ConfiguracaoServico.Instancia;
			CfgServico.tpAmb = TipoAmbiente.taHomologacao;
			CfgServico.tpEmis = TipoEmissao.teNormal;
			Emitente = new emit { CNPJ = "05499801000167", CPF = "", CRT = CRT.SimplesNacional };
			EnderecoEmitente = new enderEmit();
			ConfiguracaoDanfeNfce = new ConfiguracaoDanfeNfce(NfceDetalheVendaNormal.UmaLinha, NfceDetalheVendaContigencia.UmaLinha, "", "");
		}

		public ConfiguracaoServico CfgServico
		{
			get
			{
				Funcoes.CopiarPropriedades(_cfgServico, ConfiguracaoServico.Instancia);
				return _cfgServico;
			}
			set
			{
				_cfgServico = value;
				Funcoes.CopiarPropriedades(value, ConfiguracaoServico.Instancia);
			}
		}

		public emit Emitente { get; set; }
		public enderEmit EnderecoEmitente { get; set; }
		public ConfiguracaoDanfeNfce ConfiguracaoDanfeNfce { get; set; }

		/// <summary>
		///     Salva os dados de CfgServico em um arquivo XML
		/// </summary>
		/// <param name="arquivo">Arquivo XML onde será salvo os dados</param>
		public void Salvar(string arquivo)
		{
			var camposEmBranco = Funcoes.ObterPropriedadesEmBranco(CfgServico);

			var propinfo = Funcoes.ObterPropriedadeInfo(_cfgServico, c => c.DiretorioSalvarXml);
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
