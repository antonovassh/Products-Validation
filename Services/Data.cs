using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsValidation.Models;

namespace ProductsValidation.Services
{
    public class Data
    {
        public List<Product> Products = new List<Product>
        {
            new Product { Id = 1,Type= Product.Category.Technique, Name = "Laptop", Description = "High-performance laptop with fast processor.", Price = 999.99m,  },
            new Product { Id = 2,Type= Product.Category.Technique, Name = "Smartphone", Description = "Latest smartphone with advanced features.", Price = 699.99m,},
            new Product { Id = 3,Type= Product.Category.Technique, Name = "Headphones", Description = "Wireless headphones with noise-cancellation.", Price = 149.99m,},
            new Product { Id = 4,Type= Product.Category.Technique, Name = "Tablet", Description = "10-inch tablet with high-resolution display.", Price = 299.99m, },
            new Product { Id = 5,Type= Product.Category.Technique, Name = "Camera", Description = "Digital camera with 20MP sensor and zoom lens.", Price = 399.99m, },
            new Product { Id = 6,Type= Product.Category.Technique, Name = "Monitor", Description = "27-inch HD monitor for home or office.", Price = 199.99m,},
            new Product { Id = 7,Type= Product.Category.Technique, Name = "Keyboard", Description = "Wireless keyboard with backlight.", Price = 49.99m,  },
            new Product { Id = 8,Type= Product.Category.Technique, Name = "Mouse", Description = "High-precision optical mouse.", Price = 19.99m,},
            new Product { Id = 9,Type= Product.Category.Technique, Name = "Printer", Description = "Color laser printer with Wi-Fi.", Price = 299.99m,},
        };

        public List<User> Users = new List<User>
        {
            new User() {Id = 0, Name = "UserAdmin", Email = "admin@gmail.com", Role = "admin"},
            new User() {Id = 0, Name = "Guest", Email = "guest@gmail.com", Role = "guest"},
            new User() {Id = 0, Name = "User", Email = "user1@gmail.com", Role = "user"},
            new User() {Id = 0, Name = "User2", Email = "user2@gmail.com", Role = "user"},

        };
    }
}
