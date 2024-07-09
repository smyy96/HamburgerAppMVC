using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;
using System.ComponentModel;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class ExtraMaterial : Base
    {
        [DisplayName("Ekstra Lezzet Adı")]
        public string ExtraMaterialName { get; set; }

        [DisplayName("Fiyat")]
        public double Price { get; set; }

        [DisplayName("Resim")]
        public string PictureName { get; set; }


        [DisplayName("Kategori Adı")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
