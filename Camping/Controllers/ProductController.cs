using Microsoft.AspNetCore.Mvc;

namespace Camping.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
