using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.FA
{
    public class DtoVersionNivelPrecio
    {

        public int NivelPrecioId { get; set; }

        public int Version { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaCorte { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(250)]
        public string UsuarioCreacion { get; set; }

        public DateTime FechaHoraCreacion { get; set; }

        [StringLength(250)]
        public string? UsuarioUltModif { get; set; }

        public DateTime? FechaHoraUltModif { get; set; }

        [StringLength(250)]
        public string? UsuarioAprobacion { get; set; }

        public DateTime? FechaHoraAprobacion { get; set; }

        [StringLength(250)]
        public string? UsuarioAnulacion { get; set; }

        public DateTime? FechaHoraAnulacion { get; set; }

        [StringLength(10)]
        public string? Identificador { get; set; }

        public bool Impuesto1Incluido { get; set; }

        [StringLength(4)]
        public string? PrecioReferenciaDE { get; set; }

        public bool SincMovil { get; set; }

    }
}
