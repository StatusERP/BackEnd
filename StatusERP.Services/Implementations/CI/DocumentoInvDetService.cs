using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class DocumentoInvDetService : IDocumentoInvDetService
    {
        private readonly IDocumentoInvDetRepository _repository;
        private readonly ILogger<DocumentoInvDetService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public DocumentoInvDetService(IDocumentoInvDetRepository repository, ILogger<DocumentoInvDetService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDocumentoInvDet request, string userId, int paquete, int documento, int linea)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOC_LINADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear líneas de documento de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarDocumentoInvDet = await _repository.BuscarDocumentoInvDetAsync(paquete, documento, linea);
                if (buscarDocumentoInvDet != null)
                {
                    throw new Exception($"La línea {buscarDocumentoInvDet.LineaDocInv} para el documento {buscarDocumentoInvDet.DocumentoInvId} del paquete {buscarDocumentoInvDet.PaqueteInventarioId} ya existe");
                }
                response.Result = await _repository.CreateAsync(new DocumentoInvDet
                {
                    PaqueteInventarioId = request.PaqueteInventarioId,
                    DocumentoInvId = request.DocumentoInvId,
                    LineaDocInv = request.LineaDocInv,
                    AjusteConfigId = request.AjusteConfigId,
                    DocTributarioId = request.DocTributarioId,
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
                    Tipo = request.Tipo,
                    Subtipo = request.Subtipo,
                    Subsubtipo = request.Subsubtipo,
                    Cantidad = request.Cantidad,
                    CostoTotalLocal = request.CostoTotalLocal,
                    CostoTotalDolar = request.CostoTotalDolar,
                    PrecioTotalLocal = request.PrecioTotalLocal,
                    PrecioTotalDolar = request.PrecioTotalDolar,
                    BodegaDestinoId = request.BodegaDestinoId,
                    LocDestinoId = request.LocDestinoId,
                    CentroCuentaId = request.CentroCuentaId,
                    Secuencia = request.Secuencia,
                    UnidadDistribucionId = request.UnidadDistribucionId,
                    CAI = request.CAI,
                    TipoOperacionId = request.TipoOperacionId,
                    TipoPagoId = request.TipoPagoId,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOCDEL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar líneas de documento de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<DocumentoInvDet>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<DocumentoInvDet>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOC_LIN", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar líneas de documento de inventario.");
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

        public async Task<BaseResponseGeneric<DocumentoInvDet>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<DocumentoInvDet>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new DocumentoInvDet();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocumentoInvDet request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOC_LINMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar líneas de documento de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new DocumentoInvDet
                {
                    Id = id,
                    PaqueteInventarioId = request.PaqueteInventarioId,
                    DocumentoInvId = request.DocumentoInvId,
                    LineaDocInv = request.LineaDocInv,
                    AjusteConfigId = request.AjusteConfigId,
                    DocTributarioId = request.DocTributarioId,
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
                    Tipo = request.Tipo,
                    Subtipo = request.Subtipo,
                    Subsubtipo = request.Subsubtipo,
                    Cantidad = request.Cantidad,
                    CostoTotalLocal = request.CostoTotalLocal,
                    CostoTotalDolar = request.CostoTotalDolar,
                    PrecioTotalLocal = request.PrecioTotalLocal,
                    PrecioTotalDolar = request.PrecioTotalDolar,
                    BodegaDestinoId = request.BodegaDestinoId,
                    LocDestinoId = request.LocDestinoId,
                    CentroCuentaId = request.CentroCuentaId,
                    Secuencia = request.Secuencia,
                    UnidadDistribucionId = request.UnidadDistribucionId,
                    CAI = request.CAI,
                    TipoOperacionId = request.TipoOperacionId,
                    TipoPagoId = request.TipoPagoId,
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

