using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    public class MayorEnc:EntityBase
    {
        [Required]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required]
        public int MayorAuditoria { get; set; } 

        [Required]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required]
        [StringLength(4)]
        public string Origen { get; set; }

        [Required]
        [StringLength(1)]
        public string ClaseAsiento { get; set; }

        [Required]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required]
        public DateTime FechaUltModif { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalLocal { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalDolar { get; set; }

        public string ? Notas { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        [StringLength(1)]
        public string Exportado { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoIngresoMayor { get; set; }
    }
}
