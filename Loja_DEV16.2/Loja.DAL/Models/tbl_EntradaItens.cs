using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_EntradaItens
    {
        public int CodEntrada { get; set; }
        public int codigounico { get; set; }
        public Nullable<int> NumOrdem { get; set; }
        public string CodProduto { get; set; }
        public string DesProduto { get; set; }
        public string NCM { get; set; }
        public string Unidade { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<decimal> VlrUnitario { get; set; }
        public Nullable<decimal> VlrTotal { get; set; }
        public Nullable<decimal> Percentual { get; set; }
        public Nullable<decimal> VlrFinal { get; set; }
        public Nullable<decimal> VlrBaseICMS { get; set; }
        public Nullable<decimal> VlrPercICMS { get; set; }
        public Nullable<decimal> VlrICMS { get; set; }
        public Nullable<decimal> VlrBaseICMSST { get; set; }
        public Nullable<decimal> VlrPercICMSST { get; set; }
        public Nullable<decimal> VlrICMSST { get; set; }
        public Nullable<decimal> VlrBasePIS { get; set; }
        public Nullable<decimal> VlrPercPIS { get; set; }
        public Nullable<decimal> VlrPIS { get; set; }
        public Nullable<decimal> VlrBaseCOFINS { get; set; }
        public Nullable<decimal> VlrPercCOFINS { get; set; }
        public Nullable<decimal> VlrCOFINS { get; set; }
        public virtual tbl_Entrada tbl_Entrada { get; set; }
    }
}
