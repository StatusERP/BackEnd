using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("DiarioDet", Schema = Constants.Conjunto)]
    public class DiarioDet:EntityBase
    {
        [Required(ErrorMessage = "Se requiere un número de asiento.")]
        [StringLength(10)]
        public string Asiento { get; set; } 

        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un centro de costo.")]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable.")]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una fuente.")]
        [StringLength(40)]
        public string Fuente { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una referencia.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambio { get; set; }
    }
}
