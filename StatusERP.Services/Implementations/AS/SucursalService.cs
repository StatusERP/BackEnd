using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class SucursalService:ISucursalService
{
    private readonly ISucursalesRepository _repository;
    private readonly ILogger<SucursalService> _logger;

    public SucursalService(ISucursalesRepository repository,ILogger<SucursalService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Sucursal>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Sucursal>>();
        try
        {
            response.Result = await _repository.GetCollectionAsync(page, rows);
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

    public async  Task<BaseResponseGeneric<Sucursal>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Sucursal>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Sucursal();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoSucursal request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new Sucursal
            {
                CodSucursal = request.CodSucursal,
                Descripcion = request.Nombre,
                Activa = true,
                Updatedby = userId,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Createdby = userId,
            });
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSucursal request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Sucursal
            {
                Id = id,
                CodSucursal = request.CodSucursal,
                Descripcion = request.Nombre,
                Activa = request.Activa,
                Updatedby = userId,
                UpdateDate = DateTime.Now
            });
            
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.StackTrace);
            response.Success = false;
            response.Errors.Add(ex.Message);
        }
        return response;
    }

    public  async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            await _repository.DeleteAsync(id, userId);
            response.Success = true;
            response.Result = id;
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.StackTrace);
            response.Success = false;
            response.Errors.Add(ex.Message);
        }
        return response;
    }
}