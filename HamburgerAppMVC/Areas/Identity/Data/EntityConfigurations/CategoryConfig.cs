using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "İçecek", IsActive = true },
                new Category { Id = 2, CategoryName = "Tatlı", IsActive = true },
                new Category { Id = 3, CategoryName = "Patates", IsActive = true },
                new Category { Id = 4, CategoryName = "Sos", IsActive = true },
                new Category { Id = 5, CategoryName = "Çıtır Lezzet", IsActive = true }
                );
        }
    }
}

