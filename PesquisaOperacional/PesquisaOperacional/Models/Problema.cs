using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaOperacional.Models
{
    public class Problema
    {
        public Problema()
        {
            Restricoes = new List<Restricao>();

        }
        public Problema(Restricao item1, Restricao item2, Restricao item3) : this()
        {
            

            Restricoes.Add(item1);
            Restricoes.Add(item2);
            Restricoes.Add(item3);

        }

        public FuncaoObjetivo Funcao { get; set; }
        public List<Restricao> Restricoes { get; set; }

    }
}