using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CentroCuenta", Schema = Constants.Conjunto)]
    public class CentroCuenta:EntityBase
    {
        public int CentroCostoId { get; set; }
        public CentroCosto CentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un centro de costo.")]
        [StringLength(25)]
        public string CodCentroCosto { get; set; }

        public int CuentaContableId { get; set; }
        public CuentaContable CuentaContable { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable.")]
        [StringLength(25)]
        public string CodCuentaContable { get; set; }

        public bool Activo { get; set; }
    }
}
