using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaOperacional.Models
{
    public class Restricao
    {
        public float VariavelDeDecisao1 { get; set; }
        public float VariavelDeDecisao2 { get; set; }
        public float ValorRestricao { get; set; }
        public string Sinal { get; set; }
    }
}