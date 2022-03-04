using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("MayorAuditoria", Schema = Constants.Conjunto)]
    public class MayorAuditoria:EntityBase
    {
        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [StringLength(40)]
        public string Comentario { get; set; }
    }
}
