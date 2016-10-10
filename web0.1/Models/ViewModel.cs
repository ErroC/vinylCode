using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class ViewModel
    {
       // Products[] products = new Products[9];
        List<Products> value = new List<Products>();

        public void names(Products[] product)
        {
            /*Products[] product = new Products[9]*/;
            for (int i = 0; i < 9; i++)
            {
                product[i] = new Products();
            } 

            
            string[] name = new string[] { "Mac1", "Mac2", "Mac3", "image1", "Mac 0.1", "Pro Mac", "Mac 0", "Sticker", "Mac5" };
            decimal[] price = new decimal[] { 1500, 1600, 1200, 150, 1000, 8000, 999, 150, 950 };
            string[] Desc = new string[] { "This has a 4gig ram memory", "LCD high display and power saver", "20 gig RAM for gamers and extra fans", "Glow in the dark", "high display is power saving", "new high tec display with 3D effects", "bulid in monitor and speakers", "glow in the dark with street art", "Built in eqiupment " };
            string[] imagename = new string[] { "d1.jpg", "d2.jpg", "d3.jpg", "d4.jpg", "d5.jpg", "d6.jpg", "d7.jpg", "d8.jpg", "d9.jpg" };
            for (int i = 0; i < 9; i++)
            {
                product[i].ProductName = name[i];
                product[i].ProductDesc = Desc[i];
                product[i].image = imagename[i];
                product[i].ProductPrice = price[i];
                value.Add(product[i]);

            }
        }

        public List<Products> GetValues()
        {
            return value;
        }



    }

   
}