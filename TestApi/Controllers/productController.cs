using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class productController : ApiController
    {

        [HttpGet]
        public List<Product> GetTodaysoffers()
        {

            OfferService obj = new OfferService();

          return  obj.GetTodaysOffers();
        }
        [HttpGet]
        public List<Product> GetAllProducts()
        {

            OfferService obj = new OfferService();

            var res = obj.Inventory.OrderBy(x => x.Price).Take(3);
            return res.ToList();
        }

        [HttpGet]
        public List<Product> GetSecondowestPriceProduct()
        {

            OfferService obj = new OfferService();

            var res = obj.Inventory.OrderBy(x => x.Price).Take(2);
            return res.ToList(); 
        }

        [HttpPost]
        public void UpdateProduct()
        {

            OfferService obj = new OfferService();

            Product newProduct = new Product();
            newProduct.ProductName = "NewProd";
            newProduct.Price = 200;
            newProduct.Description = "NewProdDesc";
            obj.Inventory.Add(newProduct);
           
        }

    }
}
