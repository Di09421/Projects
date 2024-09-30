using MVC4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(DBInsert data)
        {
            if (!ModelState.IsValid || data == null)
            {
                return View(data);
            }

            Database db = new Database();
            var user = db.Login(data);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Name, false);
                return RedirectToAction("SelectAllData", "Home");
            }
            else
            {
                return View(data);
            }
    }
    public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}