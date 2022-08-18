using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class TipoImpuestoService : ITipoImpuestoService
{
    private readonly ITipoImpuestoRepository _repository;
    private readonly ILogger<TipoImpuestoService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public TipoImpuestoService(ITipoImpuestoRepository repository, ILogger<TipoImpuestoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoImpuesto request, string userId, string codTipoImpuesto)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ADM_TIPIMP_ADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear tipos de impuesto.");
                response.Success = false;
                return response;
            }

            var buscarCodTipoImpuesto = await _repository.BuscarCodTipoImpuestoAsync(codTipoImpuesto);
            if (buscarCodTipoImpuesto != null)
            {
                throw new Exception($"El codigo de tipo de impuesto {buscarCodTipoImpuesto.CodTipoImpuesto} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new TipoImpuesto
            {
                CodTipoImpuesto = request.CodTipoImpuesto,
                Descripcion = request.Descripcion,
                Activo = request.Activo,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ADM_TIPIMP_DEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar tipos de impuesto.");
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

    public async Task<BaseResponseGeneric<ICollection<TipoImpuesto>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<TipoImpuesto>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ADM_TIPIMP", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar tipos de impuesto.");
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

    public async Task<BaseResponseGeneric<TipoImpuesto>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<TipoImpuesto>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new TipoImpuesto();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoImpuesto request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_ADM_TIPIMP_MOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar tipos de impuesto.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new TipoImpuesto
            {
                Id = id,
                CodTipoImpuesto = request.CodTipoImpuesto,
                Descripcion = request.Descripcion,
                Activo = request.Activo,
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
