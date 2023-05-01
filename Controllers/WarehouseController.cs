using App_Test_Web.Models;
using App_Test_Web.Services;
using App_Test_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
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

            return RedirectToAction("Add");
        }

    }
}
