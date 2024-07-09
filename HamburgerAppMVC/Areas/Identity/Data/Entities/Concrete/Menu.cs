using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;
using System.ComponentModel;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class Menu : Base
    {
        [DisplayName("Menü Adı")]
        public string MenuName { get; set; }

        [DisplayName("Fiyatı")]
        public double Price { get; set; }

        [DisplayName("Resim Adı")]
        public string PictureName { get; set; }

        [DisplayName("Açıklaması")]
        public string Description { get; set; }
    }
}
