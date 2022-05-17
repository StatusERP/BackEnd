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
    public class IngresoLoteController : ControllerBase
    {
        private readonly IIngresoLoteService _service;
        private readonly ILogger<IngresoLoteService> _logger;

        public IngresoLoteController(IIngresoLoteService service, ILogger<IngresoLoteService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<IngresoLote>>>> Get(int page, int rows)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

            if (userId == null) return Unauthorized();
            return Ok(await _service.GetAsync(page, rows, userId.Value));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<IngresoLote>>> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoIngresoLote request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value, request.Articulo, request.Lote, request.SecuenciaLote);
            HttpContext.Response.Headers.Add("location", $"/api/CI/IngresoLote/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoIngresoLote request)
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
