using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article { Id = 1, Title = "Article 1", Content = "Content of Article 1", Category = true, UpdateAt = DateTime.Now },
                new Article { Id = 2, Title = "Article 2", Content = "Content of Article 2", Category = false, UpdateAt = DateTime.Now }
            };

            return View(articles);
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