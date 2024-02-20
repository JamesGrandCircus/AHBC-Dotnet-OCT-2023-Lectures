using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Unit_9_API.Models;
using Unit_9_API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unit_9_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryContext _libraryContext;

        public LibraryController(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        // GET: api/<LibraryController>?page=1&filter=name
        [HttpGet] // BECAUSE this HttpGet does NOT have additional ROUTE information, the DEFAULT http Get request
        // for THIS CONTROLLER will ALWAYS route to this ACTION
        public IActionResult Get()
        {
            // get ALL books!
            var response = _libraryContext.Books.ToList();
            return Ok(response);
        }

        // GET api/Library/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {

            var book = _libraryContext.Books.Find(id);
            return book != null 
                ? Ok(book) 
                : NotFound();
        }

        // POST api/<LibraryController>
        [HttpPost]    // the FromBody Attribute is 
        public IActionResult Post([FromBody] Book value) // when making a post, the user will send JSON over, which AUTO CREATES
            // a c# class representing that json data.
        {
            // var book == the "Reference to the idea that a BOOK will be CREATED!"
            var book = _libraryContext.Books.Add(value);

            // this SAVES any changes you want to make to your database
            _libraryContext.SaveChanges();

            // the book reference will AUTO update for you... so you can get that newly created ID!
            var id = book.Entity.Id;
            return Created($"/api/library/{id}", value);
        }

        // PUT api/<LibraryController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] string value)
        {

            int number;

            if (id < 10)
            {
                return Created("/api/[controller]/{id}", value);
            }

            return NotFound();
        }

        // DELETE api/<LibraryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var book = _libraryContext.Books.Find(id);

            if (book != null)
            {
                _libraryContext.Books.Remove(book);
                _libraryContext.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
    }
}
