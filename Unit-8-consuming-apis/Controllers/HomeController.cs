using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_8_consuming_apis.Models;
using Unit_8_consuming_apis.Services;

namespace Unit_8_consuming_apis.Controllers
{
    public class HomeController : Controller
    {
        private readonly DogService _dogService;

        // the way this controller has access to the DogService is through Dependancy Injection.
        // we are "INJECTING" the dogService through the constructor.  this can ONLY be done 
        // IF hte DogService exists in the same service Collection as the Controller (<see program.cs>)
        public HomeController(DogService dogService)
        {
            _dogService = dogService;
        }

        public async Task<IActionResult> Index()
        {
            var dogImage = await _dogService.GetRandomDogImage();
            var model = new IndexViewModel();
            model.ImageSrc = dogImage;
            return View(model);
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