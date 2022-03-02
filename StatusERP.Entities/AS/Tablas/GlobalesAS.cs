using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("GlobalesAS", Schema = Constants.Conjunto)]
    public class GlobalesAS:EntityBase
    {
        [Required(ErrorMessage = "Se requiere seleccionar una fecha inicial para el Periodo de Trabajo con Advertencia.")]
        public DateTime FechaAdvIni { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una fecha final para el Periodo de Trabajo con Advertencia.")]
        public DateTime FechaAdvFin { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una fecha inicial para el Periodo de Trabajo.")]
        public DateTime FechaTrabajoIni { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una fecha final para el Periodo de Trabajo.")]
        public DateTime FechaTrabajoFin { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una Moneda.")]
        [StringLength(10)]
        public string NombreMoneda { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un símbolo para la Moneda.")]
        [StringLength(3)]
        public string SimboloMoneda   { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Impuesto 1.")]
        [StringLength(10)]
        public string Impuesto1Desc { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Impuesto 2.")]
        [StringLength(10)]
        public string Impuesto2Desc { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el País Local.")]
        [StringLength(4)]
        public string PaisLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la Moneda Local.")]
        [StringLength(4)]
        public string MonedaLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la Moneda Dólar.")]
        [StringLength(4)]
        public string MonedaDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el Tipo de Cambio Dólar.")]
        [StringLength(4)]
        public string TipoCambioDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el patrón de los Centros de Costos.")]
        [StringLength(25)]
        public string PatronCeCo { get; set; }
    }
}
