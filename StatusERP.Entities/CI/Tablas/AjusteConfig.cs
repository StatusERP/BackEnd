using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("AjustesConfig", Schema = Constants.Conjunto)]
    public class AjusteConfig: EntityBase
    {
        [Required(ErrorMessage = "El código del ajuste es requerido")]
        [StringLength(4)]
        public string AjusteConfig2 { get; set; }
        
        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(15)]
        public string Descripción { get; set; }
        
        [Required(ErrorMessage = "Se requiere especificar un código para la Categoría de Artículo")]
        [StringLength(4)]
        public string CodCategoriaArticulo { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el tipo de ajuste base")]
        [StringLength(1)]
        public string AjusteBase { get; set; }
        
        
    }
}