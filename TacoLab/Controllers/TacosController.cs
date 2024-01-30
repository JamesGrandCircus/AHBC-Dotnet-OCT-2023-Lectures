using Microsoft.AspNetCore.Mvc;
using TacoLab.Models;
using TacoLab.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TacoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacosController : ControllerBase
    {
        private readonly FastFoodTacoContext _fastFoodTacoContext;

        public TacosController(FastFoodTacoContext fastFoodTacoContext)
        {
            _fastFoodTacoContext = fastFoodTacoContext;
        }

        // GET: api/<TacosController>
        [HttpGet]
        public IActionResult Get([FromQuery] bool? softShell)
        {
            var tacos = _fastFoodTacoContext.Taco.ToList();

            if (softShell != null)
            {
                var filteredTacos = tacos
                    .Where(taco => taco.SoftShell == softShell).ToList();

                return Ok(filteredTacos);
            }

            return Ok(tacos);
        }

        // GET api/<TacosController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var taco = _fastFoodTacoContext.Taco.Find(id);
            
            if (taco == null)
            {
                return NotFound();
            }
            return Ok(taco);
        }

        // POST api/<TacosController>
        [HttpPost]
        public IActionResult Post([FromBody] PostTaco postTaco)
        {
            var taco = new Taco();
            taco.Name = postTaco.Name;
            taco.SoftShell = postTaco.SoftShell;
            taco.Chips = postTaco.Chips;
            taco.Cost = postTaco.Cost;

            _fastFoodTacoContext.Taco.Add(taco);
            _fastFoodTacoContext.SaveChanges();

            return Created($"/tacos/{taco.ID}", taco);
        }

        // DELETE api/<TacosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var taco = _fastFoodTacoContext.Taco.Find(id);

            if (taco != null)
            {
                _fastFoodTacoContext.Taco.Remove(taco);
                _fastFoodTacoContext.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }
    }
}
