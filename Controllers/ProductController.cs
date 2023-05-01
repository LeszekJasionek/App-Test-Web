using Microsoft.AspNetCore.Mvc;

namespace App_Test_Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
