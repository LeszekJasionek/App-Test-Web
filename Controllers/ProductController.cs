using App_Test_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "Cars",
                Description = "It's a great car",
                Name = "Audi"
            };

            return View(product);

        }

        public IActionResult List()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Category = "Cars",
                    Description = "It's a great car",
                    Name = "Audi"
                },
                new Product
                {
                    Id = 2,
                    Category = "Drinks",
                    Description = "It's very good",
                    Name = "PEPSI"
                },
                new Product
                {
                    Id = 3,
                    Category = "Plants",
                    Description = "Very popular plant",
                    Name = "Cactus"
                }
            };

            return View(productList);
        }

        public IActionResult Data()
        {
            ViewBag.Name = "Leszek";
            ViewData["Surname"] = "Jasionek";
            TempData["SecondName"] = "Piotr";


            return View();
        }

    }
}
