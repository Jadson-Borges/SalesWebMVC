using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class BancoLocalCasa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_departamentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "departamentId",
                table: "Seller",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_departamentId",
                table: "Seller",
                newName: "IX_Seller_DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Seller",
                newName: "departamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                newName: "IX_Seller_departamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_departamentId",
                table: "Seller",
                column: "departamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
