using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class MetodoPagoService : IMetodoPagoService
{
    private readonly IMetodoPagoRepository _repository;
    private readonly ILogger<MetodoPagoService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public MetodoPagoService(IMetodoPagoRepository repository, ILogger<MetodoPagoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMetodoPago request, string userId, string codMetodoPago)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_METODO_PAGO_ADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear métodos de pago.");
                response.Success = false;
                return response;
            }

            var buscarCodMetodoPago = await _repository.BuscarCodMetodoPagoAsync(codMetodoPago);
            if (buscarCodMetodoPago != null)
            {
                throw new Exception($"El código de método de pago {buscarCodMetodoPago.CodMetodoPago} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new MetodoPago
            {
                CodMetodoPago = request.CodMetodoPago,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_METODO_PAGO_DEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar métodos de pago.");
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

    public async Task<BaseResponseGeneric<ICollection<MetodoPago>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<MetodoPago>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_OTROS_MET_PAGO", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar métodos de pago.");
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

    public async Task<BaseResponseGeneric<MetodoPago>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<MetodoPago>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new MetodoPago();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMetodoPago request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_METODO_PAGO_MOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar métodos de pago.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new MetodoPago
            {
                Id = id,
                CodMetodoPago = request.CodMetodoPago,
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

