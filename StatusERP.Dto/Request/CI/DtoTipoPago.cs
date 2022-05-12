using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoTipoPago
    {
        [Required(ErrorMessage = "Es necesario definir un código del tipo de pago.")]
        [StringLength(10)]
        public string CodTipoPago { get; set; }

        [StringLength(250)]
        public string? Descripcion { get; set; }
    }
}
