using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("DetallesFC", Schema = Constants.Conjunto)]
    public class DetalleFC:EntityBase
    {
        [StringLength(10)]
        public string ? Asiento { get; set; }

        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "El consecutivo de periodo es requerido.")]
        public int ConsecutivoPeriodo { get; set; }

        [StringLength(80)]
        public string ? Documento { get; set; }

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

        [Required(ErrorMessage = "Se debe registrar el nombre del propietario.")]
        [StringLength(80)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar el módulo origen.")]
        [StringLength(4)]
        public string Origen { get; set; }

        [StringLength(40)]
        public string ? Propietario { get; set; }

        [Required(ErrorMessage = "El rubro hijo es requerido.")]
        [StringLength(20)]
        public string RubroHijo { get; set; }

        [Required(ErrorMessage = "El rubro padre es requerido.")]
        [StringLength(20)]
        public string RubroPadre { get; set; }

        [StringLength(3)]
        public string ? Tipo { get; set; }

        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }
    }
}
