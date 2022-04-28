using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaAjuCMVId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaAjuId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsCobroExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsCobroLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsDesperdicId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsNormalId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsRetrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostDescExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostDescLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCPGarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescBonifExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescBonifLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescLineaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescLineaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDevVentasExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDevVentasLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaFaltanteRemisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaFaltInventFisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaIngDevolucId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaInvRemitidoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaMatAplicadosId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaMatProcesoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaPerdDevolucId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaPuGarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaRetAsumId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaSobranteRemisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaSobrInventFisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVariaCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVencimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExenExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExenLocId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaAjuCMVId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaAjuId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsCobroExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsCobroLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaComsVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsDesperdicId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsGastoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsNormalId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaConsRetrabajoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostDescExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCostDescLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaCPGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescBonifExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescBonifLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescLineaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDescLineaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDevVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaDevVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaFaltanteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaFaltInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaIngDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaInvRemitidoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaMatAplicadosId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaMatProcesoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaPerdDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaPuGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaRetAsumId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaSobranteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaSobrInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVariaCostoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVencimientoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExenExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CtrCtaVentasExenLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.AddColumn<int>(
                name: "CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuCMVId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsDesperdicId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsNormalId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsRetrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostDescExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostoDescLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCPGarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasLocId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltanteRemisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltInventFisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCIngDevolucId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInvRemitidoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatAplicadosId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatProcesoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPerdDevolucId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPuGarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCRetAsumId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobranteRemisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobrInventFisId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVariaCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVencimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenExpId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenLocId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuCMVId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsDesperdicId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsGastoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsNormalId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsRetrabajoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostDescExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostoDescLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCPGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltanteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCIngDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInvRemitidoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatAplicadosId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatProcesoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPerdDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPuGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCRetAsumId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobranteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobrInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVariaCostoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVencimientoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
