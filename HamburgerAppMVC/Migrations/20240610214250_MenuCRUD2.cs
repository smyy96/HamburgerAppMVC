using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class MenuCRUD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Menus",
                newName: "PictureName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureName",
                table: "Menus",
                newName: "Picture");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, null });
        }
    }
}
