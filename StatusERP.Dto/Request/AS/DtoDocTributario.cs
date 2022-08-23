using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoDocTributario
    {
        [Required(ErrorMessage = "Se requiere especificar el número del documento tributario.")]
        [StringLength(20)]
        public string NumDocTributario { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la razón social.")]
        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(150)]
        public string? Alias { get; set; }

        public string? Notas { get; set; }

        public int? TipoDocTributarioId { get; set; }

        [StringLength(10)]
        public string? DigitoVerificador { get; set; }

        public bool Activo { get; set; }

        [StringLength(1)]
        public string? TipoContribuyente { get; set; }

        [StringLength(20)]
        public string? NRC { get; set; }

        public string? Giro { get; set; }

        [StringLength(20)]
        public string? Categoria { get; set; }

        [StringLength(12)]
        public string? DUI { get; set; }

        [StringLength(20)]
        public string? Pasaporte { get; set; }

        [StringLength(20)]
        public string? Carnet { get; set; }

        [StringLength(20)]
        public string? Otro { get; set; }

        public bool InfoLegal { get; set; }
    }
}
