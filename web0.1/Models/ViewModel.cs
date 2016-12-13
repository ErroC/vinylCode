using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class ViewModel
    {
        public List<Products> product = new List<Products>();
        public Items item = new Items();
        public ViewModel()
        {

            product.Add(new Products() { Pro_id = 1, Pro_Name = "Mac1", Pro_desc = "This has a 4gig ram memory", Pro_price = 1500, Image_name = "d1.jpg" });
            product.Add(new Products() { Pro_id = 2, Pro_Name = "Mac2", Pro_desc = "LCD high display and power saver", Pro_price = 1600, Image_name = "d2.jpg" });
            product.Add(new Products() { Pro_id = 3, Pro_Name = "Mac3", Pro_desc = "20 gig RAM for gamers and extra fans", Pro_price = 1200, Image_name = "d3.jpg" });
            product.Add(new Products() { Pro_id = 4, Pro_Name = "image1", Pro_desc = "Glow in the dark", Pro_price = 150, Image_name = "d4.jpg" });
            product.Add(new Products() { Pro_id = 5, Pro_Name = "Mac 0.1", Pro_desc = "high display is power saving", Pro_price = 1000, Image_name = "d5.jpg" });
            product.Add(new Products() { Pro_id = 6, Pro_Name = "Pro Mac", Pro_desc = "new high tec display with 3D effects", Pro_price = 8000, Image_name = "d6.jpg" });
            product.Add(new Products() { Pro_id = 7, Pro_Name = "Mac 0", Pro_desc = "bulid in monitor and speakers", Pro_price = 999, Image_name = "d7.jpg" });
            product.Add(new Products() { Pro_id = 8, Pro_Name = "Sticker", Pro_desc = "glow in the dark with street art", Pro_price = 150, Image_name = "d8.jpg" });
            product.Add(new Products() { Pro_id = 9, Pro_Name = "Mac5", Pro_desc = "Built in eqiupment", Pro_price = 950, Image_name = "d9.jpg" });
        }

        public void CreateProduct(Products pro)
        {
            product.Add(pro);
        }
        public void RemoveProduct(int id)
        {
            Products pro = product.Where(o => o.Pro_id == id).FirstOrDefault();
            product.Remove(pro);
        }
    }

   
}