using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.ERPADMIN
{
    public record DtoConfirmReset(string Email,string Token, string Password);
    
}
