using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class TestController : Controller
    {// Every method creating within the Controller represents a web page. 

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public string Page1()  // consider it a method is a page/action
        {
            return "<h1>First Page</h1>";
        }

        public string Page2() // consider it a method is a page/action
        {
            return "<h1>Second Page</h1>";
        }

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult AboutPage()
        {
            ViewBag.info = "This is About Us Page info getting from controller";
            return View();
        }

        public ActionResult ContactPage()
        {
            return View();
        }

    }
}