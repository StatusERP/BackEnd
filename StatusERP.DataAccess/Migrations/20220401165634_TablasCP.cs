using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuxiliarCP",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoDebito = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Debito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoCredito = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Credito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MontoDebito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoProv = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MonedaDebito = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MontoCredito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MonedaCredito = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoDocPPago = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DocumentoDocPPago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoDocIntCte = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DocDocIntCte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FolioSATDebito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FolioSATCredito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoCambioAplica = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AsientoDifCambMR = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MontoTotalRetPago = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CodigoRetPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxiliarCP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesCP",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaUltComprime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LimpiarAplicacion = table.Column<bool>(type: "bit", nullable: false),
                    DetalleObligat = table.Column<bool>(type: "bit", nullable: false),
                    PagoOtraMoneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DocProntoPago = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    UltimoCh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoNC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoOC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoRet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VencPeriodo1 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo2 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo3 = table.Column<short>(type: "smallint", nullable: true),
                    VencPeriodo4 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo1 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo2 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo3 = table.Column<short>(type: "smallint", nullable: true),
                    AntPeriodo4 = table.Column<short>(type: "smallint", nullable: true),
                    UsarRubros = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro2Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ImpuestoPorOmision = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AsientoND = table.Column<bool>(type: "bit", nullable: false),
                    AsientoFac = table.Column<bool>(type: "bit", nullable: false),
                    AsientoInt = table.Column<bool>(type: "bit", nullable: false),
                    AsientoOD = table.Column<bool>(type: "bit", nullable: false),
                    AsientoChq = table.Column<bool>(type: "bit", nullable: false),
                    AsientoTEF = table.Column<bool>(type: "bit", nullable: false),
                    AsientoLC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoNC = table.Column<bool>(type: "bit", nullable: false),
                    AsientoOC = table.Column<bool>(type: "bit", nullable: false),
                    PaqueteCre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoAsientoCre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PaqueteDeb = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoAsientoDeb = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AsientosCtaPais = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionConta = table.Column<bool>(type: "bit", nullable: false),
                    ModAplicAsiento = table.Column<short>(type: "smallint", nullable: false),
                    UltimoQuedan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NITDuplicado = table.Column<bool>(type: "bit", nullable: false),
                    RefrescaAuto = table.Column<bool>(type: "bit", nullable: false),
                    UsarRubrosProv = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1ProvNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro2ProvNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro3ProvNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro4ProvNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Rubro5ProvNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CopiarNotasEnAsnt = table.Column<bool>(type: "bit", nullable: false),
                    AsocObligContFact = table.Column<bool>(type: "bit", nullable: false),
                    UsarRubrosVal = table.Column<bool>(type: "bit", nullable: false),
                    NomRubro1Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro2Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro3Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro4Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro5Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RubrosDiasRev = table.Column<short>(type: "smallint", nullable: true),
                    UsaFechaCont = table.Column<bool>(type: "bit", nullable: false),
                    DiasContables = table.Column<short>(type: "smallint", nullable: true),
                    NumLimiteRet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FechaUltDifCamb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoFac = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoInt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoLC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UltimoOD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NomRubro6Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro7Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro8Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro9Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NomRubro10Pro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    AsignarMismaEntidad = table.Column<bool>(type: "bit", nullable: false),
                    UltimoRed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AsientoIntCorriente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AsientoDet = table.Column<bool>(type: "bit", nullable: false),
                    AsientoPer = table.Column<bool>(type: "bit", nullable: false),
                    AsientoRet = table.Column<bool>(type: "bit", nullable: false),
                    AsientoRed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesCP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodProveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DetalleDireccion = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltMov = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdenMinima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TasaInteresMora = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Local = table.Column<bool>(type: "bit", nullable: false),
                    Congelado = table.Column<bool>(type: "bit", nullable: false),
                    DocTributarioId = table.Column<int>(type: "int", nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    CategoriaProveedorId = table.Column<int>(type: "int", nullable: false),
                    Multimoneda = table.Column<bool>(type: "bit", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rubro1Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro2Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro3Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro4Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro5Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro1Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro2Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro3Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro4Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro5Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GLN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoContribuyente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Rubro6Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro7Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro8Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro9Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro10Proveedor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModeloRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CodigoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DivGeografica1Id = table.Column<int>(type: "int", nullable: true),
                    DivGeografica2Id = table.Column<int>(type: "int", nullable: true),
                    Autoretenedor = table.Column<bool>(type: "bit", nullable: false),
                    RegimenTrib = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    SaldoTrans = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PermiteDocGP = table.Column<bool>(type: "bit", nullable: false),
                    ParticipaFlujoCaja = table.Column<bool>(type: "bit", nullable: false),
                    CURP = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaHoraUltMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Impuesto1Incluido = table.Column<bool>(type: "bit", nullable: false),
                    XSLTPersonalizado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Internaciones = table.Column<bool>(type: "bit", nullable: false),
                    TipoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PorcTarifa = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipificacionProveedor = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ItemHaciendaCompra = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoCF = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    UsaPlame = table.Column<bool>(type: "bit", nullable: false),
                    ImpCategoria = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    SistemaPensiones = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ImpNacional = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ImpPrivado = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Domiciliado = table.Column<bool>(type: "bit", nullable: false),
                    Convenio = table.Column<bool>(type: "bit", nullable: false),
                    NumIdentNoDomic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumIdentFiscBenef = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoVinculacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ExoneracionOper = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    BuenContribuyente = table.Column<bool>(type: "bit", nullable: false),
                    AgenteRetencion = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_CategoriasProveedor_CategoriaProveedorId",
                        column: x => x.CategoriaProveedorId,
                        principalSchema: "H2C",
                        principalTable: "CategoriasProveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_DivGeograficas1_DivGeografica1Id",
                        column: x => x.DivGeografica1Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas1",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Proveedores_DivGeograficas2_DivGeografica2Id",
                        column: x => x.DivGeografica2Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas2",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Proveedores_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_Paises_PaisId",
                        column: x => x.PaisId,
                        principalSchema: "H2C",
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTipoDocCP",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTipo = table.Column<short>(type: "smallint", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TipoCB = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SubTipoCB = table.Column<short>(type: "smallint", nullable: true),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoServicio = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CodigoHacienda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTipoDocCP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleRetencion",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Retencion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Pagada = table.Column<bool>(type: "bit", nullable: false),
                    Base = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Autoretenedora = table.Column<bool>(type: "bit", nullable: false),
                    TipoApliCancelar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    SaldoCancelar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaDocumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaRige = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaContable = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_DetalleRetencion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleRetencion_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoDifCambiarioCP",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioAuditoria = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaAuditoria = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaProc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    TipoCambioProc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    AsientoProc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DifCamLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DifCamDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TCambLocDocAnt = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TCambDolDocAnt = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TCambLocDocAct = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TCambDolDocAct = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NotasRev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoDifCambiarioCP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoDifCambiarioCP_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedorEntidades",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    EntidadFinancieraId = table.Column<int>(type: "int", nullable: false),
                    CuentaBanco = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CtaDefault = table.Column<bool>(type: "bit", nullable: false),
                    TipoCuenta = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CtaElectronica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorEntidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProveedorEntidades_EntidadesFinancieras_EntidadFinancieraId",
                        column: x => x.EntidadFinancieraId,
                        principalSchema: "H2C",
                        principalTable: "EntidadesFinancieras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProveedorEntidades_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Quedans",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumQuedan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaRige = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Congelado = table.Column<bool>(type: "bit", nullable: false),
                    FechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quedans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quedans_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosCP",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EmbarqueAprobado = table.Column<bool>(type: "bit", nullable: false),
                    TipoCambLiqLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoCambLiqDol = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FechaDocumento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoProrrateo = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Etiqueta = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipoEmbarque = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Aplicacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioMoneda = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaUltCredito = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChequeImpreso = table.Column<bool>(type: "bit", nullable: false),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    Seleccionado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Congelado = table.Column<bool>(type: "bit", nullable: false),
                    MontoProv = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoProv = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioProv = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Rubro1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Rubro2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Dependiente = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AsientoPendiente = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoCambActLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambActDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambActProv = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DocumentoEmbarque = table.Column<bool>(type: "bit", nullable: false),
                    FechaRevision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LiquidacCompra = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ChequeCuenta = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuedanId = table.Column<int>(type: "int", nullable: true),
                    SubTipo = table.Column<short>(type: "smallint", nullable: true),
                    FechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAnul = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AudUsuarioAnul = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    AudFechaAnul = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAprobacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MontoPago = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CuentaBanco = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
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
                    Imp1AsumidoDesc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Imp1AsumidoNoDesc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Imp1RetenidoDesc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Imp1RetenidoNoDesc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DocumentoFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EstadoEnvio = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ConceptoME = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ClaseDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    PorcIntCte = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    NumParcialidades = table.Column<short>(type: "smallint", nullable: false),
                    TasaImpositiva = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaImpositivaPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCre1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCre1Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCre2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCre2Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaGanOcasionalPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    GeneraDocFE = table.Column<bool>(type: "bit", nullable: false),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaCAI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoImpuesto2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ConsecutivoDoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ClaveDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoAfectacionIVA = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoImpuestoAfectacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifaAfectacion = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PorcAfectacionIVA = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoTotalImpuestoAcreditar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoTotalGastoAplicable = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoProporcionalidad = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ItemHacienda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    SubTotalBienes = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    SubTotalServicios = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    NCFModificado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DestinoITBis = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipoDocReferencia = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ClaveReferencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaEmisionReferencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoReferencia = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    RazonReferencia = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MontoReferencia = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    GeneDocDetrac = table.Column<bool>(type: "bit", nullable: false),
                    TipoDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ActDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PorcDetrac = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AdValorem = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ValorAduana = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Aduana = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DeducCostoEnajena = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    RentaNeta = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoRenta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ModalidadServicio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AnioDua = table.Column<int>(type: "int", nullable: true),
                    Clasificacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    MontoNoGravado = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
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
                    table.PrimaryKey("PK_DocumentosCP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosCP_DivGeograficas1_DivGeografica1Id",
                        column: x => x.DivGeografica1Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DocumentosCP_DivGeograficas2_DivGeografica2Id",
                        column: x => x.DivGeografica2Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DocumentosCP_Paises_PaisId",
                        column: x => x.PaisId,
                        principalSchema: "H2C",
                        principalTable: "Paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentosCP_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosCP_Quedans_QuedanId",
                        column: x => x.QuedanId,
                        principalSchema: "H2C",
                        principalTable: "Quedans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRetencion_ProveedorId",
                schema: "H2C",
                table: "DetalleRetencion",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCP_DivGeografica1Id",
                schema: "H2C",
                table: "DocumentosCP",
                column: "DivGeografica1Id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCP_DivGeografica2Id",
                schema: "H2C",
                table: "DocumentosCP",
                column: "DivGeografica2Id");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCP_PaisId",
                schema: "H2C",
                table: "DocumentosCP",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCP_ProveedorId",
                schema: "H2C",
                table: "DocumentosCP",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosCP_QuedanId",
                schema: "H2C",
                table: "DocumentosCP",
                column: "QuedanId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoDifCambiarioCP_ProveedorId",
                schema: "H2C",
                table: "HistoricoDifCambiarioCP",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorEntidades_EntidadFinancieraId",
                schema: "H2C",
                table: "ProveedorEntidades",
                column: "EntidadFinancieraId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorEntidades_ProveedorId",
                schema: "H2C",
                table: "ProveedorEntidades",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_CategoriaProveedorId",
                schema: "H2C",
                table: "Proveedores",
                column: "CategoriaProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_DivGeografica1Id",
                schema: "H2C",
                table: "Proveedores",
                column: "DivGeografica1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_DivGeografica2Id",
                schema: "H2C",
                table: "Proveedores",
                column: "DivGeografica2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_DocTributarioId",
                schema: "H2C",
                table: "Proveedores",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_PaisId",
                schema: "H2C",
                table: "Proveedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Quedans_ProveedorId",
                schema: "H2C",
                table: "Quedans",
                column: "ProveedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuxiliarCP",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetalleRetencion",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocumentosCP",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesCP",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "HistoricoDifCambiarioCP",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ProveedorEntidades",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "SubTipoDocCP",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Quedans",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Proveedores",
                schema: "H2C");
        }
    }
}
