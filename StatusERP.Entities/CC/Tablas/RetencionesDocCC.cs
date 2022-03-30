using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CC.Tablas
{
    [Table("RetencionesDocCC", Schema = Constants.Conjunto)]
    public class RetencionesDocCC:EntityBase
    {
        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El documento es requerido.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El código de retención es requerido.")]
        [StringLength(4)]
        public string CodigoRetencion { get; set; }

        [StringLength(50)]
        public string ? Retencion { get; set; }

        [Required(ErrorMessage = "El documento de referencia es requerido.")]
        [StringLength(20)]
        public string DocReferencia { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string? Estado { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Base { get; set; }

        public bool Autoretenedora { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        public DateTime ? FechaDocumento { get; set; }

        public DateTime ? FechaRige { get; set; }

        public DateTime ? FechaContable { get; set; }

        [StringLength(1)]
        public string ? TipoApliCancelar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoCancelar { get; set; }
    }
}
