using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class ConsecutivoUsuario:EntityBase
    {
        [Required]
        [StringLength(10)]
        public string CodConsecutivo { get; set; }

        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }
    }
}
