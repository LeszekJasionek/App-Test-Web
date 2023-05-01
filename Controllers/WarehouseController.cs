using App_Test_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
    public class WarehouseController : Controller
    {
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

            return RedirectToAction("Add");
        }

    }
}
