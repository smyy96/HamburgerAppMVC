using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class Category : Base
    {
        [DisplayName("Kategori Adı")]
        public string CategoryName { get; set; }
    }
}
