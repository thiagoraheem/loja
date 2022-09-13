using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_CEP
    {
        public string CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string BAIRRO_INICIAL { get; set; }
        public string BAIRRO_FINAL { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TIPO { get; set; }
    }
}
