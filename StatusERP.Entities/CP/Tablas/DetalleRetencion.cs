using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CP.Tablas
{
    [Table("DetalleRetencion", Schema = Constants.Conjunto)]
    public class DetalleRetencion:EntityBase
    {
        [Required(ErrorMessage ="El tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El proveedor es requerido.")]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El código de retención es requerido.")]
        [StringLength(4)]
        public string CodigoRetencion { get; set; }

        [StringLength(50)]
        public string ? Retencion { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public bool Pagada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Base { get; set; }

        public bool Autoretenedora { get; set; }

        [StringLength(1)]
        public string ? TipoApliCancelar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoCancelar { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        public DateTime ? FechaDocumento { get; set; }

        public DateTime ? FechaRige { get; set; }

        public DateTime ? FechaContable { get; set; }

        [StringLength(3)]
        public string ? ClaseDocES { get; set; }

        [StringLength(22)]
        public string ? Resolucion { get; set; }

        [StringLength(13)]
        public string ? Serie { get; set; }

        [StringLength(20)]
        public string ? ControlInterno { get; set; }

        [StringLength(22)]
        public string ? SerieNumero { get; set; }
     }
}
