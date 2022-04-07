using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("CalculosFC", Schema = Constants.Conjunto)]
    public class CalculoFC:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo de periodo es requerido.")]
        public int ConsecutivoPeriodo { get; set; }

        public bool Editado { get; set; }

        [Required(ErrorMessage = "El código del Flujo de Caja es requerido.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "El monto total para el flujo de caja en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalDolar { get; set; }

        [Required(ErrorMessage = "El monto total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalDolarEje { get; set; }

        [Required(ErrorMessage = "El monto total en moneda local para el flujo de caja es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalLocal { get; set; }

        [Required(ErrorMessage = "El monto total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalLocalEje { get; set; }

        [Required(ErrorMessage = "La naturaleza del rubro es requerida.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el código del rubro hijo asociado al flujo de caja.")]
        [StringLength(20)]
        public string RubroHijo { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el código del rubro padre asociado al flujo de caja.")]
        [StringLength(20)]
        public string RubroPadre { get; set; }

        [Required(ErrorMessage = "Se debe ingresar el tipo de cálculo utilizado para el flujo de caja.")]
        [StringLength(1)]
        public string TipoCalculo { get; set; }

        [Required(ErrorMessage = "La versión del flujo de caja es requerido.")]
        public int Version { get; set; }
    }
}
