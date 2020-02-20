using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicAspCore.Migrations
{
    public partial class add_category2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_idCategory",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "idCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_idCategory",
                table: "Products",
                column: "idCategory",
                principalTable: "Categories",
                principalColumn: "idCategory",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_idCategory",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "idCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_idCategory",
                table: "Products",
                column: "idCategory",
                principalTable: "Category",
                principalColumn: "idCategory",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
