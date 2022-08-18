using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("NivelesPrecios", Schema = Constants.Conjunto)]
    public class NivelPrecio:EntityBase
    {
        [StringLength(12)]
        public string CodNivelPrecio { get; set; }

        [StringLength(1)]
        public string Moneda { get; set; }

        public int ? CondicionPagoId { get; set; }
        public CondicionPago CondicionPago { get; set; }

        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }

        public bool Descuentos { get; set; }

        public bool SugerirDescuento { get; set; }
        
        public bool Activo { get; set; }
    }
}
