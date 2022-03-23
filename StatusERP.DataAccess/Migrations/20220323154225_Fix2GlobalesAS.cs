using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix2GlobalesAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<int>(
                name: "Moneda",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisLocal");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS",
                column: "TipoCambioDolar");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Paises_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisLocal",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_TiposCambio_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS",
                column: "TipoCambioDolar",
                principalSchema: "H2C",
                principalTable: "TiposCambio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Paises_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_TiposCambio_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<string>(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
