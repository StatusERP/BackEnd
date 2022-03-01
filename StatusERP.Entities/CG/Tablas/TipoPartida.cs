using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
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
