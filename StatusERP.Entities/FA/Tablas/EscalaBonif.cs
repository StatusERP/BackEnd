using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("EscalasBonif", Schema = Constants.Conjunto)]
    public class EscalaBonif:EntityBase 
    {
        public int VersionNivelId { get; set; }
        [ForeignKey(nameof(VersionNivelId))]
        public VersionNivelPrecio VersionNivelPrecio { get; set; }

        public int ArticuloId { get; set; }
        [ForeignKey(nameof(ArticuloId))]
        public Articulo Articulo { get; set; }

        public int NumEscalaBonif { get; set; }

        public int VersionBonif { get; set; }

        public int ArticuloBonifId { get; set; }
        [ForeignKey(nameof(ArticuloBonifId))]
        public Articulo ArticuloBonif { get; set; }

        public int MinArtFact { get; set; }

        public int ? MaxArtFact { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal UnidadesBonif { get; set; }

        public DateTime FechaInicioEsc { get; set; }

        public DateTime FechaFinEsc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? FactorBonif { get; set; }

        public DateTime ? FechaUltModif { get; set; }

        [StringLength(250)]
        public string ? UsuarioUltModif { get; set; }
    }
}
