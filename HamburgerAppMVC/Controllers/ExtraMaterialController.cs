using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using HamburgerAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerAppMVC.Controllers
{
    public class ExtraMaterialController : Controller
    {

        private readonly AppDbContext _db;

        public ExtraMaterialController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View(_db.ExtraMaterials.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExtraMaterialViewModel extraMaterialViewModel)
        {
            if(extraMaterialViewModel.Price < 0)
            {
                TempData["Hata"] = "Fiyat negatif olamaz";
                return View();
            }
            
            if(extraMaterialViewModel.Image == null || extraMaterialViewModel.Image.Length == 0)
            {
                TempData["Hata"] = "Lütfen bir resim yükleyiniz";
                return View();
            }

            ExtraMaterial extraMaterial = new ExtraMaterial();
            extraMaterial.ExtraMaterialName = extraMaterialViewModel.Name;
            extraMaterial.Price = extraMaterialViewModel.Price;

            if(extraMaterialViewModel.Image != null)
            {
                extraMaterial.Picture = extraMaterialViewModel.Image.FileName;

                var dosyaKonumu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", extraMaterial.Picture);
                var fileStream = new FileStream(dosyaKonumu, FileMode.Create);
                extraMaterialViewModel.Image.CopyTo(fileStream);
                fileStream.Close(); 
            }           
            
            _db.ExtraMaterials.Add(extraMaterial);
            _db.SaveChanges();
            return RedirectToAction("Index");  
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_db.ExtraMaterials.Find(id));
        }

        [HttpPost]
        public IActionResult Delete(ExtraMaterial extraMaterial)
        {
            if (extraMaterial.Picture != null)
            {
                ResimSil(extraMaterial);
            }

            extraMaterial.IsActive = false;

            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public void ResimSil(ExtraMaterial extraMaterial)
        {
            var resmiKullananVarMi = _db.ExtraMaterials.Any(u => u.Picture == extraMaterial.Picture && u.Id != extraMaterial.Id);

            if (!resmiKullananVarMi)
            {
                string silinecekResim = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", extraMaterial.Picture);
                System.IO.File.Delete(silinecekResim);
            }
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {

            var guncellenecekUrun = _db.ExtraMaterials.Find(id);

            ExtraMaterialViewModel extraMaterialViewModel = new ExtraMaterialViewModel();
            extraMaterialViewModel.Name = guncellenecekUrun.ExtraMaterialName;
            extraMaterialViewModel.Price = guncellenecekUrun.Price;

            ViewBag.Picture = guncellenecekUrun.Picture;
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

            guncellenenUrun.ExtraMaterialName = extraMaterialViewModel.Name;
            guncellenenUrun.Price = extraMaterialViewModel.Price;
            guncellenenUrun.Picture = extraMaterialViewModel.Image.FileName; //Resim koymayı yukarıda zorunlu hale getirdiğimden if koşulu koymadım
            var dosyaKonumu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", guncellenenUrun.Picture);

            _db.ExtraMaterials.Update(guncellenenUrun);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
