using Microsoft.AspNetCore.Mvc;

namespace HamburgerAppMVC.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
