using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jackstore.Controllers
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
        public ActionResult Masterlayout() 
        {
            return View();
        }
        public ActionResult Produce()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Dangky()
        {
            return View();
        }
        public ActionResult Timlaimk ()
        {
            return View();
        }
        public ActionResult giohang()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }

    }
}