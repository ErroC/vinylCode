using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class ViewModel
    {
        List<Products> value = new List<Products>();
        Products[] product=new Products [9];


        
        public string tempname;
        public string tempImage;
        public decimal tempprice;
        public string tempdesc;
        public int tempid;

        string[] name = new string[] { "Mac1", "Mac2", "Mac3", "image1", "Mac 0.1", "Pro Mac", "Mac 0", "Sticker", "Mac5" };
        decimal[] price = new decimal[] { 1500, 1600, 1200, 150, 1000, 8000, 999, 150, 950 };
        string[] Desc = new string[] { "This has a 4gig ram memory", "LCD high display and power saver", "20 gig RAM for gamers and extra fans", "Glow in the dark", "high display is power saving", "new high tec display with 3D effects", "bulid in monitor and speakers", "glow in the dark with street art", "Built in eqiupment " };
        string[] imagename = new string[] { "d1.jpg", "d2.jpg", "d3.jpg", "d4.jpg", "d5.jpg", "d6.jpg", "d7.jpg", "d8.jpg", "d9.jpg" };


        public void names(Products[]  product)

        {
          
            for (int i = 0; i < 9; i++)
            {
                product[i] = new Products();
            }


         
            for (int i = 0; i < 9; i++)
            {
                product[i].ProductId = i;
                product[i].ProductName = name[i];
                product[i].ProductDesc = Desc[i];
                product[i].image = imagename[i];
                product[i].ProductPrice = price[i];

                value.Add(product[i]);
                //Getvaule(i, product);
      

           }
        }

        public List<Products> GetValues()
        {
            return value;
        }

        public object Getvaule(int i, Products[] product)
        {
            return product[i]; 
        }
        //public object  Valuestest(int i)
        //{
            
        //     var testing = value.ElementAt<Products>(i);
        //     tempname=testing.ProductName;
        //    tempImage=testing.image;
        //    tempprice=testing.ProductPrice ;
        //     tempdesc=testing.ProductDesc ;
        //    tempid =testing.ProductId;
        //    return testing;
        //}

        public string GetNames(int i)
        {
            return name[i];
        }

        public string GetDec(int i)
        {
            return Desc[i];
        }

        public decimal GetPrice(int i)
        {
            return price[i];
        }

        public string GetPic(int i)
        {
            return imagename[i]; 
        }

        public void getValuesfor(int i)
        {
            var testing = value.ElementAt<Products>(i);
            tempname = testing.ProductName;
            tempImage = testing.image;
            tempprice = testing.ProductPrice;
            tempdesc = testing.ProductDesc;
            tempid = testing.ProductId;
        }
    }

   
}