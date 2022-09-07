using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoDets", Schema = Constants.Conjunto)]
    public class PedidoDet:EntityBase
    {
        public int? PedidoEncId { get; set; }
        [ForeignKey(nameof(PedidoEncId))]
        public PedidoEnc pedidoEnc { get; set; }

        public Int16 PedidoLinea { get; set; }

        public int? BodegaId { get; set; }
        [ForeignKey(nameof(BodegaId))]
        public Bodega bodega { get; set; }

        public int? LoteId { get; set; }
        [ForeignKey(nameof(LoteId))]
        public Lote lote { get; set; }

        public int? LocalizacionId { get; set; }
        [ForeignKey(nameof(LocalizacionId))]
        public Localizacion localizacion { get; set; }

        public int ArticuloId { get; set; }
        [ForeignKey(nameof(ArticuloId))]
        public Articulo articulo { get; set; }

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

        [StringLength(1)]
        public string TipoDescuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDescuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDescuento { get; set; }

        public string ? Descripcion { get; set; }

        [StringLength(100)]
        public string ? Comentario { get; set; }

        public Int16 ? PedidoLineaBonif { get; set; }

        public int? UnidadDistribucionId { get; set; }
        [ForeignKey(nameof(UnidadDistribucionId))]
        public UnidadMedida unidadDistribucion { get; set; }

        public DateTime FechaPrometida { get; set; }

        public int ? LineaOrdenCompra { get; set; }

        public int? CentroCuentaId { get; set; }
        [ForeignKey(nameof(CentroCuentaId))]
        public CentroCuenta centroCuenta { get; set; }

        [StringLength(250)]
        public string ? RazonPerdida { get; set; }

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
    }
}
