using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("DocumentosInvEnc", Schema = Constants.Conjunto)]
    public class DocumentoInvEnc:EntityBase
    {
        [Required(ErrorMessage = "Debe indicarse el paquete de inventario.")]
        [StringLength(4)]
        public string PaqueteInventario { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el documento de inventario.")]
        [StringLength(50)]
        public string DocumentoInv { get; set; }
        
        [StringLength(10)]
        public string ? Consecutivo { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la referencia.")]
        [StringLength(200)]
        public string Referencia { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse fecha y hora de creación.")]
        public DateTime FechaHorCreacion { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la fecha del documento.")]
        public DateTime FechaDocumento { get; set; }
        
        public bool Seleccionado { get; set; }

        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        public string ? MensajeSistema { get; set; }
        
        [StringLength(25)]
        public string ? UsuarioApro { get; set; }

        public DateTime ? FechaHoraAprob { get; set; }

        public bool Aprobado { get; set; }
    }
}
