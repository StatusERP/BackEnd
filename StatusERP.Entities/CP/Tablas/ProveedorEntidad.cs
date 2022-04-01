using System.ComponentModel.DataAnnotations;
using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas
{
    [Table("ProveedorEntidades", Schema = Constants.Conjunto)]
    public class ProveedorEntidad:EntityBase
    {
        [Required(ErrorMessage = "El proveedor es requerido.")]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage = "La entidad financiera es requerida.")]
        public int EntidadFinancieraId { get; set; }
        public EntidadFinanciera EntidadFinanciera { get; set; }

        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        [StringLength(20)]
        public string CuentaBanco { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        public bool CtaDefault { get; set; }

        [StringLength(12)]
        public string ? TipoCuenta { get; set; }

        [StringLength(50)]
        public string ? CtaElectronica { get; set; }
    }
}
