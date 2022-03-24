using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class UsuarioBodegaService:IUsuarioBodegaService
{
    private readonly IUsuarioBodegaRepository _repository;
    private readonly ILogger<UsuarioBodegaService> _logger;

    public UsuarioBodegaService(IUsuarioBodegaRepository repository,ILogger<UsuarioBodegaService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<UsuarioBodega>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<UsuarioBodega>>();
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

    public async Task<BaseResponseGeneric<UsuarioBodega>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<UsuarioBodega>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new UsuarioBodega();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoUsuarioBodega request, string userId, int bodegaId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarUsuarioBodega = await _repository.BuscarUsuarioBodegaAsync(userId,bodegaId);
            if (buscarUsuarioBodega != null)
            {
                throw new Exception($"El Usuario y Bodega  ya Existe");
            }
            response.Result = await _repository.CreateAsync(new UsuarioBodega
            {
                Usuario = request.Usuario,
                BodegaId = request.BodegaId,
                IsDeleted = false,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUsuarioBodega request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new UsuarioBodega
            {
                Id = id,
                Usuario = request.Usuario,
                BodegaId = request.BodegaId,
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