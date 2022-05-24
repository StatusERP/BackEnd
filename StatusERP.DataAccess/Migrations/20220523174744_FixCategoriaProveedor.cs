using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCategoriaProveedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaAnticipoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaCreditoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaDebitoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto1CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto2CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaLP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaProntoPagoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaRubro1CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtaRubro2CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrAnticipoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCreditoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrDebitoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto1CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto2CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrLP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrProntoPagoCP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrRubro1CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrRubro2CP",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaAjusteRedondeoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaAnticipoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaCPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaCreditoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaDebitoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaImpuesto1CPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaImpuesto2CPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaLPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaProntoPagoCPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaRubro1CPId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasProveedor_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaRubro2CPId");

            migrationBuilder.CreateIndex(
                name: "IxCodCategoriaProveedor",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CodCategoriaProveedor",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaAjusteRedondeoId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaAnticipoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaCreditoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaDebitoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaImpuesto1CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaImpuesto2CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaLPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaProntoPagoCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaRubro1CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor",
                column: "CtrCtaRubro2CPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasProveedor_CentroCuenta_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasProveedor_CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropIndex(
                name: "IxCodCategoriaProveedor",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaAjusteRedondeoId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaAnticipoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaCreditoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaDebitoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaLPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaProntoPagoCPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro1CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.DropColumn(
                name: "CtrCtaRubro2CPId",
                schema: "H2C",
                table: "CategoriasProveedor");

            migrationBuilder.AddColumn<string>(
                name: "CtaAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaAnticipoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaCreditoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDebitoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto1CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto2CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaLP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaProntoPagoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro1CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaRubro2CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAjusteRedondeo",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrAnticipoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrCreditoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDebitoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto1CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto2CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrLP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrProntoPagoCP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro1CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrRubro2CP",
                schema: "H2C",
                table: "CategoriasProveedor",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }
    }
}
