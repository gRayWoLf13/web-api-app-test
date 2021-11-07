using Microsoft.AspNetCore.Mvc;

namespace web_api_app_test.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}