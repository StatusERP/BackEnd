using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class PeriodoContable:EntityBase
    {
        [Required]
        public DateTime FechaFinal { get; set; }

        [Required]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        public bool FinPeriodoAnual { get; set; }

        [Required]
        public bool Abierto { get; set; }
    }
}
