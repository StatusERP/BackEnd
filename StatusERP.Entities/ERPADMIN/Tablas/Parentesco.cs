using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("Parentesco", Schema = "ERPADMIN")]
    public class Parentesco:EntityBase
    {
        public int AccionId { get; set; }
        public Accion Accion { get; set; }
        
        [Required(ErrorMessage = "Codigo Padre es requerido.")]
        public int Padre { get; set; }

        [Required(ErrorMessage = "Número (cantidad) de hermanos es requerido.")]
        public Int16 NumeroHermano { get; set; }
    }
}
