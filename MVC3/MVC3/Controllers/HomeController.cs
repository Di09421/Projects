using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            var data = new Student()
            {
                Name = "BTPS",
                Age = 20,
                Phone = "1212121212",
                IsPass = true,
            };
            return View(data);
        }
       
    }
}