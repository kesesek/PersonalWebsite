using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article { Id = 1, Title = "Article 1", Content = "Content of Article 1", Category = "Tech", CreateAt = DateTime.Now },
                new Article { Id = 2, Title = "Article 2", Content = "Content of Article 2", Category = "Health", CreateAt = DateTime.Now }
            };

            return View(articles);
        }
    }
}