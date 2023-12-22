using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Unit_7___Forms.Models;

namespace Unit_7___Forms.Controllers
{
    public class BookController : Controller
    {
        // future state, this would be a database
        private IMemoryCache _cache;

        public BookController(IMemoryCache cache)
        {
            _cache = cache;

            if (!_cache.TryGetValue("books", out List<CreateBookViewModel> books))
            {
                books = new List<CreateBookViewModel>();

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromHours(3));

                _cache.Set("books", books, cacheEntryOptions);
            }

            Console.WriteLine("I was just created in memory!");
        }

        public ActionResult List() 
        { 
            return View(_cache.Get("books")); 
        }

        // GET: BookController/Create
        [HttpGet] // <- default HttpVERB
        public ActionResult AddBook() // viewing the form that the user will fill out
        {
            return View();
        }

        // HTTP Describes the RULES of sending data over the internet
        // HTTP is a "protocol" which means several different "RULES" of sending
        // data over the internet, web apps use HTTP
        // HTTP is STATLESS, HTTP is NOT concerned with SAVING DATA

        // HTTP-VERBS <-> CRUD operations
        // =============================
        // POST       <->  Create 
        // GET        <->  Read
        // PUT        <->  Update
        // DELETE     <->  Delete

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateBookViewModel book) // getting the FORM data and "adding to our database"
        {
            try
            {
                // simply a placeholder for our database
                if (_cache.TryGetValue("books", out List<CreateBookViewModel> books))
                {
                    books.Add(book);
                }

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

    }
}
