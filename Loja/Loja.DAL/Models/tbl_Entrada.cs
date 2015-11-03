using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Entrada
    {
        public tbl_Entrada()
        {
            this.tbl_EntradaItens = new List<tbl_EntradaItens>();
        }

        public int CodEntrada { get; set; }
        public string DocEntrada { get; set; }
        public string SerieNota { get; set; }
        public Nullable<System.DateTime> DatEmissao { get; set; }
        public System.DateTime DatEntrada { get; set; }
        public int CodTipoEntrada { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public virtual tbl_TipoEntrada tbl_TipoEntrada { get; set; }
        public virtual ICollection<tbl_EntradaItens> tbl_EntradaItens { get; set; }
    }
}
