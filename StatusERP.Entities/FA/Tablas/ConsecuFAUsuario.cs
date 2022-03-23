using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("ConsecuFAUsuarios", Schema = Constants.Conjunto)]
    public class ConsecuFAUsuario:EntityBase
    {
        [Required(ErrorMessage ="El usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set;}

        [Required(ErrorMessage = "El código de consecutivo es requerido.")]
        [StringLength(10)]
        public string CodigoConsecutivo { get; set;}
    }
}
   