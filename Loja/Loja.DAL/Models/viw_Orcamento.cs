using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class viw_Orcamento
    {
        public string CodOrca { get; set; }
        public Nullable<int> Itens { get; set; }
        public Nullable<double> VlrTotal { get; set; }
        public string FlgStatus { get; set; }
    }
}
