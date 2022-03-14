using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubTipo", Schema = Constants.Conjunto)]
    public class AjusteSubTipo : EntityBase
    {
        [Required(ErrorMessage = "Se debe indicar el ajuste configurable.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar un subtipo.")]
        [StringLength(1)]
        public string SubTipo { get; set; }  
    }
}