using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
         public Product()
        {

        }
        public Product(string productname, decimal Price , string Description)
        {

            this.Price = Price;
            this.ProductName = productname;
            this.Description = Description;

        }
      
    }
}