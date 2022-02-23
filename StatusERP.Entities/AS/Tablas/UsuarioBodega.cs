using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class UsuarioBodega:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string Bodega { get; set; }

        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }
    }
}
