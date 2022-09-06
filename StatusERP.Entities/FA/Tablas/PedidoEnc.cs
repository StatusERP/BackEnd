using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CC.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoEncs", Schema = Constants.Conjunto)]
    public class PedidoEnc:EntityBase
    {
        [StringLength(50) ]
        public string Pedido { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime Fecha_Prometida { get; set; }

        public DateTime FechaProxEmbarqu { get; set; }

        public DateTime ? FechaUltEmbarque { get; set;}

        public DateTime ? FechaUltCancelac { get; set; }

        [StringLength(30)]
        public string ? OrdenCompra { get; set; }

        public DateTime ? FechaOrden { get; set; }

        [StringLength(20)]
        public string ? TarjetaCredito { get; set; }

        [StringLength(160)]
        public string ? EmbarcarA { get; set; }

        [StringLength(8)]
        public string DirecEmbarque { get; set; }

        [StringLength (50)]
        public string ? Rubro1 { get; set; }

        [StringLength(50)]
        public string? Rubro2 { get; set; }

        [StringLength(50)]
        public string? Rubro3 { get; set; }

        [StringLength(50)]
        public string? Rubro4 { get; set; }

        [StringLength(50)]
        public string? Rubro5 { get; set; }

        public string? Observaciones { get; set; }

        [StringLength(40)]
        public string? ComentarioCXC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalMercaderia { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoAnticipo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoFlete { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoSeguro { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDocumentacio { get; set; }

        [StringLength(1)]
        public string TipoDescuento1 { get; set; }

        [StringLength(1)]
        public string TipoDescuento2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalAFacturar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcComiVendedor { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcComiCobrador { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCancelado { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalUnidades { get; set; }

        public bool Impreso { get; set; }

        public DateTime FechaHora { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoVolumen { get; set; }

        [StringLength(1)]
        public string TipoPedido { get; set; }

        [StringLength(1)]
        public string MonedaPedido { get; set; }

        public int VersionNivelPrecioId { get; set; }
        [ForeignKey(nameof(VersionNivelPrecioId))]
        public VersionNivelPrecio  versionNivelPrecio { get; set; }

        public bool Autorizado { get; set; }

        [StringLength(1)]
        public string DocAGenerar { get; set; }

        [StringLength(1)]
        public string ClasePedido { get; set; }


        public int CobradorId { get; set; }
        [ForeignKey(nameof(CobradorId))]
        public Cobrador cobrador { get; set; }

        public int RutaId { get; set; }
        [ForeignKey(nameof(RutaId))]
        public Ruta ruta { get; set; }

        [StringLength(250)]
        public string Usuario { get; set; }

        public int CondicionPagoId { get; set; }
        [ForeignKey(nameof(CondicionPagoId))]
        public CondicionPago condicionPago { get; set; }

        public int BodegaId { get; set; }
        [ForeignKey(nameof(BodegaId))]
        public Bodega bodega { get; set; }

        public int ZonaId { get; set; }
        [ForeignKey(nameof(ZonaId))]
        public Zona zona { get; set; }

        public int VendedorId { get; set; }
        [ForeignKey(nameof(VendedorId))]
        public Vendedor vendedor { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        public Cliente cliente { get; set; }

        public int ClienteDireccionId { get; set; }
        [ForeignKey(nameof(ClienteDireccionId))]
        public Cliente clienteDireccion { get; set; }

        public int ClienteCorporacId { get; set; }
        [ForeignKey(nameof(ClienteCorporacId))]
        public Cliente clienteCorporac { get; set; }

        public int ClienteOrigenId { get; set; }
        [ForeignKey(nameof(ClienteOrigenId))]
        public Cliente clienteOrigen { get; set; }

        [StringLength(20)]
        public string CodCliente { get; set; }

        public int PaisId { get; set; }
        [ForeignKey(nameof(PaisId))]
        public Pais pais { get; set; }

        public int? SubTipoDocCCId { get; set; }
        [ForeignKey(nameof(SubTipoDocCCId))]
        public SubTipoDocCC subTipoDocCC { get; set; }

        [StringLength(1)]
        public string Backorder { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcIntCte { get; set; }

        public bool DescuentoCascada { get; set; }

        public string DireccionFactura { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TipoCambio { get; set; }

        public bool FijarTipoCambio { get; set; }
        
        [StringLength(1)]
        public string? OrigenPedido { get; set; }
        
        [StringLength(250)]
        public string? DescDirecEmbarque { get; set; }

        [StringLength(12)]
        public string? DivisionGeografica1 { get; set; }

        [StringLength(12)]
        public string? DivisionGeografica2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto2 { get; set; }

        [StringLength(150)]
        public string? NombreCliente { get; set; }

        public DateTime? FechaProyectada { get; set; }
        
        public DateTime? FechaAprobacion { get; set; }

        [StringLength(1)]
        public string TipoDocumento { get; set; }
        
        [StringLength(10)]
        public string? VersionCotizacion { get; set; }
        
        public string? RazonCancelaCoti { get; set; }
        
        [StringLength(250)]
        public string? DesCancelaCoti { get; set; }
        
        [StringLength(250)]
        public string? CambiosCoti { get; set; }
        
        [StringLength(50)]
        public string? CotizacionPadre { get; set; }
        
        [StringLength(4)]
        public string? TasaImpositiva { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TasaImpositivaPorc { get; set; }
        
        [StringLength(4)]
        public string? TasaCree1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TasaCree1Porc { get; set; }
        
        [StringLength(4)]
        public string? TasaCree2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TasaCree2Porc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TasaGanOcasionalPorc { get; set; }
        
        [StringLength(250)]
        public string? UsrNoAprueba { get; set; }
        
        public DateTime? FechaNoAprueba { get; set; }
        
        public string? RazonDesaprueba { get; set; }
        
        [StringLength(4)]
        public string? Modulo { get; set; }
        
        public string? CorreosEnvio { get; set; }
        
        [StringLength(3)]
        public string? Incoterms { get; set; }
       
        [StringLength(4)]
        public string? TipoOperacion { get; set; }

        [StringLength(10)]
        public string? ActividadComercial { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoOtroCargo { get; set; }

        public bool TieneRelacionados { get; set; }

        public bool EsFacturaReemplazo { get; set; }

        [StringLength(50)]
        public string? FacturaOriginalReemplazo { get; set; }

        [StringLength(10)]
        public string? ConsecutivoFTC { get; set; }

        [StringLength(50)]
        public string? NumeroFTC { get; set; }

        [StringLength(20)]
        public string? NITTransportador { get; set; }

        [StringLength(100)]
        public string? NumOCExenta { get; set; }
    }
}
