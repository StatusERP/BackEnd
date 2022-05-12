using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class GlobalesCIService : IGlobalesCIService
    {
        private readonly IGlobalesCIRepository _repository;
        private readonly ILogger<GlobalesCIService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public GlobalesCIService(IGlobalesCIRepository repository, ILogger<GlobalesCIService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesCI request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMINISTRACION", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear Globales de Control de Inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarIdGlobalesCI = await _repository.GetAllAsync(); 
                if (buscarIdGlobalesCI.Count > 0 )
                {
                    response.Errors.Add($"El registro de Globales de Inventario ya existe.");
                    response.Success = false;
                    return response;
                }
                response.Result = await _repository.CreateAsync(new GlobalesCI
                {
                    AjustarConteo = request.AjustarConteo,
                    AsistenciaAutomat = request.AsistenciaAutomat,
                    AsntAjuCompra = request.AsntAjuCompra,
                    AsntAjuConsumo = request.AsntAjuConsumo,
                    AsntAjuCosto = request.AsntAjuCosto,
                    AsntAjuFisico = request.AsntAjuFisico,
                    AsntAjuMiscelan = request.AsntAjuMiscelan,
                    AsntAjuProduc = request.AsntAjuProduc,
                    AsntAjuVencim = request.AsntAjuVencim,
                    AsntAjuVenta = request.AsntAjuVenta,
                    CntrlSeriesEntr = request.CntrlSeriesEntr,
                    CtrEnTransaccion = request.CtrEnTransaccion,
                    IntegracionConta = request.IntegracionConta,
                    TransacXUsuario = request.TransacXUsuario,
                    UsaCodigoBarras = request.UsaCodigoBarras,
                    UsaCodigoEAN13 = request.UsaCodigoEAN13,
                    UsaCodigoEAN8 = request.UsaCodigoEAN8,
                    UsaCodigoGeneric = request.UsaCodigoGeneric,
                    UsaCodigoUCC12 = request.UsaCodigoUCC12,
                    UsaCodigoUCC8 = request.UsaCodigoUCC8,
                    UsaConsecutivos = request.UsaConsecutivos,
                    UsaLocalizacion = request.UsaLocalizacion,
                    UsarAprobacion = request.UsarAprobacion,
                    UsarNumerosSerie = request.UsarNumerosSerie,
                    UsaUnidadesDist = request.UsaUnidadesDist,
                    FchUltProcAprob = request.FchUltProcAprob,
                    FchUltProcVcto = request.FchUltProcVcto,
                    FechaInicioTrans = request.FechaInicioTrans,
                    PaqueteContableId = request.PaqueteContableId,
                    TipoPartidaId = request.TipoPartidaId,
                    MaxAuditoria = request.MaxAuditoria,
                    LineasMaxTrans = request.LineasMaxTrans,
                    CostosDec = request.CostosDec,
                    ExistenciasDec = request.ExistenciasDec,
                    ModAplicAsiento = request.ModAplicAsiento,
                    PesosDec = request.PesosDec,
                    ExistEnTotales = request.ExistEnTotales,
                    NombreClasif1 = request.NombreClasif1,
                    NombreClasif2 = request.NombreClasif2,
                    NombreClasif3 = request.NombreClasif3,
                    UnidadPeso = request.UnidadPeso,
                    UnidadVolumen = request.UnidadVolumen,
                    EAN13ReglaLocal = request.EAN13ReglaLocal,
                    EAN8ReglaLocal = request.EAN8ReglaLocal,
                    ModalidadUso = request.ModalidadUso,
                    NombreClasif4 = request.NombreClasif4,
                    NombreClasif5 = request.NombreClasif5,
                    NombreClasif6 = request.NombreClasif6,
                    PrioridadBusqueda = request.PrioridadBusqueda,
                    UCC12ReglaLocal = request.UCC12ReglaLocal,
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

        
        public async Task<BaseResponseGeneric<ICollection<GlobalesCI>>> GetAsync( string userId)
        {
            var response = new BaseResponseGeneric<ICollection<GlobalesCI>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMINISTRACION", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar valores globales de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.GetAllAsync();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesCI request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMINISTRACION", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar valores globales de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new GlobalesCI
                {
                    Id = id,
                    AjustarConteo = request.AjustarConteo,
                    AsistenciaAutomat = request.AsistenciaAutomat,
                    AsntAjuCompra = request.AsntAjuCompra,
                    AsntAjuConsumo = request.AsntAjuConsumo,
                    AsntAjuCosto = request.AsntAjuCosto,
                    AsntAjuFisico = request.AsntAjuFisico,
                    AsntAjuMiscelan = request.AsntAjuMiscelan,
                    AsntAjuProduc = request.AsntAjuProduc,
                    AsntAjuVencim = request.AsntAjuVencim,
                    AsntAjuVenta = request.AsntAjuVenta,
                    CntrlSeriesEntr = request.CntrlSeriesEntr,
                    CtrEnTransaccion = request.CtrEnTransaccion,
                    IntegracionConta = request.IntegracionConta,
                    TransacXUsuario = request.TransacXUsuario,
                    UsaCodigoBarras = request.UsaCodigoBarras,
                    UsaCodigoEAN13 = request.UsaCodigoEAN13,
                    UsaCodigoEAN8 = request.UsaCodigoEAN8,
                    UsaCodigoGeneric = request.UsaCodigoGeneric,
                    UsaCodigoUCC12 = request.UsaCodigoUCC12,
                    UsaCodigoUCC8 = request.UsaCodigoUCC8,
                    UsaConsecutivos = request.UsaConsecutivos,
                    UsaLocalizacion = request.UsaLocalizacion,
                    UsarAprobacion = request.UsarAprobacion,
                    UsarNumerosSerie = request.UsarNumerosSerie,
                    UsaUnidadesDist = request.UsaUnidadesDist,
                    FchUltProcAprob = request.FchUltProcAprob,
                    FchUltProcVcto = request.FchUltProcVcto,
                    FechaInicioTrans = request.FechaInicioTrans,
                    PaqueteContableId = request.PaqueteContableId,
                    TipoPartidaId = request.TipoPartidaId,
                    MaxAuditoria = request.MaxAuditoria,
                    LineasMaxTrans = request.LineasMaxTrans,
                    CostosDec = request.CostosDec,
                    ExistenciasDec = request.ExistenciasDec,
                    ModAplicAsiento = request.ModAplicAsiento,
                    PesosDec = request.PesosDec,
                    ExistEnTotales = request.ExistEnTotales,
                    NombreClasif1 = request.NombreClasif1,
                    NombreClasif2 = request.NombreClasif2,
                    NombreClasif3 = request.NombreClasif3,
                    UnidadPeso = request.UnidadPeso,  
                    UnidadVolumen = request.UnidadVolumen,
                    EAN13ReglaLocal = request.EAN13ReglaLocal,
                    EAN8ReglaLocal = request.EAN8ReglaLocal,
                    ModalidadUso = request.ModalidadUso,
                    NombreClasif4 = request.NombreClasif4,
                    NombreClasif5 = request.NombreClasif5,
                    NombreClasif6 = request.NombreClasif6,
                    PrioridadBusqueda = request.PrioridadBusqueda,
                    UCC12ReglaLocal = request.UCC12ReglaLocal,
                    IsDeleted = false,
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
