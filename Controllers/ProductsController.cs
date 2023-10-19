using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProductsValidation.Interfaces;
using ProductsValidation.Models;
using ProductsValidation.Services;
using ProductsValidation.ViewModels;

namespace ProductsValidation.Controllers
{
    
    public class ProductsController : Controller
    {
        private List<Product> myProducts;
        private readonly IProductService _productService;

        public ProductsController(Data data , IProductService productService)
        {
            myProducts = data.Products;
            _productService = productService;
        }
        
        public IActionResult Index(int filterId, string filtername)
        {
            return View(myProducts);
        }
        
        public IActionResult View(int id)
        {
            Product prod = myProducts.Find(prod => prod.Id == id);
            if (prod != null)
            {
                return View(prod);
            }

            return View("NotExists");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prod = myProducts.Find(prod => prod.Id == id);
            if (prod != null)
            {
                return View(prod);
            }

            return View("NotExists");
        } 
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            myProducts[myProducts.FindIndex(prod => prod.Id == product.Id)] = product;
            return View(product);
        }

        [HttpGet]
        public IActionResult EditAllCategory(Product.Category selectedCategory)
        {
            var productsInCategory = _productService.GetProductsByCategory(selectedCategory);

            var viewModel = productsInCategory.Select(product => new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
            }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SavePrices(List<ProductViewModel> products)
        {
            if (ModelState.IsValid)
            {
                foreach (var productViewModel in products)
                {
                    var product = _productService.GetProductById(productViewModel.Id);
                    if (product != null)
                    {
                        product.Price = productViewModel.Price;
                        product.Description = productViewModel.Description;
                    }
                }

                return RedirectToAction("Index");
            }
            return View("EditAllCategory", products);
        }


        [HttpPost]
        public ActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                int newId = myProducts.Max(p => p.Id) + 1;
                var newProduct = new Product
                {
                    Id = newId,
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price,
                    Type = model.Type
                };

                myProducts.Add(newProduct);
                return RedirectToAction("View", new { id = newId });
            }
            model.CategoryList = new SelectList(Enum.GetValues(typeof(Product.Category)));
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new ProductViewModel
            {
                CategoryList = new SelectList(Enum.GetValues(typeof(Product.Category))),
            };

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            myProducts.Remove( myProducts.Find(product => product.Id == id));
            return View("Index", myProducts);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
