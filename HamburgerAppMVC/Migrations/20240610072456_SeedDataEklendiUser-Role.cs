using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataEklendiUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0087A671-1000-4248-9CEC-7CD8AB56940E", null, "Admin", "ADMIN" },
                    { "D5F1417F-1535-463F-9269-5115D442F26D", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "031A45EF-18ED-4BBC-80E5-D0E6FE65908C", 0, "b5ae8de9-adc7-4503-b6cc-2fcfe3ef5527", "admin@gmail.com", true, true, null, "Admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPxaUcQBXHjUxxAfHVSITSYFV7tkSgf4S1YEeppkOo0al0WcB7QNhp7YKFJzZMTN+Q==", null, false, "0310c780-98a5-427b-baaa-e1c6c09fdc2b", "Admin", false, "admin@gmail.com" },
                    { "66A51954-D206-4000-9F81-F73FE061B52D", 0, "d9953d87-31d4-47ba-806c-cff754dc0e43", "kullanici@gmail.com", true, true, null, "Kullanici Name", "KULLANICI@GMAIL.COM", "KULLANICI@GMAIL.COM", "AQAAAAIAAYagAAAAEPxaUcQBXHjUxxAfHVSITSYFV7tkSgf4S1YEeppkOo0al0WcB7QNhp7YKFJzZMTN+Q==", null, false, "992082fe-9cb6-49da-aa74-caf9592f341e", "Kullanici Surname", false, "kullanici@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0087A671-1000-4248-9CEC-7CD8AB56940E", "031A45EF-18ED-4BBC-80E5-D0E6FE65908C" },
                    { "D5F1417F-1535-463F-9269-5115D442F26D", "66A51954-D206-4000-9F81-F73FE061B52D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0087A671-1000-4248-9CEC-7CD8AB56940E", "031A45EF-18ED-4BBC-80E5-D0E6FE65908C" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "D5F1417F-1535-463F-9269-5115D442F26D", "66A51954-D206-4000-9F81-F73FE061B52D" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0087A671-1000-4248-9CEC-7CD8AB56940E");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D5F1417F-1535-463F-9269-5115D442F26D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D");
        }
    }
}
