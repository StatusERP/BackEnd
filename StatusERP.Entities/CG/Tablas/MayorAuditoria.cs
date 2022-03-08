using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("MayorAuditoria", Schema = Constants.Conjunto)]
    public class MayorAuditoria:EntityBase
    {
        [Required(ErrorMessage = "El código de usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [StringLength(40)]
        public string Comentario { get; set; }
    }
}
