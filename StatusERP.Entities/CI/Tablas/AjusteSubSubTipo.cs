using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubSubTipo", Schema = Constants.Conjunto)]

    public class AjusteSubSubTipo:EntityBase
    {
        [Required(ErrorMessage = "El Id del AjusteConfig es requerido")]
        public int AjusteConfigId { get; set; }
        
        [Required(ErrorMessage = "El código del SubSubtipo es requerido")]
        public int SubSubtipoId { get; set; }
        
    }
}


