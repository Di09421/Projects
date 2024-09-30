using mvcvalid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcvalid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ManualValidation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidBtps(student data)
        {
            if (ModelState.IsValid)
            {
                return View();

            }
            return View("ManualValidation");
        }
    }
}