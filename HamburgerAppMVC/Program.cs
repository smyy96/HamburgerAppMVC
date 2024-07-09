using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HamburgerAppMVC.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.CookiePolicy;

namespace HamburgerAppMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            var connectionString = builder.Configuration.GetConnectionString("AppDbConStr") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));


            //builder.Services.Configure<CookiePolicyOptions>(options =>
            //{
            //    options.CheckConsentNeeded = context => true; // Kullanýcýnýn çerez kullanýmýna onay vermesi gerektiðini belirtir
            //    options.MinimumSameSitePolicy = SameSiteMode.None; // Minimum same-site policy belirle
            //    options.Secure = CookieSecurePolicy.Always; // Sadece HTTPS üzerinden çerez kabul edilir
            //    options.HttpOnly = HttpOnlyPolicy.None; // HTTP-only çerez kullanýmýný belirle
            //    //options.Cookie.HttpOnly = true;
            //    //options.Cookie.IsEssential = true;
            //});

            builder.Services.AddSingleton<MailSenderConfirm>();//mail sender kullan?m? i?in 



            //identity
            builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();//Rolleri de ekledik


            builder.Services.AddSession(); // Session kullanýmýný etkinleþtirin


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.MapRazorPages();//identity

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=UserPage}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
