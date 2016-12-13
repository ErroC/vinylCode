using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web0._1.Models;

namespace web0._1.Controllers
{
    public class ItemsController : Controller
    {
        ViewModel vm = new ViewModel();
        Items item = new Items();

        private int isExiting(int id)
        {
            List<Items> cart = ((List<Items>)Session["cart"]);
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Pro_id==id)
                {
                    return i;
                }
            }
            return -1;
        }

        // GET: Items
        public ActionResult Index()
        {
            return View(vm);
        }

        public ActionResult Add(int id)
        {
            Products pro = vm.product.Where(o => o.Pro_id == id).FirstOrDefault();

            if (Session["cart"] == null)
            {
                List<Items> cart = new List<Items>();
                cart.Add(new Items(pro, 1));
                Session["cart"] = cart;
            }
            else {
                int index = isExiting(id);
                List<Items> cart = (List<Items>)Session["cart"];
                if (index == -1)
                {
                    cart.Add(new Items(pro, 1));
                }
                else
                {
                    cart[index].Quantity++;
                }
                Session["cart"] = cart;
            }

            return View("index");
        }

        public ActionResult Delete(int id)
        {
            int index = isExiting(id);
            List<Items> cart = (List<Items>)Session["cart"];
            if (cart.ElementAt(index).Quantity > 1)
            {
                cart.ElementAt(index).Quantity--;
            }
            else {
                cart.RemoveAt(index);
            }
            Session["cart"] = cart;
            return View("index");
        }
    }
}