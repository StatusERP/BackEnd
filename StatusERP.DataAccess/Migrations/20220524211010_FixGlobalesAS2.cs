using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobalesAS2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Paises_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_TiposCambio_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.RenameColumn(
                name: "TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "TipoCambioId");

            migrationBuilder.RenameColumn(
                name: "PaisLocal",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "PaisId");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesAS_TipoCambioDolar",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "IX_GlobalesAS_TipoCambioId");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesAS_PaisLocal",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "IX_GlobalesAS_PaisId");

            migrationBuilder.AddColumn<int>(
                name: "PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Paises_PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_TiposCambio_TipoCambioId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "TipoCambioId",
                principalSchema: "H2C",
                principalTable: "TiposCambio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Paises_PaisId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_TiposCambio_TipoCambioId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.RenameColumn(
                name: "TipoCambioId",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "TipoCambioDolar");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "PaisLocal");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesAS_TipoCambioId",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "IX_GlobalesAS_TipoCambioDolar");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesAS_PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                newName: "IX_GlobalesAS_PaisLocal");

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
    }
}
