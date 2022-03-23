using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("UsuarioBodega", Schema = Constants.Conjunto)]
    public class UsuarioBodega:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Bodega.")]
        [StringLength(4)]
        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código del Usuario.")]
        [StringLength(450)]
        public string Usuario { get; set; }
    }
}
