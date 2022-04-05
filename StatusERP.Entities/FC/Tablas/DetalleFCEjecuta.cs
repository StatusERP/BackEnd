using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("DetallesFCEjecuta", Schema = Constants.Conjunto)]
    public class DetalleFCEjecuta:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "El consecutivo de periodo es requerido.")]
        public int ConsecutivoPeriodo { get; set; }

        [Required(ErrorMessage = "Se debe indicar un flujo de caja.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoLocal { get; set; }

        [Required(ErrorMessage = "Se debe indicar la naturaleza.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El rubro hijo es requerido.")]
        [StringLength(20)]
        public string RubroHijo { get; set; }

        [Required(ErrorMessage = "El rubro padre es requerido.")]
        [StringLength(20)]
        public string RubroPadre { get; set; }

        [Required(ErrorMessage = "El subtipo es requerido.")]
        public Int16 SubTipo { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string? TipoDocumento { get; set; }

        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }
    }
}