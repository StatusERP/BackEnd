using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("Locks", Schema = "ERPADMIN")]
    public class Locks : EntityBase
    {
        [Required(ErrorMessage = "La llave es requerida.")]
        [StringLength(100)]
        public string Llave { get; set; }
        
        [Required(ErrorMessage = "El usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        [Required(ErrorMessage = "El id de conexión es requerido.")]
        [StringLength(80)]
        public string ConnectionId { get; set; }
        
        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }
    }
}

