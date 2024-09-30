using System.Web.Mvc;
using MVC7.Models; 

namespace MVC7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View(new Login());
        }

        [HttpPost]
        public ActionResult ContactUs(Login data)
        {
            if (ModelState.IsValid)
            {
                if (data.UserName == "Btps@gmail.com" && data.Password == "123")
                {
                    ViewBag.Message = "Login successful!";
                }
                else
                {
                    ViewBag.Error = "Login not successful!";
                }
            }
            return View(data);
        }
    }
}
