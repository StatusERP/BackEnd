using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoDets", Schema = Constants.Conjunto)]
    public class PedidoDet:EntityBase
    {
        [Required(ErrorMessage="El número de pedido es requerido." )]
        [StringLength(50)]
        public string Pedido { get; set; }

        [Required(ErrorMessage = "El número de línea de pedido es requerido.")]
        public Int16 PedidoLinea { get; set; }

        [Required(ErrorMessage = "La bodega es requerida.")]
        [StringLength(4)]
        public string Bodega { get; set; }

        [StringLength(15)]
        public string ? Lote { get; set; }

        [StringLength(8)]
        public String ? Localizacion { get; set; }

        [Required(ErrorMessage = "El código de artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La fecha de entrega.")]
        public DateTime FechaEntrega { get; set; }

        [Required(ErrorMessage = "La línea de Usuario es requerida.")]
        public Int16 LineaUsuario { get; set; }

        [Required(ErrorMessage = "El precio unitario es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "La cantidad pedida es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadPedida { get; set; }

        [Required(ErrorMessage = "La cantidad a facturar es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadAFacturar { get; set; }

        [Required(ErrorMessage = "La cantidad facturada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadFacturada { get; set; }

        [Required(ErrorMessage = "La cantidad reservada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadReservada { get; set; }

        [Required(ErrorMessage = "La cantidad bonificada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadBonificada { get; set; }

        [Required(ErrorMessage = "La cantidad cancelada es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadCancelada { get; set; }

        [Required(ErrorMessage = "El tipo de descuento es requerido.")]
        [StringLength(1)]
        public string TipoDescuento { get; set; }

        [Required(ErrorMessage = "El monto del descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento { get; set; }

        public string ? Descripcion { get; set; }

        [StringLength(100)]
        public string ? Comentario { get; set; }

        public Int16 ? PedidoLineaBonif { get; set; }

        [StringLength(6)]
        public string ? UnidadDistribucio { get; set; }

        [Required(ErrorMessage = "La fecha prometida es requerida.")]
        public DateTime FechaPrometida { get; set; }

        public int ? LineaOrdenCompra { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(250)]
        public string ? RazonPerdida { get; set; }

        [StringLength(10)]
        public string ? TipoDesc { get; set; }

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

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcImpuesto2 { get; set; }

        public bool EsOtroCargo { get; set; }

        public bool EsCanastaBasica { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcExoneracion2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoExoneracion2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcImp1Base { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcImp2Base { get; set; }

        [StringLength(2)]
        public string ? TipoDescuentoLinea { get; set; }
    }
}
