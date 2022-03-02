using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class NivelPrecio:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Nivel de Precio.")]
        [StringLength(12)]
        public string CodNivelPrecio { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código de la Moneda.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [StringLength(4)]
        public string ? CondicionPago { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el Esquema de Trabajo.")]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        public bool Descuentos { get; set; }

        public bool SugerirDescuento { get; set; }

          public bool SincMovil { get; set; }
    }
}
