using PesquisaOperacional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PesquisaOperacional.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Restricao item1 = new Restricao();
            Restricao item2 = new Restricao();
            Restricao item3 = new Restricao();
            return View(new Problema(item1, item2, item3));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}