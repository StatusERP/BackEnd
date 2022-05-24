using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;


public class CategoriaProveedorService : ICategoriaProveedorService
{
    private readonly ICategoriaProveedorRepository _repository;
    private readonly ILogger<CategoriaProveedorService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public CategoriaProveedorService(ICategoriaProveedorRepository repository, ILogger<CategoriaProveedorService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaProveedor request, string userId, string codCategoriaProveedor)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_PROADD", 9, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Categorías de Proveedores.");
                response.Success = false;
                return response;
            }

            var buscarCodCategoriaProveedor = await _repository.BuscarCodCategoriaProveedorAsync(codCategoriaProveedor);
            if (buscarCodCategoriaProveedor != null)
            {
                throw new Exception($"El código de Categoría de Proveedor {buscarCodCategoriaProveedor.CodCategoriaProveedor} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new CategoriaProveedor
            {
                CodCategoriaProveedor = request.CodCategoriaProveedor,
                Descripcion = request.Descripcion,
                CtrCtaCPId = request.CtrCtaCPId,
                CtrCtaLPId = request.CtrCtaLPId,
                CtrCtaCreditoCPId = request.CtrCtaCreditoCPId,
                CtrCtaDebitoCPId = request.CtrCtaDebitoCPId,
                CtrCtaProntoPagoCPId = request.CtrCtaProntoPagoCPId, 
                CtrCtaImpuesto1CPId = request.CtrCtaImpuesto1CPId, 
                CtrCtaImpuesto2CPId = request.CtrCtaImpuesto2CPId, 
                CtrCtaRubro1CPId = request.CtrCtaRubro1CPId, 
                CtrCtaRubro2CPId = request.CtrCtaRubro2CPId, 
                CtrCtaAnticipoCPId = request.CtrCtaAnticipoCPId,
                CtrCtaAjusteRedondeoId = request.CtrCtaAjusteRedondeoId,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_PRODEL", 9, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Categorías de Proveedores.");
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

    public async Task<BaseResponseGeneric<ICollection<CategoriaProveedor>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<CategoriaProveedor>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_PROV", 9, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Categorías de Proveedores.");
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

    public async Task<BaseResponseGeneric<CategoriaProveedor>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<CategoriaProveedor>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new CategoriaProveedor();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaProveedor request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_PROMOD", 9, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Categorías de Proveedores.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new CategoriaProveedor
            {
                Id = id,
                CodCategoriaProveedor = request.CodCategoriaProveedor,
                Descripcion = request.Descripcion,
                CtrCtaCPId = request.CtrCtaCPId,
                CtrCtaLPId = request.CtrCtaLPId,
                CtrCtaCreditoCPId = request.CtrCtaCreditoCPId,
                CtrCtaDebitoCPId = request.CtrCtaDebitoCPId,
                CtrCtaProntoPagoCPId = request.CtrCtaProntoPagoCPId,
                CtrCtaImpuesto1CPId = request.CtrCtaImpuesto1CPId,
                CtrCtaImpuesto2CPId = request.CtrCtaImpuesto2CPId,
                CtrCtaRubro1CPId = request.CtrCtaRubro1CPId,
                CtrCtaRubro2CPId = request.CtrCtaRubro2CPId,
                CtrCtaAnticipoCPId = request.CtrCtaAnticipoCPId,
                CtrCtaAjusteRedondeoId = request.CtrCtaAjusteRedondeoId,
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
