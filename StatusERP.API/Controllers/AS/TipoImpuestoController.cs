using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Interfaces.AS;
using System.Security.Claims;

namespace StatusERP.API.Controllers.AS
{
    [ApiController]
    [Route("api/AS/[controller]")]
    [Authorize]
    public class TipoImpuestoController : ControllerBase
    {
        private readonly ITipoImpuestoService _service;
        private readonly ILogger<TipoImpuestoService> _logger;

        public TipoImpuestoController(ITipoImpuestoService service, ILogger<TipoImpuestoService> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<TipoImpuesto>>>> Get(int page, int rows)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            return Ok(await _service.GetAsync(page, rows, userId.Value));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<TipoImpuesto>>> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoTipoImpuesto request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value, request.CodTipoImpuesto);
            HttpContext.Response.Headers.Add("location", $"/api/AS/TipoImpuesto/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoTipoImpuesto request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            var response = await _service.UpdateAsync(id, request, userId.Value);
            return Ok(new { response });
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.DeleteAsync(id, userId.Value);
            return Ok(response);

        }
    }
}