using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CentroCuenta", Schema = Constants.Conjunto)]
    public class CentroCuenta:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar un centro de costo.")]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable.")]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        public bool Activo { get; set; }
    }
}
