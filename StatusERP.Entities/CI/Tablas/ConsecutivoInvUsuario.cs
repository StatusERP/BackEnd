using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ConsecutivosInvUsuarios", Schema = Constants.Conjunto)]
    public class ConsecutivoInvUsuario:EntityBase
    {
        [Required(ErrorMessage = "El código del consecutivo es requerido.")]
        public int Consecutivo { get; set; }
        
        [Required(ErrorMessage = "El código del usuario es requerido.")]
        public int Usuario { get; set; }
    }
}
