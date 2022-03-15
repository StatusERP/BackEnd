using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CorrecPrivilegioUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "CategoriasArticulos",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "ClasificacionesInv",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "ConsecutivosInv",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "ConsecutivosInvUsuarios",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "ExistenciaLotes",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "IngresosLotes",
                schema: "DEMO");

            migrationBuilder.DropTable(
                name: "Lotes",
                schema: "DEMO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    ArticuloDelProv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Bultos = table.Column<short>(type: "smallint", nullable: false),
                    CalculaPercep = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaArticulo = table.Column<decimal>(type: "decimal(18,2)", maxLength: 4, nullable: false),
                    ClaseABC = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Clasificacion1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion3 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion4 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion5 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Clasificacion6 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CodArticulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodigoBarrasInvt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CodigoBarrasVent = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodigoRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CostoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoPromUltimoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoPromUltimoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DiasCuarentena = table.Column<short>(type: "smallint", nullable: false),
                    EsImpuesto = table.Column<bool>(type: "bit", nullable: false),
                    Estilo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ExistenciaMáxima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ExistenciaMínima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FactorConver1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver3 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver4 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver5 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorConver6 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FactorEmpaque = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FactorVenta = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaHoraUltModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FrecuenciaConteo = table.Column<short>(type: "smallint", nullable: false),
                    Impuesto = table.Column<decimal>(type: "decimal(18,2)", maxLength: 4, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LoteMultiplo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Manufacturador = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    MinVidaCompra = table.Column<short>(type: "smallint", nullable: false),
                    MinVidaConsumo = table.Column<short>(type: "smallint", nullable: false),
                    MinVidaVenta = table.Column<short>(type: "smallint", nullable: false),
                    ModalidadInvFis = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ModeloRetencion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObligaCuarentena = table.Column<bool>(type: "bit", nullable: false),
                    OrdenMinima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Perecedero = table.Column<bool>(type: "bit", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PesoNeto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PlazoReabast = table.Column<short>(type: "smallint", nullable: false),
                    PorcPercep = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PrecioBaseDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioBaseLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PuntoDeOrden = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    RetencionCompra = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RetencionVenta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    SugiereMin = table.Column<bool>(type: "bit", nullable: false),
                    Talla = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TiendaEnLinea = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCodBarraAlm = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    TipoCodBarraDet = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    TipoCosto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoDocIVA = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    UltimaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoInventario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoMovimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnidadAlmacen = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UnidadEmpaque = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UnidadVenta = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UsaLotes = table.Column<bool>(type: "bit", nullable: false),
                    UsaNumerosSerie = table.Column<bool>(type: "bit", nullable: false),
                    UsaReglasLocales = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    UsuarioUltModif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    VentaTarjetaCredito = table.Column<bool>(type: "bit", nullable: false),
                    VidaUtilPromedio = table.Column<short>(type: "smallint", nullable: false),
                    Volumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasArticulos",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaArticulo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CtaCompraImp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCompraLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsCobroExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsCobroLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComsVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsDesperdic = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsGasto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsNormal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaConsRetrabajo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostDescExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostDescLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbAju = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbAjuCMV = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbCPGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbIngDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbMatAplicados = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbPerdDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbPuGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCtbRetAsum = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonifExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonifLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLineaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLineaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaFaltInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaFaltanteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaInvRemitido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaInventario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaMatProceso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaSobrInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaSobranteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVariaCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVencimiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExenExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExenLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCompraImp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCompraLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsCobroExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsCobroLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComsVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsDesperdic = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsGasto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsNormal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrConsRetrabajo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostDescExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostDescLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoAju = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoAjuCMV = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoCPGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoIngDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoMatAplicados = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoPerdDevoluc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoPuGar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCtoRetAsum = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonifExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonifLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLineaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLineaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescVentaExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescVentaLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrFaltInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrFaltanteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrInvRemitido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrInventario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrMatProceso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrSobrInventFis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrSobranteRemis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVariaCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVencimiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExenExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExenLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Descripción = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasArticulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClasificacionesInv",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agrupacion = table.Column<short>(type: "smallint", nullable: false),
                    AporteCodigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CodClasificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PlantillaSerie = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TipoCodigoBarras = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UsaNumerosSerie = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionesInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInv",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Editable = table.Column<bool>(type: "bit", nullable: false),
                    EmailCFDI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FormatoImp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MultiplesTrans = table.Column<bool>(type: "bit", nullable: false),
                    SiguienteConsec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TodasTrans = table.Column<bool>(type: "bit", nullable: false),
                    UltFechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UsaTraslado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInvUsuarios",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInvUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExistenciaLotes",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    Bodega = table.Column<int>(type: "int", nullable: false),
                    CantDisponible = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantNoAprobada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantRemitida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantReservada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantVencida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Localización = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistenciaLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngresosLotes",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    SecuenciaLote = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                schema: "DEMO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CodLote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaCuarentena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LoteProveedor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoIngreso = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UltimoIngreso = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                });
        }
    }
}
