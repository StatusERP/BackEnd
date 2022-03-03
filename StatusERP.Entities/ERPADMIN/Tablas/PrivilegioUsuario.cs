using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("PrivilegioUsuario", Schema = "ERPADMIN")]
    public class PrivilegioUsuario:EntityBase
    {

        [Required(ErrorMessage = "Codigo de Usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Conjunto es requerido.")]
        [StringLength(10)]
        public string Conjunto { get; set; }


        [Required(ErrorMessage = "Codigo de Acción es requerido.")]
        public int Accion { get; set; }

        public bool Activo { get; set; }
    }
}
