using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoEncs", Schema = Constants.Conjunto)]
    public class PedidoEnc:EntityBase
    {
        [Required(ErrorMessage = "El pedido es requerido.") ]
        [StringLength(50) ]
        public string Pedido { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es requerida.")]
        public DateTime FechaPedido { get; set; }

        [Required(ErrorMessage = "La fecha prometida es requerida.")]
        public DateTime Fecha_Prometida { get; set; }

        [Required(ErrorMessage = "La fecha del próximo embarque es requerida.")]
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

        [Required(ErrorMessage = "La dirección de embarque es requerida.")]
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

        [Required(ErrorMessage = "El total de mercadería es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalMercaderia { get; set; }

        [Required(ErrorMessage = "El monto del anticipo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoAnticipo { get; set; }

        [Required(ErrorMessage = "El monto del flete es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoFlete { get; set; }

        [Required(ErrorMessage = "El monto del seguro es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoSeguro { get; set; }

        [Required(ErrorMessage = "El monto de la documentacio es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDocumentacio { get; set; }

        [Required(ErrorMessage = "El tipo descuento 1 es requerido.")]
        [StringLength(1)]
        public string TipoDescuento1 { get; set; }

        [Required(ErrorMessage = "El tipo descuento 2 es requerido.")]
        [StringLength(1)]
        public string TipoDescuento2 { get; set; }

        [Required(ErrorMessage = "El monto descuento 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento1 { get; set; }

        [Required(ErrorMessage = "El monto descuento 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento2 { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento1 { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento2 { get; set; }

        [Required(ErrorMessage = "El total del impuesto 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto1 { get; set; }

        [Required(ErrorMessage = "El total del impuesto 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto2 { get; set; }

        [Required(ErrorMessage = "El total a facturar es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalAFacturar { get; set; }

        [Required(ErrorMessage = "El porcentaje de comisión del vendedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcComiVendedor { get; set; }

        [Required(ErrorMessage = "El porcentaje de comisión del cobrador es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcComiCobrador { get; set; }

        [Required(ErrorMessage = "El total cancelado es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCancelado { get; set; }

        [Required(ErrorMessage = "El total de unidades es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalUnidades { get; set; }

        public bool Impreso { get; set; }

        [Required(ErrorMessage = "La fecha y la hora son requeridas.")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "El descuento por volumen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoVolumen { get; set; }

        [Required(ErrorMessage = "El tipo de pedido es requerido.")]
        [StringLength(1)]
        public string TipoPedido { get; set; }

        [Required(ErrorMessage = "La moneda del pedido es requerida.")]
        [StringLength(1)]
        public string MonedaPedido { get; set; }

        [Required(ErrorMessage = "La versión del nivel de precios es requerida.")]
        public int VersionNP { get; set; }

        public bool Autorizado { get; set; }

        [Required(ErrorMessage = "El documento a generar es requerido.")]
        [StringLength(1)]
        public string DocAGenerar { get; set; }

        [Required(ErrorMessage = "La clase de pedido es requerida.")]
        [StringLength(1)]
        public string ClasePedido { get; set; }

        [Required(ErrorMessage = "El tipo de moneda es requerido.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El nivel de precio es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = "El cobrador es requerido.")]
        [StringLength(4)]
        public string Cobrador { get; set; }

        [Required(ErrorMessage = "La ruta es requerida.")]
        [StringLength(4)]
        public string Ruta { get; set; }

        [Required(ErrorMessage = "El usuario es requerido.")]
        [StringLength(450)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "La bodega es requerida.")]
        [StringLength(4)]
        public string Bodega { get; set; }

        [Required(ErrorMessage = "La zona es requerida.")]
        [StringLength(4)]
        public string Zona { get; set; }

        [Required(ErrorMessage = "El vendedor es requerido.")]
        [StringLength(4)]
        public string Vendedor { get; set; }

        [Required(ErrorMessage = "El cliente es requerido.")]
        [StringLength(20)]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El cliente dirección es requerido.")]
        [StringLength(20)]
        public string ClienteDireccion { get; set; }

        [Required(ErrorMessage = "El cliente corporación es requerido.")]
        [StringLength(20)]
        public string ClienteCorporac { get; set; }

        [Required(ErrorMessage = "El cliente origen es requerido.")]
        [StringLength(20)]
        public string ClienteOrigen { get; set; }

        [Required(ErrorMessage = "El país es requerido.")]
        [StringLength(4)]
        public string Pais { get; set; }

        public Int16? SubtipoDocCXC { get; set; }

        [StringLength(3)]
        public string? TipoDocCXC { get; set; }

        [Required(ErrorMessage = "Se debe indicar el tipo de backorder.")]
        [StringLength(1)]
        public string Backorder { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcIntCte { get; set; }

        public bool DescuentoCascada { get; set; }

        [Required(ErrorMessage = "La dirección a utilizar en la factura es requerida.")]
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

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(1)]
        public string TipoDocumento { get; set; }
        
        [StringLength(10)]
        public string? VersionCotizacion { get; set; }
        
        [StringLength(10)]
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
        
        [StringLength(450)]
        public string? UsrNoAprueba { get; set; }
        
        public DateTime? FechaNoAprueba { get; set; }
        
        [StringLength(250)]
        public string? RazonDesaprueba { get; set; }
        
        [StringLength(4)]
        public string? Modulo { get; set; }
        
        public string? CorreosEnvio { get; set; }
        
        [StringLength(4)]
        public string? FormaPago { get; set; }
        
        [StringLength(50)]
        public string? ClaveReferenciaDE { get; set; }
        
        public DateTime? FechaReferenciaDE { get; set; }  
        
        [StringLength(3)]
        public string? Incoterms { get; set; }
        
        [StringLength(9)]
        public string? UADWMNumeroVendedor { get; set; }
        
        [StringLength(13)]
        public string? UADWMEnviarGLN { get; set; }
        
        [StringLength(8)]
        public string? UADWMNumeroRecepcion { get; set; }
        
        [StringLength(10)]
        public string? UADWMNumeroReclamo { get; set; }
        
        [StringLength(8)]
        public string? UADWMFechaReclamo { get; set; }
        
        [StringLength(12)]
        public string? UADPCNumeroVendedor { get; set; }
        
        [StringLength(13)]
        public string? UADPCEnviarGLN { get; set; }
        
        [StringLength(12)]
        public string? UADGSNumeroVendedor { get; set; }
        
        [StringLength(13)]
        public string? UADGSEnviarGLN { get; set; }

        [StringLength(8)]
        public string? UADGSNumeroRecepcion { get; set; }

        [StringLength(8)]
        public string? UADGSFechaRecepcion { get; set; }

        [StringLength(12)]
        public string? UADAMNumeroProveedor { get; set; }

        [StringLength(13)]
        public string? UADAMEnviarGLN { get; set; }

        [StringLength(8)]
        public string? UADAMNumeroRecepcion { get; set; }

        [StringLength(10)]
        public string? UADAMNumeroReclamo { get; set; }

        [StringLength(8)]
        public string? UADAMFechaReclamo { get; set; }

        [StringLength(8)]
        public string? UADAMFechaRecepcion { get; set; }

        [StringLength(4)]
        public string? TipoOperacion { get; set; }

        [StringLength(8)]
        public string? UADCCRemision { get; set; }
        
        public DateTime? UADCCFechaConsumo { get; set; }

        [StringLength(8)]
        public string? UADCCHojaEntrada { get; set; }

        [StringLength(10)]
        public string? ActividadComercial { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoOtroCargo { get; set; }

        [StringLength(2)]
        public string? CodigoReferenciaDE { get; set; }

        [StringLength(4)]
        public string? TipoReferenciaDE { get; set; }

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

        [StringLength(100)]
        public string? NumConsRegExo { get; set; }

        [StringLength(100)]
        public string? NumIRSEdeAgrGan { get; set; }

        [StringLength(10)]
        public string? TipoPago { get; set; }

        [StringLength(2)]
        public string? TipoDescuentoGlobal { get; set; }

        [StringLength(10)]
        public string? TipoFactura { get; set; }
    }
}
