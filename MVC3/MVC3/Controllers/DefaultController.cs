using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3.Controllers
{
    [RoutePrefix("Default")]
    public class DefaultController : Controller
    {
        [Route("Demo")]
        [Route("Btps")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("About/{id}")]
        public ActionResult About(int id)
        {
            return View();
        }
    }
}