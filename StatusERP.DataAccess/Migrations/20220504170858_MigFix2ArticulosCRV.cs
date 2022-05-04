using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigFix2ArticulosCRV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId",
                principalSchema: "H2C",
                principalTable: "CategoriasArticulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId1",
                principalSchema: "H2C",
                principalTable: "CategoriasArticulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
