using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CuadreConta", Schema = Constants.Conjunto)]
    public class CuadreConta:EntityBase
    {
        [Required]
        public int CodCuadreCG { get; set; }

        [Required]
        [StringLength(10)]
        public string Asiento { get; set; }

        [Required]
        public int Linea { get; set; }

        [Required]
        [StringLength(1)]
        public string Ubicacion { get; set; }

        [Required]
        [StringLength(4)]
        public string Origen { get; set; }

        [Required]
        [StringLength(1)]
        public string Contabilidad { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(25)]
        public string Cuenta { get; set; }

        [StringLength(60)]
        public string ? CuentaDescrip { get; set; }

        [Required]
        [StringLength(25)]
        public string Centro { get; set; }

        [StringLength(60)]
        public string ? CentroDescrip { get; set; }

        [Required]
        [StringLength(40)]
        public string Fuente { get; set; }

        [Required]
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
