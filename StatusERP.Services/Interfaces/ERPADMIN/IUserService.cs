using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;

namespace StatusERP.Services.Interfaces.ERPADMIN
{
    public interface IUserService
    {
        Task<BaseResponseGeneric<string>> RegisterAsync(DtoRegisterUser request);
        Task<DtoLoginResponse> LoginAsync(DtoLogin request);
    }
}
