using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaViewData.Models
{
    public class Venda
    {
        public int vendaId { get; set; }
        public string vendaData { get; set; }
        public decimal vendaTotal { get; set; }
    }
}