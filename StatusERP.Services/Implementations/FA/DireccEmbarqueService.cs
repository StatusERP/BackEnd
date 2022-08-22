using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class DireccEmbarqueService : IDireccEmbarqueService
{
    private readonly IDireccEmbarqueRepository _repository;
    private readonly ILogger<DireccEmbarqueService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public DireccEmbarqueService(IDireccEmbarqueRepository repository, ILogger<DireccEmbarqueService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDireccEmbarque request, string userId, int clienteId, string direccion)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_CLIENTEDIREMBAR", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear direcciones de embarque.");
                response.Success = false;
                return response;
            }

            var buscarDireccEmbarque = await _repository.BuscarDireccEmbarqueAsync(clienteId, direccion);
            if (buscarDireccEmbarque != null)
            {
                throw new Exception($"La dirección de embarque {buscarDireccEmbarque.Direccion} ya existe para el cliente {buscarDireccEmbarque.ClienteId}.");
            }
            response.Result = await _repository.CreateAsync(new DireccEmbarque
            {
                ClienteId = request.ClienteId,
                Direccion = request.Direccion,
                DetalleDireccionId = request.DetalleDireccionId,
                Descripcion = request.Descripcion,
                Contacto = request.Contacto,
                Cargo = request.Cargo,
                Telefono1 = request.Telefono1,
                Telefono2 = request.Telefono2,
                Fax = request.Fax,
                Email = request.Email,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_CLIENTEDIREMBAR", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar direcciones de embarque.");
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

    public async Task<BaseResponseGeneric<ICollection<DireccEmbarque>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<DireccEmbarque>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_CLIENTEDIREMBAR", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar direcciones de embarque.");
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

    public async Task<BaseResponseGeneric<DireccEmbarque>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<DireccEmbarque>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new DireccEmbarque();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDireccEmbarque request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_CLIENTEDIREMBAR", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar direcciones de embarque.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new DireccEmbarque
            {
                Id = id,
                ClienteId = request.ClienteId,
                Direccion = request.Direccion,
                DetalleDireccionId = request.DetalleDireccionId,
                Descripcion = request.Descripcion,
                Contacto = request.Contacto,
                Cargo = request.Cargo,
                Telefono1 = request.Telefono1,
                Telefono2 = request.Telefono2,
                Fax = request.Fax,
                Email = request.Email,
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