using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasFA_Parte2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BonifsArtXCli",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EscalaBonif = table.Column<int>(type: "int", nullable: false),
                    VersionBonif = table.Column<int>(type: "int", nullable: false),
                    CantidadInicial = table.Column<int>(type: "int", nullable: false),
                    CantidadFinal = table.Column<int>(type: "int", nullable: false),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactorBonif = table.Column<decimal>(type: "decimal(15,5)", nullable: true),
                    ArticuloBonif = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UnidadesBonif = table.Column<decimal>(type: "decimal(15,5)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonifsArtXCli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BonifsClasXCli",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Clasificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EscalaBonif = table.Column<int>(type: "int", nullable: false),
                    VersionBonif = table.Column<int>(type: "int", nullable: false),
                    CantidadInicial = table.Column<int>(type: "int", nullable: false),
                    CantidadFinal = table.Column<int>(type: "int", nullable: false),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactorBonif = table.Column<decimal>(type: "decimal(15,5)", nullable: true),
                    ArticuloBonif = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UnidadesBonif = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonifsClasXCli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecuFAUsuarios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CodigoConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecuFAUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesBonEscalaBonificacion",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regla = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CantidadMinima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadMaxima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Factor = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadInicial = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadPedida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    UnidadAlmacen = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UnidadDetalle = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CantMinimaDet = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantMaximaDet = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FactorDet = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadInicialDet = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadInicialConsol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesBonEscalaBonificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EscalasBonif",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodEscalaBonif = table.Column<int>(type: "int", nullable: false),
                    VersionBonif = table.Column<int>(type: "int", nullable: false),
                    ArticuloBonif = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MinArtFact = table.Column<int>(type: "int", nullable: false),
                    MaxArtFact = table.Column<int>(type: "int", nullable: true),
                    UnidadesBonif = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaInicioEsc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinEsc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactorBonif = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FechaUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscalasBonif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EscalasDcto",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodEscalaDcto = table.Column<int>(type: "int", nullable: false),
                    VersionDcto = table.Column<int>(type: "int", nullable: false),
                    MinUnidFact = table.Column<int>(type: "int", nullable: true),
                    MaxUnidFact = table.Column<int>(type: "int", nullable: true),
                    PorcDcto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaInicioEsc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinEsc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscalasDcto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesFA",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Llave = table.Column<short>(type: "smallint", nullable: true),
                    BodegaDefault = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CondPagoContado = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    VendedorObligator = table.Column<bool>(type: "bit", nullable: false),
                    FactExcPedido = table.Column<bool>(type: "bit", nullable: false),
                    UsaTarjetaCred = table.Column<bool>(type: "bit", nullable: false),
                    BodegaPorLinea = table.Column<bool>(type: "bit", nullable: false),
                    PermiteBackorder = table.Column<bool>(type: "bit", nullable: false),
                    CancelPedParcial = table.Column<bool>(type: "bit", nullable: false),
                    PedAImpresora = table.Column<bool>(type: "bit", nullable: false),
                    DocAImpresora = table.Column<bool>(type: "bit", nullable: false),
                    ImpreLoteSeparad = table.Column<bool>(type: "bit", nullable: false),
                    FacturaMultipag = table.Column<bool>(type: "bit", nullable: false),
                    NCRNumFactura = table.Column<bool>(type: "bit", nullable: false),
                    MultipleFMTFactu = table.Column<bool>(type: "bit", nullable: false),
                    MultipleFMTPedid = table.Column<bool>(type: "bit", nullable: false),
                    OrdenLineasFact = table.Column<bool>(type: "bit", nullable: false),
                    ReimpresionPedido = table.Column<bool>(type: "bit", nullable: false),
                    ImpPedidoAlFact = table.Column<bool>(type: "bit", nullable: false),
                    RedondearFactura = table.Column<bool>(type: "bit", nullable: false),
                    FactorRedondeo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PreciosDec = table.Column<short>(type: "smallint", nullable: false),
                    DescEnPrecio = table.Column<bool>(type: "bit", nullable: false),
                    Imp1EnPrecio = table.Column<bool>(type: "bit", nullable: false),
                    Imp1AfectaDescto = table.Column<bool>(type: "bit", nullable: false),
                    AplicaNiPrImp1 = table.Column<bool>(type: "bit", nullable: false),
                    MonedaImp1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    NivPrecioImp1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    PagoComParcial = table.Column<bool>(type: "bit", nullable: false),
                    PorcImpComision = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AsientoVentaPor = table.Column<bool>(type: "bit", nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CtrFlete = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaFlete = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrSeguro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaSeguro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDocumentanci = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDocumentaci = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpComisio = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpComisio = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    UsarRubros = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro2Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro3Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro4Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UsaBoletas = table.Column<bool>(type: "bit", nullable: false),
                    NomRubro6Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro7Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro8Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro9Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro5Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivPrePublico = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    MonedaPublico = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ColumnasEstandar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsientoCostoPor = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CambiarEsqTrab = table.Column<bool>(type: "bit", nullable: false),
                    FactDocsVencidos = table.Column<bool>(type: "bit", nullable: false),
                    FactCobroJud = table.Column<bool>(type: "bit", nullable: false),
                    FactLimiteCred = table.Column<bool>(type: "bit", nullable: false),
                    ModAplicAsiento = table.Column<short>(type: "smallint", nullable: false),
                    IntegracionConta = table.Column<bool>(type: "bit", nullable: false),
                    TipoContaOmision = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCambio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PrecisionMaxima = table.Column<bool>(type: "bit", nullable: false),
                    LineasArticulo = table.Column<short>(type: "smallint", nullable: false),
                    LineasFactura = table.Column<short>(type: "smallint", nullable: false),
                    LineasAdicionales = table.Column<short>(type: "smallint", nullable: false),
                    DetalleKits = table.Column<bool>(type: "bit", nullable: false),
                    MonedaPrecios = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Prevista1 = table.Column<bool>(type: "bit", nullable: true),
                    Prevista2 = table.Column<bool>(type: "bit", nullable: true),
                    Prevista3 = table.Column<bool>(type: "bit", nullable: true),
                    Prevista4 = table.Column<bool>(type: "bit", nullable: true),
                    Prevista5 = table.Column<bool>(type: "bit", nullable: true),
                    CtrConsumo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CCEnLinea = table.Column<bool>(type: "bit", nullable: false),
                    CGEnLinea = table.Column<bool>(type: "bit", nullable: false),
                    UsarAutorizacion = table.Column<bool>(type: "bit", nullable: false),
                    Imp1EnBonifica = table.Column<bool>(type: "bit", nullable: false),
                    Imp2EnBonifica = table.Column<bool>(type: "bit", nullable: false),
                    AsientoContCXCPor = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UsarAprobPedidos = table.Column<bool>(type: "bit", nullable: false),
                    NomRubro10Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ListaPrecios = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MargenUtilidad = table.Column<bool>(type: "bit", nullable: false),
                    MontoMinimo = table.Column<bool>(type: "bit", nullable: false),
                    DocVencidos = table.Column<bool>(type: "bit", nullable: false),
                    LimiteCredito = table.Column<bool>(type: "bit", nullable: false),
                    CobroJudicial = table.Column<bool>(type: "bit", nullable: false),
                    SinOC = table.Column<bool>(type: "bit", nullable: false),
                    DiasAtraso = table.Column<bool>(type: "bit", nullable: false),
                    MontoMinimoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoMinimoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    SaldoMaxLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    SaldoMaxDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MaxDiasAtraso = table.Column<short>(type: "smallint", nullable: true),
                    MaxDocsVenc = table.Column<short>(type: "smallint", nullable: true),
                    PreciosDecDolar = table.Column<short>(type: "smallint", nullable: false),
                    CondPagoNivPre = table.Column<bool>(type: "bit", nullable: false),
                    FactListaPrecios = table.Column<bool>(type: "bit", nullable: false),
                    FactMargenUtilid = table.Column<bool>(type: "bit", nullable: false),
                    FactMontoMinimo = table.Column<bool>(type: "bit", nullable: false),
                    FactDiasAtraso = table.Column<bool>(type: "bit", nullable: false),
                    FactSinOC = table.Column<bool>(type: "bit", nullable: false),
                    UsarRubrosVal = table.Column<bool>(type: "bit", nullable: false),
                    ImpDescClasific = table.Column<bool>(type: "bit", nullable: false),
                    LimitarMaxLineas = table.Column<bool>(type: "bit", nullable: false),
                    IndicadPedido = table.Column<bool>(type: "bit", nullable: false),
                    PrecioCosto = table.Column<bool>(type: "bit", nullable: false),
                    FactMenorReserva = table.Column<bool>(type: "bit", nullable: false),
                    AnulaCXCAplicado = table.Column<bool>(type: "bit", nullable: false),
                    TipoCostoNoExist = table.Column<bool>(type: "bit", nullable: false),
                    CalculoImp2 = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaCliente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MonedaNivel = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DescuentoCascada = table.Column<bool>(type: "bit", nullable: false),
                    Retenciones = table.Column<bool>(type: "bit", nullable: false),
                    RetencionesFletes = table.Column<bool>(type: "bit", nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AplicarDescGen = table.Column<bool>(type: "bit", nullable: false),
                    ModoDescMult = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DctoGeneral = table.Column<bool>(type: "bit", nullable: false),
                    FactDctoGeneral = table.Column<bool>(type: "bit", nullable: false),
                    AutorGrabar = table.Column<bool>(type: "bit", nullable: false),
                    AutroAprobar = table.Column<bool>(type: "bit", nullable: false),
                    AutorFactuRemitir = table.Column<bool>(type: "bit", nullable: false),
                    AutorFactRemision = table.Column<bool>(type: "bit", nullable: false),
                    CargarAprobadoCC = table.Column<bool>(type: "bit", nullable: false),
                    RemisionAImpres = table.Column<bool>(type: "bit", nullable: false),
                    DevolucAImpres = table.Column<bool>(type: "bit", nullable: false),
                    NomRubro16Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro17Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro18Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro19Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro20Cli = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreaNuevoCliente = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesFA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaquetesDescuento",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPaqueteDescuento = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TodaTienda = table.Column<bool>(type: "bit", nullable: false),
                    FechaRige = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHoraInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaHoraFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaquetesDescuento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReglasDescuento",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodReglaDescuento = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Prioridad = table.Column<int>(type: "int", nullable: true),
                    CategoriaCliente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Clasificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ArticuloPatron = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDescuento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CantidadCompra = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CantidadFacturar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Clasificacion2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion3 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion4 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion5 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion6 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    RequiereAutorizacion = table.Column<bool>(type: "bit", nullable: false),
                    FormaPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DetalleFormaPago = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MinimoDocumento = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MinimoPago = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DescFormaPago = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReglasDescuento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VersionesNivelPrecio",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCorte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAprobacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAnulacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraAnulacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Identificador = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Impuesto1Incluido = table.Column<bool>(type: "bit", nullable: false),
                    PrecioReferenciaDE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    SincMovil = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionesNivelPrecio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BonifsArtXCli",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "BonifsClasXCli",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecuFAUsuarios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DesBonEscalaBonificacion",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "EscalasBonif",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "EscalasDcto",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesFA",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PaquetesDescuento",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ReglasDescuento",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "VersionesNivelPrecio",
                schema: "H2C");
        }
    }
}
