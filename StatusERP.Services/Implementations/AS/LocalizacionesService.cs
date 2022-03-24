using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class LocalizacionesService:ILocalizacionesService
{
    private readonly ILocalizacionesRepository _repository;
    private readonly ILogger<LocalizacionesService> _logger;


    public LocalizacionesService(ILocalizacionesRepository repository,ILogger<LocalizacionesService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Localizacion>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Localizacion>>();
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

    public async Task<BaseResponseGeneric<Localizacion>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Localizacion>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Localizacion();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoLocalizaciones request, string userId, string codLocalizacion)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodLocalizacion = await _repository.BuscarCodLocalizacionAsync(codLocalizacion);
            if (buscarCodLocalizacion != null)
            {
                throw new Exception($"El codigo de Localizacion {buscarCodLocalizacion.CodLocalizacion} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new Localizacion
            {
                CodLocalizacion = request.CodLocalizacion,
                Descripcion = request.Descripcion,
                Volumen = request.Volumen,
                PesoMaximo = request.Pesomaximo,
                BodegaId = request.bodegaId,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoLocalizaciones request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Localizacion
            {
                Id = id,
                CodLocalizacion = request.CodLocalizacion,
                Descripcion = request.Descripcion,
                Volumen = request.Volumen,
                PesoMaximo = request.Pesomaximo,
                BodegaId = request.bodegaId,
                Activa = request.activa,
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