using Microsoft.AspNetCore.Mvc;

namespace WhishList.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("Index");
        }

         public IActionResult Error()
        {
            return View("Error");
        }
    }
}