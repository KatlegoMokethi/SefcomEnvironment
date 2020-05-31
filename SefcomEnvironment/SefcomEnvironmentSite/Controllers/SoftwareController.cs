using Microsoft.AspNetCore.Mvc;

namespace SefcomEnvironmentSite.Controllers
{
    public class SoftwareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
