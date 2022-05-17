using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesConfig", Schema = Constants.Conjunto)]
    public class AjusteConfig: EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodAjusteConfig { get; set; }
        
        [Required]
        [StringLength(15)]
        public string Descripcion { get; set; }
        
        [Required]
        [StringLength(1)]
        public string AjusteBase { get; set; }
        
        public bool Activa { get; set; }
        
        [Required]
        [StringLength(1)]
        public string Ingreso { get; set; }
    }
}