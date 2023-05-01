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

        public IActionResult Privacy()
        {
            return View();
        }

    }
}