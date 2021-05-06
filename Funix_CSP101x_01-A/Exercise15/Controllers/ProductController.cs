using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Exercise15.Models;

namespace Exercise15.Controllers {
    public class ProductController : Controller {
        public IActionResult Index() {
            var vm = new ProductListVM();
            vm.Discount = new Discount { Start = DateTime.Today, End = DateTime.Today.AddDays(30), Rate = 0.75 };
            vm.Products = new List<Product>();
            vm.Products.Add(new Product { ID = 101, Name = "Book", Price = 20 });
            vm.Products.Add(new Product { ID = 102, Name = "Bike", Price = 30 });
            vm.Products.Add(new Product { ID = 103, Name = "Fireworks", Price = 40 });
            return View("ProductList", vm);
        }
    }
}