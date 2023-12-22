using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit__8___Intro_to_MVC.Models;

namespace Unit__8___Intro_to_MVC.Controllers
{

    /// <summary>
    /// localhost:4040/home/privacy
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult HealthTest()
        {
            return Ok("Heres your data dude!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}