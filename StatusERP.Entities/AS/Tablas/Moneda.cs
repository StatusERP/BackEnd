using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Monedas", Schema = Constants.Conjunto)]
    public class Moneda:EntityBase
    {
        [StringLength(4)]
        public string CodMoneda { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(4)]
        public string ? CodigoISO { get; set; }
        
        public bool Activa { get; set; }
    }
}
