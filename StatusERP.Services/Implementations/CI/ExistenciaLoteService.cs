using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ExistenciaLoteService : IExistenciaLoteService
    {
        private readonly IExistenciaLoteRepository _repository;
        private readonly ILogger<ExistenciaLoteService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ExistenciaLoteService(IExistenciaLoteRepository repository, ILogger<ExistenciaLoteService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoExistenciaLote request, string userId, int bodegaId, int articuloId, int localizacionId, int loteId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear lotes.");
                    response.Success = false;
                    return response;
                }

                var buscarExistenciaLote = await _repository.BuscarExistenciaLoteAsync(bodegaId, articuloId, localizacionId, loteId);
                if (buscarExistenciaLote != null)
                {
                    throw new Exception($"La existencia para este lote y localización ya existe");
                }
                response.Result = await _repository.CreateAsync(new ExistenciaLote
                {
                    BodegaId = request.BodegaId,
                    ArticuloId = request.ArticuloId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTESBORRA", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar la existencia lotes.");
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

        public async Task<BaseResponseGeneric<ICollection<ExistenciaLote>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ExistenciaLote>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_EXISTLOCAL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar existencia de lotes.");
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

        public async Task<BaseResponseGeneric<ExistenciaLote>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ExistenciaLote>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ExistenciaLote();
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

        
        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoExistenciaLote request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTESMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar la existencia de lotes.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new ExistenciaLote
                {
                    Id = id,
                    BodegaId = request.BodegaId,
                    ArticuloId = request.ArticuloId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
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


