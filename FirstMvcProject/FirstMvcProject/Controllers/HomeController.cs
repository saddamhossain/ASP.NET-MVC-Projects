using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public string Saddam()
        {
            return "This is Saddam method under Home controller . ha ha ha ";
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
