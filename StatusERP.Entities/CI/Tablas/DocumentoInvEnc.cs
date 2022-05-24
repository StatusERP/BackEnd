using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("DocumentosInvEnc", Schema = Constants.Conjunto)]
    public class DocumentoInvEnc:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string PaqueteInventario { get; set; }
        
        [Required]
        [StringLength(50)]
        public string DocumentoInv { get; set; }

        public int? ConsecutivoId { get; set; }
        [ForeignKey(nameof(ConsecutivoId))]
        public ConsecutivoInv consecutivoInv { get; set; }

        [Required]
        [StringLength(200)]
        public string Referencia { get; set; }
        
        public DateTime FechaHorCreacion { get; set; }
        
        public DateTime FechaDocumento { get; set; }
        
        public bool Seleccionado { get; set; }

        [Required]
        [StringLength(450)]
        public string Usuario { get; set; }
        
        public string ? MensajeSistema { get; set; }
        
        [StringLength(450)]
        public string ? UsuarioApro { get; set; }

        public DateTime ? FechaHoraAprob { get; set; }

        public bool Aprobado { get; set; }
    }
}
