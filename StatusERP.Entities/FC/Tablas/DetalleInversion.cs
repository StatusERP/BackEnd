using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("DetallesInversiones", Schema = Constants.Conjunto)]
    public class DetalleInversion:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "La fecha de inversión es requerida.")]
        public DateTime FechaInversion { get; set; }

        [Required(ErrorMessage = "Debe indicarse el código de inversión.")]
        [StringLength(20)]
        public string Inversion { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoLocal { get; set; }
    }
}
