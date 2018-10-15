using ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex.Controllers
{
    public class AcessosAoSistemaController : Controller
    {
        // GET: AcessosAoSistema
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalhe(string name = "Utilizador", int num = 1)
        {
            AcessosAoSistema m = new AcessosAoSistema(name, num);
            return View(m);
        }
    }
}