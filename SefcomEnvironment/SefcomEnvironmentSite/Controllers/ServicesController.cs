using Microsoft.AspNetCore.Mvc;


namespace SefcomEnvironmentSite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
