using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Implementations.ERPADMIN;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.API.Controllers.ERPADMIN;
[ApiController]
[Route("api/ERPADMIN/[controller]")]
[Authorize]
public class ConjuntoController : ControllerBase
{
    private readonly IConjuntoService _service;
    private readonly ILogger<ConjuntoService> _logger;

    public ConjuntoController( IConjuntoService service,ILogger<ConjuntoService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<Conjunto>>>> Get(int page, int rows)
    {
        return Ok(await _service.GetAsync(page, rows));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<Conjunto>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoConjunto request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value);
        HttpContext.Response.Headers.Add("location",$"/api/ERPADMIN/conjunto/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoConjunto request)
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