using HamburgerAppMVC.Areas.Identity.Data;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using HamburgerAppMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HamburgerAppMVC.Extensions;
using Microsoft.CodeAnalysis.Elfie.Model.Tree;




namespace HamburgerAppMVC.Controllers
{
    public class UserPageController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly AppDbContext _context;

        public static List<Menu> MenuBasketList = new List<Menu>();
        public static List<ExtraMaterial> ExtraMaterialBasletList = new List<ExtraMaterial>();


        public Dictionary<int, int> MenuItemQuantities = new Dictionary<int, int>();
        public static Dictionary<int, int> ExtraMaterialItemQuantities = new Dictionary<int, int>();

        public UserPageController(AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public async Task<IActionResult> Index()
        {
            List<Menu> menuBasketList = HttpContext.Session.GetObject<List<Menu>>("MenuBasketList") ?? new List<Menu>();

            User user = null;
            if (_signInManager.IsSignedIn(User))
            {
                user = await _userManager.GetUserAsync(User);

                ViewBag.LoginControl = user; // user ı index sayfasında kontrol edeceğiz dolu ise satın al butonu aktif olacak boş ise login sayfasına yönlendirme yapacak.
            }


            ViewBag.Categories = _context.Categories.Where(c => c.IsActive == true).ToList();

            var menus = _context.Menus.Where(m => m.IsActive == true).ToList();

            ViewBag.ExtraM = _context.ExtraMaterials.Where(e => e.IsActive == true).ToList();


            return View(menus);
        }



        public IActionResult TemporaryBasketMenu(int id)
        {

            var menu = _context.Menus.Find(id);

            //session
            List<Menu> menuBasketList = HttpContext.Session.GetObject<List<Menu>>("MenuBasketList") ?? new List<Menu>();


            MenuBasketList.Add(menu);

            //session
            HttpContext.Session.SetObject("MenuBasketList", menuBasketList);

            return Json(new { success = true, message = $"{menu.MenuName} başarıyla sepetinize eklendi." });
        }


        public IActionResult TemporaryBasketExtraMaterial(int id)
        {

            var extMaterial = _context.ExtraMaterials.Find(id);

            ExtraMaterialBasletList.Add(extMaterial);

            return Json(new { success = true, message = $"{extMaterial.ExtraMaterialName} başarıyla sepetinize eklendi." });
        }


        public IActionResult Basket()
        {

            // Session'dan sepeti al
            List<Menu> menuBasketList = HttpContext.Session.GetObject<List<Menu>>("MenuBasketList") ?? new List<Menu>();



            var menuBasketItems = MenuBasketList.GroupBy(m => m.Id)
                                        .Select(g => new { Menu = g.First(), Quantity = g.Count() })
                                        .ToList();

            var extraMaterialBasketItems = ExtraMaterialBasletList.GroupBy(e => e.Id)
                                                                  .Select(g => new { ExtraMaterial = g.First(), Quantity = g.Count() })
                                                                  .ToList();

            var viewModel = new BasketViewModel
            {
                MenuBasketList = menuBasketItems.Select(bi => bi.Menu).ToList(),
                ExtraMaterialBasketList = extraMaterialBasketItems.Select(bi => bi.ExtraMaterial).ToList(),
                MenuItemQuantities = menuBasketItems.ToDictionary(bi => bi.Menu.Id, bi => bi.Quantity),
                ExtraMaterialItemQuantities = extraMaterialBasketItems.ToDictionary(bi => bi.ExtraMaterial.Id, bi => bi.Quantity)
            };

            return View(viewModel);
        }


        [HttpPost]
        public IActionResult UpdatePlusQuantity(int itemId, string itemType)
        {
            if (itemType == "menu")
            {
                var menu = _context.Menus.Find(itemId);

                MenuBasketList.Add(menu);

            }
            else
            {
                var extraMaterial = _context.ExtraMaterials.Find(itemId);

                ExtraMaterialBasletList.Add(extraMaterial);
            }

            //// Session'dan MenuBasketList'i al
            //List<Menu> menuBasketList = HttpContext.Session.GetObject<List<Menu>>("MenuBasketList") ?? new List<Menu>();


            //// MenuItemQuantities sözlüğündeki miktarı güncelle
            //MenuItemQuantities[menuId] = quantity;

            //// Güncellenmiş MenuBasketList'i tekrar Session'a kaydet
            //HttpContext.Session.SetObject("MenuBasketList", menuBasketList);

            return Json(new { success = true, message = "Miktar başarıyla güncellendi." });
        }



        [HttpPost]
        public IActionResult UpdateMinusQuantity(int itemId, string itemType)
        {
            if (itemType == "menu")
            {
                var menu = _context.Menus.FirstOrDefault(m => m.Id == itemId);

                var itemToRemove = MenuBasketList.FirstOrDefault(m => m.Id == itemId);

                MenuBasketList.Remove(itemToRemove);

            }
            else
            {
                var extraMaterial = _context.ExtraMaterials.FirstOrDefault(m => m.Id == itemId);

                var itemToRemove = ExtraMaterialBasletList.FirstOrDefault(m => m.Id == itemId);

                ExtraMaterialBasletList.Remove(itemToRemove);
            }

            return Json(new { success = true, message = "Miktar başarıyla güncellendi." });
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int itemId, string itemType, string status)
        {
            if (itemType == "menu")
            {
                var menu = _context.Menus.Find(itemId);

                if (status == "plus")
                {
                    MenuBasketList.Add(menu);
                }
                else
                {
                    var itemToRemove = MenuBasketList.FirstOrDefault(m => m.Id == itemId);
                    MenuBasketList.Remove(itemToRemove);
                }
            }
            else
            {
                var extraMaterial = _context.ExtraMaterials.Find(itemId);

                if (status == "plus")
                {
                    ExtraMaterialBasletList.Add(extraMaterial);
                }
                else
                {
                    var itemToRemove = ExtraMaterialBasletList.FirstOrDefault(e => e.Id == itemId);
                    ExtraMaterialBasletList.Remove(itemToRemove);
                }
            }

            return Json(new { success = true, message = "Miktar başarıyla güncellendi." });
        }


        [HttpPost]
        public IActionResult DeleteItem(int itemId, string itemType)
        {

            if (itemType == "menu")
            {
                var menu = _context.Menus.Where(m => m.Id == itemId).ToList();

                foreach (var item in menu)
                {
                    var itemToRemove = MenuBasketList.FirstOrDefault(e => e.Id == item.Id);
                    MenuBasketList.Remove(itemToRemove);
                }
            }
            else //extra
            {
                var extraMaterials = _context.ExtraMaterials.Where(m => m.Id == itemId).ToList();

                foreach (var item in extraMaterials)
                {
                    var itemToRemove = ExtraMaterialBasletList.FirstOrDefault(e => e.Id == item.Id);
                    ExtraMaterialBasletList.Remove(itemToRemove);
                }
            }


            return Json(new { success = true });
        }





        [HttpPost]
        public async Task<IActionResult> BuyCart([FromBody] double totalAmount)
        {
            if (totalAmount > 0)
            {
                var user = await _userManager.GetUserAsync(User);


                var order = new Order() { UserId = user.Id, OrderDate = DateTime.Now, Price = totalAmount };
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                if (MenuBasketList != null)
                {
                    var groupedMenuList = MenuBasketList.GroupBy(item => item.Id);
                    foreach (var item in groupedMenuList)
                    {
                        var menuDetails = new MenuDetail() { OrderId = order.Id, MenuId = item.Key, Total = item.Count() };
                        _context.MenuDetails.Add(menuDetails);
                        await _context.SaveChangesAsync();


                        MenuBasketList.RemoveAll(ml => ml.Id == item.Key);
                    }
                }



                if (ExtraMaterialBasletList != null)
                {
                    var groupedExtraList = ExtraMaterialBasletList.GroupBy(item => item.Id);
                    foreach (var item in groupedExtraList)
                    {
                        var extraDetails = new ExtraDetail() { OrderId = order.Id, ExtraMaterialId = item.Key, Total = item.Count() };
                        _context.ExtraDetails.Add(extraDetails);
                        await _context.SaveChangesAsync();


                        ExtraMaterialBasletList.RemoveAll(ml => ml.Id == item.Key);
                    }
                }

                return Json(new { success = true, message = "Siparişiniz alınmıştır. En kısa sürede teslim edilmek üzere yola çıkacaktır. Afiyet Olsun ♥" });
            }

            return Json(new { success = true, message = "Sepetiniz boş lütfen ürün ekleyiniz." });

        }
    }
}
