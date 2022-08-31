using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


// Esta tabla guarda relación Encabezado-Detalle con la tabla VersionNivelPrecio.  Esta tabla es el detalle.

public class ArticuloPrecioService : IArticuloPrecioService
{
    private readonly IArticuloPrecioRepository _repository;
    private readonly ILogger<ArticuloPrecioService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public ArticuloPrecioService(IArticuloPrecioRepository repository, ILogger<ArticuloPrecioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoArticuloPrecio request, string userId, int versionNivelId, int articuloId, int versionArticulo)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_ART_ADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para agregar artículos a versiones de nivel de precio.");
                response.Success = false;
                return response;
            }

            var buscarArticuloPrecio = await _repository.BuscarArticuloPrecioAsync(versionNivelId, articuloId, versionArticulo);
            if (buscarArticuloPrecio != null)
            {
                throw new Exception($"El articulo {buscarArticuloPrecio.ArticuloId} ya está incluido en esta versión de este nivel de precio.");
            }
            response.Result = await _repository.CreateAsync(new ArticuloPrecio
            {
                VersionNivelId = request.VersionNivelId,
                ArticuloId = request.ArticuloId,
                VersionArticulo = request.VersionArticulo,
                Precio = request.Precio,
                EsquemaTrabajo = request.EsquemaTrabajo,
                MargenMULR = request.MargenMULR,
                MargenUtilidad = request.MargenUtilidad,
                FechaInicio = request.FechaInicio,
                FechaFin = request.FechaFin,
                FechaUltModif = DateTime.Now,
                UsuarioUltModif = userId,
                MargenUtilidadMin = request.MargenUtilidadMin,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPREDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar artículos asociados a versiones de niveles de precio.");
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

    public async Task<BaseResponseGeneric<ICollection<ArticuloPrecio>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<ArticuloPrecio>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_ARTPRE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar artículos asociados a versiones de nivele de precio.");
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

    public async Task<BaseResponseGeneric<ArticuloPrecio>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<ArticuloPrecio>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new ArticuloPrecio();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoArticuloPrecio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_ART_MOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar articulos asociados a versiones de niveles de precio.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new ArticuloPrecio
            {
                Id = id,
                VersionNivelId = request.VersionNivelId,
                ArticuloId = request.ArticuloId,
                VersionArticulo = request.VersionArticulo,
                Precio = request.Precio,
                EsquemaTrabajo = request.EsquemaTrabajo,
                MargenMULR = request.MargenMULR,
                MargenUtilidad = request.MargenUtilidad,
                FechaInicio = request.FechaInicio,
                FechaFin = request.FechaFin,
                FechaUltModif = DateTime.Now,
                UsuarioUltModif = userId,
                MargenUtilidadMin = request.MargenUtilidadMin,
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