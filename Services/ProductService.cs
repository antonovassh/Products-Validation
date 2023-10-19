using ProductsValidation.Interfaces;
using ProductsValidation.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsValidation.Services
{
    
    public class ProductService : IProductService
    {
        private readonly Data _products;
        public ProductService(Data data)
        {
            _products = data;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products.Products;
        }

        public IEnumerable<Product> GetProductsByCategory(Product.Category category)
        {
            return _products.Products.Where(product => product.Type == category);
        }
        public Product GetProductById(int id)
        {
            return _products.Products.FirstOrDefault(product => product.Id == id);
        }
    }
}
