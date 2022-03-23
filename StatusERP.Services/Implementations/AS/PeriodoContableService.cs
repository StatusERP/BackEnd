using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class PeriodoContableService:IPeriodoContableService
{
    private readonly IPeriodosContableRepository _repository;
    private readonly ILogger<PeriodoContableService> _logger;

    public PeriodoContableService(IPeriodosContableRepository repository,ILogger<PeriodoContableService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<PeriodoContable>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<PeriodoContable>>();
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

    public async Task<BaseResponseGeneric<PeriodoContable>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<PeriodoContable>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new PeriodoContable();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPeridoContable request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new PeriodoContable
            {
                FechaFinal = request.FechaFinal,
                Contabilidad = request.Contabilidad,
                Descripcion = request.Descripcion,
                FinPeriodoAnual = request.FinPeriodoAnual,
                Abierto = true,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPeridoContable request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new PeriodoContable
            {
                Id = id,
                FechaFinal = request.FechaFinal,
                Contabilidad = request.Contabilidad,
                Descripcion = request.Descripcion,
                FinPeriodoAnual = request.FinPeriodoAnual,
                Abierto = request.Abierto,
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