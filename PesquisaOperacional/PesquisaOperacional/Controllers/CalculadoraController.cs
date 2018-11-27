using PesquisaOperacional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesquisaOperacional.Controllers
{
    public class CalculadoraController : Controller
    {

        public CalculadoraController()
        {

        }

        public ActionResult ProgLinear(Problema problema)
        {
            List<Tuple<float, float>> pontos = new List<Tuple<float, float>>();
            List<float> resultados = new List<float>();
            float resultadoFinal = new float();
            Tuple<float, float> pontoOtimo = new Tuple<float, float>(0, 0);

            foreach (Restricao item in problema.Restricoes)
            { 
                if (item.VariavelDeDecisao1 == 0)
                {
                    pontos.Add(new Tuple<float, float>(item.VariavelDeDecisao1, item.ValorRestricao));
                }
                else if (item.VariavelDeDecisao2 == 0)
                {
                    pontos.Add(new Tuple<float, float>(item.ValorRestricao, item.VariavelDeDecisao2));
                }
                else
                {
                    pontos.Add(new Tuple<float, float>(item.ValorRestricao, 0));
                    pontos.Add(new Tuple<float, float>(0, item.ValorRestricao));
                }

            }
            pontos.Add(
                new Tuple<float, float>(
                    pontos.Where(a => a.Item1 == pontos.Max(abc => abc.Item1)).First().Item1,
                    pontos.Where(a => a.Item2 == pontos.Max(cba => cba.Item2)).First().Item2));

            //}

            foreach (var ponto in pontos)
            {
                resultados.Add(problema.Funcao.Coeficiente1 * ponto.Item1 + problema.Funcao.Coeficiente2 * ponto.Item2);
            }
            if (problema.Funcao.Tipo.Equals("MAX"))
            {
                resultadoFinal = resultados.Max();
                pontoOtimo = pontos[resultados.IndexOf(resultados.Max())];
            }
            else
            {
                resultadoFinal = resultados.Min();
                pontoOtimo = pontos[resultados.IndexOf(resultados.Min())];
            }
            return View("ResultadoView", new Resultado(pontos, pontoOtimo, resultadoFinal, problema.Funcao.Tipo) );

        }

        public void AddRestricao(Problema problema)
        {
            Restricao itemNovo = new Restricao();
            problema.Restricoes.Add(itemNovo);
        }
    }
}