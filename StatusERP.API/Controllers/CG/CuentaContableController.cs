using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Implementations.CG;
using StatusERP.Services.Interfaces.CG;
using System.Security.Claims;

namespace StatusERP.API.Controllers.CG
{
    [ApiController]
    [Route("api/CG/[controller]")]
    [Authorize]
    public class CuentaContableController : ControllerBase
    {
        private readonly ICuentaContableService _service;
        private readonly ILogger<CuentaContableService> _logger;

        public CuentaContableController(ICuentaContableService service, ILogger<CuentaContableService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<CuentaContable>>>> Get(int page, int rows)
        {
            return Ok(await _service.GetAsync(page, rows));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<CuentaContable>>> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoCuentaContable request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value, request.CodCuentaContable);
            HttpContext.Response.Headers.Add("location", $"/api/CG/CuentaContable/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoCuentaContable request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            var response = await _service.UpdateAsync(id, request, userId.Value);
            return Ok(new { response });
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            var response = await _service.DeleteAsync(id, userId.Value);
            return Ok(response);

        }
    }
}