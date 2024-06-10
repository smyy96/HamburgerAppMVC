using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "0087A671-1000-4248-9CEC-7CD8AB56940E", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "D5F1417F-1535-463F-9269-5115D442F26D", Name = "User", NormalizedName = "USER" }
                );
        }
    }
}
