using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShivamITsolutions.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ Page.";

            return View();
        }

        public ActionResult ManagementTeam()
        {
            ViewBag.Message = "Management Team.";

            return View();
        }

        //

        public ActionResult Testimonials()
        {
            ViewBag.Message = "Testimonials";

            return View();
        }

        public ActionResult Careers()
        {
            ViewBag.Message = "Careers.";

            return View();
        }

        public ActionResult Vision()
        {
            ViewBag.Message = "Our Vision.";

            return View();
        }

        public ActionResult Mission()
        {
            ViewBag.Message = "Our Mission.";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Privacy";

            return View();
        }

        public ActionResult TnC()
        {
            ViewBag.Message = "Terms & Condition.";

            return View();
        }
    }
}
