using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.FA
{
    public class DtoEscalaDcto
    {
        public int VersionNivelId { get; set; }

        public int ArticuloId { get; set; }

        public int NumEscalaDcto { get; set; }

        public int VersionDcto { get; set; }

        public int ? MinUnidFact { get; set; }

        public int ? MaxUnidFact { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDcto { get; set; }

        public DateTime FechaInicioEsc { get; set; }

        public DateTime FechaFinEsc { get; set; }

        public DateTime? FechaUltModif { get; set; }

        [StringLength(250)]
        public string? UsuarioUltModif { get; set; }

    }
}
