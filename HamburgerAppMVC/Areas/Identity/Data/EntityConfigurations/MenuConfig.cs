using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class MenuConfig
    {
        public class CategoryConfig : IEntityTypeConfiguration<Menu>
        {
            public void Configure(EntityTypeBuilder<Menu> builder)
            {
                builder.HasData(
                    new Menu { Id = 1, MenuName = "Menu1", Price=100, Description="Menu1", PictureName="menu1.jpg", IsActive = true },
                    new Menu { Id = 2, MenuName = "Menu2", Price = 200, Description = "Menu2", PictureName = "menu1.jpg",IsActive = true },
                    new Menu { Id = 3, MenuName = "Menu3", Price = 300, Description = "Menu3", PictureName = "menu1.jpg" ,IsActive = true }
                    );
            }
        }
    }
}
