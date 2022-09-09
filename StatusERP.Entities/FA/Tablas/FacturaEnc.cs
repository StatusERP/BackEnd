using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Entities.CC.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("FacturaEncs", Schema = Constants.Conjunto)]
    public class FacturaEnc:EntityBase
    {
        [StringLength(1)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string Factura { get; set; } 

        public int? MovInventarioEncId { get; set; }
        [ForeignKey(nameof(MovInventarioEncId))]
        public MovInventarioEnc movInventarioEnc { get; set; }
                  
        public bool EnInvestigacion { get; set; }
        
        public bool TransAdicionales { get; set; }

        [StringLength(1)]
        public string EstadoRemision { get; set; }

        [StringLength(10)]
        public string ? PartidaDocumento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoVolumen { get; set; }

        [StringLength(1)]
        public string MonedaFactura { get; set; }

        [StringLength(40)]
        public string ? ComentarioCXC { get; set; }

        public DateTime FechaDespacho { get; set; }

        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        public DateTime FechaRecibido { get; set; }

        [StringLength(50)]
        public string ? Pedido { get; set; }

        [StringLength(50)]
        public string ? FacturaOriginal { get; set; }

        [StringLength(1)]
        public string ? TipoOriginal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ComisionCobrador { get; set; }

        [StringLength(20)]
        public string ? TarjetaCredito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalVolumen { get; set; }

        [StringLength(10)]
        public string ? NumeroAutoriza { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalPeso { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCobrado { get; set; }


        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto1 { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorDescuento2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoFlete { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoSeguro { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDocumentacio { get; set; }

        [StringLength(1)]
        public string TipoDescuento1 {get; set;}

        [StringLength(1)]
        public string TipoDescuento2 {get; set;}

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalFactura { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime ? FechaHoraAnula { get; set; }

        public DateTime ? FechaOrden { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalMercaderia { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ComisionVendedor { get; set; }

        [StringLength(30)]
        public string ? OrdenCompra { get; set; }

        public DateTime FechaHora { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalUnidades { get; set; }

        public Int16 NumeroPaginas { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambio { get; set; }

        public bool Anulada { get; set; }

        [StringLength(4)]
        public string Modulo { get; set; }

        public bool CargadoCG { get; set; }

        public bool CargadoCXC { get; set; }

        [StringLength(160)]
        public string ? EmbarcarA { get; set; }

        [StringLength(8)]
        public string ? DirecEmbarque { get; set; }

        public Int16 MultiplicadorEV { get; set; }

        public string ? Observaciones { get; set; } 

        [StringLength(50)]
        public string ? Rubro1 { get; set; }

        [StringLength(50)]
        public string? Rubro2 { get; set; }

        [StringLength(50)]
        public string? Rubro3 { get; set; }

        [StringLength(50)]
        public string? Rubro4 { get; set; }

        [StringLength(50)]
        public string? Rubro5 { get; set; }

        public int VersionNPId { get; set; }
        [ForeignKey(nameof(VersionNPId))]
        public VersionNivelPrecio VersionNivelPrecio { get; set; }

        public int CobradorId { get; set; }
        [ForeignKey(nameof(CobradorId))]
        public Cobrador Cobrador { get; set; }

        public int RutaId { get; set; }
        [ForeignKey(nameof(RutaId))]
        public Ruta Ruta { get; set; }

        [StringLength(250)]
        public string Usuario { get; set; }

        [StringLength(250)]
        public string ? UsuarioAnula { get; set; }

        public int CondicionPagoId { get; set; }
        [ForeignKey(nameof(CondicionPagoId))]
        public CondicionPago condicionPago { get; set; }

        public int ZonaId { get; set; }
        [ForeignKey(nameof(ZonaId))]
        public Zona zona { get; set; }

        public int VendedorId { get; set; }
        [ForeignKey(nameof(VendedorId))]
        public Vendedor vendedor { get; set; }

        public int? DocCreditoCCId { get; set; }
        [ForeignKey(nameof(DocCreditoCCId))]
        public DocumentosCC documentosCC { get; set; }

        public int ClienteDireccionId { get; set; }
        [ForeignKey(nameof(ClienteDireccionId))]
        public Cliente clienteDireccion { get; set; }

        public int ClienteCorporacId { get; set; }
        [ForeignKey(nameof(ClienteCorporacId))]
        public Cliente clienteCorporac { get; set; }

        public int ClienteOrigenId { get; set; }
        [ForeignKey(nameof(ClienteOrigenId))]
        public Cliente clienteOrigen { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        public Cliente cliente { get; set; }

        public int PaisId { get; set; }
        [ForeignKey(nameof(PaisId))]
        public Pais pais { get; set; }

        public int? SubTipoDocCCId { get; set; }
        [ForeignKey(nameof(SubTipoDocCCId))]
        public SubTipoDocCC subTipoDocCC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoAnticipo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TotalPesoNeto { get; set; }

        public DateTime FechaRige { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcIntCte { get; set; }

        public bool Cobrada { get; set; }

        public bool DescuentoCascada { get; set; }

        public string ? DireccionFactura { get; set; }

        public int ? DireccEmbarqueId { get; set; }
        [ForeignKey(nameof(DireccEmbarqueId))]
        public DireccEmbarque direccEmbarque { get; set; }

        public int? ConsecutivoId { get; set; }
        [ForeignKey(nameof(ConsecutivoId))]
        public ConsecutivoFA consecutivo { get; set; }

        public bool Reimpreso { get; set; }

        public int? DivisionGeografica1Id { get; set; }
        [ForeignKey(nameof(DivisionGeografica1Id))]
        public DivGeografica1 DivGeografica1 { get; set; }

        public int? DivisionGeografica2Id { get; set; }
        [ForeignKey(nameof(DivisionGeografica2Id))]
        public DivGeografica2 DivGeografica2 { get; set; }


        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto2 { get; set; }

        [StringLength(150)]
        public string? NombreCliente { get; set; }

        [StringLength(50)]
        public string ? DocFiscal { get; set; }

        [StringLength(20)]
        public string ? NombreMaquina { get; set; }

        [StringLength(20)]
        public string ? SerieResolución { get; set; }

        public int ? ConsecResolucion { get; set; }

        public bool GeneraDocFE { get; set; }

        [StringLength(4)]
        public string ? TasaImpositiva { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaImpositivaPorc { get; set; }

        [StringLength(4)]
        public string ? TasaCree1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaCree1Porc { get; set; }

        [StringLength(4)]
        public string ? TasaCree2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaCree2Porc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? AjusteRedondeo { get; set; }

        [StringLength(4)]
        public string ? FormaPago { get; set; }

        [StringLength(2)]
        public string ? JustiDevHaciend { get; set; }

        [StringLength(3)]
        public string ? Incoterms { get; set; }

       
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoOtroCargo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoTotalIVADevuelto { get; set; }

        [StringLength(2)]
        public string ? Cancelacion { get; set; }

        [StringLength(20)]
        public string ? EstadoCancelación { get; set; }

        public bool TieneRelacionados { get; set; }

        [StringLength(25)]
        public string ? Prefijo { get; set; }

        public DateTime ? FechaInicioResolucion { get; set; }

        public DateTime ? FechaFinalResolucion { get; set; }

        [StringLength(80)]
        public string ? ClaveTecnica { get; set; }

        public int ? MatriculaMercantil { get; set; }

        public bool EsFacturaReemplazo { get; set; }

        public int ? FacOriginalReemplazoId { get; set; }
        [ForeignKey(nameof(FacOriginalReemplazoId))]
        public FacturaEnc FacOriginalReemplazo { get; set; }

        [StringLength(10)]
        public string ? ConsecutivoFTC { get; set; }

        [StringLength(50)]
        public string ? NumeroFTC { get; set; }

        [StringLength(20)]
        public string ? NITTransportador { get; set; }

        [StringLength(50)]
        public string ? NCFModificado { get; set; }

        [StringLength(100)]

        public string ? NumOCExenta { get; set; }
    }
}
