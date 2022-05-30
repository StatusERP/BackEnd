using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoConsInvAjConfig
    {
        public int ConsecutivoInvId { get; set; }

        public int AjusteConfigId { get; set; }
    }
}
