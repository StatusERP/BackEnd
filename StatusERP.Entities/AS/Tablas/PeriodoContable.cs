using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("PeriodosContables", Schema = Constants.Conjunto)]
    public class PeriodoContable:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar la fecha final del Periodo Contable.")]
        public DateTime FechaFinal { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el tipo de Contabiidad.")]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción del Periodo Contable.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool FinPeriodoAnual { get; set; }

        public bool Abierto { get; set; }
    }
}
