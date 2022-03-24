using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class RutaService:IRutaService
{
    private readonly IRutaRepository _repository;
    private readonly ILogger<RutaService> _logger;

    public RutaService( IRutaRepository repository,ILogger<RutaService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public  async Task<BaseResponseGeneric<ICollection<Ruta>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Ruta>>();
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

    public async Task<BaseResponseGeneric<Ruta>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Ruta>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Ruta();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoRuta request, string userId,string codRuta)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodRuta = await _repository.BuscarCodRutaAsync(codRuta);
            if (buscarCodRuta != null)
            {
                throw new Exception($"El codigo de Sucursal {buscarCodRuta.CodRuta} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new Ruta
            {
                CodRuta = request.CodRuta,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoRuta request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Ruta
            {
                Id = id,
                CodRuta = request.CodRuta,
                Descripcion = request.Descripcion,
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