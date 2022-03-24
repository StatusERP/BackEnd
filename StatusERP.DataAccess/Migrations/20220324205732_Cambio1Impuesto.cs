using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Cambio1Impuesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CtaImp1Gen",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp1Gen",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FacturaDets",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Linea = table.Column<short>(type: "smallint", nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CostoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Pedido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Localización = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Anulada = table.Column<bool>(type: "bit", nullable: false),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DescTotLinea = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DescTotGeneral = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CantidadDevuelta = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DescuentoVolumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoLinea = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CantidadAceptada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantNoEntregada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PedidoLinea = table.Column<short>(type: "smallint", nullable: true),
                    MultiplicadorEV = table.Column<short>(type: "smallint", nullable: false),
                    SerieCadena = table.Column<int>(type: "int", nullable: true),
                    SerieCadNoAcept = table.Column<int>(type: "int", nullable: true),
                    SerieCadAceptada = table.Column<int>(type: "int", nullable: true),
                    DocumentoOrigen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LineaOrigen = table.Column<short>(type: "smallint", nullable: true),
                    TipoOrigen = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    UnidadDistribucio = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CantDespachada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoEstimLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoEstimDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoRetencion = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    BaseImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    BaseImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CantDevProceso = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoImpuesto2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PorcExoneracion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoExoneracion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    EsOtroCargo = table.Column<bool>(type: "bit", nullable: false),
                    EsCanastaBasica = table.Column<bool>(type: "bit", nullable: false),
                    EsServicioMedico = table.Column<bool>(type: "bit", nullable: false),
                    MontoDevueltoIVA = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PorcExoneracion2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoExoneracion2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoDescuentoLinea = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaDets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDets",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PedidoLinea = table.Column<short>(type: "smallint", nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Localizacion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LineaUsuario = table.Column<short>(type: "smallint", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadPedida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadAFacturar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadFacturada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadReservada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadBonificada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantidadCancelada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoDescuento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MontoDescuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcDescuento = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PedidoLineaBonif = table.Column<short>(type: "smallint", nullable: true),
                    UnidadDistribucio = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    FechaPrometida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LineaOrdenCompra = table.Column<int>(type: "int", nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    RazonPerdida = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TipoDesc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoImpuesto2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PorcExoneracion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoExoneracion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PorcImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PorcImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    EsOtroCargo = table.Column<bool>(type: "bit", nullable: false),
                    EsCanastaBasica = table.Column<bool>(type: "bit", nullable: false),
                    PorcExoneracion2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoExoneracion2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PorcImp1Base = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PorcImp2Base = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoDescuentoLinea = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoDets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoEncs",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Prometida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaProxEmbarqu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltEmbarque = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUltCancelac = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrdenCompra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarjetaCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmbarcarA = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    DirecEmbarque = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Rubro1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComentarioCXC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TotalMercaderia = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoAnticipo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoFlete = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoSeguro = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDocumentacio = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoDescuento1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoDescuento2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MontoDescuento1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDescuento2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcDescuento1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcDescuento2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalAFacturar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcComiVendedor = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcComiCobrador = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalCancelado = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalUnidades = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impreso = table.Column<bool>(type: "bit", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescuentoVolumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoPedido = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MonedaPedido = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    VersionNP = table.Column<int>(type: "int", nullable: false),
                    Autorizado = table.Column<bool>(type: "bit", nullable: false),
                    DocAGenerar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ClasePedido = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Cobrador = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Ruta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Zona = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Vendedor = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteDireccion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteCorporac = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteOrigen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    SubtipoDocCXC = table.Column<short>(type: "smallint", nullable: true),
                    TipoDocCXC = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Backorder = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    PorcIntCte = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DescuentoCascada = table.Column<bool>(type: "bit", nullable: false),
                    DireccionFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FijarTipoCambio = table.Column<bool>(type: "bit", nullable: false),
                    OrigenPedido = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DescDirecEmbarque = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DivisionGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DivisionGeografica2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    BaseImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    BaseImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    NombreCliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FechaProyectada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    VersionCotizacion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RazonCancelaCoti = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DesCancelaCoti = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CambiosCoti = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CotizacionPadre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TasaImpositiva = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaImpositivaPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCree1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCree1Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCree2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCree2Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaGanOcasionalPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UsrNoAprueba = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaNoAprueba = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RazonDesaprueba = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Modulo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CorreosEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormaPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ClaveReferenciaDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaReferenciaDE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    UADWMNumeroVendedor = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    UADWMEnviarGLN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UADWMNumeroRecepcion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADWMNumeroReclamo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UADWMFechaReclamo = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADPCNumeroVendedor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    UADPCEnviarGLN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UADGSNumeroVendedor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    UADGSEnviarGLN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UADGSNumeroRecepcion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADGSFechaRecepcion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADAMNumeroProveedor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    UADAMEnviarGLN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UADAMNumeroRecepcion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADAMNumeroReclamo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UADAMFechaReclamo = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADAMFechaRecepcion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    TipoOperacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    UADCCRemision = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UADCCFechaConsumo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UADCCHojaEntrada = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MontoOtroCargo = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CodigoReferenciaDE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoReferenciaDE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TieneRelacionados = table.Column<bool>(type: "bit", nullable: false),
                    EsFacturaReemplazo = table.Column<bool>(type: "bit", nullable: false),
                    FacturaOriginalReemplazo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConsecutivoFTC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumeroFTC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NITTransportador = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NumOCExenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumConsRegExo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumIRSEdeAgrGan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoDescuentoGlobal = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoFactura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoEncs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropTable(
                name: "FacturaDets",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PedidoDets",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PedidoEncs",
                schema: "H2C");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.AddColumn<string>(
                name: "CtaImp1Gen",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp1Gen",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }
    }
}
