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
		public static void EstornaVenda(int codVenda, int codProduto, string desMotivo)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_EstornaVenda(codVenda, codProduto, desMotivo);

			}
		}

		public static ObjectResult<string> AdicionarOrcamento(string codOrca, int codProduto)
		{
			using (var banco = new LojaContext())
			{
				return banco.spc_AdicionarOrcamento(codOrca, codProduto);

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

		public static void DescontoVenda(string codOrca, decimal desconto)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_DescontoVenda(codOrca, desconto);

			}
		}

		public static void FinalizaVenda(string codOrca, int codTipoVenda, string flgApagarOrca)
		{
			using (var banco = new LojaContext())
			{
				banco.spc_FinalizaVenda(codOrca, codTipoVenda, flgApagarOrca);

			}
		}

		public static void ExcluiTipoVenda(int codTipoVenda) { 
		
		
		}

	}
}
