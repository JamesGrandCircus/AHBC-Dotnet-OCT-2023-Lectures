using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_7_Entity_Code_First.Models;
using Unit_7_Entity_Code_First.Services;

namespace Unit_7_Entity_Code_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TodoContext _todoContext;

        public HomeController(ILogger<HomeController> logger, TodoContext todoContext)
        {
            _todoContext = todoContext;
            _logger = logger;
        }

        public IActionResult Todos()
        {
            var todos = _todoContext.Todos.ToList();
            return View(todos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Todo todoFormData)
        {
            _todoContext.Todos.Add(todoFormData);
            _todoContext.SaveChanges();
            return RedirectToAction(nameof(Todos));
        }

        public IActionResult Index()
        {
            return View();
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