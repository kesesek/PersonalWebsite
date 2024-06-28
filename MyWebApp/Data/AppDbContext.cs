using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :
base(options)
    {

    }

    public DbSet<Admin> Admin { get; set; }
    public DbSet<Article> Article { get; set; }
    public DbSet<Subscriber> Subscriber { get; set; }
    public DbSet<Pic> Pic { get; set; }

}