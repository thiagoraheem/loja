using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAL.VO
{
	public class Entrada
	{
		public string DocEntrada { get; set; }
		public System.DateTime DatEntrada { get; set; }
		public decimal QtdProduto { get; set; }
		public decimal VlrUnitario { get; set; }
		public Nullable<decimal> VlrTotal { get; set; }
		public int CodTipoEntrada { get; set; }
		public int codigounico { get; set; }
		public Nullable<double> Percentual { get; set; }
		public string DesFornecedor { get; set; }

		public string CodProduto { get; set; }
		public string DesProduto { get; set; }

	}
}
