using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.FA
{
    public class DtoPedidoDet
    {
        public int PedidoEncId { get; set; }

        public Int16 PedidoLinea { get; set; }

        public int BodegaId { get; set; }

        public int? LoteId { get; set; }

        public int? LocalizacionId { get; set; }

        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime FechaEntrega { get; set; }

        public Int16 LineaUsuario { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioUnitario { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadPedida { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadAFacturar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadFacturada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadReservada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadBonificada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadCancelada { get; set; }

        [Required(ErrorMessage = "El tipo de descuento es requerido.")]
        [StringLength(1)]
        public string TipoDescuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento { get; set; }

        public string? Descripcion { get; set; }

        [StringLength(100)]
        public string? Comentario { get; set; }

        public Int16? PedidoLineaBonif { get; set; }

        public int? UnidadDistribucionId { get; set; }

        public DateTime FechaPrometida { get; set; }

        public int? LineaOrdenCompra { get; set; }

        public int? CentroCuentaId { get; set; }

        [StringLength(250)]
        public string? RazonPerdida { get; set; }

        [StringLength(4)]
        public string? TipoImpuesto1 { get; set; }

        [StringLength(2)]
        public string? TipoTarifa1 { get; set; }

        [StringLength(4)]
        public string? TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string? TipoTarifa2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcExoneracion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoExoneracion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcImpuesto2 { get; set; }

        public bool EsOtroCargo { get; set; }

        public bool EsCanastaBasica { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcExoneracion2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoExoneracion2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcImp1Base { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcImp2Base { get; set; }
    }
}
