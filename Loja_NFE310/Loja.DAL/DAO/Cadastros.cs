using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL.Models;
using Loja.DAL.VO;
using System.Data.Entity.Core.Objects;

namespace Loja.DAL.DAO
{
	public class Cadastros
	{

		#region Orçamento

		public static List<string> AdicionarOrcamento(string codOrca, int codProduto)
		{
			using (var banco = new LojaContext())
			{
				return banco.spc_AdicionarOrcamento(codOrca, codProduto).ToList();

			}
		}

		public static void ApagarOrcamento(string codOrca)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_ApagarOrcamento(codOrca);

			}
		}

		public static void AlterarOrcamento(string codOrca, int codProduto, double qtde, double vlrUnitario)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_AlterarOrcamento(codOrca, codProduto, qtde, vlrUnitario);

			}
		}

		public static void ExcluiOrcamento(string codigo)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Orcamento.Where(x => x.CodOrca == codigo).ToList();

				banco.tbl_Orcamento.RemoveRange(dados);
				banco.SaveChanges();

			}

		}

		#endregion

		#region Parametros

		public static void ExcluiTipoVenda(int codTipoVenda)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_TipoVenda.FirstOrDefault(x => x.CodTipoVenda == codTipoVenda);

				banco.tbl_TipoVenda.Remove(dados);
				banco.SaveChanges();

			}

		}

		public static void GravaTipoVenda(tbl_TipoVenda dado)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_TipoVenda.FirstOrDefault(x => x.CodTipoVenda == dado.CodTipoVenda);

				if (registro == null)
				{
					banco.tbl_TipoVenda.Add(dado);
				}
				else
				{
					registro.DesTipoVenda = dado.DesTipoVenda;
					registro.flgAtivo = dado.flgAtivo;
					registro.flgAVista = dado.flgAVista;
					registro.QtdDias = dado.QtdDias;
				}

				banco.SaveChanges();

			}

		}

		public static void ExcluiTipoEntrada(int codTipoEntrada)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_TipoEntrada.FirstOrDefault(x => x.CodTipoEntrada == codTipoEntrada);

				banco.tbl_TipoEntrada.Remove(dados);
				banco.SaveChanges();

			}

		}

		public static void GravaTipoEntrada(tbl_TipoEntrada dado)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_TipoEntrada.FirstOrDefault(x => x.CodTipoEntrada == dado.CodTipoEntrada);

				if (registro == null)
				{
					banco.tbl_TipoEntrada.Add(dado);
				}
				else
				{
					registro.DesTipoEntrada = dado.DesTipoEntrada;
					registro.flgMovimentaEstoque = dado.flgMovimentaEstoque;
				}

				banco.SaveChanges();

			}

		}

		#endregion

		#region Clientes

		public static void ExcluiCliente(int codCliente)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Cliente.FirstOrDefault(x => x.CodCliente == codCliente);
				if (dados != null)
				{
					//banco.tbl_Cliente.Remove(dados);
					dados.FlgStatus = false;

					banco.SaveChanges();
				}

			}

		}

		public static int GravaCliente(tbl_Cliente dado)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Cliente.FirstOrDefault(x => x.CodCliente == dado.CodCliente);

				if (registro == null)
				{
					registro = banco.tbl_Cliente.Add(dado);
				}
				else
				{
					registro.NomCliente = dado.NomCliente;
					registro.NumCPF = dado.NumCPF;
					registro.NumCNPJ = dado.NumCNPJ;
					registro.NumTelefone = dado.NumTelefone;
					registro.Endereco = dado.Endereco;
					registro.Numero = dado.Numero;
					registro.Bairro = dado.Bairro;
					registro.Cidade = dado.Cidade;
					registro.Estado = dado.Estado;
					registro.Pais = dado.Pais;
					registro.Email = dado.Email;
					registro.CEP = dado.CEP;
					registro.FlgStatus = dado.FlgStatus;
				}

				banco.SaveChanges();

				return registro.CodCliente;

			}

		}

		#endregion

		#region Venda

		public static void GravaVenda(tbl_Saida dado)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == dado.CodVenda);

				if (registro == null)
				{
					banco.tbl_Saida.Add(dado);
				}
				else
				{
					registro.ChaveSefaz = dado.ChaveSefaz;
					registro.CodCliente = dado.CodCliente;
					registro.CodTipoVenda = dado.CodTipoVenda;
					registro.Data = dado.Data;
					registro.FlgStatusNFE = dado.FlgStatusNFE;
					registro.FlgStatusNota = dado.FlgStatusNota;
					registro.QtdItens = dado.QtdItens;
					registro.ValorTotal = dado.ValorTotal;
				}

				banco.SaveChanges();

			}

		}

		public static void DescontoVenda(string codOrca, double desconto, string tipo)
		{
			using (var banco = new LojaContext())
			{

				var dado = banco.tbl_Orcamento.Where(x => x.CodOrca == codOrca).ToList();

				var vlrTotal = dado.Sum(x => x.VlrUnitario);

				if (tipo == "P")
				{
					dado.ForEach(x => x.VlrDesconto = (decimal)(x.VlrCusto.Value * (desconto / 100)));
				}
				else
				{
					dado.ForEach(x => x.VlrDesconto = (decimal)((x.VlrCusto / vlrTotal) * desconto));
				}
				banco.SaveChanges();

				//banco.spc_DescontoVenda(codOrca, desconto);

			}
		}

		public static string FinalizaVenda(string codOrca, int codTipoVenda, int? codCliente, int flgNFE)
		{
			using (var banco = new LojaContext())
			{
				return banco.spc_FinalizaVenda(codOrca, codTipoVenda, codCliente, flgNFE).FirstOrDefault();

			}
		}

		public static void EstornaVenda(string codVenda, string desMotivo, bool flgVoltaNumero)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_EstornaVenda(codVenda, desMotivo, flgVoltaNumero);

			}
		}

		public static void AtualizaStatusNFE(string codVenda, string flgStatusNFE, string chave)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == codVenda);

				registro.FlgStatusNFE = flgStatusNFE;

				if (!String.IsNullOrEmpty(chave))
				{
					registro.ChaveSefaz = chave;
				}
				
				banco.SaveChanges();

			}

		}

		public static void CancelarVenda(string codVenda)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == codVenda);
				var itens = banco.tbl_SaidaItens.Where(x => x.CodVenda == codVenda).ToList();

				// voltar a quantidade de estoque para antes da venda
				foreach (var item in itens)
				{
					AlterarEstoque(item.codigounico, item.Quantidade);
				}
				
				registro.FlgStatusNFE = "X";

				banco.SaveChanges();

			}

		}

		public static void ExcluirVenda(string codVenda)
		{

			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == codVenda);
				var itens = banco.tbl_SaidaItens.Where(x => x.CodVenda == codVenda).ToList();


				banco.tbl_SaidaItens.RemoveRange(itens);
				banco.tbl_Saida.Remove(registro);

				banco.SaveChanges();

			}

		}

        public static void InutilizarVenda(string codVenda)
        {

            using (var banco = new LojaContext())
            {
                var registro = banco.tbl_Saida.FirstOrDefault(x => x.CodVenda == codVenda);

                if (registro == null)
                {
                    banco.tbl_Saida.Add(new tbl_Saida() { CodVenda = codVenda, FlgStatusNFE = "I", ValorTotal = 0, QtdItens = 0, Data = DateTime.Now, FlgStatusNota = "I", CodTipoVenda = 1 });
                }
                else
                {
                    throw new Exception("Número de nota não pode ser inutilizado");
                }

                banco.SaveChanges();

            }

        }

		#endregion

		#region Produto
		public static void ManutProduto(int codigounico, string codProduto, string desProduto, string desLocal, double vlrUnitario,
									double qtdProduto, double vlrCusto, double vlrPercent, double estMinimo, string desFornecedor,
									string codRefAntiga, double vlrUltPreco, byte[] imagem, string ncm)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_ManutProduto(codigounico, codProduto, desProduto, desLocal, vlrUnitario,
									qtdProduto, vlrCusto, vlrPercent, estMinimo, desFornecedor,
									codRefAntiga, vlrUltPreco, imagem, ncm);
			}
		}

		public static void Reajuste(decimal porcentagem, string desFornecedor)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_Reajuste(porcentagem, desFornecedor);

			}
		}

		public static int GravaProduto(tbl_Produtos dados)
		{
			try
			{


				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_Produtos.FirstOrDefault(s => s.codigounico == dados.codigounico);

					if (registro == null)
					{
						registro = banco.tbl_Produtos.Add(dados);
					}
					else
					{
						registro.CodProduto = dados.CodProduto;
						registro.CodRefAntiga = dados.CodRefAntiga;
						registro.DatCadastro = dados.DatCadastro;
						registro.DesFaz = dados.DesFaz;
						registro.DesFornecedor = dados.DesFornecedor;
						registro.DesLocal = dados.DesLocal;
						registro.DesProduto = dados.DesProduto;
						registro.EstMinimo = dados.EstMinimo;
						registro.Imagem = dados.Imagem;
						registro.NCM = dados.NCM;
						registro.QtdProduto = dados.QtdProduto;
						registro.VlrCusto = dados.VlrCusto;
						registro.VlrICMSST = dados.VlrICMSST;
						registro.VlrPercent = dados.VlrPercent;
						registro.VlrUltPreco = dados.VlrUltPreco;
						registro.VlrUnitario = dados.VlrUnitario;

					}

					banco.SaveChanges();

					return registro.codigounico;
				}
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
			{
				Exception raise = dbEx;
				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						string message = string.Format("{0}:{1}",
							validationErrors.Entry.Entity.ToString(),
							validationError.ErrorMessage);
						// raise a new exception nesting
						// the current instance as InnerException
						raise = new InvalidOperationException(message, raise);
					}
				}
				throw raise;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
		}

		public static int AlterarEstoque(int codigounico, int qtdEstoque)
		{
			try
			{

				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_Produtos.FirstOrDefault(s => s.codigounico == codigounico);

					if (registro != null)
					{
						registro.QtdProduto += qtdEstoque;
					
						banco.SaveChanges();
					}

					return registro.codigounico;
				}
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
			{
				Exception raise = dbEx;
				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						string message = string.Format("{0}:{1}",
							validationErrors.Entry.Entity.ToString(),
							validationError.ErrorMessage);
						// raise a new exception nesting
						// the current instance as InnerException
						raise = new InvalidOperationException(message, raise);
					}
				}
				throw raise;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
		}

		public static int SomarEstoque(int codigounico, int qtdEstoque)
		{
			try
			{

				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_Produtos.FirstOrDefault(s => s.codigounico == codigounico);

					if (registro != null)
					{
						registro.QtdProduto += qtdEstoque;

						banco.SaveChanges();
					}

					return registro.codigounico;
				}
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
			{
				Exception raise = dbEx;
				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						string message = string.Format("{0}:{1}",
							validationErrors.Entry.Entity.ToString(),
							validationError.ErrorMessage);
						// raise a new exception nesting
						// the current instance as InnerException
						raise = new InvalidOperationException(message, raise);
					}
				}
				throw raise;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
		}

		public static int DiminuirEstoque(int codigounico, int qtdEstoque)
		{
			try
			{

				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_Produtos.FirstOrDefault(s => s.codigounico == codigounico);

					if (registro != null)
					{
						registro.QtdProduto -= qtdEstoque;

						banco.SaveChanges();
					}

					return registro.codigounico;
				}
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
			{
				Exception raise = dbEx;
				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						string message = string.Format("{0}:{1}",
							validationErrors.Entry.Entity.ToString(),
							validationError.ErrorMessage);
						// raise a new exception nesting
						// the current instance as InnerException
						raise = new InvalidOperationException(message, raise);
					}
				}
				throw raise;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
			}
		}


		public static void ExcluiProduto(int codigo)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Produtos.FirstOrDefault(x => x.codigounico == codigo);

				if (dados != null) 
				{
					banco.tbl_Produtos.Remove(dados);
					banco.SaveChanges();
				}

			}

		}
		#endregion

		#region Entrada de Produtos

		public static void AdicionarEntrada(string docEntrada, DateTime datEntrada, int codProduto, double qtdProduto, decimal vlrUnitario, int codTipoEntrada, double percentual, string desFornecedor)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_AdicionarEntrada(docEntrada, datEntrada, codProduto, qtdProduto, vlrUnitario, codTipoEntrada, percentual, desFornecedor);
			}
		}

		public static void AlterarEntrada(string docEntrada, DateTime datEntrada, int codProduto, double qtdProduto, double vlrUnitario)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_AlterarEntrada(docEntrada, datEntrada, codProduto, qtdProduto, vlrUnitario);
			}
		}


		public static void ExcluiEntrada(int codEntrada)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Entrada.FirstOrDefault(x => x.CodEntrada == codEntrada);
				if (dados != null)
				{
					banco.tbl_Entrada.Remove(dados);
					banco.SaveChanges();
				}

			}

		}

		public static int GravaEntrada(tbl_Entrada dado)
		{
			try
			{

				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_Entrada.FirstOrDefault(x => x.CodEntrada == dado.CodEntrada);

					if (registro == null)
					{
						dado.DatEntrada = DateTime.Now;
						registro = banco.tbl_Entrada.Add(dado);
					}
					else
					{
						registro.DocEntrada = dado.DocEntrada;
						registro.SerieNota = dado.SerieNota;
						registro.DatEmissao = dado.DatEmissao;
						registro.DatEntrada = dado.DatEntrada;
						registro.CodTipoEntrada = dado.CodTipoEntrada;
						registro.CNPJ = dado.CNPJ;
						registro.CPF = dado.CPF;
						registro.Nome = dado.Nome;
					}

					banco.SaveChanges();

					return registro.CodEntrada;

				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
			}
		}


		public static void ExcluiEntradaItem(int codEntrada, int codigounico)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_EntradaItens.FirstOrDefault(x => x.CodEntrada == codEntrada && x.codigounico == codigounico);
				if (dados != null)
				{
					banco.tbl_EntradaItens.Remove(dados);
					banco.SaveChanges();
				}

			}

		}

		public static void ExcluiEntradaItens(int codEntrada)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_EntradaItens.Where(x => x.CodEntrada == codEntrada).ToList();
				if (dados != null)
				{
					banco.tbl_EntradaItens.RemoveRange(dados);
					banco.SaveChanges();
				}

			}

		}

		public static int GravaEntradaItem(tbl_EntradaItens dado)
		{

			try
			{

				using (var banco = new LojaContext())
				{
					var registro = banco.tbl_EntradaItens.FirstOrDefault(x => x.CodEntrada == dado.CodEntrada && x.codigounico == dado.codigounico);

					if (registro == null)
					{
						registro = banco.tbl_EntradaItens.Add(dado);
					}
					else
					{
						registro.NumOrdem = dado.NumOrdem;
						registro.NCM = dado.NCM;
						registro.Unidade = dado.Unidade;
						registro.Quantidade = dado.Quantidade;
						registro.VlrUnitario = dado.VlrUnitario;
						registro.VlrTotal = dado.VlrTotal;
						registro.Percentual = dado.Percentual;
						registro.VlrFinal = dado.VlrFinal;
						registro.VlrBaseICMS = dado.VlrBaseICMS;
						registro.VlrPercICMS = dado.VlrPercICMS;
						registro.VlrICMS = dado.VlrICMS;
						registro.VlrBaseICMSST = dado.VlrBaseICMSST;
						registro.VlrPercICMSST = dado.VlrPercICMSST;
						registro.VlrICMSST = dado.VlrICMSST;
						registro.VlrBasePIS = dado.VlrBasePIS;
						registro.VlrPercPIS = dado.VlrPercPIS;
						registro.VlrPIS = dado.VlrPIS;
						registro.VlrBaseCOFINS = dado.VlrBaseCOFINS;
						registro.VlrPercCOFINS = dado.VlrPercCOFINS;
						registro.VlrCOFINS = dado.VlrCOFINS;

					}

					banco.SaveChanges();

					return registro.CodEntrada;

				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
			}

		}

		#endregion

	}
}
