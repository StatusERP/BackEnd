using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class NivelPrecioService:INivelPrecioService
{
    private readonly INivelPrecioRepository _repository;
    private readonly ILogger<NivelPrecioService> _logger;

    public NivelPrecioService(INivelPrecioRepository repository,ILogger<NivelPrecioService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async  Task<BaseResponseGeneric<ICollection<NivelPrecio>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<NivelPrecio>>();
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

    public async Task<BaseResponseGeneric<NivelPrecio>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<NivelPrecio>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new NivelPrecio();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoNivelprecio request, string userId, string codNivelPrecio)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodNivelPrecio = await _repository.BuscarCodNivelPrecioAsync(codNivelPrecio);
            if (buscarCodNivelPrecio != null)
            {
                throw new Exception($"El codigo de Nivel de Precio {buscarCodNivelPrecio.CodNivelPrecio} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new NivelPrecio
            {
                CodNivelPrecio = request.CodNivelPrecio,
                EsquemaTrabajo = request.esquemaTrabajo,
                Descuentos = request.descuento,
                SugerirDescuento = request.sugerirDescuento,
                CondicionPagoId = request.CondicionPagoId,
                MonedaId = request.ModenaId,
                IsDeleted = false,
                Activo = true,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoNivelprecio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new NivelPrecio
            {
                Id = id,
                CodNivelPrecio = request.CodNivelPrecio,
                EsquemaTrabajo = request.esquemaTrabajo,
                Descuentos = request.descuento,
                SugerirDescuento = request.sugerirDescuento,
                CondicionPagoId = request.CondicionPagoId,
                MonedaId = request.ModenaId,
                Activo = request.Activo,
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