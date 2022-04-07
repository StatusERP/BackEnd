using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("TiposCuentasBancos", Schema = Constants.Conjunto)]
    public class TipoCuentaBanco:EntityBase
    {
        [Required(ErrorMessage ="El tipo de cuenta es requerido.") ]
        [StringLength(12)]
        public string CodTipoCuentaBanco { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
