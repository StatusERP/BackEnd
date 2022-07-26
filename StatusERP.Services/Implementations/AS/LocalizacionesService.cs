using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class LocalizacionesService:ILocalizacionesService
{
    private readonly ILocalizacionesRepository _repository;
    private readonly ILogger<LocalizacionesService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public LocalizacionesService(ILocalizacionesRepository repository,ILogger<LocalizacionesService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }
    public async Task<BaseResponseGeneric<ICollection<Localizacion>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<Localizacion>>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_LOCAL", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para ver Localizaciones");
                response.Success = false;
                return response;
            }

            response.Result = await _repository.GetCollectionAsync();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoLocalizaciones request, string userId, string codLocalizacion, int BodegaId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_LOCALADD", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para crear localizaciones");
                response.Success = false;
                return response;
            }

            var buscarCodLocalizacion = await _repository.BuscarBodegaLocalizacionAsync(BodegaId, codLocalizacion);
            if (buscarCodLocalizacion != null)
            {
                throw new Exception($"El codigo de cocalización {buscarCodLocalizacion.CodLocalizacion} ya existe para la bodega {buscarCodLocalizacion.BodegaId}.");
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_LOCALMOD", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para modificar Localizaciones");
                response.Success = false;
                return response;
            }
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_LOCALDEL", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para Modificar Localizaciones");
                response.Success = false;
                return response;
            }
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

    public async Task<BaseResponseGeneric<ICollection<Localizacion>>> GetByIdBodegaAsync(int id,string userId)
    {
        var response = new BaseResponseGeneric<ICollection< Localizacion>>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_LOCAL", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para ver Localizaciones");
                response.Success = false;
                return response;
            }
            response.Result = await _repository.GetByIdBodegaAsync(id);
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