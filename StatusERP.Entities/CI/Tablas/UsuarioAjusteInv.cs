using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("UsuarioAjusteInv", Schema = Constants.Conjunto)]
    public class UsuarioAjusteInv:EntityBase
    {
        [Required]
        [StringLength(250)]
        public string Usuario { get; set; }
        
        public int AjusteConfig { get; set; }
        public AjusteConfig ajusteConfig { get; set; }

    }
}
