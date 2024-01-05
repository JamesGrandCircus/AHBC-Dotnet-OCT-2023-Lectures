using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using unit_7_Entity_Framework_DB_First.Models;
using unit_7_Entity_Framework_DB_First.Services;

namespace unit_7_Entity_Framework_DB_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryContext _libraryContext;

        // Dependency Injection, is the act of Injecting or "Providing" our class 
        // dependency in the CONTRUCTOR of our Class that DEPENDS on said 
        // depdancy.  In this example our HomeController will DEPEND on 
        // our LibraryContext.  In order to Provide this dependency, you simply
        // add it as a parameter for the HomeController Contructor, and ALSO
        // add it to your SERVICE COLLECTION IN PROGRAM.CS!!!!!!!!!!!!!!@!!!!!!@#@#!@#!@#!@#!@#!@#
        public HomeController(ILogger<HomeController> logger, LibraryContext libraryContext) // Constructor Dependency INjection
        {
            _logger = logger;
            _libraryContext = libraryContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            var booksModel = _libraryContext.Books.ToList();
            return View(booksModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}