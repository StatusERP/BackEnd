using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Zona:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodZona { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
