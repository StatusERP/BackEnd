using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Pais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaComisionId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DireccionId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                schema: "H2C",
                table: "Paises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAdValoremId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaComisionId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaComisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaPensionAFPCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaPensionONPCPId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_DireccionId",
                schema: "H2C",
                table: "Paises",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_MonedaId",
                schema: "H2C",
                table: "Paises",
                column: "MonedaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaAdValoremId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaComisionId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaComisionId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaPensionAFPCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises",
                column: "CtrCtaPensionONPCPId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_Direcciones_DireccionId",
                schema: "H2C",
                table: "Paises",
                column: "DireccionId",
                principalSchema: "H2C",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_Monedas_MonedaId",
                schema: "H2C",
                table: "Paises",
                column: "MonedaId",
                principalSchema: "H2C",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaComisionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_CentroCuenta_CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Direcciones_DireccionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Monedas_MonedaId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaComisionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_DireccionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_MonedaId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaAdValoremId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaComisionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaPensionAFPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CtrCtaPensionONPCPId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "DireccionId",
                schema: "H2C",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "MonedaId",
                schema: "H2C",
                table: "Paises");
        }
    }
}
