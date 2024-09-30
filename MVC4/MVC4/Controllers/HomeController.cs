using MVC4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DBInsert data)
        {
            Database database = new Database();
            if (data != null)
            {
                int result = database.DataInsert(data);
                ViewBag.info = "Data Insertedd Successfully ";
                if (result > 0)
                {
                    return RedirectToAction("SelectAllData");
                }
            }
            return View();
        }
        public ActionResult SelectAllData()
        {
            Database database = new Database();
            var data = database.SelectAllData();
            return View(data);
        }

        public ActionResult GetData(int id)
        {
            Database database = new Database();
            var data = database.SelectData(id);
            if (data == null)
            {
                return HttpNotFound("Data not found");
            }

            return View(data);
        }

        public ActionResult UpdateData(int id)
        {
            Database database = new Database();
            var data = database.SelectData(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult UpdateData(DBInsert newUpdatedData)
        {
            Database database = new Database();
            var result = database.UpdateData(newUpdatedData);
            if (result > 0)
                return RedirectToAction("SelectAllData");
            return View();
        }
        public ActionResult DeleteData(int id)
        {
            Database database = new Database();
            var result = database.DeleteData(id);
            return RedirectToAction("SelectAllData");
        }
            public ActionResult Email()
        {
            return View();
        }
    }
}
