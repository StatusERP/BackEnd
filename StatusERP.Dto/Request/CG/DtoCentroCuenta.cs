using System.ComponentModel.DataAnnotations;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.AS.Tablas;


namespace StatusERP.Dto.Request.CG
{
    public class DtoCentroCuenta
    {
        public int CentroCostoId { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código del centro de costo.")]
        [StringLength(25)]
        public string CodCentroCosto { get; set; }

        public int CuentaContableId { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el código de la cuenta contable.")]
        [StringLength(25)]
        public string CodCuentaContable { get; set; }

        public bool Activo { get; set; }
    }
}