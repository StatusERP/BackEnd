using StatusERP.Entities.CB.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("MovBancosRubroFC", Schema = Constants.Conjunto)]
    public class MovBancosRubroFC:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        public int CuentaBancariaid { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El código de flujo de caja es requerido.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "La naturaleza es requerida.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "El número es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal Numero { get; set; }

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
        [StringLength(3)]
        public string SubTipo { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCDolar { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCLocal { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string TipoDocumento { get; set; }
    }
}
