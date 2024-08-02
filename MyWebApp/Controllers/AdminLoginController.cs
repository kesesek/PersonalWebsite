using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using MyWebApp.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminLoginController : Controller
{
    private readonly AppDbContext _context;

    public AdminLoginController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string username, string password)
    {
        var admin = _context.Admin.SingleOrDefault(a => a.Username == username);

        if (admin != null && PasswordHasher.VerifyPassword(password, admin.EncryptedPassword))
        {
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // use viewbag to deliver message dynamically
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
    }
}