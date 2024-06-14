// Namespace declaration
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Private field, used for dependency injection logger
        private readonly ILogger<HomeController> _logger;

        // Constructor, initialize the controller using dependency injection mode
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action method, used to handle home page requests
        public IActionResult Index()
        {
            return View();
        }
        // Used to handle privacy page requests
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create a new ErrorViewModel instance
            // The RequestId property is set to the ID of the current activity, if one exists, or to the tracking identifier of the HTTP request otherwise.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}