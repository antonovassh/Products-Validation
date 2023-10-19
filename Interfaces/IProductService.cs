using ProductsValidation.Models;
using System.Collections.Generic;

namespace ProductsValidation.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(Product.Category category);
        Product GetProductById(int id);
    }
}
