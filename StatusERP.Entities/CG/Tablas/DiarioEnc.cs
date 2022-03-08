using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("DiarioEnc", Schema = Constants.Conjunto)]
    public class DiarioEnc:EntityBase
    {
        [Required(ErrorMessage = "Se requiere un número de asiento.")]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required(ErrorMessage = "Se requiere un código de paquete.")]
        [StringLength(4)]
        public string Paquete { get; set; }

        [Required(ErrorMessage = "Se requiere un tipo de asiento.")]
        [StringLength(4)]
        public string TipoAsiento { get; set; }

        [Required(ErrorMessage = "Se requiere la fecha del asiento.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se requiere el tipo de contabilidad.")]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required(ErrorMessage = "Se requiere el módulo origen del asiento.")]
        [StringLength(4)]
        public string Origen { get; set; }

        [Required(ErrorMessage = "Se requiere la clase de asiento.")]
        [StringLength(1)]
        public string ClaseAsiento { get; set; }

        [Required(ErrorMessage = "Se requiere el monto total del débito en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalDebitoLoc { get; set; }

        [Required(ErrorMessage = "Se requiere el monto total del débito en moneda dólar.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalDebitoDol { get; set; }

        [Required(ErrorMessage = "Se requiere el monto total del crédito en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCreditoLoc { get; set; }

        [Required(ErrorMessage = "Se requiere el monto total del crédito en moneda dólar.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalCreditoDol { get; set; }

        [Required(ErrorMessage = "Se requiere el monto de la diferencia entre débitos y créditos en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalControlLoc { get; set; }

        [Required(ErrorMessage = "Se requiere el monto de la diferencia entre débitos y créditos en moneda dólar.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TotalControlDol { get; set; }

        [Required(ErrorMessage = "Ultimo usuario es requerido.")]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required(ErrorMessage = "Ultima fecha de modificación es requerida.")]
        public DateTime FechaUltModif { get; set; }

        public bool Marcado { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "El usuario que creó es requerido.")]
        [StringLength(25)]
        public string UsuarioCreacion { get; set; }

        [Required(ErrorMessage = "La fecha de creación es requerida.")]
        public DateTime FechaCreacion { get; set; }


    }
}
