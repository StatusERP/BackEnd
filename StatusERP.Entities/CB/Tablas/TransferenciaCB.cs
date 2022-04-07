using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("TransferenciasCB", Schema = Constants.Conjunto)]
    public class TransferenciaCB : EntityBase
    {
        [Required(ErrorMessage = "La cuenta origen es requerida.")]
        public int CuentaOrigenId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El tipo origen es requerido.")]
        [StringLength(3)]
        public string TipoOrigen { get; set; }

        [Required(ErrorMessage = "El número origen es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal NumeroOrigen { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(80)]
        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoComision { get; set; }

        [Required(ErrorMessage = "El monto origen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoOrigen { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        [Required(ErrorMessage = "La fecha y hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraModific { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime ? FechaAplicacion { get; set; }

        [StringLength(100)]
        public string ? Rubro1Trans { get; set; }

        [StringLength(100)]
        public string? Rubro2Trans { get; set; }

        [StringLength(100)]
        public string? Rubro3Trans { get; set; }

        [StringLength(100)]
        public string? Rubro4Trans { get; set; }

        [StringLength(100)]
        public string? Rubro5Trans { get; set; }

        [StringLength(100)]
        public string? Rubro6Trans { get; set; }

        [StringLength(100)]
        public string? Rubro7Trans { get; set; }

        [StringLength(100)]
        public string? Rubro8Trans { get; set; }

        [StringLength(100)]
        public string? Rubro9Trans { get; set; }

        [StringLength(100)]
        public string? Rubro10Trans { get; set; }

        [StringLength(50)]
        public string? DocumentoFiscal { get; set; }

        [StringLength(50)]
        public string? DocumentoGlobal { get; set; }

        [StringLength(10)]
        public string? MetodoPago { get; set; }
    }
}
