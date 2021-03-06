using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("NivelesPrecios", Schema = Constants.Conjunto)]
    public class NivelPrecio:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Nivel de Precio.")]
        [StringLength(12)]
        public string CodNivelPrecio { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código de la Moneda.")]
        public int MonedaId { get; set; }
        public Moneda Moneda { get; set; }

        public int ? CondicionPagoId { get; set; }
        public CondicionPago CondicionPago { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el Esquema de Trabajo.")]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        public bool Descuentos { get; set; }

        public bool SugerirDescuento { get; set; }
        
        public bool Activo { get; set; }
    }
}
