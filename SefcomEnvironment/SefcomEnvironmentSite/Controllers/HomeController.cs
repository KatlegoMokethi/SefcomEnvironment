using Microsoft.AspNetCore.Mvc;

namespace SefcomEnvironmentSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
