using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Orcamento
    {
        public string CodOrca { get; set; }
        public string CodProduto { get; set; }
        public string DescProduto { get; set; }
        public Nullable<double> Quantidade { get; set; }
        public Nullable<double> VlrUnitario { get; set; }
        public Nullable<double> VlrCusto { get; set; }
        public string DesLocal { get; set; }
        public Nullable<double> PF { get; set; }
        public string FlgStatus { get; set; }
        public Nullable<System.DateTime> DatOrca { get; set; }
        public int codigounico { get; set; }
        public virtual tbl_Produtos tbl_Produtos { get; set; }
    }
}
