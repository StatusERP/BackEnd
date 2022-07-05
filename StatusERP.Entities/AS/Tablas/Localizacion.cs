using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Localizaciones", Schema = Constants.Conjunto)]
    public class Localizacion:EntityBase
    {

        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código de la Localización.")]
        [StringLength(4)]
        public string CodLocalizacion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción de la Localización.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere ingresar el volumen de la Localización.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Volumen { get; set; }

        [Required(ErrorMessage = "Se requiere ingresar el peso máximo de la Localización.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoMaximo { get; set; }
        
        public bool Activa { get; set; }
    }
}
