using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class DocumentoInvEncService : IDocumentoInvEncService
    {
        private readonly IDocumentoInvEncRepository _repository;
        private readonly ILogger<DocumentoInvEncService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public DocumentoInvEncService(IDocumentoInvEncRepository repository, ILogger<DocumentoInvEncService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDocumentoInvEnc request, string userId, string paquete, string documento)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOCADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear documentos de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarDocumentoInvEnc = await _repository.BuscarDocumentoInvEncAsync(paquete, documento);
                if (buscarDocumentoInvEnc != null)
                {
                    throw new Exception($"El documento de inventario {buscarDocumentoInvEnc.DocumentoInv} para el paquete {buscarDocumentoInvEnc.PaqueteInventario} ya existe");
                }
                response.Result = await _repository.CreateAsync(new DocumentoInvEnc
                {
                    PaqueteInventario = request.PaqueteInventario,
                    DocumentoInv = request.DocumentoInv,
                    ConsecutivoId = request.ConsecutivoId,
                    Referencia = request.Referencia,
                    FechaHorCreacion = request.FechaHorCreacion,
                    FechaDocumento = request.FechaDocumento,
                    Seleccionado = request.Seleccionado,
                    Usuario = request.Usuario,
                    MensajeSistema = request.MensajeSistema,
                    UsuarioApro = request.UsuarioApro,
                    FechaHoraAprob = request.FechaHoraAprob,
                    Aprobado = request.Aprobado,
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
                    response.Errors.Add($"No tiene privilegios para eliminar documentos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<DocumentoInvEnc>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<DocumentoInvEnc>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar documentos de inventario.");
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

        public async Task<BaseResponseGeneric<DocumentoInvEnc>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<DocumentoInvEnc>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new DocumentoInvEnc();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocumentoInvEnc request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TP_DOCMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar documentos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new DocumentoInvEnc
                {
                    Id = id,
                    PaqueteInventario = request.PaqueteInventario,
                    DocumentoInv = request.DocumentoInv,
                    ConsecutivoId = request.ConsecutivoId,
                    Referencia = request.Referencia,
                    FechaDocumento = request.FechaDocumento,
                    Seleccionado = request.Seleccionado,
                    Usuario = request.Usuario,
                    MensajeSistema = request.MensajeSistema,
                    UsuarioApro = request.UsuarioApro,
                    FechaHoraAprob = request.FechaHoraAprob,
                    Aprobado = request.Aprobado,
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
    }
}

