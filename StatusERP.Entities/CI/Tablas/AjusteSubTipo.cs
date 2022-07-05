using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubTipo", Schema = Constants.Conjunto)]
    public class AjusteSubTipo : EntityBase
    {
        [Required]
        [StringLength(4)]
        public string AjusteConfig { get; set; }

        public int AjusteConfigId { get; set; }
        public AjusteConfig AjusteConfigPK { get; set; }

        [Required]
        [StringLength(1)]
        public string SubTipo { get; set; }  
    }
}