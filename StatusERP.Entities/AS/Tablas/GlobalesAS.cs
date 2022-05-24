using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{   
    [Table("GlobalesAS", Schema = Constants.Conjunto)]
    public class GlobalesAS:EntityBase
    {
        public DateTime FechaAdvIni { get; set; }

        public DateTime FechaAdvFin { get; set; }

        public DateTime FechaTrabajoIni { get; set; }

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

        public int? PaisLocalId { get; set; }
        [ForeignKey(nameof(PaisLocalId))]
        public Pais Pais { get; set; }

        public int MonedaLocalId { get; set; }
        public Moneda MonedaLocal { get; set; }

        public int MonedaDolarId { get; set; }
        public Moneda MonedaDolar { get; set; }

        public int TipoCambioId { get; set; }
        public TipoCambio TipoCambio { get; set; }

        [Required]
        [StringLength(25)]
        public string PatronCeCo { get; set; }
    }
}
