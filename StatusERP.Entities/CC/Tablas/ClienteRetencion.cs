using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CC.Tablas
{
    [Table("ClientesRetenciones", Schema = Constants.Conjunto)]
    public class ClienteRetencion:EntityBase
    {
        [Required(ErrorMessage = "El cliente es requerido.")]
        [StringLength(20)]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El código de retención es requerido.")]
        [StringLength(4)]
        public string CodigoRetencion { get; set; }

        public string ? Notas { get; set; }
    }
}
