using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaViewData.Models
{
    public class Produto
    {
        public int prodId { get; set; }
        public string prodNome { get; set; }
        public decimal prodValor { get; set; }
        public ushort prodQtd { get; set; }
    }
}