using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCentroCuenta2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CentroCuenta_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.CreateIndex(
                name: "IxCentroCodCuentaCod",
                schema: "H2C",
                table: "CentroCuenta",
                columns: new[] { "CodCentroCosto", "CodCuentaContable" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCentroIdCuentaId",
                schema: "H2C",
                table: "CentroCuenta",
                columns: new[] { "CentroCostoId", "CuentaContableId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCentroCodCuentaCod",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropIndex(
                name: "IxCentroIdCuentaId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_CentroCuenta_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CentroCostoId");
        }
    }
}
