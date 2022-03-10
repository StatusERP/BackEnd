using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("PrivilegioUsuario", Schema = "ERPADMIN")]
    public class PrivilegioUsuario:EntityBase
    {
        [Required(ErrorMessage = "Codigo de Usuario es requerido.")]
        [StringLength(36)]
        public string UsuarioId { get; set; }
        
        [Required(ErrorMessage = "Conjunto es requerido.")]
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }

        [Required(ErrorMessage = "Codigo de Acción es requerido.")]
        public int AccionId { get; set; }
        public Accion Accion { get; set; }

        public bool Activo { get; set; }
    }
}
