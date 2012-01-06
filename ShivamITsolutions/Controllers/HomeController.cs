using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShivamITsolutions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "SHIVAM Consultancy and IT Services Pvt. Ltd.";

            return View();
        }
        
    }
}
