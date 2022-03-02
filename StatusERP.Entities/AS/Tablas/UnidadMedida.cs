using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("UnidadesMedida", Schema = Constants.Conjunto)]
    public class UnidadMedida:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Unidad de Medida.")]
        [StringLength(6)]
        public string CodUnidadMedida { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la Descripción de la Unidad de Medida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
