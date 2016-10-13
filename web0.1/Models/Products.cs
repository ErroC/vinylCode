using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public string image { get; set; }
    }
}