using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Implementations.CG;
using System.Security.Claims;

namespace StatusERP.API.Controllers.CG
{
    [ApiController]
    [Route ("api/CG/[controller]")]
    [Authorize]
    public class TipoPartidaController : ControllerBase
    {
        private readonly ITipoPartidaService _service;
        private readonly ILogger<TipoPartidaService> _logger;

        public TipoPartidaController(ITipoPartidaService service,ILogger<TipoPartidaService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponseGeneric<ICollection<TipoPartida>>>> Get(int page, int rows)
        {
            return Ok(await _service.GetAsync(page, rows));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<TipoPartida>>> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoTipoPartida request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value, request.codTipoPartida);
            HttpContext.Response.Headers.Add("location", $"/api/AS/zona/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoTipoPartida request)
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
