using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("FacturaEncs", Schema = Constants.Conjunto)]
    public class FacturaEnc:EntityBase
    {
        [Required(ErrorMessage="El tipo de documento es requerido." )]
        [StringLength(1)]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El número de factura es requerido.")]
        [StringLength(50)]
        public string Factura { get; set; }
        
        public int ? MovInventarioEncId { get; set; }
        
        public bool EstaDespachado { get; set; }
        
        public bool EnInvestigacion { get; set; }
        
        public bool TransAdicionales { get; set; }

        [Required(ErrorMessage = "El estado de la remisión es requerido.")]
        [StringLength(1)]
        public string EstadoRemision { get; set; }

        [StringLength(10)]
        public string ? AsientoDocumento { get; set; }

        [Required(ErrorMessage = "El descuento volumen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoVolumen { get; set; }

        [Required(ErrorMessage = "La moneda factura es requerida.")]
        [StringLength(1)]
        public string MonedaFactura { get; set; }

        [StringLength(40)]
        public string ? ComentarioCXC { get; set; }

        [Required(ErrorMessage = "La fecha de despacho es requerida.")]
        public DateTime FechaDespacho { get; set; }

        [Required(ErrorMessage = "La clase de documento es requerida.")]
        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [Required(ErrorMessage = "La fecha de recibido es requerida.")]
        public DateTime FechaRecibido { get; set; }

        [StringLength(50)]
        public string ? Pedido { get; set; }

        [StringLength(50)]
        public string ? FacturaOriginal { get; set; }

        [StringLength(1)]
        public string ? TipoOriginal { get; set; }

        [Required(ErrorMessage = "La comisión del cobrador es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ComisionCobrador { get; set; }

        [StringLength(20)]
        public string ? TarjetaCredito { get; set; }

        [Required(ErrorMessage = "El total de volumen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalVolumen { get; set; }

        [StringLength(10)]
        public string ? NumeroAutoriza { get; set; }

        [Required(ErrorMessage = "El total de peso es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalPeso { get; set; }

        [Required(ErrorMessage = "El monto cobrado es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCobrado { get; set; }

        [Required(ErrorMessage = "El total de impuesto 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto1 { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La fecha de entrega es requerida.")]
        public DateTime FechaEntrega { get; set; }

        [Required(ErrorMessage = "El total de impuesto 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto2 { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorDescuento2 { get; set; }

        [Required(ErrorMessage = "El monto del flete es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoFlete { get; set; }

        [Required(ErrorMessage = "El monto del seguro es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoSeguro { get; set; }

        [Required(ErrorMessage = "El monto de la documentación es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDocumentacio { get; set; }

        [Required(ErrorMessage = "El tipo de descuento 1 es requerido.")]
        [StringLength(1)]
        public string TipoDescuento1 {get; set;}

        [Required(ErrorMessage = "El tipó de descuento 2 es requerido.")]
        [StringLength(1)]
        public string TipoDescuento2 {get; set;}

        [Required(ErrorMessage = "El monto del descuento 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento1 { get; set; }

        [Required(ErrorMessage = "El monto del descuento 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento2 { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento1 { get; set; }

        [Required(ErrorMessage = "El total de la factura es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalFactura { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es requerida.")]
        public DateTime FechaPedido { get; set; }

        public DateTime ? FechaHoraAnula { get; set; }

        public DateTime ? FechaOrden { get; set; }

        [Required(ErrorMessage = "El total de mercadería es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalMercaderia { get; set; }

        [Required(ErrorMessage = "La comisión del vendedor es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ComisionVendedor { get; set; }

        [StringLength(30)]
        public string ? OrdenCompra { get; set; }

        [Required(ErrorMessage = "La fecha y la hora son requeridas.")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "El total de unidades es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalUnidades { get; set; }

        [Required(ErrorMessage = "El número de páginas es requerido.")]
        public Int16 NumeroPaginas { get; set; }

        [Required(ErrorMessage = "El tipo de cambio es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambio { get; set; }

        public bool Anulada { get; set; }

        [Required(ErrorMessage = "El módulo es requerido.")]
        [StringLength(4)]
        public string Modulo { get; set; }

        public bool CargadoCG { get; set; }

        public bool CargadoCXC { get; set; }

        [StringLength(160)]
        public string ? EmbarcarA { get; set; }

        [StringLength(8)]
        public string ? DirecEmbarque { get; set; }

        [Required(ErrorMessage = "El multiplicador EV es requerido.")]
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

        [Required(ErrorMessage = "La versión del Nivel de Precios es requerida.")]
        public int VersionNP { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El nivel de precios es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = " El cobrador es requerido.")]
        public int CobradorId { get; set; }
        public Cobrador Cobrador {get; set;}

        [Required(ErrorMessage = "La ruta es requerida.")]
        public int RutaId { get; set; }
        public Ruta Ruta { get; set; }

        [Required(ErrorMessage = "El usuario es requerido.")]
        [StringLength(450)]
        public string Usuario { get; set; }

        [StringLength(450)]
        public string ? UsuarioAnula { get; set; }

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "La zona es requerida.")]
        public int ZonaId { get; set; }
        public Zona Zona { get; set; }

        [Required(ErrorMessage = " El vendedor es requerido.")]
        public int VendedorId { get; set; }
        public Vendedor Vendedor { set; get; }

        [StringLength(50)]
        public string ? DocCreditoCXC { get; set; }

        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(20)]
        public string ClienteDireccion { get; set; }

        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(20)]
        public string ClienteCorporac { get; set; }

        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(20)]
        public string ClienteOrigen { get; set; }

        [Required(ErrorMessage = "El cliente es requerido.")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "El país es requerido.")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        public Int16 ? SubTipoDocCXC { get; set; }

        [StringLength(3)]
        public string ? TipoCreditoCXC { get; set; }

        [StringLength(3)]
        public string ? TipoDocCXC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoAnticipo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TotalPesoNeto { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime FechaRige { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcIntCte { get; set; }

        public bool Cobrada { get; set; }

        public bool DescuentoCascada { get; set; }

        public string ? DireccionFactura { get; set; }

        [StringLength(250)]
        public string ? DireccionEmbarque { get; set; }

        [StringLength(10)]
        public string ? Consecutivo { get; set; }

        public bool Reimpreso { get; set; }

        public int ? DivisionGeografica1Id { get; set; }
        public DivGeografica1 DivGeografica1 { get; set; }
                
        public int? DivisionGeografica2Id { get; set; }
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
        public decimal ? TasaGanOcasionalPorc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? AjusteRedondeo { get; set; }

        [StringLength(3)]
        public string ? UsoCFDI { get; set; }

        [StringLength(4)]
        public string ? FormaPago { get; set; }

        [StringLength(50)]
        public string ? ClaveReferenciaDE { get; set; }

        public DateTime ? FechaReferenciaDE { get; set; }

        [StringLength(2)]
        public string ? JustiDevHaciend { get; set; }

        [StringLength(3)]
        public string ? Incoterms { get; set; }

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

        [StringLength(50)]
        public string ? ClaveDE { get; set; }

        [StringLength(10)]
        public string ? ActividadComercial { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoOtroCargo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoTotalIVADevuelto { get; set; }

        [StringLength(2)]
        public string ? CodigoReferenciaDE { get; set; }

        [StringLength(4)]
        public string ? TipoReferenciaDE { get; set; }

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

        [StringLength(50)]
        public string ? FacturaOriginalReemplazo { get; set; }

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

        [StringLength(100)]
        public string ? NumConsRegExo { get; set; }

        [StringLength(100)]
        public string ? NumIRSedeAgrGan { get; set; }

        [StringLength(30)]
        public string ? UADWMTipoNC { get; set; }

        [StringLength(1)]
        public string ? CuentaAsiento { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }

        [StringLength(2)]
        public string ? TipoDescuentoGlobal { get; set; }

        [StringLength(10)]
        public string ? TipoFactura { get; set; }

        [StringLength(2)]
        public string ? TipoNC { get; set; }

        [StringLength(4)]
        public string ? TipoDetrac { get; set; }

        [StringLength(4)]
        public string ? ActDetrac { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcDetrac { get; set; }

        [StringLength(40)]
        public string ? GUUIDOriginal { get; set; }
     }
}
