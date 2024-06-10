using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HamburgerAppMVC.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<User>
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<ExtraDetail> ExtraDetails { get; set; }
    public DbSet<ExtraMaterial> ExtraMaterials { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<MenuDetail> MenuDetails { get; set; }
    public DbSet<Order> Orders { get; set; }



    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);


        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//EntityConfig Dosyaların eklenmesi

    }
}
