using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    
    [Table("TiposPartida", Schema = Constants.Conjunto)]
    public class TipoPartida:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodTipoPartida { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
