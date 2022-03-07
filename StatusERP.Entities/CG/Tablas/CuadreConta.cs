using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CuadreConta", Schema = Constants.Conjunto)]
    public class CuadreConta:EntityBase
    {
        [Required(ErrorMessage = "El código del Cuadre CG es requerido.")]
        public int CodCuadreCG { get; set; }

        [Required(ErrorMessage = "El número de asiento es requerido.")]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required(ErrorMessage = "El número de línea es requerido.")]
        public int Linea { get; set; }

        [Required(ErrorMessage = "La ubicacíón es requerida.")]
        [StringLength(1)]
        public string Ubicacion { get; set; }

        [Required(ErrorMessage = "El módulo origen es requerido.")]
        [StringLength(4)]
        public string Origen { get; set; }

        [Required(ErrorMessage = "El tipoo de Contabilidad es requerido.")]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El código de cuenta contable es requerido.")]
        [StringLength(25)]
        public string Cuenta { get; set; }

        [StringLength(60)]
        public string ? CuentaDescrip { get; set; }

        [Required(ErrorMessage = "El código del centro de costo es requerido.")]
        [StringLength(25)]
        public string Centro { get; set; }

        [StringLength(60)]
        public string ? CentroDescrip { get; set; }

        [Required(ErrorMessage = "La fuente es requerida.")]
        [StringLength(40)]
        public string Fuente { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitoLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitoDol { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditoLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditoDol { get; set; }
    }
}
