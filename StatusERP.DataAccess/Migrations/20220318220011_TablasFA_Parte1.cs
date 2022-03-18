using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasFA_Parte1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticuloPrecios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VersionArticulo = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    EsquemaTrabajo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MargenMULR = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MargenUtilidad = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MargenUtilidadMin = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloPrecios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirEmbarqueDefault = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contribuyente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Multimoneda = table.Column<bool>(type: "bit", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoCredito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoNoCargos = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    LimiteCredito = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ExcederLimite = table.Column<bool>(type: "bit", nullable: false),
                    TasaInteres = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TasaInteresesMora = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaUltMora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltMov = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MonedaNivel = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AceptaBackorder = table.Column<bool>(type: "bit", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Zona = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Ruta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Vendedor = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Cobrador = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AceptaFracciones = table.Column<bool>(type: "bit", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    ExentoImpuestos = table.Column<bool>(type: "bit", nullable: false),
                    ExencionImp1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ExencionImp2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CobroJudicial = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaCliente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ClaseABC = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DiasAbastecimien = table.Column<short>(type: "smallint", nullable: false),
                    UsaTarjeta = table.Column<bool>(type: "bit", nullable: false),
                    TarjetaCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipoTarjeta = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    FechaVenceTar = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RequiereOC = table.Column<bool>(type: "bit", nullable: false),
                    EsCorporacion = table.Column<bool>(type: "bit", nullable: false),
                    CliCorporacAsoc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegistrarDocsACorp = table.Column<bool>(type: "bit", nullable: false),
                    UsarDirEmbCorp = table.Column<bool>(type: "bit", nullable: false),
                    AplicacAbiertas = table.Column<bool>(type: "bit", nullable: false),
                    VerifLimCredCorp = table.Column<bool>(type: "bit", nullable: false),
                    UsarDescCorp = table.Column<bool>(type: "bit", nullable: false),
                    DocAGenerar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Rubro1_Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro2_Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro3_Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TieneConvenio = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiasPromAtraso = table.Column<short>(type: "smallint", nullable: false),
                    Rubro1Cli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro2Cli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro3Cli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro4Cli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro5Cli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AsocObligContFact = table.Column<bool>(type: "bit", nullable: false),
                    Rubro4Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro5Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro6Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro7Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro8Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro9Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro10Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UsarPreciosCorp = table.Column<bool>(type: "bit", nullable: false),
                    UsarExencImpCorp = table.Column<bool>(type: "bit", nullable: false),
                    DiasDeCobro = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    AjusteFechaCobro = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClaseDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Local = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoContribuyente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Rubro11Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro12Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro13Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro14Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro15Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro16Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro17Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro18Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro19Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro20Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModeloRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AceptaDocElectronico = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmaDocElectronico = table.Column<bool>(type: "bit", nullable: false),
                    EmailDocElectronico = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailPedEDI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AceptaDocEDI = table.Column<bool>(type: "bit", nullable: false),
                    NotificarErrorEDI = table.Column<bool>(type: "bit", nullable: false),
                    EmailErrorPedEDI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodigoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DivisionGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DivisionGeografica2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    RegimenTrib = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Moroso = table.Column<bool>(type: "bit", nullable: false),
                    ModifNombEnFac = table.Column<bool>(type: "bit", nullable: false),
                    SaldoTrans = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PermiteDocGP = table.Column<bool>(type: "bit", nullable: false),
                    ParticipaFlujoCaja = table.Column<bool>(type: "bit", nullable: false),
                    CURP = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FchHoraUltMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailDocElectronicoCopia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DetallarKits = table.Column<bool>(type: "bit", nullable: false),
                    XsltPersonalizado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NombreAddenda = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GeoLatitud = table.Column<decimal>(type: "decimal(28,12)", nullable: true),
                    GeoLongitud = table.Column<decimal>(type: "decimal(28,12)", nullable: true),
                    DivisionGeografica3 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DivisionGeografica4 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    SubTipoDoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    APIRecepcionDE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UsaAPIRecepcion = table.Column<bool>(type: "bit", nullable: false),
                    UserAPIRecepcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PassAPIRecepecion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TipoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipificacionCliente = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    AfectacionIVA = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    EsExtranjero = table.Column<bool>(type: "bit", nullable: false),
                    ItemHacienda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoGenerar = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoPersoneria = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UsoCFDI = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EsAgentePercepcion = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosFA",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UsuarioUlt = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Longitud = table.Column<short>(type: "smallint", nullable: false),
                    ValorConsecutivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaHoraUlt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Formato = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UsaEsquemaCajas = table.Column<bool>(type: "bit", nullable: false),
                    ValorMaximo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroCopias = table.Column<int>(type: "int", nullable: false),
                    Original = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Copia1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Copia2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Copia3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Copia4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Copia5 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Reimpresion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Resolucion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Serie = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DeConsRPT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ValorInicial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeCCRPT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MatriculaMercantil = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosFA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposFactura",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Factura = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Boleta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LiquidacionCompra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposFactura", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticuloPrecios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosFA",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposFactura",
                schema: "H2C");
        }
    }
}
