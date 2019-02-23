using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHTMLHelperPageMode.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewIndex()
        {
            ViewBag.PageMode = "View";
            return View("Index");
        }
    }
}