using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("MayorDet", Schema = Constants.Conjunto)]
    public class MayorDet:EntityBase
    {
        [Required]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required]
        public int Consecutivo { get; set; }

        [Required]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required]
        [StringLength(40)]
        public string Fuente { get; set; }

        [Required]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required]
        [StringLength(4)]
        public string Origen { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitoDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditoDolar { get; set; }

        [Required]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required]
        [StringLength(1)]
        public string ClaseAsiento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TipoCambio { get; set; }
    }
}
