using Microsoft.AspNetCore.Mvc;
namespace RazorImplementation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}