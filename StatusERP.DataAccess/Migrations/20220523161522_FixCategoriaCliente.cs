using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCategoriaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentrosCosto_CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaAnticipoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaCobrCom",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaContado",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaCostLin",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaCostVent",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaCreditoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaDebitoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaDescBonif",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaDescGral",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaDescLin",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaDevVentas",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto1CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto2CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaIntCorr",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaIntMoraCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaLC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaProntoPagoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaRecibosCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaRubro1CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaRubro2CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaVendCom",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaVentas",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtaVentasExen",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrAnticipoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCobrCom",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrContado",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCostLin",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCostVent",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCreditoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrDebitoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrDescBonif",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrDescGral",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrDescLin",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrDevVentas",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto1CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto2CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrIntCorr",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrIntMoraCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrLC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrProntoPagoCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrRecibosCC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrRubro1CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrRubro2CC",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrVendCom",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrVentas",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrVentasExen",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaAjusteRedondeoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaAnticipoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCobrComId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaContadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCostLinId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCostVentId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCreditoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDebitoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescBonifId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescGralId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescLinId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDevVentasId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaImpuesto1CCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaImpuesto2CCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaIntCorrId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaIntMoraCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaLCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaProntoPagoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRecibosCCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRubro1CCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRubro2CCId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVendComId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVentasExenId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVentasId");

            migrationBuilder.CreateIndex(
                name: "IxCodCategoriaCliente",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CodCategoriaCliente",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaAjusteRedondeoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaAnticipoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCobrComId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaContadoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCostLinId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCostVentId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaCreditoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDebitoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescBonifId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescGralId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDescLinId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaDevVentasId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaImpuesto1CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaImpuesto2CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaIntCorrId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaIntMoraCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaLCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaProntoPagoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRecibosCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRubro1CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaRubro2CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVendComId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVentasExenId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CtrCtaVentasId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasClientes_CentroCuenta_CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasClientes_CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropIndex(
                name: "IxCodCategoriaCliente",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaCobrComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaContadoId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostVentId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaCreditoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaDebitoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescBonifId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescGralId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescLinId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaDevVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaIntCorrId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaLCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaRecibosCCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro1CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro2CCId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaVendComId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasExenId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasId",
                schema: "H2C",
                table: "CategoriasClientes");

            migrationBuilder.AddColumn<int>(
                name: "CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaAnticipoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCobrCom",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaContado",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostLin",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostVent",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCreditoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDebitoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescBonif",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescGral",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescLin",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDevVentas",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto1CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto2CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaIntCorr",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaIntMoraCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaLC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaProntoPagoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRecibosCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro1CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro2CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVendCom",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentas",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasExen",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAnticipoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCobrCom",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrContado",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostLin",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostVent",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCreditoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDebitoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescBonif",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescGral",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescLin",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDevVentas",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto1CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto2CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrIntCorr",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrIntMoraCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrLC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrProntoPagoCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRecibosCC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro1CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro2CC",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVendCom",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentas",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasExen",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CentroCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CuentaContableId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CentrosCosto_CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CentroCostoId",
                principalSchema: "H2C",
                principalTable: "CentrosCosto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasClientes_CuentasContables_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CuentaContableId",
                principalSchema: "H2C",
                principalTable: "CuentasContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
