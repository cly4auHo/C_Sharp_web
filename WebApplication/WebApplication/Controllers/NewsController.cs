using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.News = NewsBase.News;
            return View();
        }
    }
}