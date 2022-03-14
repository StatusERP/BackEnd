using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas


{
    [Table("Favoritos", Schema = "ERPADMIN")]

    public class Favoritos : EntityBase
    {
        [Required(ErrorMessage = "La acción es requerida.")]
        public int Accion { get; set; }
        
        [Required(ErrorMessage = "El usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        public int ? Posicion { get; set; }
        
        [Required(ErrorMessage = "El valor para AccionModulo es requerido")]
        public int AccionModulo { get; set; }
        
        [Required(ErrorMessage = "El valor Padre es requerido.")]
        public int Padre { get; set; }
    }
}