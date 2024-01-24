using Microsoft.AspNetCore.Mvc;
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

        // GET: api/<LibraryController>
        [HttpGet] // BECAUSE this HttpGet does NOT have additional ROUTE information, the DEFAULT http Get request
        // for THIS CONTROLLER will ALWAYS route to this ACTION
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/<LibraryController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            if (id < 10)
            {
                return Ok($"Hey, you provided an ID of {id}");
            }

            return NotFound();
        }

        // POST api/<LibraryController>
        [HttpPost]    // the FromBody Attribute is 
        public void Post([FromBody] Library value) // when making a post, the user will send JSON over, which AUTO CREATES
            // a c# class representing that json data.
        {
            Created("/api/[controller]/{id}", value);
        }

        // PUT api/<LibraryController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] string value)
        {

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

            if (id < 10) // logic will change when we intrioduce databases
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
