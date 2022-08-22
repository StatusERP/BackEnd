using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class NivelPrecioService : INivelPrecioService
{
    private readonly INivelPrecioRepository _repository;
    private readonly ILogger<NivelPrecioService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public NivelPrecioService(INivelPrecioRepository repository, ILogger<NivelPrecioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoNivelPrecio request, string userId, string codNivelPrecio)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_NPRECADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear niveles de precio.");
                response.Success = false;
                return response;
            }

            var buscarCodNivelPrecio = await _repository.BuscarCodNivelPrecioAsync(codNivelPrecio);
            if (buscarCodNivelPrecio != null)
            {
                throw new Exception($"El código de nivel de precio {buscarCodNivelPrecio.CodNivelPrecio} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new NivelPrecio
            {
                CodNivelPrecio = request.CodNivelPrecio,
                EsquemaTrabajo = request.EsquemaTrabajo,
                Descuentos = request.Descuentos,
                SugerirDescuento = request.SugerirDescuento,
                CondicionPagoId = request.CondicionPagoId,
                Moneda = request.Moneda,
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {

        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_NPRECDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar niveles de precio.");
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

    public async Task<BaseResponseGeneric<ICollection<NivelPrecio>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<NivelPrecio>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_NPREC", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar niveles de precio.");
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoNivelPrecio request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_NPRECMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar niveles de precio.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new NivelPrecio
            {
                Id = id,
                CodNivelPrecio = request.CodNivelPrecio,
                EsquemaTrabajo = request.EsquemaTrabajo,
                Descuentos = request.Descuentos,
                SugerirDescuento = request.SugerirDescuento,
                CondicionPagoId = request.CondicionPagoId,
                Moneda = request.Moneda,
                Activo = request.Activo,
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