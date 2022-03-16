using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("UsuarioAjusteInv", Schema = Constants.Conjunto)]
    public class UsuarioAjusteInv:EntityBase
    {
        [Required(ErrorMessage = "Debe especificarse un usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse el código del ajuste.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
    }
}
