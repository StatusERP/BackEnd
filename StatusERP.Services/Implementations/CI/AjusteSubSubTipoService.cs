using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class AjusteSubSubTipoService : IAjusteSubSubTipoService
    {
        private readonly IAjusteSubSubTipoRepository _repository;
        private readonly ILogger<AjusteSubSubTipoService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public AjusteSubSubTipoService(IAjusteSubSubTipoRepository repository, ILogger<AjusteSubSubTipoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteSubSubTipo request, string userId, string ajusteConfig, string subSubTipo)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear SubSubTipos de ajuste.");
                    response.Success = false;
                    return response;
                }

                var buscarAjusteSubSubTipo = await _repository.BuscarAjusteSubSubTipoAsync(ajusteConfig, subSubTipo);
                if (buscarAjusteSubSubTipo != null)
                {
                    throw new Exception($"El codigo de SubSubTipo {buscarAjusteSubSubTipo.Subsubtipo} para el código de ajuste {buscarAjusteSubSubTipo.AjusteConfig} ya existe");
                }
                response.Result = await _repository.CreateAsync(new AjusteSubSubTipo
                {
                    AjusteConfig = request.AjusteConfig,
                    Subsubtipo = request.Subsubtipo,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar SubSubTipos de ajuste.");
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

        public async Task<BaseResponseGeneric<ICollection<AjusteSubSubTipo>>> GetAsync( string userId)
        {
            var response = new BaseResponseGeneric<ICollection<AjusteSubSubTipo>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar SubSubTipos de ajuste.");
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

        public async Task<BaseResponseGeneric<AjusteSubSubTipo>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<AjusteSubSubTipo>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new AjusteSubSubTipo();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteSubSubTipo request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar SubSubTipos de ajuste.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new AjusteSubSubTipo
                {
                    Id = id,
                    AjusteConfig = request.AjusteConfig,
                    Subsubtipo = request.Subsubtipo,
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