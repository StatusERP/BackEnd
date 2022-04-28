using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class CategoriaArticuloService : ICategoriaArticuloService
    {
        private readonly ICategoriaArticuloRepository _repository;
        private readonly ILogger<CategoriaArticuloService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public CategoriaArticuloService(ICategoriaArticuloRepository repository, ILogger<CategoriaArticuloService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaArticulo request, string userId, string codCategoriaArticulo)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CCONTADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear categorías de artículos.");
                    response.Success = false;
                    return response;
                }

                var buscarCodCategoriaArticulo = await _repository.BuscarCodCategoriaArticuloAsync(codCategoriaArticulo);
                if (buscarCodCategoriaArticulo != null)
                {
                    throw new Exception($"El codigo de categoría de artículo {buscarCodCategoriaArticulo.CodCategoriaArticulo} ya existe");
                }
                response.Result = await _repository.CreateAsync(new CategoriaArticulo
                {
                    CodCategoriaArticulo = request.CodCategoriaArticulo,
                    Descripcion = request.Descripcion,
                    CtrCtaInventarioId = request.CtrCtaInventarioId,
                    CtrCtaVentasLocId = request.CtrCtaVentasLocId,
                    CtrCtaVentasExpId = request.CtrCtaVentasExpId,
                    CtrCtaCompraLocId = request.CtrCtaCompraLocId,
                    CtrCtaCompraImpId = request.CtrCtaCompraImpId,
                    CtrCtaDescVentaLocId = request.CtrCtaDescVentaLocId,
                    CtrCtaDescVentaExpId = request.CtrCtaDescVentaExpId,
                    CtrCtaCostVentaLocId = request.CtrCtaCostVentaLocId,
                    CtrCtaCostVentaExpId = request.CtrCtaCostVentaExpId,
                    CtrCtaComsVentaLocId = request.CtrCtaComsVentaLocId,
                    CtrCtaComsVentaExpId = request.CtrCtaComsVentaExpId,
                    CtrCtaComsCobroLocId = request.CtrCtaComsCobroLocId,
                    CtrCtaComsCobroExpId = request.CtrCtaComsCobroExpId,
                    CtrCtaDescLineaLocId = request.CtrCtaDescLineaLocId,
                    CtrCtaDescLineaExpId = request.CtrCtaDescLineaExpId,
                    CtrCtaCostDescLocId = request.CtrCtaCostDescLocId,
                    CtrCtaCostDescExpId = request.CtrCtaCostDescExpId,
                    CtrCtaSobrInventFisId = request.CtrCtaSobrInventFisId,
                    CtrCtaFaltInventFisId = request.CtrCtaFaltInventFisId,
                    CtrCtaVariaCostoId = request.CtrCtaVariaCostoId,
                    CtrCtaVencimientoId = request.CtrCtaVencimientoId,
                    CtrCtaSobranteRemisId = request.CtrCtaSobranteRemisId,
                    CtrCtaFaltanteRemisId = request.CtrCtaFaltanteRemisId,
                    CtrCtaInvRemitidoId = request.CtrCtaInvRemitidoId,
                    CtrCtaMatProcesoId = request.CtrCtaMatProcesoId,
                    CtrCtaConsNormalId = request.CtrCtaConsNormalId,
                    CtrCtaConsRetrabajoId = request.CtrCtaConsRetrabajoId,
                    CtrCtaConsGastoId = request.CtrCtaConsGastoId,
                    CtrCtaConsDesperdicId = request.CtrCtaConsDesperdicId,
                    CtrCtaDescBonifLocId = request.CtrCtaDescBonifLocId,
                    CtrCtaDescBonifExpId = request.CtrCtaDescBonifExpId,
                    CtrCtaDevVentasLocId = request.CtrCtaDevVentasLocId,
                    CtrCtaDevVentasExpId = request.CtrCtaDevVentasExpId,
                    CtrCtaRetAsumId = request.CtrCtaRetAsumId,
                    CtrCtaAjuId = request.CtrCtaAjuId,
                    CtrCtaAjuCMVId = request.CtrCtaAjuCMVId,
                    CtrCtaCPGarId = request.CtrCtaCPGarId,
                    CtrCtaPuGarId = request.CtrCtaPuGarId,
                    CtrCtaIngDevolucId = request.CtrCtaIngDevolucId,
                    CtrCtaPerdDevolucId = request.CtrCtaPerdDevolucId,
                    CtrCtaMatAplicadosId = request.CtrCtaMatAplicadosId,
                    CtrCtaVentasExenLocId = request.CtrCtaVentasExenLocId,
                    CtrCtaVentasExenExpId = request.CtrCtaVentasExenExpId,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CCONTDEL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar categorías de artículos.");
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

        public async Task<BaseResponseGeneric<ICollection<CategoriaArticulo>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<CategoriaArticulo>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CCONT", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar categorías de artículos.");
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

        public async Task<BaseResponseGeneric<CategoriaArticulo>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<CategoriaArticulo>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new CategoriaArticulo();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaArticulo request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CCONTMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar categorías de artículos.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new CategoriaArticulo
                {
                    Id = id,
                    CodCategoriaArticulo = request.CodCategoriaArticulo,
                    Descripcion = request.Descripcion,
                    CtrCtaInventarioId = request.CtrCtaInventarioId,
                    CtrCtaVentasLocId = request.CtrCtaVentasLocId,
                    CtrCtaVentasExpId = request.CtrCtaVentasExpId,
                    CtrCtaCompraLocId = request.CtrCtaCompraLocId,
                    CtrCtaCompraImpId = request.CtrCtaCompraImpId,
                    CtrCtaDescVentaLocId = request.CtrCtaDescVentaLocId,
                    CtrCtaDescVentaExpId = request.CtrCtaDescVentaExpId,
                    CtrCtaCostVentaLocId = request.CtrCtaCostVentaLocId,
                    CtrCtaCostVentaExpId = request.CtrCtaCostVentaExpId,
                    CtrCtaComsVentaLocId = request.CtrCtaComsVentaLocId,
                    CtrCtaComsVentaExpId = request.CtrCtaComsVentaExpId,
                    CtrCtaComsCobroLocId = request.CtrCtaComsCobroLocId,
                    CtrCtaComsCobroExpId = request.CtrCtaComsCobroExpId,
                    CtrCtaDescLineaLocId = request.CtrCtaDescLineaLocId,
                    CtrCtaDescLineaExpId = request.CtrCtaDescLineaExpId,
                    CtrCtaCostDescLocId = request.CtrCtaCostDescLocId,
                    CtrCtaCostDescExpId = request.CtrCtaCostDescExpId,
                    CtrCtaSobrInventFisId = request.CtrCtaSobrInventFisId,
                    CtrCtaFaltInventFisId = request.CtrCtaFaltInventFisId,
                    CtrCtaVariaCostoId = request.CtrCtaVariaCostoId,
                    CtrCtaVencimientoId = request.CtrCtaVencimientoId,
                    CtrCtaSobranteRemisId = request.CtrCtaSobranteRemisId,
                    CtrCtaFaltanteRemisId = request.CtrCtaFaltanteRemisId,
                    CtrCtaInvRemitidoId = request.CtrCtaInvRemitidoId,
                    CtrCtaMatProcesoId = request.CtrCtaMatProcesoId,
                    CtrCtaConsNormalId = request.CtrCtaConsNormalId,
                    CtrCtaConsRetrabajoId = request.CtrCtaConsRetrabajoId,
                    CtrCtaConsGastoId = request.CtrCtaConsGastoId,
                    CtrCtaConsDesperdicId = request.CtrCtaConsDesperdicId,
                    CtrCtaDescBonifLocId = request.CtrCtaDescBonifLocId,
                    CtrCtaDescBonifExpId = request.CtrCtaDescBonifExpId,
                    CtrCtaDevVentasLocId = request.CtrCtaDevVentasLocId,
                    CtrCtaDevVentasExpId = request.CtrCtaDevVentasExpId,
                    CtrCtaRetAsumId = request.CtrCtaRetAsumId,
                    CtrCtaAjuId = request.CtrCtaAjuId,
                    CtrCtaAjuCMVId = request.CtrCtaAjuCMVId,
                    CtrCtaCPGarId = request.CtrCtaCPGarId,
                    CtrCtaPuGarId = request.CtrCtaPuGarId,
                    CtrCtaIngDevolucId = request.CtrCtaIngDevolucId,
                    CtrCtaPerdDevolucId = request.CtrCtaPerdDevolucId,
                    CtrCtaMatAplicadosId = request.CtrCtaMatAplicadosId,
                    CtrCtaVentasExenLocId = request.CtrCtaVentasExenLocId,
                    CtrCtaVentasExenExpId = request.CtrCtaVentasExenExpId,
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
}
