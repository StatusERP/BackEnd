using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoGlobalesAS
    {
        public DateTime FechaAdvIni { get; set; }

        public DateTime FechaAdvFin { get; set; }

        public DateTime FechaTrabajoIni { get; set; }

        public DateTime FechaTrabajoFin { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una Moneda.")]
        [StringLength(10)]
        public string NombreMoneda { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un símbolo para la Moneda.")]
        [StringLength(3)]
        public string SimboloMoneda { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Impuesto 1.")]
        [StringLength(10)]
        public string Impuesto1Desc { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Impuesto 2.")]
        [StringLength(10)]
        public string Impuesto2Desc { get; set; }

        public int PaisLocalId { get; set; }

        public int MonedaLocalId { get; set; }

        public int MonedaDolarId { get; set; }

        public int TipoCambioId { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el patrón de los Centros de Costos.")]
        [StringLength(25)]
        public string PatronCeCo { get; set; }
    }
}
