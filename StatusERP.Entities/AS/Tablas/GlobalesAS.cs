using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class GlobalesAS:EntityBase
    {
        [Required]
        public DateTime FechaAdvIni { get; set; }

        [Required]
        public DateTime FechaAdvFin { get; set; }

        [Required]
        public DateTime FechaTrabajoIni { get; set; }

        [Required]
        public DateTime FechaTrabajoFin { get; set; }

        [Required]
        [StringLength(10)]
        public string NombreMoneda { get; set; }

        [Required]
        [StringLength(3)]
        public string SimboloMoneda   { get; set; }

        [Required]
        [StringLength(10)]
        public string Impuesto1Desc { get; set; }

        [Required]
        [StringLength(10)]
        public string Impuesto2Desc { get; set; }

        [Required]
        [StringLength(4)]
        public string PaisLocal { get; set; }

        [Required]
        [StringLength(4)]
        public string MonedaLocal { get; set; }

        [Required]
        [StringLength(4)]
        public string MonedaDolar { get; set; }

        [Required]
        [StringLength(4)]
        public string TipoCambioDolar { get; set; }

        [Required]
        [StringLength(25)]
        public string PatronCeCo { get; set; }
    }
}
