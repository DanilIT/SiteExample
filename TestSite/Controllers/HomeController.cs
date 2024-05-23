using Microsoft.AspNetCore.Mvc;

namespace TestSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
