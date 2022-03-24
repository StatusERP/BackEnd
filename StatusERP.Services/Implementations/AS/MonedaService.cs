using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class MonedaService:IMonedaService
{
    private readonly IMonedaRepository _repository;
    private readonly ILogger<MonedaService> _logger;

    public MonedaService(IMonedaRepository repository,ILogger<MonedaService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Moneda>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Moneda>>();
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

    public async Task<BaseResponseGeneric<Moneda>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Moneda>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Moneda();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMoneda request, string userId , string codMoneda)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodMoneda = await _repository.BuscarCodMonedaAsync(codMoneda);
            if (buscarCodMoneda != null)
            {
                throw new Exception($"El codigo de Moneda {buscarCodMoneda.CodMoneda} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new Moneda
            {
                CodMoneda = request.CodMoneda,
                Nombre = request.Nombre,
                CodigoISO = request.CodigoIso,
                IsDeleted = false,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMoneda request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Moneda
            {
                Id = id,
                CodMoneda = request.CodMoneda,
                Nombre = request.Nombre,
                CodigoISO = request.CodigoIso,
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