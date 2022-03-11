using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesSubTipo", Schema = Constants.Conjunto)]
    public class AjusteSubTipo : EntityBase
    {
        [Required(ErrorMessage = "Se debe indicar un ajuste")]
        public int AjusteConfig { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar un subtipo")]
        public int Subtipo { get; set; }  
    }
}