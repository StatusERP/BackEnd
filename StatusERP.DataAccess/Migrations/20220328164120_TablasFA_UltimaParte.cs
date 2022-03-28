using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasFA_UltimaParte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacturaEncs",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Factura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MovInventarioEncId = table.Column<int>(type: "int", nullable: true),
                    EstaDespachado = table.Column<bool>(type: "bit", nullable: false),
                    EnInvestigacion = table.Column<bool>(type: "bit", nullable: false),
                    TransAdicionales = table.Column<bool>(type: "bit", nullable: false),
                    EstadoRemision = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AsientoDocumento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DescuentoVolumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MonedaFactura = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ComentarioCXC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FechaDespacho = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClaseDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaRecibido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pedido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FacturaOriginal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoOriginal = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ComisionCobrador = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TarjetaCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TotalVolumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    NumeroAutoriza = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TotalPeso = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoCobrado = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorDescuento2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoFlete = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoSeguro = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDocumentacio = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoDescuento1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoDescuento2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MontoDescuento1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDescuento2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcDescuento1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalFactura = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraAnula = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalMercaderia = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ComisionVendedor = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    OrdenCompra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalUnidades = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    NumeroPaginas = table.Column<short>(type: "smallint", nullable: false),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Anulada = table.Column<bool>(type: "bit", nullable: false),
                    Modulo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CargadoCG = table.Column<bool>(type: "bit", nullable: false),
                    CargadoCXC = table.Column<bool>(type: "bit", nullable: false),
                    EmbarcarA = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    DirecEmbarque = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    MultiplicadorEV = table.Column<short>(type: "smallint", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rubro1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubro5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VersionNP = table.Column<int>(type: "int", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CobradorId = table.Column<int>(type: "int", nullable: false),
                    RutaId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioAnula = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    DocCreditoCXC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClienteDireccion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteCorporac = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteOrigen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    SubTipoDocCXC = table.Column<short>(type: "smallint", nullable: true),
                    TipoCreditoCXC = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    TipoDocCXC = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    MontoAnticipo = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TotalPesoNeto = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    FechaRige = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PorcIntCte = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Cobrada = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoCascada = table.Column<bool>(type: "bit", nullable: false),
                    DireccionFactura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionEmbarque = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Consecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Reimpreso = table.Column<bool>(type: "bit", nullable: false),
                    DivisionGeografica1Id = table.Column<int>(type: "int", nullable: true),
                    DivGeografica1Id = table.Column<int>(type: "int", nullable: false),
                    DivisionGeografica2Id = table.Column<int>(type: "int", nullable: true),
                    DivGeografica2Id = table.Column<int>(type: "int", nullable: false),
                    BaseImpuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    BaseImpuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    NombreCliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DocFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreMaquina = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SerieResolución = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ConsecResolucion = table.Column<int>(type: "int", nullable: true),
                    GeneraDocFE = table.Column<bool>(type: "bit", nullable: false),
                    TasaImpositiva = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaImpositivaPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCree1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCree1Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaCree2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TasaCree2Porc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TasaGanOcasionalPorc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AjusteRedondeo = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UsoCFDI = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    FormaPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ClaveReferenciaDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaReferenciaDE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JustiDevHaciend = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
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
                    ClaveDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MontoOtroCargo = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoTotalIVADevuelto = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CodigoReferenciaDE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoReferenciaDE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Cancelacion = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    EstadoCancelación = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TieneRelacionados = table.Column<bool>(type: "bit", nullable: false),
                    Prefijo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaInicioResolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinalResolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClaveTecnica = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    MatriculaMercantil = table.Column<int>(type: "int", nullable: true),
                    EsFacturaReemplazo = table.Column<bool>(type: "bit", nullable: false),
                    FacturaOriginalReemplazo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConsecutivoFTC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumeroFTC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NITTransportador = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NCFModificado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumOCExenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumConsRegExo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumIRSedeAgrGan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UADWMTipoNC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CuentaAsiento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoDescuentoGlobal = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoFactura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoNC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ActDetrac = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PorcDetrac = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    GUUIDOriginal = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaEncs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "H2C",
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Cobradores_CobradorId",
                        column: x => x.CobradorId,
                        principalSchema: "H2C",
                        principalTable: "Cobradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_DivGeograficas1_DivGeografica1Id",
                        column: x => x.DivGeografica1Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_DivGeograficas2_DivGeografica2Id",
                        column: x => x.DivGeografica2Id,
                        principalSchema: "H2C",
                        principalTable: "DivGeograficas2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Paises_PaisId",
                        column: x => x.PaisId,
                        principalSchema: "H2C",
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalSchema: "H2C",
                        principalTable: "Rutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalSchema: "H2C",
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaEncs_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalSchema: "H2C",
                        principalTable: "Zonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ClienteId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_CobradorId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_DivGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivGeografica1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_DivGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivGeografica2Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_PaisId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_RutaId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_VendedorId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ZonaId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ZonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaEncs",
                schema: "H2C");
        }
    }
}
