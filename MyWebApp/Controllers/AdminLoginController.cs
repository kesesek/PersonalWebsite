using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
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

    // to do: admin login function

}