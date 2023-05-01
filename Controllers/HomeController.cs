using App_Test_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App_Test_Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [Route("privacy-policy")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Privacy");
        }

        [Route("testowy-route/{name}")]
        public IActionResult Product(string name)
        {
            return View();
        }

    }
}