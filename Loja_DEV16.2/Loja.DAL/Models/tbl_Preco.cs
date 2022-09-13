using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Preco
    {
        public string CodProduto { get; set; }
        public Nullable<decimal> VlrProduto { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
    }
}
