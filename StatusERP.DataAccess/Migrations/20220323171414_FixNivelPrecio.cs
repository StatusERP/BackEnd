using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixNivelPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CondicionPago",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NivelesPrecios_CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "CondicionPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_NivelesPrecios_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "MonedaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelesPrecios_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "CondicionPagoId",
                principalSchema: "H2C",
                principalTable: "CondicionesPago",
                principalColumn: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NivelesPrecios_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelesPrecios_Monedas_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropIndex(
                name: "IX_NivelesPrecios_CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropIndex(
                name: "IX_NivelesPrecios_MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "Activo",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.DropColumn(
                name: "MonedaId",
                schema: "H2C",
                table: "NivelesPrecios");

            migrationBuilder.AddColumn<string>(
                name: "CondicionPago",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "NivelesPrecios",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");
        }
    }
}
