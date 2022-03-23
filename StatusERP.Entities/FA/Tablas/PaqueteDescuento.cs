using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.FA.Tablas
{
    [Table("PaquetesDescuento", Schema = Constants.Conjunto)]
    public class PaqueteDescuento: EntityBase
    {
        
        [Required(ErrorMessage ="El código del paquete de descuento es requerido.")]
        [StringLength(12)]
        public string CodPaqueteDescuento { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(250)]
        public string Descripcion { get; set; } 

        public bool Activo { get; set; }

        public bool TodaTienda { get; set; }

        [Required(ErrorMessage = "La fecha rige es requerida.")]
        public DateTime FechaRige { get; set; }

        [Required(ErrorMessage = "La fecha vence es requerida.")]
        public DateTime FechaVence { get; set; }

        public string ? Notas { get; set; }

        public DateTime ? FechaHoraInicio { get; set; }

        public DateTime ? FechaHoraFin { get; set; }
    }
}
