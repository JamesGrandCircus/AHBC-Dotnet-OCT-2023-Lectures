using Microsoft.AspNetCore.Mvc;
using TacoLab.Models;
using TacoLab.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TacoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly FastFoodTacoContext _fastFoodTacoContext;

        public DrinksController(FastFoodTacoContext fastFoodTacoContext)
        {
            _fastFoodTacoContext = fastFoodTacoContext;
        }

        // GET: api/<TacosController>
        [HttpGet]
        public IActionResult Get([FromQuery] string? sortByCost)
        {
            var drinks = _fastFoodTacoContext.Drink.ToList();

            if (sortByCost != null && sortByCost.ToLower() == "ascending")
            {
                var filteredDrinks = drinks
                    .OrderBy(drink => drink.Cost);

                return Ok(filteredDrinks);
            }
            else if (sortByCost != null && sortByCost.ToLower() == "descending")
            {
                var filteredDrinks = drinks
                    .OrderByDescending(drink => drink.Cost);

                return Ok(filteredDrinks);
            }

            return Ok(drinks);
        }

        // GET api/<TacosController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var drink = _fastFoodTacoContext.Drink.Find(id);
            
            if (drink == null)
            {
                return NotFound();
            }
            return Ok(drink);
        }

        // POST api/<TacosController>
        [HttpPost]
        public IActionResult Post([FromBody] PostDrink postDrink)
        {
            var drink = new Drink();
            drink.Name = postDrink.Name;
            drink.Slushie = postDrink.Slushie;
            drink.Cost = postDrink.Cost;

            _fastFoodTacoContext.Drink.Add(drink);
            _fastFoodTacoContext.SaveChanges();

            return Created($"/tacos/{drink.ID}", drink);
        }

        // POST api/<TacosController>
        [HttpPut("id")]
        public IActionResult Put([FromRoute] int id, [FromBody] PostDrink postDrink)
        {
            var drink = _fastFoodTacoContext.Drink.Find(id);

            if (drink != null)
            {
                drink.ID = id;
                drink.Name = postDrink.Name;
                drink.Slushie = postDrink.Slushie;
                drink.Cost = postDrink.Cost;

                _fastFoodTacoContext.Drink.Update(drink);
                _fastFoodTacoContext.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        // DELETE api/<TacosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var drink = _fastFoodTacoContext.Drink.Find(id);

            if (drink != null)
            {
                _fastFoodTacoContext.Drink.Remove(drink);
                _fastFoodTacoContext.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }
    }
}
