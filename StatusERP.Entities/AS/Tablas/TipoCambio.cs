using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TiposCambio", Schema = Constants.Conjunto)]
    public class TipoCambio:EntityBase
    {
        [StringLength(4)]
        public string CodTipoCambio { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
