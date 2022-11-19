using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class DificultToExplain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "LinkToImage");

            migrationBuilder.AddColumn<int>(
                name: "ProductClassId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkToImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductClasses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductClassId",
                table: "Products",
                column: "ProductClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductClasses_ProductClassId",
                table: "Products",
                column: "ProductClassId",
                principalTable: "ProductClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductClasses_ProductClassId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductClasses");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductClassId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductClassId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "LinkToImage",
                table: "Products",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
