using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("AsientosCheques", Schema = Constants.Conjunto)]
    public class AsientoCheque:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        [Required(ErrorMessage = "El centro de costo es requerido.")]
        [StringLength(25)]
        public string CtrContable { get; set; }

        [Required(ErrorMessage = "La cuenta contable es requerida.")]
        [StringLength(25)]
        public string CtaContable { get; set; }

        [Required(ErrorMessage = "El tipo de asiento es requerido.")]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Debito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Credito { get; set; }
    }
}
