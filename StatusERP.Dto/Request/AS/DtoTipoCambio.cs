using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoTipoCambio
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Tipo de Cambio.")]
        [StringLength(4)]
        public string CodTipoCambio { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción del Tipo de Cambio.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}