using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL.Models;
using Loja.DAL.VO;

namespace Loja.DAL.DAO
{
	public class Consultas
	{
		public static List<tbl_Produtos> ObterProdutosAtivos()
		{
			using (var banco = new LojaContext())
			{
				var produtos = from prod in banco.tbl_Produtos
							   where prod.QtdProduto > 0
							   select prod;

				return produtos.ToList();

			}
		}

		public static List<tbl_Produtos> ObterProdutos()
		{
			using (var banco = new LojaContext())
			{
				var produtos = from prod in banco.tbl_Produtos
							   select prod;

				return produtos.ToList();

			}
		}

		public static tbl_Produtos ObterProduto(int codigounico)
		{

			using (var banco = new LojaContext())
			{
				var registro = (from prod in banco.tbl_Produtos
								where prod.codigounico == codigounico
								select prod).FirstOrDefault();
				return registro;
			}
		}

		public static int ObterQtdeProdutos()
		{
			using (var banco = new LojaContext())
			{
				var produtos = banco.tbl_Produtos.Count();

				return produtos;

			}
		}

		public static double ObterQtdeItens()
		{
			using (var banco = new LojaContext())
			{
				var produtos = banco.tbl_Produtos.AsEnumerable().Sum(o => o.QtdProduto) ?? 0;

				return produtos;

			}
		}

		public static List<DadosCombo> ObterTipoVendaCombo()
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipovenda in banco.tbl_TipoVenda
							where tipovenda.flgAtivo == true
							select new DadosCombo { Codigo = tipovenda.CodTipoVenda.ToString(), Descricao = tipovenda.DesTipoVenda };

				return dados.ToList();
			}
		}

		public static List<tbl_Saida> ObterVendas(DateTime inicio, DateTime fim)
		{
			using (var banco = new LojaContext())
			{
				var dados = from saida in banco.tbl_Saida
							where saida.Data >= inicio && saida.Data <= fim
							select saida;

				return dados.ToList();
			}
		}

		public static List<tbl_Saida> ObterVendasItens(DateTime inicio, DateTime fim)
		{
			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Saida.Include("tbl_SaidaItens").Where(saida => saida.Data >= inicio && saida.Data <= fim).ToList();

				return dados;
			}
		}

		public static List<tbl_SaidaItens> ObterVendaItens(int codVenda)
		{
			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_SaidaItens.Include("tbl_Produtos").Where(saida => saida.CodVenda == codVenda).ToList();

				return dados;
			}
		}

		public static tbl_Saida ObterVenda(int codVenda)
		{
			using (var banco = new LojaContext())
			{
				var dados = banco.tbl_Saida.Include("tbl_SaidaItens").FirstOrDefault(saida => saida.CodVenda == codVenda);

				foreach (var item in dados.tbl_SaidaItens) { 
					var produto = ObterProduto(item.codigounico);
					item.tbl_Produtos = produto;
				}

				return dados;
			}
		}

		public static List<tbl_Orcamento> ObterOrcamentos(string codOrca)
		{
			using (var banco = new LojaContext())
			{
				var dado = from orcam in banco.tbl_Orcamento
						   where orcam.CodOrca == codOrca
						   select orcam;
				return dado.ToList();
			}
		}

		public static List<DadosCombo> ObterOrcamentosCombo()
		{
			using (var banco = new LojaContext())
			{
				var dado = from orcam in banco.tbl_Orcamento
						   where orcam.FlgStatus == "O"
						   group orcam by orcam.CodOrca into grupo
						   select new DadosCombo
						   {
							   Codigo = grupo.Key,
							   Descricao = grupo.Count().ToString()
						   };
				return dado.ToList();
			}
		}

		public static List<Entrada> ObterEntrada(string docEntrada)
		{

			using (var banco = new LojaContext())
			{

				var entradas = from entrada in banco.tbl_Entrada
							   join produto in banco.tbl_Produtos on entrada.codigounico equals produto.codigounico
							   where entrada.DocEntrada == docEntrada
							   select new Entrada()
							   {
								   DatEntrada = entrada.DatEntrada,
								   DocEntrada = entrada.DocEntrada,
								   Percentual = entrada.Percentual,
								   QtdProduto = entrada.QtdProduto,
								   VlrTotal = entrada.VlrTotal,
								   VlrUnitario = entrada.VlrUnitario,
								   CodProduto = produto.CodProduto,
								   DesProduto = produto.DesProduto,
								   codigounico = produto.codigounico
							   };
				return entradas.ToList();


			}

		}

		public static List<Entrada> ObterEntrada(DateTime inicio, DateTime fim)
		{

			using (var banco = new LojaContext())
			{

				var registro = from entrada in banco.tbl_Entrada
							   join produto in banco.tbl_Produtos on entrada.codigounico equals produto.codigounico
							   where entrada.DatEntrada >= inicio && entrada.DatEntrada <= fim
							   select new Entrada()
							   {
								   DatEntrada = entrada.DatEntrada,
								   DocEntrada = entrada.DocEntrada,
								   Percentual = entrada.Percentual,
								   QtdProduto = entrada.QtdProduto,
								   VlrTotal = entrada.VlrTotal,
								   VlrUnitario = entrada.VlrUnitario,
								   CodProduto = produto.CodProduto,
								   DesProduto = produto.DesProduto,
								   codigounico = produto.codigounico
							   };
				return registro.ToList();

			}


		}

		public static List<string> ObterFornecedores()
		{

			using (var banco = new LojaContext())
			{

				var cons = from forn in banco.tbl_Produtos
						   group forn by forn.DesFornecedor into gFornecedor
						   select gFornecedor.Key;

				return cons.ToList();
			}
		}


		public static List<DadosCombo> ObterTipoEntradaCombo()
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipoentrada in banco.tbl_TipoEntrada
							select new DadosCombo { Codigo = tipoentrada.CodTipoEntrada.ToString(), Descricao = tipoentrada.DesTipoEntrada };

				return dados.ToList();
			}
		}

		public static List<tbl_TipoVenda> ObterTipoVendas()
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipovenda in banco.tbl_TipoVenda
							select tipovenda;

				return dados.ToList();
			}
		}

		public static tbl_TipoVenda ObterTipoVenda(int codTipoVenda)
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipovenda in banco.tbl_TipoVenda
							where tipovenda.CodTipoVenda == codTipoVenda
							select tipovenda;

				return dados.FirstOrDefault();
			}
		}

		public static List<tbl_TipoEntrada> ObterTipoEntradas()
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipoentrada in banco.tbl_TipoEntrada
							select tipoentrada;

				return dados.ToList();
			}
		}

		public static tbl_TipoEntrada ObterTipoEntrada(int codTipoEntrada)
		{

			using (var banco = new LojaContext())
			{
				var dados = from tipoentrada in banco.tbl_TipoEntrada
							where tipoentrada.CodTipoEntrada == codTipoEntrada
							select tipoentrada;

				return dados.FirstOrDefault();
			}
		}


		public static List<tbl_Cliente> ObterClientes() {

			using (var banco = new LojaContext())
			{
				return banco.tbl_Cliente.ToList();
			}
		}

		public static tbl_Cliente ObterCliente(int codCliente)
		{

			using (var banco = new LojaContext())
			{
				return banco.tbl_Cliente.FirstOrDefault(x => x.CodCliente == codCliente);
			}
		}

	}

}
