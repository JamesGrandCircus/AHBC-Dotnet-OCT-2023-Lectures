using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_7___Forms.Models;

namespace Unit_7___Forms.Controllers
{
    // <ControllerName - Controller>/<ActionName>
    // for example. home/privacy (casing does NOT matter for a URL)
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var total = AddTwoNumbers(1, 2);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            // Models in an MVC application represent the data
            // that the controller will PASS onto the view.
            var contactViewModel = new ContactViewModel()
            {
                Name = "James Jackson",
                Email = "JamesbmJackson@gmail.com",
                PhoneNumber = "123-456-7890",
                Age = 35
            };


            return View(contactViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }
}