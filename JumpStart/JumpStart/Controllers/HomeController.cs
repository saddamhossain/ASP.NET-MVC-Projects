using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JumpStart.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
          
            ViewBag.Message = "This is index page";

            return View();
        }

        public ActionResult Spaghetti()
        {
            return View();
        }

    }
}
