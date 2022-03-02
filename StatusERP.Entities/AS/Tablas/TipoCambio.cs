using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TiposCambio", Schema = Constants.Conjunto)]
    public class TipoCambio:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Tipo de Cambio.")]
        [StringLength(4)]
        public string CodTipoCambio { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción del Tipo de Cambio.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
