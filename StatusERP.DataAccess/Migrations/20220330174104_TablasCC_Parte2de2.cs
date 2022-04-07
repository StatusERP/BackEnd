using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCC_Parte2de2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalesCC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UltNotaCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltNotaDebito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltInteresMora = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltReciboDinero = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltFactura = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltOtroCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltOtroDebito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltRetencion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaUltComprime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LimpiarAplicacion = table.Column<bool>(type: "bit", nullable: false),
                    IntroFacturas = table.Column<bool>(type: "bit", nullable: false),
                    TipoAsientoDeb = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PaqueteDeb = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoAsientoCre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PaqueteCre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    VencPeriodo1 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo2 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo3 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo4 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo1 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo2 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo3 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo4 = table.Column<short>(type: "smallint", nullable: true),
                    AsientoFac = table.Column<bool>(type: "bit", nullable: false),
                    AsientoInt = table.Column<bool>(type: "bit", nullable: false),
                    AsientoND = table.Column<bool>(type: "bit", nullable: false),
                    AsientoOD = table.Column<bool>(type: "bit", nullable: false),
                    AsientoLC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoREC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoNC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoOC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoDEP = table.Column<bool>(type: "bit", nullable: false),
                    AsientoTEF = table.Column<bool>(type: "bit", nullable: false),
                    AsientosCtaPais = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionConta = table.Column<bool>(type: "bit", nullable: false),
                    ModAplicAsiento = table.Column<short>(type: "smallint", nullable: false),
                    NitDuplicado = table.Column<bool>(type: "bit", nullable: false),
                    RefrescaAuto = table.Column<bool>(type: "bit", nullable: false),
                    DocProntoPago = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DetalleObligat = table.Column<bool>(type: "bit", nullable: false),
                    UsarRubros = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro2Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ImpPorOmision = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    UsarRubrosCli = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1CliNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro2CliNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro3CliNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro4CliNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro5CliNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CopiarNotasEnAsnt = table.Column<bool>(type: "bit", nullable: false),
                    AsocObligContFact = table.Column<bool>(type: "bit", nullable: false),
                    VencPeriodo5 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo6 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo5 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo6 = table.Column<short>(type: "smallint", nullable: true),
                    AsociacionDeDocs = table.Column<bool>(type: "bit", nullable: false),
                    NomRubro1Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro2Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro3Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro4Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro5Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UsarRubrosVal = table.Column<bool>(type: "bit", nullable: false),
                    RubrosDiasRev = table.Column<short>(type: "smallint", nullable: true),
                    AsientoIntC = table.Column<bool>(type: "bit", nullable: false),
                    UltInteresCte = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FechaUltDifCamb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltLetraCambio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltDeposito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltTEF = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltRetDebito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomRubro11Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro12Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro13Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro14Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro15Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    AsientoDet = table.Column<bool>(type: "bit", nullable: true),
                    AsientoPer = table.Column<bool>(type: "bit", nullable: true),
                    AsientoRet = table.Column<bool>(type: "bit", nullable: true),
                    AsientoRed = table.Column<bool>(type: "bit", nullable: true),
                    SubTipoProntoPago = table.Column<short>(type: "smallint", nullable: true),
                    ConsecutivoGL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ConsecutivoDE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesCC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalesCC",
                schema: "H2C");
        }
    }
}
