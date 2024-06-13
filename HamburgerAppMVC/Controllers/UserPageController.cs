using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerAppMVC.Controllers
{
    public class UserPageController : Controller
    {
        private readonly AppDbContext _context;

        public static List<Menu> MenuBasletList = new List<Menu>();
        public static List<ExtraMaterial> ExtraMaterialBasletList = new List<ExtraMaterial>();

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

            var menu = _context.Menus.Find(id);

            MenuBasletList.Add(menu);

            return Json(new { success = true, message = $"{menu.MenuName} başarıyla sepetinize eklendi." });
        }


        public IActionResult TemporaryBasketExtraMaterial(int id)
        {

            var extMaterial = _context.ExtraMaterials.Find(id);

            ExtraMaterialBasletList.Add(extMaterial);

            return Json(new { success = true, message = $"{extMaterial.ExtraMaterialName} başarıyla sepetinize eklendi." });
        }
    }
}
