using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaAnticipoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaAnticipoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaComisionCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaContado",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCostoLin",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCostoVen",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCreditoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaCreditoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDebitoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDebitoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDescBonif",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDescGral",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDescLin",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaDevVentas",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaGasCom",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto1CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto1CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto2CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto2CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaIntCorriente",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaIntMoraCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaLC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaLP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaProntoPagoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaProntoPagoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRecibosCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRentaCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRubro1CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRubro1CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRubro2CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaRubro2CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaVentas",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtaVentasExen",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrAnticipoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrAnticipoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrComisionCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrContado",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCostoLin",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCostoVen",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCreditoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCreditoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDebitoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDebitoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDescBonif",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDescGral",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDescLin",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrDevVentas",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrGasCom",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto1CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto1CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto2CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto2CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrIntCorriente",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrIntMoraCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrLC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrLP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrProntoPagoCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrProntoPagoCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRecibosCC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRentaCP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRubro1CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRubro1CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRubro2CC",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrRubro2CP",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrVentas",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrVentasExen",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaContadoId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaGasComId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaLCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaLPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaVentasId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAjusteRedondeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAnticipoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAnticipoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaComisionCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaContadoId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaContadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCostoLinId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCostoVenId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCreditoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCreditoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDebitoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDebitoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescBonifId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescGralId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescLinId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDevVentasId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaGasComId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaGasComId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto1CCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto1CPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto2CCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto2CPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaIntCorrienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaIntMoraCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaLCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaLCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaLPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaLPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaProntoPagoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaProntoPagoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRecibosCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRentaCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro1CCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro1CPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro2CCId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro2CPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaVentasExenId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaVentasId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaVentasId");

            migrationBuilder.CreateIndex(
                name: "IxCodPais",
                schema: "H2C",
                table: "Paises",
                column: "CodPais",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAjusteRedondeoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAnticipoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAnticipoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaComisionCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaContadoId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaContadoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCostoLinId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCostoVenId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCreditoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaCreditoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDebitoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDebitoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescBonifId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescGralId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDescLinId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaDevVentasId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaGasComId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaGasComId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto1CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto1CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto2CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaImpuesto2CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaIntCorrienteId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaIntMoraCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaLCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaLCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaLPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaLPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaProntoPagoCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaProntoPagoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRecibosCCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRentaCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro1CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro1CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro2CCId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaRubro2CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaVentasExenId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaVentasId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaVentasId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaContadoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaGasComId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaLCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaLPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaContadoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaGasComId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaLCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaLPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IxCodPais",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaAnticipoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaComisionCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaContadoId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostoLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCostoVenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCreditoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaCreditoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDebitoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDebitoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescBonifId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescGralId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDescLinId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaDevVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaGasComId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaIntCorrienteId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaIntMoraCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaLCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaLPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaProntoPagoCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRecibosCCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRentaCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro1CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro1CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro2CCId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro2CPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasExenId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaVentasId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.AddColumn<string>(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaAnticipoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaAnticipoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaComisionCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaContado",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostoLin",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCostoVen",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCreditoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCreditoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDebitoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDebitoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescBonif",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescGral",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDescLin",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDevVentas",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaGasCom",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto1CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto1CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto2CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto2CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaIntCorriente",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaIntMoraCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaLC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaLP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaProntoPagoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaProntoPagoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRecibosCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRentaCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro1CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro1CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro2CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro2CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentas",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaVentasExen",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAnticipoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAnticipoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrComisionCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrContado",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostoLin",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCostoVen",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCreditoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCreditoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDebitoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDebitoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescBonif",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescGral",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDescLin",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDevVentas",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrGasCom",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto1CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto1CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto2CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto2CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrIntCorriente",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrIntMoraCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrLC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrLP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrProntoPagoCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrProntoPagoCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRecibosCC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRentaCP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro1CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro1CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro2CC",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro2CP",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentas",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrVentasExen",
                schema: "H2C",
                table: "Paises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }
    }
}
