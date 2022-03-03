using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("Membresia", Schema = "ERPADMIN")]
    public class Membresia:EntityBase
    {
        [Required(ErrorMessage = "Nombre Membresia es requerido.")]
        [StringLength(50)]
        public string NombreMembresia { get; set; }

        [Required(ErrorMessage = "Debe ingresar la vigencia (en días).")]
         public int Vigencia { get; set; }

        public bool Activa { get; set; }
    }
}
