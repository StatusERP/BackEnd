using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
    public class CuentaContable : EntityBase
    {
        [Required]
        [StringLength(25)]
        public string CodCuentaContable { get; set; }

        [StringLength(4)]
        public string ? SeccionCuenta { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoDetallado { get; set; }

        [Required]
        [StringLength(1)]
        public string SaldoNormal { get; set; }

        [Required]
        [StringLength(1)]
        public string Conversion { get; set; }

        [Required]
        [StringLength(4)]
        public string TipoCambio { get; set; }

        public bool AceptaDatos { get; set; }

        public bool UsaCentroCosto { get; set; }

        public string ? Notas { get; set; }

        public bool UsoRestringido { get; set; }

        [StringLength(1)]
        public string ? OrigenConversion { get; set; }
    }
}
