using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;
using unit_7_Entity_Framework_DB_First.Models;
using unit_7_Entity_Framework_DB_First.Services;

namespace unit_7_Entity_Framework_DB_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryContext _libraryDatabase;

        // Dependency Injection, is the act of Injecting or "Providing" our class 
        // dependency in the CONTRUCTOR of our Class that DEPENDS on said 
        // depdancy.  In this example our HomeController will DEPEND on 
        // our LibraryContext.  In order to Provide this dependency, you simply
        // add it as a parameter for the HomeController Contructor, and ALSO
        // add it to your SERVICE COLLECTION IN PROGRAM.CS!!!!!!!!!!!!!!@!!!!!!@#@#!@#!@#!@#!@#!@#
        public HomeController(ILogger<HomeController> logger, LibraryContext libraryContext) // Constructor Dependency INjection
        {
            _logger = logger;
            _libraryDatabase = libraryContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            var booksModel = _libraryDatabase.Books.ToList();
            return View(booksModel);
        }

        // returns the create View or Page
        public IActionResult Create() // this is an HttpGet
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var book = _libraryDatabase.Books.Find(id);
            return View(book);
        }


        [HttpPost]
        public IActionResult Edit(Book bookFormData, int id) // I ddon't need this ROUTE PARAMTER
        {
            _libraryDatabase.Books.Update(bookFormData);
            _libraryDatabase.SaveChanges();

            return RedirectToAction(nameof(Books));
        }

        // Overloaded Method with an attribute of HttpPost
        [HttpPost]
        // this action will actually HANDLE creating our new book
        public IActionResult Create(Book bookFormData)
        {
            _libraryDatabase.Books.Add(bookFormData);
            _libraryDatabase.SaveChanges();
            return RedirectToAction(nameof(Books));
        }

        public IActionResult Delete(int id)
        {
            //                               Find will FIND that specific "Row" with the given PRIMARY KEY
            var book = _libraryDatabase.Books.Find(id);

            if (book != null)
            {
                _libraryDatabase.Books.Remove(book);

                // SUPER IMPORTANT! if you are providing an UPDATE, INSERT, or DELETE Action, you HAVE 
                // to save your changes before they reflect in the actual database table.
                _libraryDatabase.SaveChanges();
            }

            return RedirectToAction(nameof(Books));
        }

        private int AddNumbers(int x)
        {
            return x + x;
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