using StatusERP.Entities.CB.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("FCCuentasBancos", Schema = Constants.Conjunto)]
    public class FCCuentaBanco:EntityBase
    {
        public bool Activo { get; set; }

        [Required(ErrorMessage = "Se debe indicar una cuenta bancaria.")]
        public int CuentaBancoId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "Se debe indicar un código de flujo de caja.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }
    }
}
