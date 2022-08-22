using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Implementations.FA;
using StatusERP.Services.Interfaces.FA;

namespace StatusERP.API.Controllers.FA;
[ApiController]
[Route("api/FA/[controller]")]
[Authorize]
public class DireccEmbarqueController : ControllerBase
{
    private readonly IDireccEmbarqueService _service;
    private readonly ILogger<DireccEmbarqueService> _logger;

    public DireccEmbarqueController(IDireccEmbarqueService service, ILogger<DireccEmbarqueService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<DireccEmbarque>>>> Get()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

        if (userId == null) return Unauthorized();

        return Ok(await _service.GetAsync(userId.Value));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<DireccEmbarque>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoDireccEmbarque request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value, request.ClienteId, request.Direccion);
        HttpContext.Response.Headers.Add("location", $"/api/FA/DireccEmbarque/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoDireccEmbarque request)
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