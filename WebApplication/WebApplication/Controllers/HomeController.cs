using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public IActionResult Index()
        {
            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
    }
}
