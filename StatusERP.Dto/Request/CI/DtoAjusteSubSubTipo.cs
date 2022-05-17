using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CI
{
    public class DtoAjusteSubSubTipo
    {
        [Required(ErrorMessage = " El código de ajuste configurable es requerido.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }

        [Required(ErrorMessage = "El código del Subsubtipo es requerido")]
        [StringLength(1)]
        public string Subsubtipo { get; set; }
    }
}
