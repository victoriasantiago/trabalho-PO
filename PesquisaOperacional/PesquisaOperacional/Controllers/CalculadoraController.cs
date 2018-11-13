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

        public ActionResult ProgLinear(FuncaoObjetivo funcao, List<Restricao> restricoes)
        {
            List<Tuple<float, float>> pontos = new List<Tuple<float, float>>();
            List<float> resultados = new List<float>();

            foreach(Restricao item in restricoes)
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

            foreach(var ponto in pontos)
            {
                resultados.Add(funcao.Coeficiente1 * ponto.Item1 + funcao.Coeficiente2 * ponto.Item2);
            }
            if (funcao.Tipo.Equals("MAX"))
            {
                float resultadoFinal = resultados.Max();
                Tuple<float, float> pontoOtimo = pontos[resultados.IndexOf(resultados.Max())];
            }
            else
            {
                float resultadoFinal = resultados.Min();
                Tuple<float, float> pontoOtimo = pontos[resultados.IndexOf(resultados.Min())];
            }
            return View();

        }
    }
}