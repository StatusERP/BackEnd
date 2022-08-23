using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class CategoriaClienteService : ICategoriaClienteService
{
    private readonly ICategoriaClienteRepository _repository;
    private readonly ILogger<CategoriaClienteService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public CategoriaClienteService(ICategoriaClienteRepository repository, ILogger<CategoriaClienteService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaCliente request, string userId, string codCategoriaCliente)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_CLIADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Categorías de Clientes.");
                response.Success = false;
                return response;
            }

            var buscarCodCategoriaCliente = await _repository.BuscarCodCategoriaClienteAsync(codCategoriaCliente);
            if (buscarCodCategoriaCliente != null)
            {
                throw new Exception($"El codigo de Categoría de Cliente {buscarCodCategoriaCliente.CodCategoriaCliente} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new CategoriaCliente
            {
                CodCategoriaCliente = request.CodCategoriaCliente,
                Descripcion = request.Descripcion,
                CtrCtaVentasId = request.CtrCtaVentasId,
                CtrCtaDescGralId = request.CtrCtaDescGralId,
                CtrCtaCostVentId = request.CtrCtaCostVentId,
                CtrCtaDescLinId = request.CtrCtaDescLinId,
                CtrCtaCostLinId = request.CtrCtaCostLinId,
                CtrCtaVendComId = request.CtrCtaVendComId,
                CtrCtaCobrComId = request.CtrCtaCobrComId,
                CtrCtaCCId = request.CtrCtaCCId,
                CtrCtaLCId = request.CtrCtaLCId,
                CtrCtaContadoId = request.CtrCtaContadoId,
                CtrCtaProntoPagoCCId = request.CtrCtaProntoPagoCCId,
                CtrCtaIntMoraCCId = request.CtrCtaIntMoraCCId,
                CtrCtaRecibosCCId = request.CtrCtaRecibosCCId,
                CtrCtaDebitoCCId = request.CtrCtaDebitoCCId,
                CtrCtaCreditoCCId = request.CtrCtaCreditoCCId,
                CtrCtaImpuesto1CCId = request.CtrCtaImpuesto1CCId,
                CtrCtaImpuesto2CCId = request.CtrCtaImpuesto2CCId,
                CtrCtaRubro1CCId = request.CtrCtaRubro1CCId,
                CtrCtaRubro2CCId = request.CtrCtaRubro2CCId,
                CtrCtaAnticipoCCId = request.CtrCtaAnticipoCCId,
                CtrCtaDescBonifId = request.CtrCtaDescBonifId,
                CtrCtaDevVentasId = request.CtrCtaDevVentasId,
                CtrCtaIntCorrId = request.CtrCtaIntCorrId,
                CtrCtaVentasExenId = request.CtrCtaVentasExenId,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_CLIDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Categorías de Clientes.");
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

    public async Task<BaseResponseGeneric<ICollection<CategoriaCliente>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<CategoriaCliente>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_CLI", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Categorías de Clientes.");
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

    public async Task<BaseResponseGeneric<CategoriaCliente>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<CategoriaCliente>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new CategoriaCliente();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaCliente request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CATEGOR_CLIMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Categorías de Clientes.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new CategoriaCliente
            {
                Id = id,
                CodCategoriaCliente = request.CodCategoriaCliente,
                Descripcion = request.Descripcion,
                CtrCtaVentasId = request.CtrCtaVentasId,
                CtrCtaDescGralId = request.CtrCtaDescGralId,
                CtrCtaCostVentId = request.CtrCtaCostVentId,
                CtrCtaDescLinId = request.CtrCtaDescLinId,
                CtrCtaCostLinId = request.CtrCtaCostLinId,
                CtrCtaVendComId = request.CtrCtaVendComId,
                CtrCtaCobrComId = request.CtrCtaCobrComId,
                CtrCtaCCId = request.CtrCtaCCId,
                CtrCtaLCId = request.CtrCtaLCId,
                CtrCtaContadoId = request.CtrCtaContadoId,
                CtrCtaProntoPagoCCId = request.CtrCtaProntoPagoCCId,
                CtrCtaIntMoraCCId = request.CtrCtaIntMoraCCId,
                CtrCtaRecibosCCId = request.CtrCtaRecibosCCId,
                CtrCtaDebitoCCId = request.CtrCtaDebitoCCId,
                CtrCtaCreditoCCId = request.CtrCtaCreditoCCId,
                CtrCtaImpuesto1CCId = request.CtrCtaImpuesto1CCId,
                CtrCtaImpuesto2CCId = request.CtrCtaImpuesto2CCId,
                CtrCtaRubro1CCId = request.CtrCtaRubro1CCId,
                CtrCtaRubro2CCId = request.CtrCtaRubro2CCId,
                CtrCtaAnticipoCCId = request.CtrCtaAnticipoCCId,
                CtrCtaDescBonifId = request.CtrCtaDescBonifId,
                CtrCtaDevVentasId = request.CtrCtaDevVentasId,
                CtrCtaIntCorrId = request.CtrCtaIntCorrId,
                CtrCtaVentasExenId = request.CtrCtaVentasExenId,
                CtrCtaAjusteRedondeoId = request.CtrCtaAjusteRedondeoId,
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
