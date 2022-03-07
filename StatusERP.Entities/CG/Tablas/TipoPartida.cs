using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    
    [Table("TiposPartida", Schema = Constants.Conjunto)]
    public class TipoPartida:EntityBase
    {
        [Required(ErrorMessage = "El código del tipo de partida es requerido.")]
        [StringLength(4)]
        public string CodTipoPartida { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
