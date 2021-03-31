using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class OfferService
    {
        public OfferService()
        {
            setProducts();
        }
        public List<Product> Inventory { get; set; }

        
        private void setProducts()
        {

            List<Product> Products = new List<Product>()
            {
                new Product{ProductName="p1",Price=1000,Description="P1Desc"},
                new Product{ProductName="p2",Description="P2Desc",Price=200},
                new Product{ProductName="p3",Description="P3Desc",Price=400},
                new Product{ProductName="p4",Description="P4Desc",Price=700},
                new Product{ProductName="p5",Description="P5Desc",Price=600},
                new Product{ProductName="p6",Description="P6Desc",Price=800}
            };
            this.Inventory = new List<Product>();
            this.Inventory.AddRange(Products);
        }

       public List<Product> GetTodaysOffers()
        {

            Random rand = new Random();
            List<Product> Products = new List<Product>()
            {

                new Product{ProductName= rand.NextDouble()+"p1",Price=1000,Description="P1Desc"},
                new Product{ProductName= rand.NextDouble()+"p2",Description="P2Desc",Price=200},
                new Product{ProductName= rand.NextDouble()+"p3",Description="P3Desc",Price=400},
               
            };
            return Products;
        }

    }
}
