using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Zonas", Schema = Constants.Conjunto)]
    public class Zona:EntityBase
    {
        [StringLength(4)]
        public string CodZona { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
