using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CC.Tablas
{
    [Table("SaldosClientes", Schema = Constants.Conjunto)]
    public class SaldoCliente:EntityBase
    {
        [Required(ErrorMessage = "El cliente es requerido.")]
        [StringLength(20)]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El saldo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "El saldo corporativo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCorporacion { get; set; }

        [Required(ErrorMessage = "El saldo de las sucursales es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoSucursales { get; set; }

        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime FechaUltMov { get; set; }
    }
}
