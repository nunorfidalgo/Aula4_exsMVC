using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex.Controllers
{
    public class OlaController : Controller
    {
        // GET: Ola
        //public string Index()
        public ActionResult Index()
        {
            //return "This is the ola controller..."; // View();
            return Content("This is the OlaController <b> default </b> action...(Ola/Index)");
        }
        // GET: /Ola/Welcome
        //public string Welcome()
        public ContentResult Welcome()
        {
            //return "This is the Welcome action method (Ola/Method)...";
            return Content("This is the Welcome action method (Ola/Method)...");
        }
    }
}