using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveImage(string name, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var filename = file.FileName;
                var extension=Path.GetExtension(filename);
                if(extension ==".jpg" || extension==".png")
                {
                    var minImgSize = 5 * 1024 * 1024;
                    if(minImgSize >= file.ContentLength)
                    {
                        var folderPath = Server.MapPath("~/Content/Img/");
                        var filePath = folderPath + filename;
                        var demoPath=Path.Combine(folderPath, filePath);
                        file.SaveAs(filePath);
                        Insert insert = new Insert();
                        string resultMessage = insert.Img(name, filePath);
                        ViewBag.Message = resultMessage;

                        ViewBag.ImgName = filename;
                        ViewBag.successmsg = "Image uploaded successfully!";
                    }
                    else
                    {
                        ViewBag.errormsg = "Please Upload minimum 5 Mb Image";
                    }
                }
                else
                {
                    ViewBag.errormsg = "Please Upload jpg or png Image";
                }
            }
            else
            {
                ViewBag.errormsg = "No file selected. Please choose an image to upload.";
            }
            return View("SaveImage");
        }
    }
}
