using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerAppMVC.Controllers
{
    public class UserPageController : Controller
    {
        private readonly AppDbContext _context;

        public static List<Menu> Menus;

        public UserPageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsActive == true).ToList();

            var menus = _context.Menus.Where(m => m.IsActive == true).ToList();

            ViewBag.ExtraM = _context.ExtraMaterials.Where(e => e.IsActive == true).ToList();


            return View(menus);
        }



        public IActionResult TemporaryBasketMenu(int id)
        {
            return Json(new { success = true, message = "Ürün sepete eklendi!" });
        }
    }
}
