using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.DataAcess.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poducts_Categories_CategoryId",
                table: "Poducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Poducts_CoverTypes_CoverTypeId",
                table: "Poducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Poducts",
                table: "Poducts");

            migrationBuilder.RenameTable(
                name: "Poducts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Poducts_CoverTypeId",
                table: "Products",
                newName: "IX_Products_CoverTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Poducts_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverTypes_CoverTypeId",
                table: "Products",
                column: "CoverTypeId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverTypes_CoverTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Poducts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CoverTypeId",
                table: "Poducts",
                newName: "IX_Poducts_CoverTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Poducts",
                newName: "IX_Poducts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Poducts",
                table: "Poducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Poducts_Categories_CategoryId",
                table: "Poducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Poducts_CoverTypes_CoverTypeId",
                table: "Poducts",
                column: "CoverTypeId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
