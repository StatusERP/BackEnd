using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.AS
{
   
        public record DtoUpdateBodega(string Nombre, string Tipo, bool Activa, string Telefono, string Direccion);
    
}
