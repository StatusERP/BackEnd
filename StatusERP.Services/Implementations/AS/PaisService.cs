using AutoMapper;
using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS
{
    public class PaisService : IPaisService
    {
        private readonly IPaisRepository _repository;
        private readonly ILogger<PaisService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
        private readonly IMapper _mapper;

        public PaisService(IPaisRepository repository, ILogger<PaisService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPais request, string userId, string codPais)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISADD", Constants.EmpresaId, userId);




                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene Privilegios para crear países.");
                    response.Success = false;
                    return response;
                }


                var buscarCodBodega = await _repository.BuscarCodPaisAsync(codPais);
                if (buscarCodBodega != null)
                {
                    response.Errors.Add($"El código de país {buscarCodBodega.CodPais} ya existe.");
                    response.Success = false;
                    return response;


                }

                response.Result = await _repository.CreateAsync(new Pais
                {
                    CodPais = request.CodPais,
                    Nombre = request.Nombre,
                    CodigoISO = request.CodigoISO,
                    CtrCtaVentasId = request.CtrCtaVentasId,
                    CtrCtaDescGralId = request.CtrCtaDescGralId,
                    CtrCtaCostoVenId = request.CtrCtaCostoVenId,
                    CtrCtaDescLinId = request.CtrCtaDescLinId,
                    CtrCtaCostoLinId = request.CtrCtaCostoLinId,
                    CtrCtaGasComId = request.CtrCtaGasComId,
                    CtrCtaContadoId  = request.CtrCtaContadoId,
                    CtrCtaCCId = request.CtrCtaCCId,
                    CtrCtaLCId = request.CtrCtaLCId,
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
                    CtrCtaLPId = request.CtrCtaLPId,
                    CtrCtaCreditoCPId = request.CtrCtaCreditoCPId, 
                    CtrCtaDebitoCPId = request.CtrCtaDebitoCPId, 
                    CtrCtaCPId = request.CtrCtaCPId,
                    CtrCtaProntoPagoCPId = request.CtrCtaProntoPagoCPId,
                    CtrCtaComisionCPId = request.CtrCtaComisionCPId,
                    CtrCtaImpuesto1CPId = request.CtrCtaImpuesto1CPId,
                    CtrCtaImpuesto2CPId = request.CtrCtaImpuesto2CPId,
                    CtrCtaRubro1CPId = request.CtrCtaRubro1CPId, 
                    CtrCtaRubro2CPId = request.CtrCtaRubro2CPId,
                    CtrCtaAnticipoCPId = request.CtrCtaAnticipoCPId, 
                    CtrCtaDescBonifId = request.CtrCtaDescBonifId,
                    CtrCtaDevVentasId = request.CtrCtaDevVentasId,
                    CtrCtaIntCorrienteId = request.CtrCtaIntCorrienteId,
                    CtrCtaVentasExenId = request.CtrCtaVentasExenId,
                    CtrCtaAjusteRedondeoId = request.CtrCtaAjusteRedondeoId,
                    CtrCtaRentaCPId = request.CtrCtaRentaCPId,
                    CtrCtaPensionONPCPId = request.CtrCtaPensionONPCPId,
                    CtrCtaPensionAFPCPId = request.CtrCtaPensionAFPCPId,
                    CtrCtaAdValoremId = request.CtrCtaAdValoremId,
                    CtrCtaComisionId = request.CtrCtaComisionId,
                    EtiquetaDivGeo1 = request.EtiquetaDivGeo1,
                    EtiquetaDivGeo2 = request.EtiquetaDivGeo2,
                    DireccionId = request.DireccionId,
                    MonedaId = request.MonedaId,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISDEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar países.");
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

        public async Task<BaseResponseGeneric<ICollection<Pais>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Pais>>();
            try
            {

                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISES", Constants.EmpresaId, userId);


                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar países.");
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

        public async Task<BaseResponseGeneric<Pais>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Pais>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Pais();
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

        
        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPais request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar países.");
                    response.Success = false;
                    return response;
                }

                response.Result = await _repository.UpdateAsync(new Pais
                {
                    Id = id,
                    CodPais = request.CodPais,
                    Nombre = request.Nombre,
                    CodigoISO = request.CodigoISO,
                    CtrCtaVentasId = request.CtrCtaVentasId,
                    CtrCtaDescGralId = request.CtrCtaDescGralId,
                    CtrCtaCostoVenId = request.CtrCtaCostoVenId,
                    CtrCtaDescLinId = request.CtrCtaDescLinId,
                    CtrCtaCostoLinId = request.CtrCtaCostoLinId,
                    CtrCtaGasComId = request.CtrCtaGasComId,
                    CtrCtaContadoId = request.CtrCtaContadoId,
                    CtrCtaCCId = request.CtrCtaCCId,
                    CtrCtaLCId = request.CtrCtaLCId,
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
                    CtrCtaLPId = request.CtrCtaLPId,
                    CtrCtaCreditoCPId = request.CtrCtaCreditoCPId,
                    CtrCtaDebitoCPId = request.CtrCtaDebitoCPId,
                    CtrCtaCPId = request.CtrCtaCPId,
                    CtrCtaProntoPagoCPId = request.CtrCtaProntoPagoCPId,
                    CtrCtaComisionCPId = request.CtrCtaComisionCPId,
                    CtrCtaImpuesto1CPId = request.CtrCtaImpuesto1CPId,
                    CtrCtaImpuesto2CPId = request.CtrCtaImpuesto2CPId,
                    CtrCtaRubro1CPId = request.CtrCtaRubro1CPId,
                    CtrCtaRubro2CPId = request.CtrCtaRubro2CPId,
                    CtrCtaAnticipoCPId = request.CtrCtaAnticipoCPId,
                    CtrCtaDescBonifId = request.CtrCtaDescBonifId,
                    CtrCtaDevVentasId = request.CtrCtaDevVentasId,
                    CtrCtaIntCorrienteId = request.CtrCtaIntCorrienteId,
                    CtrCtaVentasExenId = request.CtrCtaVentasExenId,
                    CtrCtaAjusteRedondeoId = request.CtrCtaAjusteRedondeoId,
                    CtrCtaRentaCPId = request.CtrCtaRentaCPId,
                    CtrCtaPensionONPCPId = request.CtrCtaPensionONPCPId, 
                    CtrCtaPensionAFPCPId = request.CtrCtaPensionAFPCPId,
                    CtrCtaAdValoremId = request.CtrCtaAdValoremId,
                    CtrCtaComisionId = request.CtrCtaComisionId,
                    EtiquetaDivGeo1 = request.EtiquetaDivGeo1,
                    EtiquetaDivGeo2 = request.EtiquetaDivGeo2,
                    DireccionId = request.DireccionId,
                    MonedaId = request.MonedaId,
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
    }
}
