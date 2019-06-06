using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        TTWebsiteEntities db = new TTWebsiteEntities();
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

        public ActionResult GetCategories()
        {
            var result = from item in db.Categories where item.Hide == false orderby item.Position select item;
            return PartialView(result.ToList());
        }

        public ActionResult GetHotProducts()
        {
            var result = from item in db.Products where item
        }
    }
}