using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new int[] { 30,40,50,60,70,80};

            //return View(model);
            //return View("About",model);
            return View("Contact", model);
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
    }
}