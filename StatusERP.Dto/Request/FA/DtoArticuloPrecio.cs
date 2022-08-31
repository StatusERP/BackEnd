using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.FA
{
    public class DtoArticuloPrecio
    {
        public int VersionNivelId { get; set; }

        public int ArticuloId { get; set; }

        public int VersionArticulo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El esquema de trabajo es requerido.")]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MargenMULR { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal MargenUtilidad { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime? FechaUltModif { get; set; }

        [StringLength(25)]
        public string? UsuarioUltModif { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MargenUtilidadMin { get; set; }

    }
}
