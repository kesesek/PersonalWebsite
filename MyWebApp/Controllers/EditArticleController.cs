// This is for editing/writing articles.
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class EditArticleController : Controller
    {
        // GET: /editArticle
        [HttpGet("/editArticle")]
        public IActionResult EditArticle()
        {
            return View("Index");
        }
    }
}