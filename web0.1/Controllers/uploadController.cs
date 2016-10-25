using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web0._1.Models;

namespace web0._1.Controllers
{
    public class uploadController : Controller
    {
        // GET: upload
        public ActionResult upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload(upload mRegister)
        {
            //Check server side validation using data annotation
            if (ModelState.IsValid)
            {
                //TO:DO
                var fileName = Path.GetFileName(mRegister.file.FileName);
                var path = Path.Combine(Server.MapPath("~/images"), fileName);
                mRegister.file.SaveAs(path);
                ViewBag.Message = "File has been uploaded successfully";
                ModelState.Clear();
            }
            return View("upload");
        }
    }
}