using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("UsuarioAjusteInv", Schema = Constants.Conjunto)]
    public class UsuarioAjusteInv:EntityBase
    {
        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        [Required]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
    }
}
