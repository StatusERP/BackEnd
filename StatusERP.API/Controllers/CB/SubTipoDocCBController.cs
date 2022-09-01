using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.CB;
using StatusERP.Dto.Response;
using StatusERP.Entities.CB.Tablas;
using StatusERP.Services.Implementations.CB;
using StatusERP.Services.Interfaces.CB;

namespace StatusERP.API.Controllers.CB;
[ApiController]
[Route("api/CB/[controller]")]
[Authorize]
public class SubTipoDocCBController : ControllerBase
{
    private readonly ISubTipoDocCBService _service;
    private readonly ILogger<SubTipoDocCBService> _logger;

    public SubTipoDocCBController(ISubTipoDocCBService service, ILogger<SubTipoDocCBService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<SubTipoDocCB>>>> Get()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

        if (userId == null) return Unauthorized();

        return Ok(await _service.GetAsync(userId.Value));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<SubTipoDocCB>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoSubTipoDocCB request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value, request.Tipo, request.SubTipo);
        HttpContext.Response.Headers.Add("location", $"/api/CB/SubTipoDocCB/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoSubTipoDocCB request)
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
