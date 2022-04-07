using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("MovReportados", Schema = Constants.Conjunto)]
    public class MovReportados: EntityBase
    {
        [Required(ErrorMessage = "El número de documento es requerido.")]
        public int DocReportado { get; set; }

        public int ? CuentaBancariaId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal Numero { get; set; }

        [Required(ErrorMessage = "El monto del documento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El modo de registro es requerido.")]
        [StringLength(1)]
        public string ModoRegistro { get; set; }

        public bool Compensado { get; set; }

        public int ? ConciliacionId { get; set; }
        public ConciliacionBancaria ConciliacionBancaria { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "La fecha y la hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        public DateTime ? FechaHoraModific { get; set; }

        public int ? DocCompensac { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific { get; set; }

        [StringLength(3)]
        public string ? TipoCF { get; set; }
     }
}
