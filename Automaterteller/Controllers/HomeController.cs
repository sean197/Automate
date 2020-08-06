using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Automaterteller.Controllers
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

            return PartialView();

        }

        // Post method activates when we send the form...
        //... tag to the post
        [HttpPost] 
        // Contact method takes in a string parameter
        public ActionResult Contact(string message)
        {
            // TODO: send message to HQ
            ViewBag.Message = "Thanks BRAV.";

            return View();
        }

        public ActionResult Foo()
        {
            ViewBag.Message = "Your contact page.";

            // The about page will open under Foo() method
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCSATM!";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}