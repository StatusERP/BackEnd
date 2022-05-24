using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoUsuarioAjusteInv
    {
        [Required(ErrorMessage = "Debe especificarse un usuario.")]
        [StringLength(250)]
        public string Usuario { get; set; }

        public int AjusteConfig { get; set; }
    }
}
