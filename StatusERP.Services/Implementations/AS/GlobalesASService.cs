using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class GlobalesASService:IGlobalesASService
{
    private readonly IGlobalesAsRepository _repository;
    private readonly ILogger<GlobalesASService> _logger;

    public GlobalesASService(IGlobalesAsRepository repository,ILogger<GlobalesASService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
     public async Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<GlobalesAS>>();
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

    public async Task<BaseResponseGeneric<GlobalesAS>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<GlobalesAS>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new GlobalesAS();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesAS request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new GlobalesAS
            {
                FechaAdvIni = request.FechaAdvIni,
                FechaAdvFin = request.FechaAdvFin,
                FechaTrabajoIni = request.FechaTraIni,
                FechaTrabajoFin = request.FechaTraFin,
                NombreMoneda = request.NombreMoneda,
                SimboloMoneda = request.SimboloMoneda,
                Impuesto1Desc = request.Imp1,
                Impuesto2Desc = request.Imp2,
                PaisId = request.PaisLocal,
                MonedaDolar = request.MonedaDolar,
                MonedaLocal = request.MonedaLocal,
                TipoCambioId = request.TipoCambioDolar,
                PatronCeCo = request.PatronCeCo,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesAS request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new GlobalesAS
            {
                Id = id,
                FechaAdvIni = request.FechaAdvIni,
                FechaAdvFin = request.FechaAdvFin,
                FechaTrabajoIni = request.FechaTraIni,
                FechaTrabajoFin = request.FechaTraFin,
                NombreMoneda = request.NombreMoneda,
                SimboloMoneda = request.SimboloMoneda,
                Impuesto1Desc = request.Imp1,
                Impuesto2Desc = request.Imp2,
                PaisId = request.PaisLocal,
                MonedaDolar = request.MonedaDolar,
                MonedaLocal = request.MonedaLocal,
                TipoCambioId = request.TipoCambioDolar,
                PatronCeCo = request.PatronCeCo,
                IsDeleted = false,
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
}