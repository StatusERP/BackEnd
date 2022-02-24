using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class DocTributario:EntityBase
    {
        [Required]
        [StringLength(20)]
        public string CodDocTributario { get; set; }

        [Required]
        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(150)]
        public string ? Alias { get; set; }

        public string ? Notas { get; set; }

        [StringLength(10)]
        public string ? DigitoVerificador { get; set; }

        [Required]
        public bool Activo { get; set; }

        [StringLength(1)]
        public string ? TipoContribuyente { get; set; }

        [StringLength(20)]
        public string ? NRC { get; set; }

        public string ? Giro { get; set; }

        [StringLength(20)]
        public string ? Categoria { get; set; }

        [StringLength(12)]
        public string ? DUI { get; set; }

        [StringLength(20)]
        public string ? Pasaporte { get; set; }

        [StringLength(20)]
        public string ? Carnet { get; set; }

        [StringLength(20)]
        public string ? Otro { get; set; }

        [Required]
        public bool InfoLegal { get; set; }
    }
}
