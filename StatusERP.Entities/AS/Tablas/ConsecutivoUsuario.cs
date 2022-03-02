using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
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
