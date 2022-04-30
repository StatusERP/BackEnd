using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCompraImpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCompraLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasLocId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCompraImpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCompraLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.AddColumn<int>(
                name: "CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraImpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasLocId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraImpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
