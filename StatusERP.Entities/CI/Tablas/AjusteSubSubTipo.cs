using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubSubTipo", Schema = Constants.Conjunto)]

    public class AjusteSubSubTipo:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
        
        [Required]
        [StringLength(1)]
        public string Subsubtipo { get; set; }
    }
}


