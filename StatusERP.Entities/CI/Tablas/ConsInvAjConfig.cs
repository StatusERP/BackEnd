using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CP.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ConsInvAjConfig", Schema = Constants.Conjunto)]
    public class ConsInvAjConfig : EntityBase
    {
        public int ConsecutivoInvId { get; set; }
        public ConsecutivoInv ConsecutivoInv { get; set; }

        public int AjusteConfigId { get; set; }
        public AjusteConfig AjusteConfig { get; set; }

    }
}
