using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class hometController : Controller
    {
        // GET: homet
        public ActionResult Index()
        {
            TempData["U1"] = "User1";
            return View();
        }

        public ActionResult About()
        {
            var userCount = TempData["U1"];
            TempData.Keep("U1");
            ViewBag.userCount = userCount;
            return View();
        }

        public ActionResult Contact()
        {
            var userCount = TempData.Peek("U1");
            ViewBag.userCount = userCount;
            return View();
        }

        //using Model

        public ActionResult StudentInfo()
        {
            var data = StudentData();
            return View(data);
        }
        public Student StudentData()
        {
            //string qry = $"select * from tableName where id = {id}";
         
            return new Student()
            {
                Name = "BTPS",
                Age = "20",
                Phone = "65456456456"
            };
            //Student student = new Student();
            //student.Name = "BTPS";
            //student.Age = "20";
            //student.Phone = "111111111";
            //return student;

        }
        public ActionResult InlineHtmlHelper()
        {
            return View();
        }

    }
}


