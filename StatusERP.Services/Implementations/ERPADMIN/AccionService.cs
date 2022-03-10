using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN;

public class AccionService:IAccionService
{
    private readonly IAccionRepository _repository;
    private readonly ILogger<AccionService> _logger;

    public AccionService(IAccionRepository repository,ILogger<AccionService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Accion>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Accion>>();
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

    public async Task<BaseResponseGeneric<Accion>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Accion>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Accion();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoAccion request, string userId)
    {
       var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new Accion
            {
                CodAccion = request.Accion,
                NombreAccion = request.nombreAccion,
                Descripcion = request.Descripicon,
                NombreConstante = request.NombreConstante,
                EsModulo = request.EsModulo,
                Tipo = request.Tipo,
                Subtipo = request.SubTipo,
                Tabla = request.Tabla,
                Invocacion = request.Invocacion,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAccion request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Accion
            {
                Id = id,
                CodAccion = request.Accion,
                NombreAccion = request.nombreAccion,
                Descripcion = request.Descripicon,
                NombreConstante = request.NombreConstante,
                EsModulo = request.EsModulo,
                Tipo = request.Tipo,
                Subtipo = request.SubTipo,
                Tabla = request.Tabla,
                Invocacion = request.Invocacion,
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