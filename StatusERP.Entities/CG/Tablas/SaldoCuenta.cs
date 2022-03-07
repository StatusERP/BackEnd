using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("SaldoCuentas", Schema = Constants.Conjunto)]
    public class SaldoCuenta:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el centro de costo.")]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la cuenta contable.")]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el saldo fiscal en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoFiscLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el saldo fiscal en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoFiscDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el saldo corporativo en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCorpLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el saldo corporativo en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCorpDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el débito fiscal en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoFiscLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el crédito fiscal en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoFiscLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el débito corporativo en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoCorpLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el crédito corporativo en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoCorpLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el débito fiscal en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoFiscDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el crédito fiscal en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoFiscDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el débito corporativo en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoCorpDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el crédito corporativo en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoCorpDolar { get; set; }
    }
}
