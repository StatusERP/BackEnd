using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Rutas", Schema = Constants.Conjunto)]
    public class Ruta:EntityBase
    {
        [StringLength(4)]
        public string CodRuta { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
