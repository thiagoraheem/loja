using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Entrada
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
        public virtual tbl_Produtos tbl_Produtos { get; set; }
        public virtual tbl_TipoEntrada tbl_TipoEntrada { get; set; }
    }
}
