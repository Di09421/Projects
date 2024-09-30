using MVC6.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;

namespace MVC6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public bool GetData(Login data)
        {
            return true;
        }

        public string AjaxCallGet()
        {
            return " AjaxCallGET call ok ";
        }
        [HttpPost]
        public string AjaxCallPost(Login data)
        {
            string username = data.UserName;
            string password= data.Password;
            return $" UserName={username} password={password}";
        }

        public ActionResult JsonClass()
        {
            return View();
        }
        public JsonResult JsonData()
        {
            Student student= new Student()
            {
                Name = "Ram",
                Age = 12,
                Phone="23357876677",
                IsPass=true,
            };

            var json = JsonConvert.SerializeObject(student);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}
