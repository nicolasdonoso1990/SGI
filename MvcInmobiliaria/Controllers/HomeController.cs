using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInmobiliaria.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de esta versión.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ante cualquier duda con la operación del sistema, comuníquese.";

            return View();
        }   
        
    }
    
}
