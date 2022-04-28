using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.RenameColumn(
                name: "CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                newName: "CCCostVentaLocId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriasArticulos_CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                newName: "IX_CategoriasArticulos_CCCostVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaInventarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaInventarioId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.RenameColumn(
                name: "CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                newName: "CCInventarioId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriasArticulos_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                newName: "IX_CategoriasArticulos_CCInventarioId");

            migrationBuilder.AddColumn<int>(
                name: "CCId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInventarioId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
