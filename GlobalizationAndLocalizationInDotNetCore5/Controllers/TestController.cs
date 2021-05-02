using Microsoft.AspNetCore.Mvc;

namespace GlobalizationAndLocalizationInDotNetCore5.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}