using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCC_Parte1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuxiliarCC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCredito = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    TipoDebito = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Credito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Debito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MontoCredito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDebito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoCliCredito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoDocPPago = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DocumentoDocPPago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MontoCliDebito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MonedaCredito = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MonedaDebito = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CliReporteCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CliReporteDebito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CliDocCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CliDocDebito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoDocIntCte = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DocDocIntCte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FolioSATDebito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FolioSATCredito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoCambioAplica = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AsientoDifCambMR = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EsIntCorriente = table.Column<bool>(type: "bit", nullable: false),
                    DocAsocPerce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxiliarCC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesRetenciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesRetenciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosCC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Contrarecibo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aplicacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaDocumento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoCliente = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoCliente = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioMoneda = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioCliente = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambActLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambActDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambActCli = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Rubro1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Rubro2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Dependiente = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltCredito = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CargadoDeFact = table.Column<bool>(type: "bit", nullable: false),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AsientoPendiente = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaseDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumParcialidades = table.Column<short>(type: "smallint", nullable: false),
                    FechaRevision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CobradorId = table.Column<int>(type: "int", nullable: true),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CtaBancaria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    VendedorId = table.Column<int>(type: "int", nullable: true),
                    ClienteReporte = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteOrigen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Subtipo = table.Column<short>(type: "smallint", nullable: true),
                    PorcIntCte = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoDocOrigen = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DocDocOrigen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaAnul = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AudUsuarioAnul = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    AudFechaAnul = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumDocCB = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FechaCobro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuditoriaCobro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    FechaSeguimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ObservacionesCobro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UsuarioAprobacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Anulado = table.Column<bool>(type: "bit", nullable: true),
                    CodigoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    DivisionGeografica1Id = table.Column<int>(type: "int", nullable: true),
                    DivGeografica1Id = table.Column<int>(type: "int", nullable: false),
                    DivisionGeografica2Id = table.Column<int>(type: "int", nullable: true),
                    DivGeografica2Id = table.Column<int>(type: "int", nullable: false),
                    BaseImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    BaseImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DependienteGP = table.Column<bool>(type: "bit", nullable: false),
                    SaldoTrans = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaProyectada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PorcRecuperacion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    SaldoTransCli = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DocumentoFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Facturado = table.Column<bool>(type: "bit", nullable: false),
                    GeneraDocFE = table.Column<bool>(type: "bit", nullable: false),
                    TasaImpositiva = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaImpositivaPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCre1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCre1Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCre2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCre2Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaGanOcasionalPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    EntidadFinancieraId = table.Column<int>(type: "int", nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CuentaOrigen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UsoCFDI = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ClaveUnidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ClaveProdServi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FormaPago = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    TipoRelacion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClaveReferenciaDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaReferenciaDE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JustiDevHacienda = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Consecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoOperacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ClavePSPub = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ClaveDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoImpuesto2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cancelacion = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    EstadoCancelacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TieneRelacionados = table.Column<bool>(type: "bit", nullable: false),
                    ItemHacienda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Prefijo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaInicioResolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinResolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClaveTecnica = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    MatriculaMercantil = table.Column<int>(type: "int", nullable: true),
                    EsFacturaReemplazo = table.Column<bool>(type: "bit", nullable: false),
                    FacturaOriginalReemplazo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoReferenciaDE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ConsecutivoFTC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumeroFTC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NITTransportador = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CodigoReferenciaDE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NCFModificado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumOCExenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumConsRegExo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumIrsedeAgrGan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ADWMTipoNC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoFactura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoDescuento = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoNC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoND = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NumeroOrden = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ActDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PorcDetrac = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    GUUIDOriginal = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ClaseDocES = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Resolucion = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: true),
                    Serie = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    ControlInterno = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SerieNumero = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosCC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosCC_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "H2C",
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosCC_Cobradores_CobradorId",
                        column: x => x.CobradorId,
                        principalSchema: "H2C",
                        principalTable: "Cobradores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentosCC_DivGeograficas1_DivGeografica1Id",
                        column: x => x.DivGeografica1Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosCC_DivGeograficas2_DivGeografica2Id",
                        column: x => x.DivGeografica2Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DocumentosCC_EntidadesFinancieras_EntidadFinancieraId",
                        column: x => x.EntidadFinancieraId,
                        principalSchema: "H2C",
                        principalTable: "EntidadesFinancieras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentosCC_Paises_PaisId",
                        column: x => x.PaisId,
                        principalSchema: "H2C",
                        principalTable: "Paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentosCC_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalSchema: "H2C",
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RetencionesDocCC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Retencion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocReferencia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Base = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Autoretenedora = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaDocumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaRige = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaContable = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoApliCancelar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    SaldoCancelar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetencionesDocCC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaldosClientes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoCorporacion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoSucursales = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaUltMov = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaldosClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubTiposDocCC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Subtipo = table.Column<short>(type: "smallint", nullable: false),
                    TipoCB = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SubTipoCB = table.Column<short>(type: "smallint", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CalculaImp2 = table.Column<bool>(type: "bit", nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoServicio = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ConceptoNC = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ConceptoFAC = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ConceptoND = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoDoc = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CodigoHacienda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoOperacFac = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoOperacNC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoOperacND = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ConsecutivoFac = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTiposDocCC", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_ClienteId",
                schema: "H2C",
                table: "DocumentosCC",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_CobradorId",
                schema: "H2C",
                table: "DocumentosCC",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_DivGeografica1Id",
                schema: "H2C",
                table: "DocumentosCC",
                column: "DivGeografica1Id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_DivGeografica2Id",
                schema: "H2C",
                table: "DocumentosCC",
                column: "DivGeografica2Id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_EntidadFinancieraId",
                schema: "H2C",
                table: "DocumentosCC",
                column: "EntidadFinancieraId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_PaisId",
                schema: "H2C",
                table: "DocumentosCC",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCC_VendedorId",
                schema: "H2C",
                table: "DocumentosCC",
                column: "VendedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuxiliarCC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ClientesRetenciones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocumentosCC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "RetencionesDocCC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "SaldosClientes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "SubTiposDocCC",
                schema: "H2C");
        }
    }
}
