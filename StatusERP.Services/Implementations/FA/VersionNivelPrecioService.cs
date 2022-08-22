using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class VersionNivelPrecioService : IVersionNivelPrecioService
{
    private readonly IVersionNivelPrecioRepository _repository;
    private readonly ILogger<VersionNivelPrecioService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public VersionNivelPrecioService(IVersionNivelPrecioRepository repository, ILogger<VersionNivelPrecioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoVersionNivelPrecio request, string userId, int NivelPrecioId, int version)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPRE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear versiones de niveles de precio.");
                response.Success = false;
                return response;
            }

            var buscarVNP = await _repository.BuscarVersionNivelPrecioIdAsync(NivelPrecioId, version);
            if (buscarVNP != null)
            {
                throw new Exception($"La versión {buscarVNP.Version} ya existe para el nivel de Precios {buscarVNP.NivelPrecioId}.");
            }
            response.Result = await _repository.CreateAsync(new VersionNivelPrecio
            {
                NivelPrecioId  = request.NivelPrecioId,
                Version = request.Version,
                FechaInicio = request.FechaInicio,
                FechaCorte = request.FechaCorte,
                Estado = request.Estado,
                UsuarioCreacion = userId,
                FechaHoraCreacion = DateTime.Now,
                UsuarioUltModif = userId,
                FechaHoraUltModif = DateTime.Now,
                UsuarioAprobacion = request.UsuarioAprobacion,
                FechaHoraAprobacion = request.FechaHoraAprobacion,
                UsuarioAnulacion = request.UsuarioAnulacion,
                FechaHoraAnulacion = request.FechaHoraAnulacion,
                Identificador = request.Identificador,
                Impuesto1Incluido = request.Impuesto1Incluido,
                PrecioReferenciaDE = request.PrecioReferenciaDE,
                SincMovil = request.SincMovil,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPRE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar versiones de niveles de precio.");
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

    public async Task<BaseResponseGeneric<ICollection<VersionNivelPrecio>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<VersionNivelPrecio>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPRE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar versiones de niveles de precio.");
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

    public async Task<BaseResponseGeneric<VersionNivelPrecio>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<VersionNivelPrecio>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new VersionNivelPrecio();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVersionNivelPrecio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPRE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar versiones de niveles de precio.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new VersionNivelPrecio
            {
                Id = id,
                NivelPrecioId = request.NivelPrecioId,
                Version = request.Version,
                FechaInicio = request.FechaInicio,
                FechaCorte = request.FechaCorte,
                Estado = request.Estado,
                UsuarioCreacion = userId,
                FechaHoraCreacion = DateTime.Now,
                UsuarioUltModif = userId,
                FechaHoraUltModif = DateTime.Now,
                UsuarioAprobacion = request.UsuarioAprobacion,
                FechaHoraAprobacion = request.FechaHoraAprobacion,
                UsuarioAnulacion = request.UsuarioAnulacion,
                FechaHoraAnulacion = request.FechaHoraAnulacion,
                Identificador = request.Identificador,
                Impuesto1Incluido = request.Impuesto1Incluido,
                PrecioReferenciaDE = request.PrecioReferenciaDE,
                SincMovil = request.SincMovil,
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
}
