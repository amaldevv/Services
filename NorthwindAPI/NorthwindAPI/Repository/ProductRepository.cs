using NorthwindAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
    

        public IEnumerable<Product> GetProducts()
        {
            NorthwindEntities entities = new NorthwindEntities();
            entities.Configuration.ProxyCreationEnabled = false;
            var products = from r in entities.Products select r;
            return products.ToList();
        }

        public bool AddProduct(Product p)
        {
            try
            {
                NorthwindEntities entities = new NorthwindEntities();
                entities.Products.Add(p);
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool UpdateProduct(Product p)
        {
            try
            {
                NorthwindEntities entities = new NorthwindEntities();
                Product proudctToUpdate = (from r in entities.Products
                                           where
                                               r.ProductID == p.ProductID
                                           select r).FirstOrDefault();

                proudctToUpdate.ProductName = p.ProductName;
                proudctToUpdate.UnitPrice = p.UnitPrice;
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteProduct(int productID)
        {
            try
            {
                NorthwindEntities entities = new NorthwindEntities();
                Product proudctToDelete = (from r in entities.Products
                                           where
                                               r.ProductID == productID
                                           select r).FirstOrDefault();
                entities.Products.Remove(proudctToDelete);
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}