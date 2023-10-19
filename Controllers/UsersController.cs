using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ProductsValidation.Models;
using ProductsValidation.Services;

namespace ProductsValidation.Controllers
{
    public class UsersController : Controller
    {
        private List<User> users;

        public UsersController(Data data)
        {
            users = data.Users;
        }
        
        public IActionResult Index(string id)
        {
            return View("Index", users);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            users.Add(user);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(string name)
        {
            var user = users.Find(user => user.Name == name);
            return View(user);
        }

    }
}
