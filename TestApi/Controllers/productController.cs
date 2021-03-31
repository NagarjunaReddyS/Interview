using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using TestApi.Models;

namespace TestApi.Controllers
{
    


    public class productController : ApiController
    {
        [Route("~/api/GetTodaysoffers")]
        [HttpGet]
        public List<Product> GetTodaysoffers()
        {

            OfferService obj = new OfferService();

          return  obj.GetTodaysOffers();
        }
        [Route("~/api/GetAllProducts")]
        [HttpGet]
        public List<Product> GetAllProducts()
        {

            OfferService obj = new OfferService();

            var res = obj.Inventory.OrderBy(x => x.Price).Take(3);
            return res.ToList();
        }
        [Route("~/api/GetSecondowestPriceProduct")]
        [HttpGet]
        public Product GetSecondowestPriceProduct()
        {
            OfferService obj = new OfferService();
            var res = obj.Inventory.OrderBy(x => x.Price).Take(2);
            var tes=  res.Max(a=>a.Price);
            return res.FirstOrDefault(x => x.Price == tes);

        }
        [Route("~/api/AddNewProduct")]
        [HttpPost]
        public HttpResponseMessage AddNewProduct([FromBody] Product product )
        {
            try
            {

                OfferService obj = new OfferService();
                Product newProduct = new Product();
                newProduct.ProductName = product.ProductName;
                newProduct.Price = product.Price;
                newProduct.Description = product.Description;
                obj.Inventory.Add(newProduct);
                var message = Request.CreateResponse(HttpStatusCode.Created, newProduct);
                message.Headers.Location = new Uri(Request.RequestUri + newProduct.ProductName.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
