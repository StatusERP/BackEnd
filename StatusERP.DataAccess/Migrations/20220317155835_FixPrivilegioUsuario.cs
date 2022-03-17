using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPrivilegioUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AsistenciaAutomat",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CntrlSeriesEntr",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EAN13ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EAN8ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineasMaxTrans",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModalidadUso",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrioridadBusqueda",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TransacXUsuario",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UCC12ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoBarras",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoEAN13",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoEAN8",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoGeneric",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoUCC12",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaCodigoUCC8",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaConsecutivos",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsaUnidadesDist",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsarAprobacion",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsarNumerosSerie",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Articulos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodArticulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Clasificacion1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion3 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion4 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion5 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion6 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    FactorConver1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver3 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver4 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver5 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver6 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TiendaEnLinea = table.Column<bool>(type: "bit", nullable: false),
                    VentaTarjetaCredito = table.Column<bool>(type: "bit", nullable: false),
                    PesoNeto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Volumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Bultos = table.Column<short>(type: "smallint", nullable: false),
                    CategoriaArticulo = table.Column<decimal>(type: "decimal(18,2)", maxLength: 4, nullable: false),
                    Impuesto = table.Column<decimal>(type: "decimal(18,2)", maxLength: 4, nullable: false),
                    FactorEmpaque = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FactorVenta = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ExistenciaMínima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ExistenciaMáxima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PuntoDeOrden = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioBaseLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioBaseDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    UltimaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoMovimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoInventario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClaseABC = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FrecuenciaConteo = table.Column<short>(type: "smallint", nullable: false),
                    CodigoBarrasVent = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodigoBarrasInvt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    UsaLotes = table.Column<bool>(type: "bit", nullable: false),
                    ObligaCuarentena = table.Column<bool>(type: "bit", nullable: false),
                    MinVidaCompra = table.Column<short>(type: "smallint", nullable: false),
                    MinVidaConsumo = table.Column<short>(type: "smallint", nullable: false),
                    MinVidaVenta = table.Column<short>(type: "smallint", nullable: false),
                    VidaUtilPromedio = table.Column<short>(type: "smallint", nullable: false),
                    DiasCuarentena = table.Column<short>(type: "smallint", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ArticuloDelProv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OrdenMinima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PlazoReabast = table.Column<short>(type: "smallint", nullable: false),
                    LoteMultiplo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsaNumerosSerie = table.Column<bool>(type: "bit", nullable: false),
                    ModalidadInvFis = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    TipoCodBarraDet = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    TipoCodBarraAlm = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    UsaReglasLocales = table.Column<bool>(type: "bit", nullable: false),
                    UnidadAlmacen = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UnidadEmpaque = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UnidadVenta = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Perecedero = table.Column<bool>(type: "bit", nullable: false),
                    Manufacturador = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RetencionVenta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RetencionCompra = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ModeloRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Estilo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Talla = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TipoCosto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CostoPromUltimoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoPromUltimoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    EsImpuesto = table.Column<bool>(type: "bit", nullable: false),
                    TipoDocIVA = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SugiereMin = table.Column<bool>(type: "bit", nullable: false),
                    CalculaPercep = table.Column<bool>(type: "bit", nullable: false),
                    PorcPercep = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasArticulos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaArticulo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrInventario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaInventario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCompraLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCompraLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCompraImp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCompraImp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsCobroLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsCobroLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsCobroExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsCobroExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLineaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLineaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLineaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLineaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostDescLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostDescLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostDescExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostDescExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrSobrInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaSobrInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrFaltInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaFaltInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVariaCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVariaCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVencimiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVencimiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrSobranteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaSobranteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrFaltanteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaFaltanteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrInvRemitido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaInvRemitido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrMatProceso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaMatProceso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsNormal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsNormal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsRetrabajo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsRetrabajo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsGasto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsGasto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsDesperdic = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsDesperdic = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonifLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonifLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonifExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonifExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoRetAsum = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbRetAsum = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoAju = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbAju = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoAjuCMV = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbAjuCMV = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoCPGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbCPGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoPuGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbPuGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoIngDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbIngDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoPerdDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbPerdDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoMatAplicados = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbMatAplicados = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExenLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExenLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExenExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExenExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasArticulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClasificacionesInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodClasificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Agrupacion = table.Column<short>(type: "smallint", nullable: false),
                    UsaNumerosSerie = table.Column<bool>(type: "bit", nullable: false),
                    PlantillaSerie = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AporteCodigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TipoCodigoBarras = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionesInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiguienteConsec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Editable = table.Column<bool>(type: "bit", nullable: false),
                    MultiplesTrans = table.Column<bool>(type: "bit", nullable: false),
                    FormatoImp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UltFechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TodasTrans = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    UsaTraslado = table.Column<bool>(type: "bit", nullable: false),
                    EmailCFDI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInvUsuarios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInvUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosInvEnc",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaqueteInventario = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DocumentoInv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Consecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaHorCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDocumento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Seleccionado = table.Column<bool>(type: "bit", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MensajeSistema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioApro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraAprob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosInvEnc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExistenciaLotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodega = table.Column<int>(type: "int", nullable: false),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    Localización = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    CantDisponible = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantReservada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantNoAprobada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantVencida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantRemitida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistenciaLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngresosLotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    SecuenciaLote = table.Column<int>(type: "int", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodLote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LoteProveedor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCuarentena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoIngreso = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimoIngreso = table.Column<int>(type: "int", nullable: false),
                    FechaFabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovsInventarioDet",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    FechaHoraTransac = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AjusteConfig = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Localizacion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Subtipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Subsubtipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Contabilizada = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    UnidadDistribucion = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AsientoCardex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DocFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoOperacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovsInventarioDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovsInventarioEnc",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModuloOrigen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Aplicacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UsuarioAprob = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraAprob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaqueteInventario = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovsInventarioEnc", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IxUsuarioId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CategoriasArticulos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ClasificacionesInv",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosInv",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosInvUsuarios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocumentosInvEnc",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ExistenciaLotes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "IngresosLotes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Lotes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovsInventarioDet",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovsInventarioEnc",
                schema: "H2C");

            migrationBuilder.DropIndex(
                name: "IxUsuarioId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.DropColumn(
                name: "AsistenciaAutomat",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "CntrlSeriesEntr",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "EAN13ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "EAN8ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "LineasMaxTrans",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "ModalidadUso",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "PrioridadBusqueda",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "TransacXUsuario",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UCC12ReglaLocal",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoBarras",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoEAN13",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoEAN8",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoGeneric",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoUCC12",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaCodigoUCC8",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaConsecutivos",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsaUnidadesDist",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsarAprobacion",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "UsarNumerosSerie",
                schema: "H2C",
                table: "GlobalesCI");
        }
    }
}
