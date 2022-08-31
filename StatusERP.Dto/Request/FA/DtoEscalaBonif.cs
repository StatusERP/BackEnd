using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.FA
{
    public class DtoEscalaBonif
    {
        public int VersionNivelId { get; set; }

        public int ArticuloId { get; set; }

        public int NumEscalaBonif { get; set; }

        public int VersionBonif { get; set; }

        public int ArticuloBonifId { get; set; }

        public int MinArtFact { get; set; }

        public int? MaxArtFact { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal UnidadesBonif { get; set; }

        public DateTime FechaInicioEsc { get; set; }

        public DateTime FechaFinEsc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? FactorBonif { get; set; }

        public DateTime? FechaUltModif { get; set; }

        [StringLength(250)]
        public string? UsuarioUltModif { get; set; }

    }
}
