using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class DivGeografica2:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string Pais { get; set; }

        [Required]
        [StringLength(12)]
        public string CodDivGeografica1 { get; set; }

        [Required]
        [StringLength(12)]
        public string CodDivGeografica2 { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
