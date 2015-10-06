using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL.Models;
using Loja.DAL.VO;

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
		

	}
}
