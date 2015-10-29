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
		public static void EstornaVenda(int codVenda, string desMotivo, bool flgVoltaNumero)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_EstornaVenda(codVenda, desMotivo, flgVoltaNumero);

			}
		}

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

		public static int FinalizaVenda(string codOrca, int codTipoVenda, int? codCliente)
		{
			using (var banco = new LojaContext())
			{
				return banco.spc_FinalizaVenda(codOrca, codTipoVenda, codCliente).FirstOrDefault();

			}
		}

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


		public static void ExcluiProduto(int codigo)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Produtos.FirstOrDefault(x => x.codigounico == codigo);

				banco.tbl_Produtos.Remove(dados);
				banco.SaveChanges();

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
		
		public static void ExcluiTipoVenda(int codTipoVenda) {

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_TipoVenda.FirstOrDefault(x => x.CodTipoVenda == codTipoVenda);

				banco.tbl_TipoVenda.Remove(dados);
				banco.SaveChanges();

			}
		
		}

		public static void GravaTipoVenda (tbl_TipoVenda dado){
		
			using(var banco = new LojaContext())
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
				else { 
					registro.DesTipoEntrada = dado.DesTipoEntrada;
					registro.flgMovimentaEstoque = dado.flgMovimentaEstoque;
				}

				banco.SaveChanges();

			}

		}



		public static void ExcluiCliente(int codCliente)
		{

			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Cliente.FirstOrDefault(x => x.CodCliente == codCliente);

				banco.tbl_Cliente.Remove(dados);
				banco.SaveChanges();

			}

		}

		public static int GravaCliente(tbl_Cliente dado)
		{
		
			using (var banco = new LojaContext())
			{
				var registro = banco.tbl_Cliente.FirstOrDefault(x => x.CodCliente == dado.CodCliente);

				if (registro == null)
				{
					banco.tbl_Cliente.Add(dado);
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
				}

				banco.SaveChanges();

				return registro.CodCliente;

			}

		}


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

	}
}
