using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("BonifsClasXCli", Schema = Constants.Conjunto)]
    public class BonifClasXCli:EntityBase 
    {
        [Required(ErrorMessage ="El cliente es requerido.")]
        [StringLength(20)]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "La clasificación es requerida.")]
        [StringLength(12)]
        public string Clasificacion { get; set; }

        [Required(ErrorMessage = "La escala de bonificación es requerida.")]
        public int EscalaBonif { get; set; }

        [Required(ErrorMessage = "La versión de la bonificación es requerida.")]
        public int VersionBonif { get; set; }

        [Required(ErrorMessage = "La cantidad inicial es requerida.")]
        public int CantidadInicial { get; set; }

        [Required(ErrorMessage = "La cantidad final es requerida.")]
        public int CantidadFinal { get; set; }

        [Required(ErrorMessage = "La fecha inicial es requerida.")]
        public DateTime FechaInicial { get; set; }

        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFinal { get; set; }

        [Column(TypeName = "decimal(15,5)")]
        public decimal ? FactorBonif { get; set; }

        [Required(ErrorMessage = "El artículo a bonificar es requerido.")]
        [StringLength(20)]
        public string ArticuloBonif { get; set; }

        [Required(ErrorMessage = "Las unidades a bonificar son requeridas.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal UnidadesBonif { get; set; }
    }
}
