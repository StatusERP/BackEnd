using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("EscalasBonif", Schema = Constants.Conjunto)]
    public class EscalaBonif:EntityBase 
    {
        [Required(ErrorMessage ="El nivel precio es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }

        [Required(ErrorMessage = "El artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [Required(ErrorMessage = "La escala de bonificación es requerida.")]
        public int CodEscalaBonif { get; set; }

        [Required(ErrorMessage = "La versión de bonificación es requerida.")]
        public int VersionBonif { get; set; }

        [Required(ErrorMessage = "El código del artículo bonificado es requerido.")]
        [StringLength(20)]
        public string ArticuloBonif { get; set; }

        [Required(ErrorMessage = "La cantidad mínima de artículos facturados es requerida.")]
        public int MinArtFact { get; set; }

        public int ? MaxArtFact { get; set; }

        [Required(ErrorMessage = "Las unidades bonificadas son requeridas.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal UnidadesBonif { get; set; }

        [Required(ErrorMessage = "La fecha inicio es requerida.")]
        public DateTime FechaInicioEsc { get; set; }

        [Required(ErrorMessage = "La fecha fin es requerida.")]
        public DateTime FechaFinEsc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? FactorBonif { get; set; }

        public DateTime ? FechaUltModif { get; set; }

        [StringLength(25)]
        public string ? UsuarioUltModif { get; set; }
    }
}
