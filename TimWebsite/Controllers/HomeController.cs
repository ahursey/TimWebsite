using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CV()
        {
            ViewBag.Message = "Curriculum Vitae";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }

        public ActionResult Research()
        {
            ViewBag.Message = "My Research";

            return View();
        }
    }
}