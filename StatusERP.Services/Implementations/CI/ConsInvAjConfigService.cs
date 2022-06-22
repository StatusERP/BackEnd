using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ConsInvAjConfigService : IConsInvAjConfigService
    {
        private readonly IConsInvAjConfigRepository _repository;
        private readonly ILogger<ConsInvAjConfigService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ConsInvAjConfigService(IConsInvAjConfigRepository repository, ILogger<ConsInvAjConfigService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsInvAjConfig request, string userId, int consecutivoId, int ajusteId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CONSEC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para asignar consecutivos a ajustes de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarConsInvAjConfig = await _repository.BuscarConsecAjusteAsync (consecutivoId, ajusteId);
                if (buscarConsInvAjConfig != null)
                {
                    throw new Exception($"El consecutivo {buscarConsInvAjConfig.ConsecutivoInvId} ya está asignado al tipo de ajuste configurable {buscarConsInvAjConfig.AjusteConfigId}.");
                }
                response.Result = await _repository.CreateAsync(new ConsInvAjConfig
                {
                    ConsecutivoInvId = request.ConsecutivoInvId,
                    AjusteConfigId = request.AjusteConfigId,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CONSEC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar asociación de consecutivos a ajustes configurables.");
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

        public async Task<BaseResponseGeneric<ICollection<ConsInvAjConfig>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ConsInvAjConfig>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CONSEC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar consecutivos de ajustes de inventario.");
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

        public async Task<BaseResponseGeneric<ConsInvAjConfig>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ConsInvAjConfig>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ConsInvAjConfig();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsInvAjConfig request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CONSEC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar asociaciones de consecutivos a ajustes de inventario.");
                    response.Success = false;
                    return response;
                }

                response.Result = await _repository.UpdateAsync(new ConsInvAjConfig
                {
                    Id = id,
                    ConsecutivoInvId = request.ConsecutivoInvId,
                    AjusteConfigId = request.AjusteConfigId,
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


