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
        //No defino FK porque no estoy validando el Id del AjusteConfig, sino el CodAjusteConfig
        
        [Required]
        [StringLength(1)]
        public string SubTipo { get; set; }  
    }
}