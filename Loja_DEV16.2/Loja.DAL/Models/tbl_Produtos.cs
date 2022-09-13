using System;
using System.Collections.Generic;

namespace Loja.DAL.Models
{
    public partial class tbl_Produtos
    {
        public tbl_Produtos()
        {
            this.tbl_SaidaItens = new List<tbl_SaidaItens>();
        }

        public string CodProduto { get; set; }
        public string DesProduto { get; set; }
        public string DesLocal { get; set; }
        public Nullable<double> VlrUnitario { get; set; }
        public Nullable<double> QtdProduto { get; set; }
        public Nullable<double> VlrCusto { get; set; }
        public Nullable<double> VlrPercent { get; set; }
        public Nullable<double> EstMinimo { get; set; }
        public string DatCadastro { get; set; }
        public string DesFornecedor { get; set; }
        public string CodRefAntiga { get; set; }
        public Nullable<double> DesFaz { get; set; }
        public Nullable<double> VlrUltPreco { get; set; }
        public byte[] Imagem { get; set; }
        public int codigounico { get; set; }
        public string NCM { get; set; }
        public Nullable<double> VlrICMSST { get; set; }
        public virtual ICollection<tbl_SaidaItens> tbl_SaidaItens { get; set; }
    }
}
