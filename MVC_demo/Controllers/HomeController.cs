using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_demo.Controllers
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
        //my first mvc knockoutJS
        public ActionResult First()
        {
            return View();
        }
        //监控属性
        public ActionResult Second()
        {
            return View();
        }

        public ActionResult Third()
        {
            return View();
        }

        public ActionResult Four()
        {
            return View();
        }

        public ActionResult Fifth()
        {
            return View();
        }
    }
}