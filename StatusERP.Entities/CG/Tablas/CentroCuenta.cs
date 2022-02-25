using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
    public class CentroCuenta:EntityBase
    {
        [Required]
        [StringLength(25)]
        public string CentroCosto { get; set; }

        [Required]
        [StringLength(25)]
        public string CuentaContable { get; set; }

        public bool Activo { get; set; }
    }
}
