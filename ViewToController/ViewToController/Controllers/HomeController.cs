using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewToController.Models;


namespace ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            if (userName == "Btps" && password == "1234")
            {
                return View();
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult LoginByFormCollection(FormCollection data)
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginByModel(Login data)
        {
            string userName = data.UserName;
            string password = data.Password;

            DBwork dBwork = new DBwork();
            int result = dBwork.LoginDtlsInsert(userName, password);
            if (result == 1)
            {
                ViewBag.Result = "Success";
            }
            else
            {
                ViewBag.Result = "Error";
            }
            return View();
        }
       [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // Handle Registration Post
        [HttpPost]
        public ActionResult Register(Register data)
        {
            if (ModelState.IsValid)
            {
                if (data.Password == data.ConfirmPassword)
                {
                    UserRegister UR = new UserRegister();
                    int result = UR.RegisterDtlsInsert(data.Name, data.Email, data.Phone, data.Address, data.City, data.State, data.Country, data.ZipCode, data.Password, data.ConfirmPassword);

                    ViewBag.Result = result > 0 ? "Registration Successful" : "Error during registration";
                }
                else
                {
                    ViewBag.Result = "Passwords do not match";
                }
            }
            return View(data);
        }

        // Display Edit Form
        [HttpGet]
        public ActionResult EditProfile()
        {
           
            return View();
        }

        // Handle Edit Post
        [HttpPost]
        public ActionResult EditProfile(Register data)
        {
            if (ModelState.IsValid)
            {
                if (data.Password == data.ConfirmPassword)
                {
                    UserRegister userRegister = new UserRegister();
                    int result = userRegister.UpdateProfile(data.id, data.Name, data.Email, data.Phone, data.Address, data.City, data.State, data.Country, data.ZipCode, data.Password, data.ConfirmPassword);

                    ViewBag.Message = result > 0 ? "Profile updated successfully!" : "Error updating profile.";
                    return RedirectToAction("Profile");
                }
                else
                {
                    ViewBag.Message = "Passwords do not match.";
                }
            }
            return View(data);
        }

        // Delete Profile
        [HttpGet]
        // Display Edit Form
       
        public ActionResult DeleteProfile()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult DeleteProfile(Register data)
        {
            UserRegister userRegister = new UserRegister();
            int result = userRegister.DeleteProfile(data.id);

            ViewBag.Message = result > 0 ? "Profile deleted successfully!" : "Error deleting profile.";
            return RedirectToAction("Index");
        }

        // List All Users
        [HttpGet]
        public ActionResult ListUsers()
        {
            UserRegister userRegister = new UserRegister();
            List<Register> users = userRegister.GetAllUsers();
            return View(users);
        }
    }
}
   
        


   


   