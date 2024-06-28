using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var recentArticles = await _context.Article
                                                   .OrderByDescending(a => a.UpdateAt)
                                                   .Take(4)
                                                   .Select(a => new ArticleViewModel
                                                   {
                                                       Title = a.Title,
                                                       Content = a.Content,
                                                       UpdateAt = a.UpdateAt
                                                   })
                                                   .ToListAsync();
                return View(recentArticles);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while fetching recent articles: {Exception}", ex);
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
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