using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class ZonaService:IZonaService
{
    private readonly IZonaRepository _repository;
    private readonly ILogger<ZonaService> _logger;

    public ZonaService( IZonaRepository repository, ILogger<ZonaService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    
    public async Task<BaseResponseGeneric<ICollection<Zona>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Zona>>();
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

    public async Task<BaseResponseGeneric<Zona>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Zona>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Zona();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoZona request, string userId,string codZona)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodBodega = await _repository.BuscarCodZonaAsync(codZona);
            if (buscarCodBodega != null)
            {
              
                response.Errors.Add($"El codigo de Zona {buscarCodBodega.CodZona} ya Existe");
                response.Success = false;
                return response;
            }
            response.Result = await _repository.CreateAsync(new Zona
            {
                CodZona = request.CodZona,
                Descripcion = request.Descripcion,
                Activa = true,
                Updatedby = userId,
                UpdateDate = DateTime.Now,
                Createdby = userId,
                CreateDate = DateTime.Now
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoZona request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
           
            response.Result = await _repository.UpdateAsync(new Zona
            {
                Id = id,
                CodZona = request.CodZona,
                Descripcion = request.Descripcion,
                Activa = request.Activo,
                Updatedby = userId,
                UpdateDate = DateTime.Now
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
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