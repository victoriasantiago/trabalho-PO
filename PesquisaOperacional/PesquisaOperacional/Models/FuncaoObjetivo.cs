using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaOperacional.Models
{
    public class FuncaoObjetivo
    {
        public string Tipo { get; set; } // define se é de maximização ou minimização
        public float Coeficiente1 { get; set; }
        public float Coeficiente2 { get; set; }

    }
}