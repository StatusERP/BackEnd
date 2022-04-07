using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas
{
    [Table("AuxiliarCP", Schema = Constants.Conjunto)]
    public class AuxiliarCP:EntityBase
    {
        [Required(ErrorMessage = "El proveedor es requerido.")]
        [StringLength(20)]
        public string Proveedor { get; set; }

        [Required(ErrorMessage = "El tipo de débito es requerido.")]
        [StringLength(3)]
        public string TipoDebito { get; set; }

        [Required(ErrorMessage = "El número del documento de débito es requerido.")]
        [StringLength(50)]
        public string Debito { get; set; }

        [Required(ErrorMessage = "La fecha de aplicación del documento es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El tipo de documento de crédito es requerido.")]
        [StringLength(3)]
        public string TipoCredito { get; set; }

        [Required(ErrorMessage = "El número del documento de crédito es requerido.")]
        [StringLength(50)]
        public string Credito { get; set; }

        [Required(ErrorMessage = "El monto del débito es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDebito { get; set; }

        [Required(ErrorMessage = "El monto de la transacción en la moneda del proveedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoProv { get; set; }

        [Required(ErrorMessage = "El monto de la transacción en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoLocal { get; set; }

        [Required(ErrorMessage = "El monto de la transacción en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "El código de la moneda del documento de débito es requerido.")]
        [StringLength(4)]
        public string MonedaDebito { get; set; }

        [Required(ErrorMessage = "El monto del crédito es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCredito { get; set; }

        [Required(ErrorMessage = "El código de la moneda del documento de crédito es requerido.")]
        [StringLength(4)]
        public string MonedaCredito { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        [StringLength(3)]
        public string ? TipoDocPPago { get; set; }

        [StringLength(50)]
        public string ? DocumentoDocPPago { get; set; }

        [StringLength(3)]
        public string ? TipoDocIntCte { get; set; }

        [StringLength(50)]
        public string ? DocDocIntCte { set; get; }

        [StringLength(50)]
        public string?  FolioSATDebito { get; set; }

        [StringLength(50)]
        public string? FolioSATCredito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TipoCambioAplica { get; set; }

        [StringLength(10)]
        public string ? AsientoDifCambMR { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoTotalRetPago { get; set; }

        [StringLength(4)]
        public string ? CodigoRetPago { get; set; }
    }
}
