using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class NivelPrecio:EntityBase
    {
        [Required]
        [StringLength(12)]
        public string CodNivelPrecio { get; set; }

        [Required]
        [StringLength(1)]
        public string Moneda { get; set; }

        [StringLength(4)]
        public string ? CondicionPago { get; set; }

        [Required]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        [Required]
        public bool Descuentos { get; set; }

        [Required]
        public bool SugerirDescuento { get; set; }

        [Required]
        public bool SincMovil { get; set; }
    }
}
