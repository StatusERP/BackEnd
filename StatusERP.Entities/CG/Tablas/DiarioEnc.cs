using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    public class DiarioEnc:EntityBase
    {
        [Required]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required]
        [StringLength(4)]
        public string Paquete { get; set; }

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
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalDebitoLoc { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalDebitoDol { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCreditoLoc { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCreditoDol { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalControlLoc { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalControlDol { get; set; }

        [Required]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required]
        public DateTime FechaUltModif { get; set; }

        [Required]
        [StringLength(1)]
        public string Marcado { get; set; }

        public string ? Notas { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }


    }
}
