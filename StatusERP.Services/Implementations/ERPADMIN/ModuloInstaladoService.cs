using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN;

public class ModuloInstaladoService:IModuloInstaladoService
{
    private readonly IModuloInstaladoRepository _repository;
    private readonly ILogger<ModuloInstaladoService> _logger;

    public ModuloInstaladoService(IModuloInstaladoRepository repository,ILogger<ModuloInstaladoService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<ModuloInstalado>>> GetAsync(int conjunto)
    {
        var response = new BaseResponseGeneric<ICollection<ModuloInstalado>>();
        try
        {
            response.Result = await _repository.GetCollectionAsync(conjunto);
            response.Success = true;
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.StackTrace);
            response.Success = false;
            response.Errors.Add(ex.Message);
        }

        return response;
    }

    public Task<BaseResponseGeneric<ModuloInstalado>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseGeneric<int>> CreateAsync(DtoModuloInstalado request, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoModuloInstalado request, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }
}