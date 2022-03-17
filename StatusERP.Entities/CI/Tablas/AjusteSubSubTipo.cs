using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubSubTipo", Schema = Constants.Conjunto)]

    public class AjusteSubSubTipo:EntityBase
    {
        [Required(ErrorMessage = " El código de ajuste configurable es requerido.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
        
        [Required(ErrorMessage = "El código del Subsubtipo es requerido")]
        [StringLength(1)]
        public string SubsubtipoId { get; set; }
    }
}


