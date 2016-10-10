using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web0._1.Models;

namespace web0._1.Controllers
{
    public class ProductController : Controller
    {
        ViewModel vw = new ViewModel();
        Products[] pro = new Products[9]; 
        // GET: Product
        public ActionResult Index()
        {
            vw.names(pro);
            
            return View(vw);
        }
        
    }
}