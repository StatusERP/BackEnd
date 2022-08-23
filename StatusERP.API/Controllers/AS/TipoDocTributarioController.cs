using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.API.Controllers.AS;
[ApiController]
[Route("api/AS/[controller]")]
[Authorize]
public class TipoDocTributarioController : ControllerBase
{
    private readonly ITipoDocTributarioService _service;
    private readonly ILogger<TipoDocTributarioService> _logger;

    public TipoDocTributarioController(ITipoDocTributarioService service, ILogger<TipoDocTributarioService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<TipoDocTributario>>>> Get()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

        if (userId == null) return Unauthorized();

        return Ok(await _service.GetAsync(userId.Value));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<TipoDocTributario>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoTipoDocTributario request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value, request.CodTipoDT);
        HttpContext.Response.Headers.Add("location", $"/api/AS/TipoDocTributario/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoTipoDocTributario request)
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