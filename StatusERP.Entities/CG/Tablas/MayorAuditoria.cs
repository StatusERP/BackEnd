using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
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
