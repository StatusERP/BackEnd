using StatusERP.Entities.CB.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("ChequesRubroFC", Schema = Constants.Conjunto)]
    public class ChequeRubroFC:EntityBase
    {
        [Required(ErrorMessage = "El número de cheque es requerido.")]
        public int ChequeInterno { get; set; }

        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        public int CuentaBancoId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El número de flujo de caja es requerido.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "La naturaleza es requerida.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El rubro hijo es requerido es requerido.")]
        [StringLength(20)]
        public string RubroHijo { get; set; }

        [Required(ErrorMessage = "El rubro padre es requerido.")]
        [StringLength(20)]
        public string RubroPadre { get; set; }

        [Required(ErrorMessage = "El subtipo es requerido.")]
        public Int16 SubTipo { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string TipoDocumento { get; set; }
    }
}
