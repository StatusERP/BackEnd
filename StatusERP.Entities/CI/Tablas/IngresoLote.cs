using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("IngresosLotes", Schema = Constants.Conjunto)]
    public class IngresoLote:EntityBase
    {
        [Required(ErrorMessage = "El código del artículo es requerido.")]
        public int Articulo { get; set; }

        [Required(ErrorMessage = "El lote es requerido.")]
        public int Lote { get; set; }
        
        [Required(ErrorMessage = "El valor de secuencia lote es requerido.")]
        public int SecuenciaLote { get; set; }
        
        public DateTime ? FechaEntrada { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal? CantidadIngresada { get; set; }
    }
}
