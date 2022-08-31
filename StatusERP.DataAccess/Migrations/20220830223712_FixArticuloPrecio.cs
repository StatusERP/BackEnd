using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticuloPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.RenameColumn(
                name: "Version",
                schema: "H2C",
                table: "ArticuloPrecios",
                newName: "VersionNivelId");

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloPrecios_ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IxVersionNivel_Articulo_VersionArticulo",
                schema: "H2C",
                table: "ArticuloPrecios",
                columns: new[] { "VersionNivelId", "ArticuloId", "VersionArticulo" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticuloPrecios_Articulos_ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticuloPrecios_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "ArticuloPrecios",
                column: "VersionNivelId",
                principalSchema: "H2C",
                principalTable: "VersionesNivelPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticuloPrecios_Articulos_ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticuloPrecios_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropIndex(
                name: "IX_ArticuloPrecios_ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropIndex(
                name: "IxVersionNivel_Articulo_VersionArticulo",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "ArticuloPrecios");

            migrationBuilder.RenameColumn(
                name: "VersionNivelId",
                schema: "H2C",
                table: "ArticuloPrecios",
                newName: "Version");

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "ArticuloPrecios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "ArticuloPrecios",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "ArticuloPrecios",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
