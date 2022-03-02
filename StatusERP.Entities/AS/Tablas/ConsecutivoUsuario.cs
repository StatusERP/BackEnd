using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("ConsecutivoUsuario", Schema = Constants.Conjunto)]
    public class ConsecutivoUsuario:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de Consecutivo.")]
        [StringLength(10)]
        public string CodConsecutivo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }
    }
}
