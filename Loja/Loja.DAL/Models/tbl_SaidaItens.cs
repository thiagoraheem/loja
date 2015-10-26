using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_SaidaItens
    {
        public int CodVenda { get; set; }
        public int codigounico { get; set; }
        public System.DateTime DatSaida { get; set; }
        public string CodOrcamento { get; set; }
        public string CodProduto { get; set; }
        public string DesProduto { get; set; }
        public decimal VlrUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal VlrCusto { get; set; }
        public Nullable<decimal> VlrFinal { get; set; }
        public virtual tbl_Produtos tbl_Produtos { get; set; }
        public virtual tbl_Saida tbl_Saida { get; set; }
    }
}
