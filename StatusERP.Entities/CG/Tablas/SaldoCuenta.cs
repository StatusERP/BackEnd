using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("SaldoCuentas", Schema = Constants.Conjunto)]
    public class SaldoCuenta:EntityBase
    {
        [Required]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoFiscLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoFiscDolar { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCorpLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCorpDolar { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoFiscLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoFiscLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoCorpLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoCorpLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoFiscDolar { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoFiscDolar { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoCorpDolar { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoCorpDolar { get; set; }
    }
}
