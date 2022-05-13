using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CI
{
    public class DtoTipoOperacion
    {
        [Required(ErrorMessage = "Es necesario definir un código del tipo de operación.")]
        [StringLength(10)]
        public string CodTipoOperacion { get; set; }

        [StringLength(250)]
        public string? Descripcion { get; set; }
    }
}
