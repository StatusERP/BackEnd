using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("UsuarioPaquete", Schema = Constants.Conjunto)]
    public class UsuarioPaquete:EntityBase
    {
        [Required(ErrorMessage = "El código del paquete es requerido")]
        [StringLength(4)]
        public string Paquete { get; set; }

        [Required(ErrorMessage = "El código del usuario es requerido")]
        [StringLength(25)]
        public string Usuario { get; set; }

        public bool SoloLectura { get; set; }

        public bool Aplicacion { get; set; }

        public bool Agregar { get; set; }

        public bool Eliminar { get; set; }

        public bool Total { get; set; }
    }
}
