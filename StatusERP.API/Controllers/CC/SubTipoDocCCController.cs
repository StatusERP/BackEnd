using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.CC;
using StatusERP.Dto.Response;
using StatusERP.Entities.CC.Tablas;
using StatusERP.Services.Implementations.CC;
using StatusERP.Services.Interfaces.CC;

namespace StatusERP.API.Controllers.CC;
[ApiController]
[Route("api/CC/[controller]")]
[Authorize]
public class SubTipoDocCCController : ControllerBase
{
    private readonly ISubTipoDocCCService _service;
    private readonly ILogger<SubTipoDocCCService> _logger;

    public SubTipoDocCCController(ISubTipoDocCCService service,ILogger<SubTipoDocCCService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<SubTipoDocCC>>>> Get()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

        if (userId == null) return Unauthorized();

        return Ok(await _service.GetAsync(userId.Value));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<SubTipoDocCC>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoSubTipoDocCC request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value, request.Tipo, request.Subtipo);
        HttpContext.Response.Headers.Add("location",$"/api/CC/SubTipoDocCC/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoSubTipoDocCC request)
    {
        var userId=HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response =await _service.UpdateAsync(id, request,userId.Value);
        return Ok(new {response});
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
    {
        var userId=HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response = await _service.DeleteAsync(id,userId.Value);
        return Ok(response);
           
    }
}