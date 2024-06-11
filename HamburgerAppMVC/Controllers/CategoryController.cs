using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }


        public async Task<IActionResult> Details(int id)
        {

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return PartialView("_CategoryDetailsPartial", category);
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);


            category.IsActive = false;
            _context.Update(category);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }




        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, Category category)
        //{
        //    if (id != category.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {

        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(category);
        //}


    }
}
