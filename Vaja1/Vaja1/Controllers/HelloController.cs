using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vaja1.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pozdravljen(string ime, int num=1)
        {
            ViewBag.Message = "Pozdravljen " + ime;
            ViewBag.num = num;
            return View();
        }
    }
}