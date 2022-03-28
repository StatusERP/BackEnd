using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.API.Controllers.AS;

    [ApiController]
    [Route("api/AS/[controller]")]
    [Authorize]
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalService _service;

        public SucursalController(ISucursalService service)
        {
          _service = service;
        }

    [HttpGet]    
    public async Task<ActionResult<BaseResponseGeneric<ICollection<Sucursal>>>> Get(
        int page,
        int rows
    )
    {

        return Ok(await _service.GetAsync(page, rows));

    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<Sucursal>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoSucursal request)
    {
        var userid = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userid == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userid.Value,request.CodSucursal);
        HttpContext.Response.Headers.Add("location", $"/api/AS/cobrador/{response.Result}");
        return Ok(response);
        
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Put(int id, DtoSucursal request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response = await _service.UpdateAsync(id, request,userId.Value);
            
        return Ok(response);
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id )
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response = await _service.DeleteAsync(id,userId.Value);
        return Ok(response);

    }
    

} 
    

