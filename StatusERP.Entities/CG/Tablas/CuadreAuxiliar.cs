using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CuadreAuxiliar", Schema = Constants.Conjunto)]
    public class CuadreAuxiliar:EntityBase
    {
        [Required(ErrorMessage = "El código del Cuadre CG es requerido.")]
        public int CodCuadreCG { get; set; }

        [Required(ErrorMessage = "La descripción de la Tabla Origen es requerida.")]
        [StringLength(30)]
        public string TablaOrigen { get; set; }

        [StringLength(250)]
        public string ? Referencia { get; set; }

        [Required(ErrorMessage = "La fecha del cuadre es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El concepto es requerido.")]
        [StringLength(250)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        [Required(ErrorMessage = "Debe especificar el monto del débito en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoLoc { get; set; }

        [Required(ErrorMessage = "Debe especificar el monto del débito en moneda dólar.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoDol { get; set; }

        [Required(ErrorMessage = "Debe especificar el monto del crédito en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoLoc { get; set; }

        [Required(ErrorMessage = "Debe especificar el monto del crédito en moneda dólar.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoDol { get; set; }

        [Required(ErrorMessage = "Debe especificar el módulo origen.")]
        [StringLength(4)]
        public string Origen { get; set; }
    }
}
