using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("PeriodosFC", Schema = Constants.Conjunto)]
    public class PeriodoFC:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFinal { get; set; }

        [Required(ErrorMessage = "La fecha inicial es requerida.")]
        public DateTime FechaInicial { get; set; }

        [Required(ErrorMessage = "Debe indicarse un flujo de caja.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "Se debe indicar el tipo de periodo.")]
        [StringLength(1)]
        public string TipoPeriodo { get; set; }
    }
}
