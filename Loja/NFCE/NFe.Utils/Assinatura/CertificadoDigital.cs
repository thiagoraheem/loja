/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using System;
using System.Security.Cryptography.X509Certificates;
using DFeCfg = DFe.Utils.ConfiguracaoCertificado;
using DFeTipoCert = DFe.Utils.TipoCertificado;

namespace NFe.Utils.Assinatura
{
    public static class CertificadoDigital
    {
        public static X509Certificate2 ObterCertificado(ConfiguracaoCertificado configuracaoCertificado)
        {
            if (configuracaoCertificado == null)
                throw new ArgumentNullException("configuracaoCertificado");

            var cfg = new DFeCfg
            {
                ManterDadosEmCache = configuracaoCertificado.ManterDadosEmCache,
                SignatureMethodSignedXml = configuracaoCertificado.SignatureMethodSignedXml,
                DigestMethodReference = configuracaoCertificado.DigestMethodReference
            };

            if (!string.IsNullOrEmpty(configuracaoCertificado.Arquivo))
            {
                cfg.TipoCertificado = DFeTipoCert.A1Arquivo;
                cfg.Arquivo = configuracaoCertificado.Arquivo;
                cfg.Senha = configuracaoCertificado.Senha;
            }
            else
            {
                cfg.TipoCertificado = DFeTipoCert.A1Repositorio;
                cfg.Serial = configuracaoCertificado.Serial;
            }

            return DFe.Utils.Assinatura.CertificadoDigital.ObterCertificado(cfg);
        }

        /// <summary>
        /// Exibe a lista de certificados instalados no PC e devolve o certificado selecionado
        /// </summary>
        /// <returns></returns>
        public static X509Certificate2 ObterDoRepositorio()
        {
            return DFe.Utils.Assinatura.CertificadoDigital.ListareObterDoRepositorio();
        }

        /// <summary>
        /// Obtém um certificado instalado no PC a partir do número de série passado no parâmetro
        /// </summary>
        /// <param name="numeroSerial">Serial do certificado</param>
        /// <param name="senha">Informe a senha se desejar que o usuário não precise digitá-la toda vez que for iniciada uma nova instância da aplicação</param>
        /// <returns></returns>
        public static X509Certificate2 ObterDoRepositorio(string numeroSerial, string senha = null)
        {
            if (string.IsNullOrEmpty(numeroSerial))
                throw new Exception("O nº de série do certificado não foi informado para a função ObterDoRepositorio!");
            var cfg = new DFeCfg
            {
                Serial = numeroSerial,
                TipoCertificado = string.IsNullOrEmpty(senha) ? DFeTipoCert.A1Repositorio : DFeTipoCert.A3,
                Senha = senha
            };

            return DFe.Utils.Assinatura.CertificadoDigital.ObterCertificado(cfg);
        }

        /// <summary>
        /// Obtém um certificado a partir do arquivo e da senha passados nos parâmetros
        /// </summary>
        /// <param name="arquivo">Arquivo do certificado digital</param>
        /// <param name="senha">Senha do certificado digital</param>
        /// <returns></returns>
        public static X509Certificate2 ObterDeArquivo(string arquivo, string senha)
        {
            var cfg = new DFeCfg
            {
                TipoCertificado = DFeTipoCert.A1Arquivo,
                Arquivo = arquivo,
                Senha = senha
            };

            return DFe.Utils.Assinatura.CertificadoDigital.ObterCertificado(cfg);
        }
    }
}
