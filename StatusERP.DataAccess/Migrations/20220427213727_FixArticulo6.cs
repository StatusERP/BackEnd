using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CtaCompraImp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCompraLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaComsCobroExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaComsCobroLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaComsVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaComsVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaConsDesperdic",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaConsGasto",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaConsNormal",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaConsRetrabajo",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCostDescExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCostDescLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCostVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbAju",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbAjuCMV",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbCPGar",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbIngDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbMatAplicados",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbPerdDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbPuGar",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaCtbRetAsum",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescBonifExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescBonifLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescLineaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescLineaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDescVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDevVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaDevVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaFaltInventFis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaFaltanteRemis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaInvRemitido",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaInventario",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaMatProceso",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaSobrInventFis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaSobranteRemis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVariaCosto",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVencimiento",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVentasExenExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVentasExenLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtaVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCompraImp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCompraLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrComsCobroExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrComsCobroLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrComsVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrComsVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrConsDesperdic",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrConsGasto",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrConsNormal",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrConsRetrabajo",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCostDescExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCostDescLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCostVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCostVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoAju",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoAjuCMV",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoCPGar",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoIngDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoMatAplicados",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoPerdDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoPuGar",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtoRetAsum",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescBonifExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescBonifLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescLineaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescLineaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDescVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDevVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrDevVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrFaltInventFis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrFaltanteRemis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrInvRemitido",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrInventario",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrMatProceso",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrSobrInventFis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrSobranteRemis",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVariaCosto",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVencimiento",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVentasExenExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVentasExenLoc",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrVentasLoc",
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
                name: "CCComsVentaLocId",
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
                name: "CCCostVentaExpId",
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
                name: "CCId",
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
                name: "CCInventarioId",
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

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "int",
                nullable: true);

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
                name: "IX_CategoriasArticulos_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaLocId");

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
                name: "IX_CategoriasArticulos_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaExpId");

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
                name: "IX_CategoriasArticulos_CCId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCIngDevolucId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasArticulos_CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInventarioId");

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
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuCMVId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCAjuId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCAjuId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraImpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCompraLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsCobroLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCComsVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsDesperdicId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsGastoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsNormalId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCConsRetrabajoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostDescExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostoDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostoDescLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCostVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCCPGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescBonifLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescLineaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDescVentaLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCDevVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltanteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCFaltInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCIngDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInventarioId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCInvRemitidoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatAplicadosId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCMatProcesoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPerdDevolucId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCPuGarId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCRetAsumId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobranteRemisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCSobrInventFisId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVariaCostoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVencimientoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExenLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasExpId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos",
                column: "CCVentasLocId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCCompraLocId",
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
                name: "FK_CategoriasArticulos_CentroCuenta_CCComsVentaLocId",
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
                name: "FK_CategoriasArticulos_CentroCuenta_CCCostVentaExpId",
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
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCDescVentaLocId",
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
                name: "FK_CategoriasArticulos_CentroCuenta_CCId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCInventarioId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasArticulos_CentroCuenta_CCVentasLocId",
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
                name: "IX_CategoriasArticulos_CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCCompraLocId",
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
                name: "IX_CategoriasArticulos_CCComsVentaLocId",
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
                name: "IX_CategoriasArticulos_CCCostVentaExpId",
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
                name: "IX_CategoriasArticulos_CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCDescVentaLocId",
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
                name: "IX_CategoriasArticulos_CCId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCInventarioId",
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

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasArticulos_CCVentasLocId",
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
                name: "CCCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCCompraLocId",
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
                name: "CCComsVentaLocId",
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
                name: "CCCostVentaExpId",
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
                name: "CCDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCDescVentaLocId",
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
                name: "CCId",
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
                name: "CCInventarioId",
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

            migrationBuilder.DropColumn(
                name: "CCVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CCVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaAjuCMVId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaAjuId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCPGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCompraImpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCompraLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaComsCobroExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaComsCobroLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaComsVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaComsVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaConsDesperdicId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaConsGastoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaConsNormalId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaConsRetrabajoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostDescExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostDescLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescBonifExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescBonifLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescLineaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescLineaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescVentaExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescVentaLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDevVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaDevVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaFaltInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaFaltanteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaIngDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaInvRemitidoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaInventarioId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaMatAplicadosId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaMatProcesoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaPerdDevolucId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaPuGarId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaRetAsumId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaSobrInventFisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaSobranteRemisId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVariaCostoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVencimientoId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasExenExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasExenLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasExpId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasLocId",
                schema: "H2C",
                table: "CategoriasArticulos");

            migrationBuilder.AddColumn<string>(
                name: "CtaCompraImp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCompraLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaComsCobroExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaComsCobroLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaComsVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaComsVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaConsDesperdic",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaConsGasto",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaConsNormal",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaConsRetrabajo",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostDescExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostDescLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbAju",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbAjuCMV",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbCPGar",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbIngDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbMatAplicados",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbPerdDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbPuGar",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCtbRetAsum",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescBonifExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescBonifLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescLineaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescLineaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDevVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDevVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaFaltInventFis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaFaltanteRemis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaInvRemitido",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaInventario",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaMatProceso",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaSobrInventFis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaSobranteRemis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVariaCosto",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVencimiento",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasExenExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasExenLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCompraImp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCompraLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrComsCobroExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrComsCobroLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrComsVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrComsVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrConsDesperdic",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrConsGasto",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrConsNormal",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrConsRetrabajo",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostDescExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostDescLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoAju",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoAjuCMV",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoCPGar",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoIngDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoMatAplicados",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoPerdDevoluc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoPuGar",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCtoRetAsum",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescBonifExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescBonifLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescLineaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescLineaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescVentaExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescVentaLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDevVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDevVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrFaltInventFis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrFaltanteRemis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrInvRemitido",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrInventario",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrMatProceso",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrSobrInventFis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrSobranteRemis",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVariaCosto",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVencimiento",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasExenExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasExenLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasExp",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasLoc",
                schema: "H2C",
                table: "CategoriasArticulos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }
    }
}
