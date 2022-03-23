using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class TipoCambioService:ITipoCambioService
{
    private readonly ITipoCambioRepository _repository;
    private readonly ILogger<TipoCambioService> _logger;

    public TipoCambioService(ITipoCambioRepository repository ,ILogger<TipoCambioService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<TipoCambio>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<TipoCambio>>();
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

    public async Task<BaseResponseGeneric<TipoCambio>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<TipoCambio>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new TipoCambio();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoCambio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new TipoCambio
            {
                CodTipoCambio = request.CodTipoCambio,
                Descripcion = request.Descripcion,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoCambio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new TipoCambio
            {
                Id = id,
                CodTipoCambio = request.CodTipoCambio,
                Descripcion = request.Descripcion,
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