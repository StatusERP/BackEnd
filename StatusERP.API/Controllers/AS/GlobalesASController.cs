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
public class GlobalesASController : ControllerBase
{
    private readonly IGlobalesASService _service;
    private readonly ILogger<GlobalesASService> _logger;

    public GlobalesASController(IGlobalesASService service,ILogger<GlobalesASService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<GlobalesAS>>>> Get()
    {

        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        return Ok(await _service.GetAllAsync(userId.Value));


        
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<GlobalesAS>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoGlobalesAS request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value);
        HttpContext.Response.Headers.Add("location",$"/api/AS/globalesAS/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoGlobalesAS request)
    {
        var userId=HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response =await _service.UpdateAsync(id, request,userId.Value);
        return Ok(new {response});
    }
}