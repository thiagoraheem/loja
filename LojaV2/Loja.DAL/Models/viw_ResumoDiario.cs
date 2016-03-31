using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class viw_ResumoDiario
    {
        public System.DateTime Data { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public string Mes { get; set; }
    }
}
