using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using NorthwindAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    public class CategoryController : ApiController
    {
        static readonly ICategoryRepository repository = new CategoryRepository();

        // GET: Get Categories 
        [System.Web.Http.HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return repository.GetCategories().ToList();

        }
        /*[System.Web.Http.HttpGet]
        public DataSourceResult GetCategories([DataSourceRequest] DataSourceRequest request)
        {
            return repository.GetCategories().ToList().ToDataSourceResult(request);
        }*/
    }
}
