using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;


public class ArticlesController : Controller
{
        private readonly AppDbContext _context;
        public ArticlesController(AppDbContext context)
        {
            _context = context;
        }

        // For article detail page
        public IActionResult Details(int id)
        {
            var article = _context.Article.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            var viewModel = new ArticleViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                Category = article.Category,
                CreateAt = article.CreateAt,
                UpdateAt = article.UpdateAt
            };

            return View(viewModel);
        }
}