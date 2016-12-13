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
        
        // GET: Product
        public ActionResult Index()
        {
            return View(vw);
        }
    //    [HttpPost]
        public ActionResult Details(int? Productid)
        {

            var pros = vw.product.Where(o => o.Pro_id == Productid).FirstOrDefault();

            if (pros == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(pros);
            }
        }

    }
}