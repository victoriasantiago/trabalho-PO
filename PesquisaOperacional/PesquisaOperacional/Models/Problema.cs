using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaOperacional.Models
{
    public class Problema
    {
        public FuncaoObjetivo Funcao { get; set; }
        //public List<Restricao> Restricoes { get; set; }
        public Restricao restricao1 { get; set; }
        public Restricao restricao2 { get; set; }
        public Restricao restricao3 { get; set; }

    }
}