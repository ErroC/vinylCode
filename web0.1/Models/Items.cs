using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class Items
    {
        private Products product = new Products();
        private int quantity;

        public Products Product
        {
            get
            { return product; }

            set
            { product = value;}
        }

        public int Quantity
        {
            get
            { return quantity;}

            set
            {  quantity = value;}
        }

        public Items()
        { }

        public Items(Products pro,int q)
        {
            quantity = q;
            product = pro;
        }
    }
}