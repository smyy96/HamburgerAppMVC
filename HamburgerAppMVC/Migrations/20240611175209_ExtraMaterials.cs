using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class ExtraMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
