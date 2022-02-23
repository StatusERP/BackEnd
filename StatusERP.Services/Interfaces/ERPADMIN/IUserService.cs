using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Services.Interfaces.ERPADMIN
{
    public interface IUserService
    {
        Task<BaseResponseGeneric<string>> RegisterAsync(DtoRegisterUser request);
        Task<DtoLoginResponse> LoginAsync(DtoLogin request);
    }
}
