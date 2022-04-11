using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix2CuentaContable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CentroCuenta_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetTransCB_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "DetTransCB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CuentaContable",
                schema: "H2C",
                table: "CuentaContable");

            migrationBuilder.RenameTable(
                name: "CuentaContable",
                schema: "H2C",
                newName: "CuentasContables",
                newSchema: "H2C");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CuentasContables",
                schema: "H2C",
                table: "CuentasContables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentasContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CentroCuenta_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentasContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetTransCB_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "DetTransCB",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentasContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CentroCuenta_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CentroCuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetTransCB_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "DetTransCB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CuentasContables",
                schema: "H2C",
                table: "CuentasContables");

            migrationBuilder.RenameTable(
                name: "CuentasContables",
                schema: "H2C",
                newName: "CuentaContable",
                newSchema: "H2C");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CuentaContable",
                schema: "H2C",
                table: "CuentaContable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentaContable",
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

            migrationBuilder.AddForeignKey(
                name: "FK_DetTransCB_CuentaContable_CuentaContableId",
                schema: "H2C",
                table: "DetTransCB",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentaContable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
