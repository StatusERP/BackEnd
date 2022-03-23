using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Implementations.ERPADMIN;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.API.Controllers.ERPADMIN;

[ApiController]
[Route("api/ERPADMIN/[controller]")]
public class ModuloInstaladoController : ControllerBase
{
    private readonly IModuloInstaladoService _service;
    private readonly ILogger<ModuloInstaladoService> _logger;

    public ModuloInstaladoController(IModuloInstaladoService service, ILogger<ModuloInstaladoService> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<ModuloInstalado>>>> Get(int conjunto,string empresa)
    {
        return Ok(await _service.GetAsync(conjunto));

    }   
}