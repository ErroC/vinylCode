using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web0._1.Models;

namespace web0._1.Controllers
{
    public class HomeController : Controller
    {
        ViewModel vw = new ViewModel();
      
        // GET: Home
        public ActionResult Index()
        {
           
            return View(vw);
        }

        public ActionResult Contact()
        {
            return View();
        } 

        public ActionResult About_us()
        {
            return View();
        }

    
    }
}