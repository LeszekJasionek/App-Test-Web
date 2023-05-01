using App_Test_Web.Models;
using App_Test_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public ProductController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

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
            var productList = _warehouseService.GetAll();

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
