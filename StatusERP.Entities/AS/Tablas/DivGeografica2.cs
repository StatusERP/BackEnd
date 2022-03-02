using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("DivGeograficas2", Schema = Constants.Conjunto)]
    public class DivGeografica2:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de País.")]
        [StringLength(4)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Se requiere especificar código de División Geográfica 1.")]
        [StringLength(12)]
        public string CodDivGeografica1 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar código de División Geográfica 2.")]
        [StringLength(12)]
        public string CodDivGeografica2 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre de la División Geográfica 2.")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
