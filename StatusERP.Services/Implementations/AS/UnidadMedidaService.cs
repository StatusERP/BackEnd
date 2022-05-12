using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class UnidadMedidaService:IUnidadMedidaService
{
    private readonly IUnidadMedidaRepository _repository;
    private readonly ILogger<UnidadMedidaService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public UnidadMedidaService(IUnidadMedidaRepository repository,ILogger<UnidadMedidaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }
    public async Task<BaseResponseGeneric<ICollection<UnidadMedida>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<UnidadMedida>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_UNIMED", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para ver Unidades de Medida");
                response.Success = false;
                return response;
            }

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

    public async Task<BaseResponseGeneric<UnidadMedida>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<UnidadMedida>();
        try
        {

            response.Result = await _repository.GetByIdAsync(id) ?? new UnidadMedida();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoUnidadMedida request, string userId,string codUnidadMedida)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodUnidadMedida = await _repository.BuscarCodUnidadMedidaAsync(codUnidadMedida);
            if (buscarCodUnidadMedida != null)
            {
                throw new Exception($"El codigo de Unidad de Medida {buscarCodUnidadMedida.CodUnidadMedida} ya Existe");
            }

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_UNIMEDADD", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para Crear Unidades de Medida");
                response.Success = false;
                return response;
            }

            response.Result = await _repository.CreateAsync(new UnidadMedida
            {
                CodUnidadMedida = request.CodUnidadMedida.ToUpper(),
                Descripcion =  request.Descripcion,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUnidadMedida request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_UNIMEDMOD", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para Modificar Unidades de Medida");
                response.Success = false;
                return response;
            }

            response.Result = await _repository.UpdateAsync(new UnidadMedida
            {
                Id = id,
                CodUnidadMedida = request.CodUnidadMedida,
                Descripcion = request.Descripcion,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_UNIMEDDEL", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para Eliminar Unidades de Medida");
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
}