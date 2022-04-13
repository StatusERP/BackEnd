using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCentroCuenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "CentroCuenta",
                newName: "CodCuentaContable");

            migrationBuilder.RenameColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "CentroCuenta",
                newName: "CodCentroCosto");

            migrationBuilder.AddColumn<int>(
                name: "CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CentroCuenta_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CentroCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_CentroCuenta_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CuentaContableId");

            migrationBuilder.AddForeignKey(
                name: "FK_CentroCuenta_CentrosCosto_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CentroCostoId",
                principalSchema: "H2C",
                principalTable: "CentrosCosto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CentroCuenta_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentaContable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CentroCuenta_CentrosCosto_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_CentroCuenta_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropIndex(
                name: "IX_CentroCuenta_CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropIndex(
                name: "IX_CentroCuenta_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropColumn(
                name: "CentroCostoId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropColumn(
                name: "CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.RenameColumn(
                name: "CodCuentaContable",
                schema: "H2C",
                table: "CentroCuenta",
                newName: "CuentaContable");

            migrationBuilder.RenameColumn(
                name: "CodCentroCosto",
                schema: "H2C",
                table: "CentroCuenta",
                newName: "CentroCosto");
        }
    }
}
