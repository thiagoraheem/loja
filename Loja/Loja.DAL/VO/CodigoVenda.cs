using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Loja.DAL.VO
{
    public class CodigoVenda
    {
        [Key]
        public int CodVenda { get; set; }
        public int MinVenda { get; set; }
        public int MaxVenda { get; set; }
    }
}
