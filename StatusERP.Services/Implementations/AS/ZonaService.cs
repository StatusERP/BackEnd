using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class ZonaService : IZonaService
{
    private readonly IZonaRepository _repository;
    private readonly ILogger<ZonaService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public ZonaService(IZonaRepository repository, ILogger<ZonaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoZona request, string userId, string codZona)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ZONAADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Zonas.");
                response.Success = false;
                return response;
            }

            var buscarCodZona = await _repository.BuscarCodZonaAsync(codZona);
            if (buscarCodZona != null)
            {
                throw new Exception($"El código de Zona {buscarCodZona.CodZona} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new Zona
            {
                CodZona = request.CodZona,
                Descripcion = request.Descripcion,
                Activa = request.Activa,
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {

        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ZONADEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Zonas");
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

    public async Task<BaseResponseGeneric<ICollection<Zona>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<Zona>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ZONAS", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Zonas.");
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

    public async Task<BaseResponseGeneric<Zona>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Zona>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Zona();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoZona request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ZONAMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Zonas.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new Zona
            {
                Id = id,
                CodZona = request.CodZona,
                Descripcion = request.Descripcion,
                Activa = request.Activa,
                IsDeleted = false,
                Updatedby = userId,
                UpdateDate = DateTime.Now,
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

