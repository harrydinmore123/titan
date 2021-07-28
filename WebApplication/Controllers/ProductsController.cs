using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickType;

namespace WebApplication.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            using StreamReader r = new StreamReader("data/products.json");
            string jsonString = r.ReadToEnd();
            var welcome = Welcome.FromJson(jsonString);
            ViewData["Welcome"] = welcome;
            return View();
        }

    }
}
