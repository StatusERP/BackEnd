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
public class LocalizacionesController : ControllerBase
{
    private readonly ILocalizacionesService _service;
    private readonly ILogger<LocalizacionesService> _logger;

    public LocalizacionesController(ILocalizacionesService service,ILogger<LocalizacionesService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<Localizacion>>>> Get()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        return Ok(await _service.GetAsync(userId.Value));
    }
    /*
    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<Localizacion>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }
    */

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<Localizacion>>> GetBodega(int id)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        return Ok(await _service.GetByIdBodegaAsync(id,userId.Value));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoLocalizaciones request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value,request.CodLocalizacion, request.bodegaId);
        HttpContext.Response.Headers.Add("location",$"/api/AS/localizaciones/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoLocalizaciones request)
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