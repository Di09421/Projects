using MVC8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC8.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User data)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                int result = db.RegisterUser(data);
                if (result > 0)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            Database db = new Database();
            var loggedInUser = db.LoginUser(user.Name, user.Password);

            if (loggedInUser != null)
            {
                FormsAuthentication.SetAuthCookie(loggedInUser.Email, false);
                return RedirectToAction("SecurePage", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid credentials";
                return View(user);
            }
        }

        [Authorize]
        public ActionResult SecurePage()
        {
            var userEmail = User.Identity.Name;
            ViewBag.UserEmail = userEmail;
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
