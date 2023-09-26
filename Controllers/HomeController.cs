using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShip.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Ship - Manage Your Ship's Database Today.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Author.";

            return View();
        }
    }
}