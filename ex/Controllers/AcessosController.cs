using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex.Controllers
{
    public class AcessosController : Controller
    {
        // GET: Acessos
        public ActionResult Index()
        {
            return View();
        }

        // localhost:13176/Acessos/Detalhe?name=Nuno&num=5
        public ActionResult Detalhe(string name, int num = 1)
        {
            ViewBag.UserName = name;
            ViewBag.NumTimes = num;
            return View();
        }
    }
}