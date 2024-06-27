using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :
base(options)
    {

    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Subscriber> Subscribers { get; set; }
    public DbSet<Pic> Pics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Admin>().ToTable("admin");
        modelBuilder.Entity<Article>().ToTable("article");
        modelBuilder.Entity<Subscriber>().ToTable("subscriber");
        modelBuilder.Entity<Pic>().ToTable("pic");
    }
}