using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class VendedorService : IVendedorService
{
    private readonly IVendedorRepository _repository;
    private readonly ILogger<VendedorService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public VendedorService(IVendedorRepository repository, ILogger<VendedorService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoVendedor request, string userId, string codVendedor)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_VENDEDORADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear vendedores.");
                response.Success = false;
                return response;
            }

            var buscarCodVendedor = await _repository.BuscarCodVendedorAsync(codVendedor);
            if (buscarCodVendedor != null)
            {
                throw new Exception($"El código de vendedor {buscarCodVendedor.CodVendedor} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new Vendedor
            {
                CodVendedor = request.CodVendedor,
                Nombre = request.Nombre,
                Email = request.Email,
                Telefono = request.Telefono,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_VENDEDORDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar vendedores");
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

    public async Task<BaseResponseGeneric<ICollection<Vendedor>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<Vendedor>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_VENDEDORES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar vendedores.");
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

    public async Task<BaseResponseGeneric<Vendedor>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Vendedor>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Vendedor();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVendedor request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_VENDEDORMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar vendedores.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new Vendedor
            {
                Id = id,
                CodVendedor = request.CodVendedor,
                Nombre = request.Nombre,
                Email = request.Email,
                Telefono = request.Telefono,
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

