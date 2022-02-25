using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Ruta:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodRuta { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        public bool Activa { get; set; }
    }
}
