using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("IngresosLotes", Schema = Constants.Conjunto)]
    public class IngresoLote:EntityBase
    {
        public int Articulo { get; set; }

        public int Lote { get; set; }
        
        public int SecuenciaLote { get; set; }
        
        public DateTime ? FechaEntrada { get; set; }


        [Column(TypeName = "decimal(28,8)")] 
        public decimal? CantidadIngresada { get; set; }
    }
}
