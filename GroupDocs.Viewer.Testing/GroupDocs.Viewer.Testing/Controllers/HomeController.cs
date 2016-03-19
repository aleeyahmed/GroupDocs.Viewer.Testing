using GroupDocs.Viewer.Examples.CSharp;
using GroupDocs.Viewer.Testing.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GroupDocs.Viewer.Testing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Convert()
        {
            return View();
        }
        [HttpPost]  
        public ActionResult Convert(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {

                string path = Path.Combine(Server.MapPath("~/Content/WordFiles/"),
                                           Path.GetFileName(file.FileName));
                file.SaveAs(path);
                UploadedFiles.myList.Clear();
                ViewGenerator.RenderDocumentAsImages(path);
               
                ViewBag.Message = "File Converted successfully";

            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}