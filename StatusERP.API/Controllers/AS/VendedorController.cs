using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.API.Controllers.AS
{
    [ApiController]
    [Route("api/AS/[controller]")]
    //[Authorize(Roles=Constants.RoleAdministrador)]
    public class VendedorController:ControllerBase
    {
        private readonly IVendedorService _service;

        public VendedorController(IVendedorService service)
        {
            _service = service;
        }
        [HttpGet]   
        //filter =""
        //page =1||2
        //rows =10||10
        public async Task< ActionResult<BaseResponseGeneric< ICollection<Vendedor>>>> Get(
            int page,
            int rows,
            int conjunto)
        {

            return Ok(await _service.GetAsync(conjunto, page, rows));

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric <Vendedor>>> Get(int id)
        {
                       return Ok(await _service.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoVendedor request)
        {
            var response = await _service.CreateAsync(request);

            HttpContext.Response.Headers.Add("location", $"/api/AS/vendedor/{response.Result}");
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DtoVendedor request)
        {
            var response =await _service.UpdateAsync(id, request);
            return Ok(new {response});
        }
        
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
        {
            var response = await _service.DeleteAsync(id);
            return Ok(response);
           
        }
    }
}
