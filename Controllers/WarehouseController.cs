using App_Test_Web.Models;
using App_Test_Web.Services;
using App_Test_Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
    [Authorize]
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }

            var id = _warehouseService.Save(body);

            ViewData["ProductId"] = id;
            TempData["ProductId"] = id;

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var products = _warehouseService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var productId = _warehouseService.GetSingle(id);
            return View(productId);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _warehouseService.Delete(id);
            return RedirectToAction("List");
        }


    }
}
