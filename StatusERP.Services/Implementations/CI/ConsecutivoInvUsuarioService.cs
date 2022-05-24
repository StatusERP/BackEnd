using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ConsecutivoInvUsuarioService : IConsecutivoInvUsuarioService
    {
        private readonly IConsecutivoInvUsuarioRepository _repository;
        private readonly ILogger<ConsecutivoInvUsuarioService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ConsecutivoInvUsuarioService(IConsecutivoInvUsuarioRepository repository, ILogger<ConsecutivoInvUsuarioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoInvUsuario request, string userId, int consecutivo, int usuario)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONSPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para asociar consecutivos de inventario a usuarios");
                    response.Success = false;
                    return response;
                }

                var buscarConsecutivoInvUsuario = await _repository.BuscarConsecutivoInvUsuarioAsync(consecutivo, usuario);
                if (buscarConsecutivoInvUsuario != null)
                {
                    throw new Exception($"El consecutivo de inventario {buscarConsecutivoInvUsuario.Consecutivo} ya está asociado al usuario {buscarConsecutivoInvUsuario.Usuario}.");
                }
                response.Result = await _repository.CreateAsync(new ConsecutivoInvUsuario
                {
                    Consecutivo = request.Consecutivo,
                    Usuario = request.Usuario,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONSPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar asociaciones de los consecutivos de inventario a usuarios.");
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

        public async Task<BaseResponseGeneric<ICollection<ConsecutivoInvUsuario>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ConsecutivoInvUsuario>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONSPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar asociaciones de consecutivos de inventario a usuarios.");
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

        public async Task<BaseResponseGeneric<ConsecutivoInvUsuario>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ConsecutivoInvUsuario>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ConsecutivoInvUsuario();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoInvUsuario request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONSPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar permisos de usuario a consecutivos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new ConsecutivoInvUsuario
                {
                    Id = id,
                    Consecutivo = request.Consecutivo,
                    Usuario = request.Usuario,
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
    }}