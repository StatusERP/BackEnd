using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("UsuarioPaquete", Schema = Constants.Conjunto)]
    public class UsuarioPaquete:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string Paquete { get; set; }

        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required]
        public bool SoloLectura { get; set; }

        [Required]
        public bool Aplicacion { get; set; }

        [Required]
        public bool Agregar { get; set; }

        [Required]
        public bool Eliminar { get; set; }

        [Required]
        public bool Total { get; set; }
    }
}
