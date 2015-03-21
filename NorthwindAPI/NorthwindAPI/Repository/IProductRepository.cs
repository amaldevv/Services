using NorthwindAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool AddProduct(Product p);
        bool UpdateProduct(Product p);
        bool DeleteProduct(int ProductID);
    }
}
