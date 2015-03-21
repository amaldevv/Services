using NorthwindAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            NorthwindEntities entities = new NorthwindEntities();
            entities.Configuration.ProxyCreationEnabled = false;
            var categories = from r in entities.Categories select r;
            return categories.ToList();
        }
    }
}