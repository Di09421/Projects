using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        //// GET: Home
        public ActionResult Index()
        {

            ViewBag.UserName = "BTPS";    
            ViewData["Password"] = "12345";
            var userStatus = 0;
            if (userStatus == 1)
            {
                ViewBag.user = "Ok";
            }
            else
            {
                ViewBag.user = "NotOk";
            }

            return View();
        }

        public ActionResult AboutUs()
        {
            TempData["userStatus"] = "block";
            return View();
        }


        public ActionResult Contact()
        {
            try
            {
                var status = TempData["userStatus"];
                if (status != null)
                {
                    if (status.ToString() == "block")
                    {
                        return View("Index");
                    }
                }
                else
                {
                    return View("Index");
                }

                ViewBag.userStatus = TempData["userStatus"];
                return View();
            }
            catch
            {
                throw;
            }

        }


        public string emp(string name)
        {
            return name;
        }

        public string student(string id, string name)
        {
            return $"Id is :{id} and Name is:{name}";
        }

        public string teacher(string id,string name ,string course)
        {
            return $"Id is:{id} , Name is:{name} and Course is:{course}";
        }
    }
}
