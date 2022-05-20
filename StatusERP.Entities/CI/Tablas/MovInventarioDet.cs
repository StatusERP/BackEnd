using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("MovsInventarioDet", Schema = Constants.Conjunto)]
    public class MovInventarioDet:EntityBase
    {
        public int MovInventarioEncId { get; set; }
        public MovInventarioEnc movInventarioEnc { get; set; }

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

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(1)]
        public string Subtipo { get; set; }

        [Required]
        [StringLength(1)]
        public string Subsubtipo { get; set; }

        [Required]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotDol { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        public bool Contabilizada { get; set; }

        public DateTime Fecha { get; set; }

        public int ? CentroCuentaId { get; set; }
        public CentroCuenta centroCuenta { get; set; }

        public int ? UnidadDistribucionId { get; set; }
        [ForeignKey(nameof(UnidadDistribucionId))]
        public UnidadMedida unidadMedida { get; set; }

        [StringLength(10)]
        public string ? AsientoCardex { get; set; }

        [StringLength(50)]
        public string ? DocFiscal { get; set; }

        public int ? TipoOperacionId { get; set; }
        public TipoOperacion tipoOperacion { get; set; }

        public int? TipoPagoId { get; set; }
        [ForeignKey(nameof(TipoPagoId))]
        public TipoPago tipoPago { get; set; }
    }
}
