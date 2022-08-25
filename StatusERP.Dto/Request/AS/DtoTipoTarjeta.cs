using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoTipoTarjeta
    {

        [Required(ErrorMessage = "Se requiere especificar el código del tipo de tarjeta.")]
        [StringLength(12)]
        public string CodTipoTarjeta { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el tipo de cobro.")]
        [StringLength(1)]
        public string TipoCobro { get; set; }

        [StringLength(100)]
        public string? AssemblyInvocation { get; set; }
    }
}
