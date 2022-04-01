using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas
{
    [Table("Quedans", Schema = Constants.Conjunto)]
    public class Quedan:EntityBase
    {
        [Required(ErrorMessage ="El número de quedan es requerido.")]
        [StringLength(50)]
        public string NumQuedan { get; set; }

        [Required(ErrorMessage = "El proveedor es requerido.")]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "El usuario de la última modificación es requerido.")]
        [StringLength(450)]
        public string UsuarioUltMod { get; set; }

        public DateTime ? FechaRige { get; set; }

        public DateTime ? FechaUltMod { get; set; }

        [StringLength(1)]
        public string ? Estado { get; set; }

        public string ? Notas { get; set; }

        public DateTime ? FechaEmision { get; set; }

        public bool Congelado { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es requerida.")]
        public DateTime FechaVence { get; set; }
    }
}
