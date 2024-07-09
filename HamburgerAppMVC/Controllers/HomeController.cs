using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HamburgerAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //uygulama aya�a kalkt��� zaman ilk olarak bu sayfa y�klenecek �r�n listesi sat�n al butonu olmadan g�z�kecektir.
        public IActionResult Index()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsActive == true).ToList();

            var menus = _context.Menus.Where(m => m.IsActive == true).ToList();

            ViewBag.ExtraM = _context.ExtraMaterials.Where(e => e.IsActive == true).ToList();


            return View(menus);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
