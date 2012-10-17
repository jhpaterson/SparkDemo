using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparkDemo.Models;

namespace SparkDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.Products = new List<Product>{
                new Product{ProductID=1,ProductName="Banana",Description="Yellow",Price=9.99M},
                new Product{ProductID=2,ProductName="Apple",Description="Green",Price=9.99M},
                new Product{ProductID=3,ProductName="Orange",Description="Blue",Price=9.99M}
            };

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
