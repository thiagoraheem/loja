using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_SaidasEstorno
    {
        public string CodVenda { get; set; }
        public int codigounico { get; set; }
        public System.DateTime DatSaida { get; set; }
        public string CodOrcamento { get; set; }
        public string CodProduto { get; set; }
        public string DesProduto { get; set; }
        public decimal VlrUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal VlrCusto { get; set; }
        public Nullable<decimal> VlrFinal { get; set; }
        public int CodTipoVenda { get; set; }
        public System.DateTime DatEstorno { get; set; }
        public string MotivoEstorno { get; set; }
    }
}
