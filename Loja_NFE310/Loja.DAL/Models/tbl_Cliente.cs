using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Cliente
    {
        public int CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string NumCPF { get; set; }
        public string NumCNPJ { get; set; }
        public string NumTelefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public Nullable<bool> FlgStatus { get; set; }
    }
}
