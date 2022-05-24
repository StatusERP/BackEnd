using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("TiposOperacion", Schema = Constants.Conjunto)]
    public class TipoOperacion : EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodTipoOperacion { get; set; }

        [StringLength(250)]
        public string? Descripcion { get; set; }
    }
}