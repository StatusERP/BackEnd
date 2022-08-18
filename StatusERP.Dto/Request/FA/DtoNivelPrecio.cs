using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.FA
{
    public class DtoNivelPrecio
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Nivel de Precio.")]
        [StringLength(12)]
        public string CodNivelPrecio { get; set; }

        [StringLength(1)]
        public string Moneda { get; set; }

        public int? CondicionPagoId { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el Esquema de Trabajo.")]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        public bool Descuentos { get; set; }

        public bool SugerirDescuento { get; set; }

        public bool Activo { get; set; }

    }
}
