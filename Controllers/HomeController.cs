using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Current MVC Version : " + typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public ActionResult GetCountrys()
        {
            ViewBag.Countrys= new List<string>() { "India", "UK", "US", "Canada" };

            ViewData["States"] = new List<string>() { "Gujarat", "UP", "MP", "GOA" };

            return View();
        }
    }
}