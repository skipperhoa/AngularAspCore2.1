using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicAspCore.Migrations
{
    public partial class add_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCategory",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    idCategory = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.idCategory);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_idCategory",
                table: "Products",
                column: "idCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_idCategory",
                table: "Products",
                column: "idCategory",
                principalTable: "Category",
                principalColumn: "idCategory",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_idCategory",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_idCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "idCategory",
                table: "Products");
        }
    }
}
