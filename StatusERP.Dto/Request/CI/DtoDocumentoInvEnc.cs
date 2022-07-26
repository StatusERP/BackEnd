using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoDocumentoInvEnc
    {
        public int PaqueteInventarioId { get; set; }

        [Required(ErrorMessage = "Debe indicarse el documento de inventario.")]
        [StringLength(50)]
        public string DocumentoInv { get; set; }

        public int? ConsecutivoId { get; set; }

        [Required(ErrorMessage = "Debe indicarse la referencia.")]
        [StringLength(200)]
        public string Referencia { get; set; }

        public DateTime FechaHorCreacion { get; set; }

        public DateTime FechaDocumento { get; set; }

        public bool Seleccionado { get; set; }

        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        [StringLength(450)]
        public string Usuario { get; set; }

        public string? MensajeSistema { get; set; }

        [StringLength(450)]
        public string? UsuarioApro { get; set; }

        public DateTime? FechaHoraAprob { get; set; }

        public bool Aprobado { get; set; }
    }
}
