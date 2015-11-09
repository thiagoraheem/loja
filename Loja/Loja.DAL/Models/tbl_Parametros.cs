using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Parametros
    {
        public string EmpresaNome { get; set; }
        public string EmpresaEndereco { get; set; }
        public string EmpresaTelefone { get; set; }
        public string EmpresaEmail { get; set; }
        public string EmpresaWebSite { get; set; }
        public string EmpresaSlogan { get; set; }
        public byte[] EmpresaLogotipo { get; set; }
        public string EmpresaCNPJ { get; set; }
        public string EmpresaInscEstadual { get; set; }
        public Nullable<int> SisCodVenda { get; set; }
        public Nullable<int> SisNumNF { get; set; }
    }
}
