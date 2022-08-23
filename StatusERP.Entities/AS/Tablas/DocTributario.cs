using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("DocTributarios", Schema = Constants.Conjunto)]
    public class DocTributario:EntityBase
    {
        [StringLength(20)]
        public string NumDocTributario { get; set; }

        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(150)]
        public string ? Alias { get; set; }

        public string ? Notas { get; set; }

        public int? TipoDocTributarioId { get; set; }
        [ForeignKey(nameof(TipoDocTributarioId))]
        public TipoDocTributario TipoDocTributario { get; set; }

        [StringLength(10)]
        public string ? DigitoVerificador { get; set; }

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

        public bool InfoLegal { get; set; }
    }
}
