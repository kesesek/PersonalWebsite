using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using MyWebApp.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminSignUpController : Controller
{
    private readonly AppDbContext _context;
    public AdminSignUpController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        bool adminCheck = await _context.Admin.AnyAsync();
        if (adminCheck)
        {
            return RedirectToAction("Index", "AdminLogin");
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(SignUpModel model)
    {
        if (ModelState.IsValid)
        {
            // Create an admin
            var admin = new Admin
            {
                Username = model.Username,
                EncryptedPassword = PasswordHasher.HashPassword(model.Password),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _context.Admin.Add(admin);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "AdminLogin");
        }
        // Preserve user-entered data in form fields
        return View(model);
    }
}