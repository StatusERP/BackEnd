using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("MayorEnc", Schema = Constants.Conjunto)]
    public class MayorEnc:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar un número de asiento")]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un número de MayorAuditoría")]
        public int MayorAuditoria { get; set; } 

        [Required(ErrorMessage = "Se requiere especificar un tipo de Asiento")]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha del Asiento")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el tipo de Contabilidad")]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el origen del Asiento")]
        [StringLength(4)]
        public string Origen { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la clase del Asiento.")]
        [StringLength(1)]
        public string ClaseAsiento { get; set; }

        [Required(ErrorMessage = "El último usuario es requerido.")]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required(ErrorMessage = "La fecha y la hora de la última modificación son requeridas.")]
        public DateTime FechaUltModif { get; set; }

        [Required(ErrorMessage = "El valor del monto total local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalLocal { get; set; }

        [Required(ErrorMessage = "El valor del monto total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalDolar { get; set; }
        
        public string ? Notas { get; set; }

        [Required(ErrorMessage = "El usuario creación es requerido.")]
        [StringLength(25)]
        public string UsuarioCreacion { get; set; }

        [Required(ErrorMessage = "La fecha creación es requerida.")]
        public DateTime FechaCreacion { get; set; }

        public bool Exportado { get; set; }

        [Required(ErrorMessage = "Se debe indicar si la transacción es normal (N) o extemporánea (E).")]
        [StringLength(1)]
        public string TipoIngresoMayor { get; set; }
    }
}
