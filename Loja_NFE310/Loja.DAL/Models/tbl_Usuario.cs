using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Usuario
    {
        public string CODIGO { get; set; }
        public string NOME { get; set; }
        public string TSENHA { get; set; }
        public string STATUS { get; set; }
        public string NIVEL { get; set; }
    }
}
