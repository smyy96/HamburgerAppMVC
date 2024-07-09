using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class ExtraMaterialsCRUD1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "ExtraMaterials",
                newName: "PictureName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "736532d9-91b4-45dd-8461-ec33e6349e26", "b5641354-f720-4ad2-babf-1bedc6b17d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "491f85e5-f409-4591-aa71-ec01e1360800", "0aaaa25e-b05f-4468-aad4-0359fb87ff9e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureName",
                table: "ExtraMaterials",
                newName: "Picture");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d409698c-b6c9-4595-a9fa-8e371dd94606", "77c0442d-c65d-4112-8334-5062efd38e74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb367f4e-5374-464b-b8b0-9611d2ebf6bf", "981b8b36-a406-4349-883d-639708a1c882" });
        }
    }
}
