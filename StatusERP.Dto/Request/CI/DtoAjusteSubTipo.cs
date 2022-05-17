using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoAjusteSubTipo
    {
        [Required(ErrorMessage = "Se debe indicar el ajuste configurable.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }

        [Required(ErrorMessage = "Se debe indicar un subtipo.")]
        [StringLength(1)]
        public string SubTipo { get; set; }
    }
}
