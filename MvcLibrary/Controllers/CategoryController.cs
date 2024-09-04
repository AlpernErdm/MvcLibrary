using Microsoft.AspNetCore.Mvc;

namespace MvcLibrary.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
