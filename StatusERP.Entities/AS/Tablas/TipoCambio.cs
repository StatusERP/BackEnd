using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class TipoCambio:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodTipoCambio { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
