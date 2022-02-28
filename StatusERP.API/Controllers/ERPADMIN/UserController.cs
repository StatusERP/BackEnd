using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
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
        [HttpPost]
        [ProducesResponseType(typeof(BaseResponseGeneric<string>),200)]
        [ProducesResponseType(typeof(BaseResponseGeneric<string>), 400)]
        public async Task<IActionResult> Register(DtoRegisterUser request)
        {
            var response = await service.RegisterAsync( request);
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
