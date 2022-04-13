using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CuentasContables", Schema = Constants.Conjunto)]
    public class CuentaContable : EntityBase
    {
        [Required(ErrorMessage = "El código de cuenta contable es requerido.")]
        [StringLength(25)]
        public string CodCuentaContable { get; set; }

        [StringLength(4)]
        public string ? SeccionCuenta { get; set; }

        [Required(ErrorMessage = "La descripción de la cuenta contable es requerida.")]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se debe seleccionar uno de tres valores: B(Balance), E(Estado de Resultados), O(Orden)")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Se debe seleccionar un valor para el Tipo Detallado ")]
        [StringLength(1)]
        public string TipoDetallado { get; set; }

        [Required(ErrorMessage = "Se debe indicar el Saldo Normal de la Cuenta.")]
        [StringLength(1)]
        public string SaldoNormal { get; set; }

        [Required(ErrorMessage = "Debe indicarse el tipo de conversión")]
        [StringLength(1)]
        public string Conversion { get; set; }

        [Required(ErrorMessage = "Se requiere indicar el TipoCambio")]
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
