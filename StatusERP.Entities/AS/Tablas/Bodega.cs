using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Bodegas", Schema = Constants.Conjunto)]
    public class Bodega:EntityBase
    {
        [StringLength(4)]
        public string CodBodega { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public bool Activa { get; set; }

        [StringLength(15)]
        public string ? Telefono { get; set; }

        [StringLength(250)]
        public string ? Direccion { get; set; }
    }
}
 