using Microsoft.AspNetCore.Mvc;

namespace Unit_9_API.Controllers
{
    // when working with Api Projects, you are fully engaged with the semnatics of HTTP.
    [ApiController]
    [Route("[controller]")] // Routes can take template variables, to indicate a placeholder name. so
    // ["controller"] in this context means to GET to this controller , you would have to put the controller name 
    // MINUS the word controller.  => /WeatherForecast
    public class WeatherForecastController : ControllerBase // in MVC your controller inherits "Controller", in api ,
        // your controller inherits ControllerBase
    {

        // each method contains it's OWN ROUTE!!!!
        // we will be returning IActionResults soon
        [HttpGet("Hello-World")] // your HttbVerb Attributes allow you to append the name of your Route / Endpoint
        public IActionResult GetHelloWorld() // although we are returning a string, this is STILL our action
            // your action names are NOW YOURS! GO WILD, name them WHATEVER THE FUCK YOU WANT!
        {
            // this returns a "Hello world!" in the Body of the http response with an 
            // OK 200 status code.
            return Ok("Hello world!");
        }
    }
}
