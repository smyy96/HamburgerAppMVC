using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class MenuCRUD3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2754814-e9c8-4b55-835f-a0fac6b20b84", "88835783-da2b-4aec-8b53-671720238f34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6187889-1957-4d48-b5af-ceea42c17bcb", "021b50d3-72a5-4aa8-aa2f-cd66e86893a7" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "IsActive", "MenuName", "PictureName", "Price" },
                values: new object[,]
                {
                    { 1, "Menu1", true, "Menu1", "menu1.jpg", 100.0 },
                    { 2, "Menu2", true, "Menu2", "menu1.jpg", 200.0 },
                    { 3, "Menu3", true, "Menu3", "menu1.jpg", 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31505bae-959c-48ae-bd9f-4ba4a2523488", "003aeb9d-732e-4632-aea7-1b682743670d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0de69e2b-4aaf-42f0-b3d1-8cb46f20ed9d", "4e66ee3f-32a0-40e6-a9b5-30ec2360cd37" });
        }
    }
}
