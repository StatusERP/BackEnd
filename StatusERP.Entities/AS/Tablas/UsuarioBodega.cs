using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("UsuarioBodega", Schema = Constants.Conjunto)]
    public class UsuarioBodega:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Bodega.")]
        [StringLength(4)]
        public string Bodega { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código del Usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }
    }
}
