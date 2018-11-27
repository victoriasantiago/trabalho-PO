using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaOperacional.Models
{
    public class Resultado
    {
        public Resultado(List<Tuple<float, float>> pontos, Tuple<float, float> pontoOtimo, float resultadoFinal, string tipoFuncao)
        {
            EixoX = new List<float>();
            EixoY = new List<float>();
            foreach(var item in pontos)
            {
                EixoX.Add(item.Item1);
                EixoY.Add(item.Item2);
            }

            this.PontoOtimo = pontoOtimo;
            this.ResultadoFinal = resultadoFinal;
            this.TipoFuncao = tipoFuncao;
        }

        public List<float> EixoX { get; set; }
        public List<float> EixoY { get; set; }
        public Tuple<float, float> PontoOtimo { get; set; }
        public float ResultadoFinal { get; set; }
        public string TipoFuncao { get; set; }
    }
}