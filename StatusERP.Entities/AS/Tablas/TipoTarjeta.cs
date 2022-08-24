using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TiposTarjeta", Schema = Constants.Conjunto)]
    public class TipoTarjeta : EntityBase
    {
        [StringLength(12)]
        public string CodTipoTarjeta { get; set; }

        [StringLength(1)]
        public string TipoCobro { get; set; }

        [StringLength(100)]
        public string? AssemblyInvocation { get; set; }
    }
}
