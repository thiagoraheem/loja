using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_NCM
    {
        public string codigo { get; set; }
        public string ex { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public Nullable<decimal> nacionalfederal { get; set; }
        public Nullable<decimal> importadosfederal { get; set; }
        public Nullable<decimal> estadual { get; set; }
        public Nullable<decimal> municipal { get; set; }
        public Nullable<System.DateTime> vigenciainicio { get; set; }
        public Nullable<System.DateTime> vigenciafim { get; set; }
        public string chave { get; set; }
        public string versao { get; set; }
        public string fonte { get; set; }
    }
}
