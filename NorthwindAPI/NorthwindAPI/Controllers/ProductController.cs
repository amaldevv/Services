using NorthwindAPI.Models;
using NorthwindAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http ;
using System.Net.Http;
using Kendo.Mvc;

namespace NorthwindAPI.Controllers
{
    public class ProductController : ApiController
    {
        
        static readonly IProductRepository repository = new ProductRepository();

        // GET: Get Products 
        [System.Web.Http.HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return repository.GetProducts().ToList();
        }



        // POST: Add Product
        [System.Web.Http.HttpPost]
        public HttpResponseMessage AddProduct(Product p)
        {
            
            bool result = repository.AddProduct(p);
            HttpResponseMessage response;
            if (result)
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.Created);
            }
            else
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.ExpectationFailed);

            }
            return response;
        }

        //PUT Update Product
        [System.Web.Http.HttpPut]
        public HttpResponseMessage UpdateProduct(Product p)
        {
            bool result = repository.UpdateProduct(p);
            HttpResponseMessage response;
            if (result)
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.ExpectationFailed);

            }
            return response;

        }

        //PUT Delete Product
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            bool result = repository.DeleteProduct(id);
            HttpResponseMessage response;
            if (result)
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.ExpectationFailed);

            }
            return response;

        }
    }
}