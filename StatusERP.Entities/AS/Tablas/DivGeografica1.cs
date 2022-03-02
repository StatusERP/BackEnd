using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class DivGeografica1:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de País.")]
        [StringLength(4)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Se requiere especificar código de División Geográfica 1.")]
        [StringLength(12)]
        public string CodDivGeografica1 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre de la División Geográfica 1.")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
