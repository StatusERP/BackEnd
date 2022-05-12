using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("MovsInventarioDet", Schema = Constants.Conjunto)]
    public class MovInventarioDet:EntityBase
    {
        public int Consecutivo { get; set; }
        public DateTime ? FechaHoraTransac {get; set; }
        public int ? DocTributarioId { get; set; }
        public DocTributario docTributario { get; set; }
        public int ? AjusteConfigId { get; set; }
        public AjusteConfig ajusteConfig { get; set; }
        public int ArticuloId { get; set; }
        public Articulo articulo { get; set; }
        public int ? BodegaId { get; set; }
        public Bodega bodega { get; set; }
        public int ? LocalizacionId { get; set;}
        public Localizacion localizacion { get; set; }
        public int ? LoteId { get; set; }
        public Lote lote { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El subtipo es requerido.")]
        [StringLength(1)]
        public string Subtipo { get; set; }

        [Required(ErrorMessage = "El subsubtipo es requerido.")]
        [StringLength(1)]
        public string Subsubtipo { get; set; }

        [Required(ErrorMessage = "La naturaleza es requerida.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El costo total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotLoc { get; set; }

        [Required(ErrorMessage = "El costo total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotDol { get; set; }

        [Required(ErrorMessage = "El precio total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Required(ErrorMessage = "El precio total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        public bool Contabilizada { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        public int ? CentroCuentaId { get; set; }
        public CentroCuenta centroCuenta { get; set; }

        public int ? UnidadDistribucion { get; set; }
        public UnidadMedida unidadMedida { get; set; }

  
        [StringLength(10)]
        public string ? AsientoCardex { get; set; }

        [StringLength(50)]
        public string ? DocFiscal { get; set; }

        [StringLength(4)]
        public string ? TipoOperacion { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }           
    }
}
