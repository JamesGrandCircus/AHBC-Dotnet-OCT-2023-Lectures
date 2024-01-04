using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NuGet.Packaging.Signing;
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

            if (!_cache.TryGetValue("ids", out int ids))
            {
                ids = 0;

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromHours(3));

                _cache.Set("ids", ids, cacheEntryOptions);
            }

            Console.WriteLine("I was just created in memory!");
        }

        public ActionResult List() 
        {

            // this viewmodel is the data we will SEND BACK to the view
            // thin of this case as our "books from our database from now"
            var booksViewModel = _cache.Get("books");

            return View(booksViewModel);
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

        // HTTP-METHOD (VERBS) <-> CRUD operations
        // =============================
        // POST       <->  Create 
        // GET        <->  Read
        // PUT        <->  Update
        // DELETE     <->  Delete

        // POST: BookController/Create

        // Author=J.R.R. Tolkien&Genre=Fantasy/Adventure&Title=Fellowship of the Ring
        //
        //
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateBookViewModel book) // getting the FORM data and "adding to our database"
        {
            try
            {
                int ids = (int)_cache.Get("ids");

                // simply a placeholder for our database
                if (_cache.TryGetValue("books", out List<CreateBookViewModel> books))
                {
                    // assign the books id by the value, then increment the value of Ids by one
                    book.Id = ids++;
                    books.Add(book);

                    _cache.Set("ids", ids);
                }

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // for Both route and query parameters, we are injecting data DIRECTLY into the Http URL
        //
        // route parameters
        // https://www.amazon.com/Book/DeleteBook/Torani-Syrup-French-Vanilla-Ounce/
        //
        //
        //


        // query parameters
        //
        //   ?firstParameter=cheese&secondParameter=movies
        //
        // https://www.youtube.com/watch?v=q1pBwQl6zZ0
        //
        //
        //


        // provide a parameter for your NON post actions, if you DO use POST, you need to be explicit
        [HttpGet]
        public ActionResult DeleteBook(int id)
        {
            if (_cache.TryGetValue("books", out List<CreateBookViewModel> books))
            {

                // Book1, Id= 1
                // Book2, Id= 2
                // Book3, Id= 3
                //

                // parameter id == 2

                // look for all books that DOES NOT have the id of 2
                books = books.Where(book => book.Id != id)
                              .ToList();
                _cache.Set("books", books);
                // Book1, Id= 1
                // Book3, Id= 3
            }

            return RedirectToAction(nameof(List));
        }

        public ActionResult UpdateBook(int id)
        {
            CreateBookViewModel book = null;
            if (_cache.TryGetValue("books", out List<CreateBookViewModel> books))
            {
                // this method will be your best friend guys, like, I promise
                // first or defaault allows you get get a SINGLE FIRST item from your list as long as the condition
                // in your lambda is true
                // if there are NO results in your lambda, you get the default value, given that CReateBookViewModel
                // is a class, it's a reference type.
                book = books.FirstOrDefault(book => book.Id == id);
            }

            return View(book);
        }

        [HttpPost]
        public ActionResult UpdateBook(CreateBookViewModel updatedBookModel)
        {
            if (_cache.TryGetValue("books", out List<CreateBookViewModel> books))
            {
                // this method will be your best friend guys, like, I promise
                // first or defaault allows you get get a SINGLE FIRST item from your list as long as the condition
                // in your lambda is true
                // if there are NO results in your lambda, you get the default value, given that CReateBookViewModel
                // is a class, it's a reference type.
                var book = books.FirstOrDefault(book => book.Id == updatedBookModel.Id);

                if (book != null)
                {
                    book.Author = updatedBookModel.Author;
                    book.Title = updatedBookModel.Title;
                    book.Genre = updatedBookModel.Genre;
                }

                // _cache.Set("books", books);

            }

            return RedirectToAction(nameof(List));
        }
    }
}
