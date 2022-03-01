using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.API.Controllers.ERPADMIN
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase   
    {
        private readonly IUserService service;

        public UserController( IUserService service)
        {
            this.service = service;
        }
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(typeof(BaseResponseGeneric<string>),200)]
        [ProducesResponseType(typeof(BaseResponseGeneric<string>), 400)]
        public async Task<IActionResult> Register(DtoRegisterUser request)
        {
            var response = await service.RegisterAsync( request);
            return response.Success ? Ok(response) : BadRequest(response);
        }
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(typeof(DtoLoginResponse),200)]
        [ProducesResponseType(typeof(DtoLoginResponse), 403)]
        public async Task<IActionResult> Login(DtoLogin resquest)
        {
            var response = await service.LoginAsync(resquest);
            return response.Success ? Ok(response) : Unauthorized(response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SendTokenToResetPassword([FromBody]DtoResetPasssword request)
        {
            return Ok(await service.SendTokenToResetPasswordAsnc(request));

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(DtoConfirmReset request)
        {
            return Ok(await service.ResetPassword(request));
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(DtoChangePassword request)
        {
            return Ok(await service.ChangePassword(request));
        }


    }

    
}
