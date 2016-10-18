using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            // vw.Getvaule(1,pro); 
            //vw.Valuestest(1); 
            vw.names(pro);
            vw.GetValues();
          
            return View(vw);
        }

        //public ActionResult Details(int? id)
        //{
        //    if (id==null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    if (pro[id].ProductId==null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View();
        //}
        
    }
}