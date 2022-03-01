using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CobradoresMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.EnsureSchema(
                name: "PRUEBA");

            migrationBuilder.CreateTable(
                name: "TablaCobradores",
                schema: "PRUEBA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCobrador = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConjuntoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaCobradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaCobradores_Conjuntos_ConjuntoId",
                        column: x => x.ConjuntoId,
                        principalTable: "Conjuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaCobradores_ConjuntoId",
                schema: "PRUEBA",
                table: "TablaCobradores",
                column: "ConjuntoId");

            migrationBuilder.CreateIndex(
                name: "IxCobradorId",
                schema: "PRUEBA",
                table: "TablaCobradores",
                column: "CodCobrador",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaCobradores",
                schema: "PRUEBA");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConjuntoId = table.Column<int>(type: "int", nullable: false),
                    CodPais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodigoISO = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EtiquetaDivGeo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EtiquetaDivGeo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pais_Conjuntos_ConjuntoId",
                        column: x => x.ConjuntoId,
                        principalTable: "Conjuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pais_ConjuntoId",
                table: "Pais",
                column: "ConjuntoId");

            migrationBuilder.CreateIndex(
                name: "IxPaisId",
                table: "Pais",
                column: "CodPais",
                unique: true);
        }
    }
}
