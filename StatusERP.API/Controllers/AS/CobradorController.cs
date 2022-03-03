using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using System.Security.Claims;

namespace StatusERP.API.Controllers.AS
{
    [ApiController]
    [Route("api/AS/[controller]")]
    [Authorize]
    public class CobradorController : ControllerBase
    {
        private readonly ICobradorService _service;

        public CobradorController(ICobradorService service)
        {
            _service = service;
        }
        [HttpGet]
        //filter =""
        //page =1||2
        //rows =10||10
        public async Task<ActionResult<BaseResponseGeneric<ICollection<Cobrador>>>> Get(
            int page,
            int rows
            )
        {

            return Ok(await _service.GetAsync(page, rows));

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<Cobrador>>> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoCobrador request)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

            if (userId == null) return Unauthorized();
            var response = await _service.CreateAsync(request, userId.Value);

            HttpContext.Response.Headers.Add("location", $"/api/AS/vendedor/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoCobrador request)
        {
            var response = await _service.UpdateAsync(id, request);
            return Ok(new { response });
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
        {
            var response = await _service.DeleteAsync(id);
            return Ok(response);

        }
    }
}
