using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_TipoEntrada
    {
        public tbl_TipoEntrada()
        {
            this.tbl_Entrada = new List<tbl_Entrada>();
        }

        public int CodTipoEntrada { get; set; }
        public string DesTipoEntrada { get; set; }
        public bool flgMovimentaEstoque { get; set; }
        public virtual ICollection<tbl_Entrada> tbl_Entrada { get; set; }
    }
}
