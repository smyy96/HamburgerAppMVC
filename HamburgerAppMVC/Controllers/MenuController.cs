using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using HamburgerAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly AppDbContext _db;

        public MenuController(AppDbContext db)
        {
            _db = db;
        }

        //Listeleme
        public IActionResult Index()
        {
            return View(_db.Menus.ToList());
        }

        //Oluşturma

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuViewModel menuViewModel)
        {
            if (menuViewModel.Price < 0)
            {
                TempData["Hata"] = "Fiyat negatif olamaz";
                return View();
            }

            Menu menu = new Menu();
            menu.MenuName = menuViewModel.MenuName;
            menu.Price = menuViewModel.Price;
            menu.Description = menuViewModel.Description;

            if (menuViewModel.Picture != null)
            {
                menu.PictureName = menuViewModel.Picture.FileName;

                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", menu.PictureName);

                var akisOrtami = new FileStream(konum, FileMode.Create);

                menuViewModel.Picture.CopyTo(akisOrtami);

                akisOrtami.Close();

            }
            _db.Menus.Add(menu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Silme 
        [HttpGet]
        public IActionResult Delete(int id)
        {

            return View(_db.Menus.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Menu menu)
        {
            if (menu.PictureName != null)
                ResimSil(menu);

            _db.Menus.Remove(menu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Güncelleme

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //önce id 'yi asp-route-id'den yakalayacağız
            //sonra güncelleme ekranından yine resim seçileceği için,
            //viewmodel ile ilgilenmemiz gerekir.
            //fakat gelen id'ile bulduğumuz ürün HAKİKİ üründür.
            //Ama biz viewmodel ile ilgileneceğimiz için bu hakiki ürünün 
            //prop.larını viewmodel'e aktarıp, view'ına bu viewmodel'i 
            //göndereceğiz.


            var guncellencekUrun = _db.Menus.Find(id);
            MenuViewModel menuViewModel = new MenuViewModel();
            menuViewModel.MenuName = guncellencekUrun.MenuName;
            menuViewModel.Price = guncellencekUrun.Price;
            menuViewModel.Description = guncellencekUrun.Description;

            ViewBag.PictureName = guncellencekUrun.PictureName;
            TempData["Id"] = id;

            return View(menuViewModel);

        }

        [HttpPost]
        public IActionResult Edit(MenuViewModel menuViewModel)
        {
            //Güncelleme formundaki güncelle butonuna basıldığı zaman
            //elimizde view model olacak. (çünkü kişi resim güncelleyeceği
            //için yine view model aracılığı ile yapmalıdır. (Gette 
            //anlattığımız gibi. 
            //Bu elimizdeki viewmodel bizim güncel özelliklerimizin
            //olduğu view modeldir. 
            //Ürünü güncelleyebilmek için bu güncel özellikleri olan
            //view modeldan yine HAKİKİ ürüne geçip, özelliklerini 
            //atayıp güncelleme işlemini yapacağız.

            if (menuViewModel.Price < 0)
            {
                TempData["Hata"] = "Fiyat negatif olamaz";
                return View();
            }


            var guncellenenUrun = _db.Menus.Find(TempData["Id"]);

            guncellenenUrun.MenuName = menuViewModel.MenuName;
            guncellenenUrun.Price = menuViewModel.Price;
            guncellenenUrun.Description = menuViewModel.Description;

            //kişi resim eklemek zorunda değil.
            //eğer resim varsa, resim adını urun  nesnesinin resim adına,
            //resmin kendisini de
            //wwwroot klasörü içerisinde resimler klasrüne  kaydededlim

            if (menuViewModel.Picture != null &&
                menuViewModel.Picture.FileName != guncellenenUrun.PictureName)
            {
                if (guncellenenUrun.PictureName != null)
                    ResimSil(guncellenenUrun);

                //dosyanın adını, urun nesnesinin resim adına atayalım
                guncellenenUrun.PictureName = menuViewModel.Picture.FileName;

                //Dosyanın kaydedileceği konumu belirleyelim
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", guncellenenUrun.PictureName);

                //Kaydetmek için bir akış ortamı oluşturalım
                var akisOrtami = new FileStream(konum, FileMode.Create);

                //Resmi kaydet
                menuViewModel.Picture.CopyTo(akisOrtami);

                //ortamı kapat
                akisOrtami.Close();

            }

            _db.Menus.Update(guncellenenUrun);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = _db.Menus
                .FirstOrDefault(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }


        [HttpGet]
        public IActionResult ResimKaldir(int id)
        {
            //gelen id'ye ait olan ürünü db'den getir ve view'ına gönder.
            //böylece emin misiniz ekranı gelmiş olacak.
            return View(_db.Menus.Find(id));
        }
        [HttpPost]
        public IActionResult ResimKaldir(Menu menu)
        {
            //evet'e basınca buraya gelecek ve o ürünün resmini null yapacak.


            ResimSil(menu); //o resmi kullanan başka ürün yoksa silme bölümü

            menu.PictureName = null;
            _db.Menus.Update(menu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public void ResimSil(Menu menu)
        {
            //bu metod, kendisine parametre olarak gönderilen urunun resmini kullanan başka 
            //ürün yoksa o resmi klasörden silecek

            var resmiKullananBaskaVarMi = _db.Menus.Any(u => u.PictureName == menu.PictureName &&
            u.Id != menu.Id);
            if (!resmiKullananBaskaVarMi) //başka yoksa sil
            {
                //resmi bul
                string silinecekResim = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/Images", menu.PictureName);

                //o resmi sil.
                System.IO.File.Delete(silinecekResim);
            }
        }

    }
}
