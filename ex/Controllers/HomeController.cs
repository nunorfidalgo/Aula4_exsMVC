using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index() //public ActionResult Index()
        {
            return "<br>(Home/Index)<br><h2>This it the MVC 1ª App <b> default </b> action... </h2><br>"; //View();
        }
    }
}