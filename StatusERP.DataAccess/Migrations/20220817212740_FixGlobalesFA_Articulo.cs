using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobalesFA_Articulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.RenameColumn(
                name: "AutroAprobar",
                schema: "H2C",
                table: "GlobalesFA",
                newName: "AutorAprobar");

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_ArticuloId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "ArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_Articulos_ArticuloId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_Articulos_ArticuloId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_ArticuloId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.RenameColumn(
                name: "AutorAprobar",
                schema: "H2C",
                table: "GlobalesFA",
                newName: "AutroAprobar");

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
