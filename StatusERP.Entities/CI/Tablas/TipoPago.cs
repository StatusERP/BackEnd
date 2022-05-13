using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("TiposPago", Schema = Constants.Conjunto)]
    public class TipoPago : EntityBase 
    {
        [Required]
        [StringLength(10) ]
        public string CodTipoPago { get; set; }

        [StringLength (250) ]
        public string ? Descripcion { get; set; }
    }
}
