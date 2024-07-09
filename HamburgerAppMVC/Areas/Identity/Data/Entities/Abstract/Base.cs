using System.ComponentModel;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract
{
    public abstract class Base : IBase
    {

        public int Id { get; set; }

        [DisplayName("Durumu")]
        public bool IsActive { get; set; } = true;
    }
}
