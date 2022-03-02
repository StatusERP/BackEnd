using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;

namespace StatusERP.Services.Interfaces.ERPADMIN
{
    public interface IUserService
    {
        Task<BaseResponseGeneric<string>> RegisterAsync(DtoRegisterUser request);
        Task<DtoLoginResponse> LoginAsync(DtoLogin request);

        Task<BaseResponseGeneric<string>> SendTokenToResetPasswordAsnc(DtoResetPasssword request);
        Task<BaseResponseGeneric<string>> ResetPassword(DtoConfirmReset request);
        Task<BaseResponse> ChangePassword(DtoChangePassword request);
    }
}
