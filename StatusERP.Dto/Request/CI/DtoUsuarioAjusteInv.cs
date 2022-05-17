using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoUsuarioAjusteInv
    {
        [Required(ErrorMessage = "Debe especificarse un usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Debe especificarse el código del ajuste.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
    }
}
