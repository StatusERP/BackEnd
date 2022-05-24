using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TiposImpuesto", Schema = Constants.Conjunto)]
    public class TipoImpuesto : EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodTipoImpuesto { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}