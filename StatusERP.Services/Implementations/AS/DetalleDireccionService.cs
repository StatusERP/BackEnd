using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class DetalleDireccionService : IDetalleDireccionService
{
    private readonly IDetalleDireccionRepository _repository;
    private readonly ILogger<DetalleDireccionService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public DetalleDireccionService(IDetalleDireccionRepository repository, ILogger<DetalleDireccionService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDetalleDireccion request, string userId, int codDetalleDireccion)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear detalle de direcciones.");
                response.Success = false;
                return response;
            }

            var buscarCodDetalleDireccion = await _repository.BuscarCodDetalleDireccionAsync(codDetalleDireccion);
            if (buscarCodDetalleDireccion != null)
            {
                throw new Exception($"El código de detalle dirección {buscarCodDetalleDireccion.CodDetalleDireccion} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new DetalleDireccion
            {
                CodDetalleDireccion = request.CodDetalleDireccion,
                DireccionId = request.DireccionId,
                Campo01 = request.Campo01,
                Campo02 = request.Campo02,
                Campo03 = request.Campo03,
                Campo04 = request.Campo04,
                Campo05 = request.Campo05,
                Campo06 = request.Campo06,
                Campo07 = request.Campo07,
                Campo08 = request.Campo08,
                Campo09 = request.Campo09,
                Campo10 = request.Campo10,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar detalle de direcciones.");
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

    public async Task<BaseResponseGeneric<ICollection<DetalleDireccion>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<DetalleDireccion>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar detalle de direcciones.");
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

    public async Task<BaseResponseGeneric<DetalleDireccion>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<DetalleDireccion>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new DetalleDireccion();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDetalleDireccion request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar detalle de direcciones.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new DetalleDireccion
            {
                Id = id,
                DireccionId = request.DireccionId,
                Campo01 = request.Campo01,
                Campo02 = request.Campo02,
                Campo03 = request.Campo03,
                Campo04 = request.Campo04,
                Campo05 = request.Campo05,
                Campo06 = request.Campo06,
                Campo07 = request.Campo07,
                Campo08 = request.Campo08,
                Campo09 = request.Campo09,
                Campo10 = request.Campo10,
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