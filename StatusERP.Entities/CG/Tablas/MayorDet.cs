using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("MayorDet", Schema = Constants.Conjunto)]
    public class MayorDet:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el número de asiento.")]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el centro de costo.")]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la cuenta contable.")]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el tipo de asiento.")]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fuente.")]
        [StringLength(40)]
        public string Fuente { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la referencia.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el origen.")]
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

        [Required(ErrorMessage = "Se requiere especificar si es contabilidad fiscal o corporativa.")]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la clase de asiento.")]
        [StringLength(1)]
        public string ClaseAsiento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TipoCambio { get; set; }
    }
}
