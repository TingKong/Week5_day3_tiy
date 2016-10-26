using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace htmlToNet.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index(string name = "Ting", int id = 1)
        {
            ViewBag.Name = name;
            ViewBag.ID = id;

            return View();
        }
    }
}