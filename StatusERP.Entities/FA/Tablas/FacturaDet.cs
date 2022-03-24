using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("FacturaDets", Schema = Constants.Conjunto)]
    public class FacturaDet:EntityBase
    {
        [Required(ErrorMessage = "El número de factura es requerido." )]
        [StringLength(50)]
        public string Factura { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(1)]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "La línea es requerida.")]
        public Int16 Linea { get; set; }

        [Required(ErrorMessage = "La bodega es requerida.")]
        [StringLength(4)]
        public string Bodega { get; set; }

        [Required(ErrorMessage = "Debe indicarse el costo total en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalDolar { get; set; }

        [StringLength(50)]
        public string ? Pedido { get; set; }

        [Required(ErrorMessage = "Debe indicarse el artículo.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [StringLength(8)]
        public string ? Localización { get; set; }

        [StringLength(15)]
        public string ? Lote { get; set; }

        public bool Anulada { get; set; }

        [Required(ErrorMessage = "La fecha de la factura es requerida.")]
        public DateTime FechaFactura { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "El total del impuesto 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto1 { get; set; }

        [Required(ErrorMessage = "El total del impuesto 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalImpuesto2 { get; set; }

        [Required(ErrorMessage = "El descuento total por línea es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescTotLinea { get; set; }

        [Required(ErrorMessage = "El descuento total general es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescTotGeneral { get; set; }

        [Required(ErrorMessage = "El costo total es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotal { get; set; }

        [Required(ErrorMessage = "El precio total es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotal { get; set; }

        public string ? Descripcion { get; set; }

        [StringLength(100)]
        public string ? Comentario { get; set; }

        [Required(ErrorMessage = "La cantidad devuelta es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadDevuelta { get; set; }

        [Required(ErrorMessage = "El descuento volumen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoVolumen { get; set; }

        [Required(ErrorMessage = "El tipo línea es requerido.")]
        [StringLength(1)]
        public string TipoLinea { get; set; }

        [Required(ErrorMessage = "La cantidad aceptada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadAceptada { get; set; }

        [Required(ErrorMessage = "La cantidad no entrega es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoEntregada { get; set; }

        [Required(ErrorMessage = "El costo total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalLocal { get; set; }

        public Int16 ? PedidoLinea { get; set; }

        [Required(ErrorMessage = "El multiplicado EV es requerido.")]
        public Int16 MultiplicadorEV { get; set; }

        public int ? SerieCadena { get; set; }

        public int? SerieCadNoAcept { get; set; }

        public int? SerieCadAceptada { get; set; }

        [StringLength(50)]
        public string ? DocumentoOrigen { get; set; }

        public Int16 ? LineaOrigen { get; set; }

        [StringLength(1)]
        public string ? TipoOrigen { get; set; }

        [StringLength(6)]
        public string ? UnidadDistribucio { get; set; }

        [Required(ErrorMessage = "La cantidad despachada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDespachada { get; set; }

        [Required(ErrorMessage = "El costo estimado en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoEstimLocal { get; set; }

        [Required(ErrorMessage = "El costo estimado en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoEstimDolar { get; set; }

        [Required(ErrorMessage = "El monto de la retención es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoRetencion { get; set; }

       [Column(TypeName = "decimal(28,8)")]
        public decimal ? BaseImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? BaseImpuesto2 { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [Required(ErrorMessage = "La cantidad a devolver en proceso es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDevProceso { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto1 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa1 { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcExoneracion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoExoneracion { get; set; }

        public bool EsOtroCargo { get; set; }

        public bool EsCanastaBasica { get; set; }

        public bool EsServicioMedico { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoDevueltoIVA { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcExoneracion2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoExoneracion2 { get; set; }

        [StringLength(2)]
        public string? TipoDescuentoLinea { get; set; }
    }
}
