using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Moneda:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Moneda.")]
        [StringLength(4)]
        public string CodMoneda { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre de la Moneda.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(4)]
        public string ? CodigoISO { get; set; }
    }
}
