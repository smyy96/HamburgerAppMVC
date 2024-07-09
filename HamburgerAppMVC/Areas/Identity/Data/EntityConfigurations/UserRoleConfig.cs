using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "0087A671-1000-4248-9CEC-7CD8AB56940E", // admin
                   UserId = "031A45EF-18ED-4BBC-80E5-D0E6FE65908C"  // admin
               },
               new IdentityUserRole<string>
               {
                   RoleId = "D5F1417F-1535-463F-9269-5115D442F26D", // kullanıcı
                   UserId = "66A51954-D206-4000-9F81-F73FE061B52D"  // kullancı
               }
           );
        }
    }
}
