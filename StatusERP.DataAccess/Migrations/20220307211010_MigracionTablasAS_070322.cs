using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigracionTablasAS_070322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasProveedor",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaProveedor = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasProveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicionesPago",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DiasNeto = table.Column<int>(type: "int", nullable: false),
                    PagosParciales = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoContado = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCondPago = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PlazoCondPago = table.Column<int>(type: "int", nullable: true),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionesPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosGlobales",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivoGlobal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Longitud = table.Column<int>(type: "int", nullable: false),
                    Entidad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FormatoImpresionDetallado = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FormatoImpresionResumido = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ValorInicial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ValorFinal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoValor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaHoraUlt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosGlobales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivoUsuario",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivoUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaContable",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SeccionCuenta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoDetallado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    SaldoNormal = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Conversion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCambio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AceptaDatos = table.Column<bool>(type: "bit", nullable: false),
                    UsaCentroCosto = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsoRestringido = table.Column<bool>(type: "bit", nullable: false),
                    OrigenConversion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaContable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivGeograficas1",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodDivGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivGeograficas1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivGeograficas2",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodDivGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CodDivGeografica2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivGeograficas2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocTributarios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodDocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigitoVerificador = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoContribuyente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    NRC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Giro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DUI = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Pasaporte = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Carnet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Otro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InfoLegal = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTributarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesFinancieras",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodEntidadFinanciera = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CodElectronico = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesFinancieras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesAS",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAdvIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAdvFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTrabajoIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTrabajoFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMoneda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SimboloMoneda = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Impuesto1Desc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Impuesto2Desc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PaisLocal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MonedaLocal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MonedaDolar = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TipoCambioDolar = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PatronCeCo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localizaciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodLocalizacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Volumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PesoMaximo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMoneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CodigoISO = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelesPrecios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodNivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    EsquemaTrabajo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Descuentos = table.Column<bool>(type: "bit", nullable: false),
                    SugerirDescuento = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelesPrecios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodigoISO = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EtiquetaDivGeo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EtiquetaDivGeo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodosContables",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FinPeriodoAnual = table.Column<bool>(type: "bit", nullable: false),
                    Abierto = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodosContables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodRuta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCambio",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoCambio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodUnidadMedida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioBodega",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioBodega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodZona = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasClientes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaCliente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCostoId = table.Column<int>(type: "int", nullable: false),
                    CtaVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CuentaContableId = table.Column<int>(type: "int", nullable: false),
                    CtrDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVent = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostVent = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVendCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVendCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCobrCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCobrCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntCorr = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntCorr = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriasClientes_CentrosCosto_CentroCostoId",
                        column: x => x.CentroCostoId,
                        principalSchema: "H2C",
                        principalTable: "CentrosCosto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriasClientes_CuentaContable_CuentaContableId",
                        column: x => x.CuentaContableId,
                        principalSchema: "H2C",
                        principalTable: "CuentaContable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriasClientes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CategoriasProveedor",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CondicionesPago",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosGlobales",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivoUsuario",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DivGeograficas1",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DivGeograficas2",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocTributarios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "EntidadesFinancieras",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesAS",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Localizaciones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Monedas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "NivelesPrecios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Paises",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PeriodosContables",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Rutas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposCambio",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "UnidadesMedida",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "UsuarioBodega",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Zonas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuentaContable",
                schema: "H2C");
        }
    }
}
