using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Zonas", Schema = Constants.Conjunto)]
    public class Zona:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Zona.")]
        [StringLength(4)]
        public string CodZona { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la Descripción de la Zona.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
