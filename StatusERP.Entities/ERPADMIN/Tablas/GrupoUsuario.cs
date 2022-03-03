using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("GrupoUsuario", Schema = "ERPADMIN")]
    public class GrupoUsuario: EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Grupo.")]
        [StringLength(25)]
        public string Grupo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código del Usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }

    }
}
