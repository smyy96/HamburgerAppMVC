using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using HamburgerAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Controllers
{
    public class ExtraMaterialController : Controller
    {

        private readonly AppDbContext _db;

        public ExtraMaterialController(AppDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _db.Categories.ToListAsync();
            ViewBag.Category = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExtraMaterialViewModel extraMaterialViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = await _db.Categories.ToListAsync();
                return View(extraMaterialViewModel);
            }

            ExtraMaterial extraMaterial = new ExtraMaterial
            {
                ExtraMaterialName = extraMaterialViewModel.ExtraMaterialName,
                Price = extraMaterialViewModel.Price,
                CategoryId = extraMaterialViewModel.CategoryId
            };

            if (extraMaterialViewModel.Image != null && extraMaterialViewModel.Image.Length > 0)
            {
                extraMaterial.PictureName = extraMaterialViewModel.Image.FileName;
                var dosyaKonumu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", extraMaterial.PictureName);
                using (var fileStream = new FileStream(dosyaKonumu, FileMode.Create))
                {
                    await extraMaterialViewModel.Image.CopyToAsync(fileStream);
                }
            }

            _db.ExtraMaterials.Add(extraMaterial);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(_db.ExtraMaterials.Include(e => e.Category).ToList());
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_db.ExtraMaterials.Find(id));
        }

        [HttpPost]
        public IActionResult Delete(ExtraMaterial extraMaterial)
        {
            if (extraMaterial.PictureName != null)
            {
                ResimSil(extraMaterial);
            }

            extraMaterial.IsActive = false;

            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public void ResimSil(ExtraMaterial extraMaterial)
        {
            var resmiKullananVarMi = _db.ExtraMaterials.Any(u => u.PictureName == extraMaterial.PictureName && u.Id != extraMaterial.Id);

            if (!resmiKullananVarMi)
            {
                string silinecekResim = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", extraMaterial.PictureName);
                System.IO.File.Delete(silinecekResim);
            }
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {

            var guncellenecekUrun = _db.ExtraMaterials.Find(id);

            ExtraMaterialViewModel extraMaterialViewModel = new ExtraMaterialViewModel();
            extraMaterialViewModel.ExtraMaterialName = guncellenecekUrun.ExtraMaterialName;
            extraMaterialViewModel.Price = guncellenecekUrun.Price;

            //ViewBag.Picture = guncellenecekUrun.PictureName;
            TempData["Id"] = id;

            return View(extraMaterialViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ExtraMaterialViewModel extraMaterialViewModel)
        {
            if(extraMaterialViewModel.Price < 0)
            {
                TempData["Hata"] = "Fiyat negatif olamaz";
                return View();
            }

            var guncellenenUrun = _db.ExtraMaterials.Find(TempData["Id"]);

            guncellenenUrun.ExtraMaterialName = extraMaterialViewModel.ExtraMaterialName;
            guncellenenUrun.Price = extraMaterialViewModel.Price;
            guncellenenUrun.PictureName = extraMaterialViewModel.Image.FileName; //Resim koymayı yukarıda zorunlu hale getirdiğimden if koşulu koymadım
            var dosyaKonumu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", guncellenenUrun.PictureName);

            _db.ExtraMaterials.Update(guncellenenUrun);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
