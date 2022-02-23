using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Moneda:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodMoneda { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(4)]
        public string ? CodigoISO { get; set; }
    }
}
