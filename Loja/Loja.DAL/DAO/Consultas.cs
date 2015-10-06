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

	}

}
