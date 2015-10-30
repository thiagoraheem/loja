using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_TipoVenda
    {
        public tbl_TipoVenda()
        {
            this.tbl_Saida = new List<tbl_Saida>();
        }

        public int CodTipoVenda { get; set; }
        public string DesTipoVenda { get; set; }
        public Nullable<bool> flgAtivo { get; set; }
        public Nullable<bool> flgAVista { get; set; }
        public Nullable<decimal> QtdDias { get; set; }
        public string CodigoSefaz { get; set; }
        public virtual ICollection<tbl_Saida> tbl_Saida { get; set; }
    }
}
