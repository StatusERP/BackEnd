using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Implementations.FA;
using StatusERP.Services.Interfaces.FA;
using System.Security.Claims;

namespace StatusERP.API.Controllers.FA
{
    [ApiController]
    [Route("api/FA/[controller]")]
    [Authorize]
    public class GlobalesFAController : ControllerBase
    {
        private readonly IGlobalesFAService _service;
        private readonly ILogger<GlobalesFAService> _logger;

        public GlobalesFAController(IGlobalesFAService service, ILogger<GlobalesFAService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<GlobalesFA>>>> Get()
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

            if (userId == null) return Unauthorized();
            return Ok(await _service.GetAsync(userId.Value));
        }


        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoGlobalesFA request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value);
            HttpContext.Response.Headers.Add("location", $"/api/FA/GlobalesFA/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoGlobalesFA request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            var response = await _service.UpdateAsync(id, request, userId.Value);
            return Ok(new { response });
        }

    }
}