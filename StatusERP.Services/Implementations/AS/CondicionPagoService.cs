using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class CondicionPagoService:ICondicionPagoService
{
    private readonly ICondicionPagoRepository _repository;
    private readonly ILogger<CondicionPago> _logger;

    public CondicionPagoService(ICondicionPagoRepository repository,ILogger<CondicionPago> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<CondicionPago>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<CondicionPago>>();
        try
        {
            response.Result = await _repository.GetCollectionAsync(page, rows);
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.StackTrace);
            response.Success = false;
            response.Errors.Add(ex.Message);
        }
        return response;
    }

    public async Task<BaseResponseGeneric<CondicionPago>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<CondicionPago>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new CondicionPago();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCondicionPago request, string userId)
    {
        var response = new BaseCollectionResponse<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new CondicionPago
            {
                CodCondicionPago = request.CodCondiconPago,
                Descripcion = request.Descripcion,
                DiasNeto = request.DiasNeto,
                PagosParciales = request.PagosParciales,
                DescuentoContado = request.DescuentoContado,
                TipoCondPago = request.TipoCondPago,
                PlazoCondPago = request.PlazoCondPago,
                Activa = true,
                Createdby = userId,
                CreateDate = DateTime.Now,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCondicionPago request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new CondicionPago
            {
                Id = id,
                CodCondicionPago = request.CodCondiconPago,
                Descripcion = request.Descripcion,
                DiasNeto = request.DiasNeto,
                PagosParciales = request.PagosParciales,
                DescuentoContado = request.DescuentoContado,
                TipoCondPago = request.TipoCondPago,
                PlazoCondPago = request.PlazoCondPago,
                Activa = request.Activa,
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