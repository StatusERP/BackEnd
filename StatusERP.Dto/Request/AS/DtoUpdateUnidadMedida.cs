using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.AS
{
    public record DtoUpdateUnidadMedida
    {
        public string descripcion { get; set; }
        public string updatedby { get; set; }
      //  public DateTime updateDate { get; set; }
    }
}
