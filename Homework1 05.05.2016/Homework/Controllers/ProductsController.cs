using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index()
        {
            return "default";
        }


        public ActionResult Fruits()
        {
            var fruits = new List<string>() { "Apple", "Orange" };
            ViewBag.Fruits = fruits;
            return View();
        }


        public int Vegetables()
        {
            return 5;
        }


        public string Meat()
        {
            return "No meat here";
        }

    }
}