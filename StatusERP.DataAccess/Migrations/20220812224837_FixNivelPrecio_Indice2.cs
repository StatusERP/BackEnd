using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixNivelPrecio_Indice2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NivelesPrecios_Monedas_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropIndex(
                name: "IX_NivelesPrecios_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropIndex(
                name: "IxCodNivelPrecio",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.RenameColumn(
                name: "UltimoAsientoFiscal",
                schema: "H2C",
                table: "PaquetesContables",
                newName: "UltimoAsiento");

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IxCodPaqueteInv",
                schema: "H2C",
                table: "PaquetesInv",
                column: "CodPaqueteInv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCodPaquete",
                schema: "H2C",
                table: "PaquetesContables",
                column: "CodPaquete",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCodNivelPrecio_Moneda",
                schema: "H2C",
                table: "NivelesPrecios",
                columns: new[] { "CodNivelPrecio", "Moneda" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodPaqueteInv",
                schema: "H2C",
                table: "PaquetesInv");

            migrationBuilder.DropIndex(
                name: "IxCodPaquete",
                schema: "H2C",
                table: "PaquetesContables");

            migrationBuilder.DropIndex(
                name: "IxCodNivelPrecio_Moneda",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.RenameColumn(
                name: "UltimoAsiento",
                schema: "H2C",
                table: "PaquetesContables",
                newName: "UltimoAsientoFiscal");

            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NivelesPrecios_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IxCodNivelPrecio",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "CodNivelPrecio",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelesPrecios_Monedas_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "MonedaId",
                principalSchema: "H2C",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
