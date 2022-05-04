using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Implementations.CI;
using StatusERP.Services.Interfaces.CI;
using System.Security.Claims;

namespace StatusERP.API.Controllers.CI
{
    [ApiController]
    [Route("api/CI/[controller]")]
    [Authorize]
    public class GlobalesCIController : ControllerBase
    {
        private readonly IGlobalesCIService _service;
        private readonly ILogger<GlobalesCIService> _logger;

        public GlobalesCIController(IGlobalesCIService service, ILogger<GlobalesCIService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<GlobalesCI>>>> Get(int page, int rows)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

            if (userId == null) return Unauthorized();
            return Ok(await _service.GetAsync(page, rows, userId.Value));
        }


        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoGlobalesCI request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value);
            HttpContext.Response.Headers.Add("location", $"/api/CI/GlobalesCI/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoGlobalesCI request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            var response = await _service.UpdateAsync(id, request, userId.Value);
            return Ok(new { response });
        }

    }
}
