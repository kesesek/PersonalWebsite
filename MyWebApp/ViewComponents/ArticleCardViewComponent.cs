using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.ViewComponents
{
    public class ArticleCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Article article)
        {
            return View(article);
        }
    }
}