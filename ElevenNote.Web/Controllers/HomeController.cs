using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Grant()
        {
            ViewBag.Message = "Grant's view.";

            return View();
        }

        public ActionResult Houck()
        {
            ViewBag.Message = "Houck's view.";

            return View();
        }

        public ActionResult FizzBuzz()
        {
            ViewBag.Message = "FizBuzz View";

            return View();
        }
    }
}