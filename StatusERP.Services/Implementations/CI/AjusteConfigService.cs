using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class AjusteConfigService : IAjusteConfigService
    {
        private readonly IAjusteConfigRepository _repository;
        private readonly ILogger<AjusteConfigService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public AjusteConfigService(IAjusteConfigRepository repository, ILogger<AjusteConfigService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteConfig request, string userId, string codAjusteConfig)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUM", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear ajustes de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarCodAjusteConfig = await _repository.BuscarCodAjusteConfigAsync(codAjusteConfig);
                if (buscarCodAjusteConfig != null)
                {
                    throw new Exception($"El código de ajuste de inventario {buscarCodAjusteConfig.CodAjusteConfig} ya existe");
                }
                response.Result = await _repository.CreateAsync(new AjusteConfig
                {
                    CodAjusteConfig = request.CodAjusteConfig,
                    Descripcion = request.Descripcion,
                    AjusteBase = request.AjusteBase,
                    Activa = request.Activa,
                    Ingreso = request.Ingreso,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUM", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar ajustes de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<AjusteConfig>>> GetAsync( string userId)
        {
            var response = new BaseResponseGeneric<ICollection<AjusteConfig>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUM", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar ajustes de inventario.");
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

        public async Task<BaseResponseGeneric<AjusteConfig>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<AjusteConfig>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new AjusteConfig();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteConfig request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUM", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar ajustes de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new AjusteConfig
                {
                    Id = id,
                    CodAjusteConfig = request.CodAjusteConfig,
                    Descripcion = request.Descripcion,
                    AjusteBase = request.AjusteBase,
                    Activa = request.Activa,
                    Ingreso = request.Ingreso,
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