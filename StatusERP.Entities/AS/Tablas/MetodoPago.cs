using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("MetodosPago", Schema = Constants.Conjunto)]
    public class MetodoPago : EntityBase
    {
        [StringLength(4)]
        public string CodMetodoPago { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
