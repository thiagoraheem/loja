using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Saida
    {
        public tbl_Saida()
        {
            this.tbl_SaidaItens = new List<tbl_SaidaItens>();
        }

        public string CodVenda { get; set; }
        public System.DateTime Data { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public Nullable<int> QtdItens { get; set; }
        public string FlgStatusNFE { get; set; }
        public string ChaveSefaz { get; set; }
        public string FlgStatusNota { get; set; }
        public Nullable<int> CodTipoVenda { get; set; }
        public Nullable<int> CodCliente { get; set; }
		public string NumProtocolo { get; set; }
		public virtual tbl_TipoVenda tbl_TipoVenda { get; set; }
        public virtual ICollection<tbl_SaidaItens> tbl_SaidaItens { get; set; }
    }
}
