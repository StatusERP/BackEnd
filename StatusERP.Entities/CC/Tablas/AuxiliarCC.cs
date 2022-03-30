using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CC.Tablas
{
    [Table("AuxiliarCC", Schema = Constants.Conjunto)]
    public class AuxiliarCC:EntityBase
    {
        [Required(ErrorMessage = "El tipo crédito es requerido.")]
        [StringLength(3)]
        public string TipoCredito { get; set; }

        [Required(ErrorMessage = "El tipo débito es requerido.")]
        [StringLength(3)]
        public string TipoDebito { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = " El documento de crédito es requerido.")]
        [StringLength(50)]
        public string Credito { get; set; }

        [Required(ErrorMessage = "El documento de débito es requerido.")]
        [StringLength(50)]
        public string Debito { get; set; }

        [Required(ErrorMessage = "El monto del crédito es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCredito { get; set; }

        [Required(ErrorMessage = "El monto del débito es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDebito { get; set; }

        [Required(ErrorMessage = "El monto en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoLocal { get; set; }

        [Required(ErrorMessage = " El monto en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "El monto del crédito en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCliCredito { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        [StringLength(3)]
        public string ? TipoDocPPago { get; set; }

        [StringLength(50)]
        public string ? DocumentoDocPPago { get; set; }

        [Required(ErrorMessage = "El monto del débito en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCliDebito { get; set; }

        [Required(ErrorMessage = "La moneda del documento de crédito es requerida.")]
        [StringLength(4)]
        public string MonedaCredito { get; set; }

        [Required(ErrorMessage = "La moneda del documento de débito es requerida.")]
        [StringLength(4)]
        public string MonedaDebito { get; set; }

        [Required(ErrorMessage = "El código del cliente corporación del cliente origen correspondiente al documento es requerido.")]
        [StringLength(20)]
        public string CliReporteCredito { get; set; }

        [Required(ErrorMessage = "El código del cliente corporación del cliente origen correspondiente al documento es requerido.")]
        [StringLength(20)]
        public string CliReporteDebito { get; set; }

        [Required(ErrorMessage = "El código del cliente que ingresó el documento de crédito es requerido.")]
        [StringLength(20)]
        public string CliDocCredito { get; set; }

        [Required(ErrorMessage = "El código del cliente que ingresó el documento de débito es requerido.")]
        [StringLength(20)]
        public string CliDocDebito { get; set; }

        [StringLength(3)]
        public string ? TipoDocIntCte { get; set; }

        [StringLength(50)]
        public string ? DocDocIntCte { get; set; }

        [StringLength(50)]
        public string ? FolioSATDebito { get; set; }

        [StringLength(50)]
        public string ? FolioSATCredito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TipoCambioAplica { get; set; }

        [StringLength(10)]
        public string ? AsientoDifCambMR { get; set; }

        public bool EsIntCorriente { get; set; }

        [StringLength(50)]
        public string ? DocAsocPerce { get; set; }
    }
}
