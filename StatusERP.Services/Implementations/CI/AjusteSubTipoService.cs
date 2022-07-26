using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class AjusteSubTipoService : IAjusteSubTipoService
    {
        private readonly IAjusteSubTipoRepository _repository;
        private readonly ILogger<AjusteSubTipoService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public AjusteSubTipoService(IAjusteSubTipoRepository repository, ILogger<AjusteSubTipoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteSubTipo request, string userId, string ajusteConfig, string subTipo)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear subtipos de ajuste.");
                    response.Success = false;
                    return response;
                }

                var buscarAjusteSubTipo = await _repository.BuscarAjusteSubTipoAsync(ajusteConfig, subTipo);
                if (buscarAjusteSubTipo != null)
                {
                    throw new Exception($"El codigo de subtipo {buscarAjusteSubTipo.SubTipo} para el código de ajuste {buscarAjusteSubTipo.AjusteConfig} ya existe");
                }
                response.Result = await _repository.CreateAsync(new AjusteSubTipo
                {
                    AjusteConfig = request.AjusteConfig,
                    SubTipo = request.SubTipo,
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
                    response.Errors.Add($"No tiene privilegios para eliminar subtipos de ajuste.");
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

        public async Task<BaseResponseGeneric<ICollection<AjusteSubTipo>>> GetAsync( string userId)
        {
            var response = new BaseResponseGeneric<ICollection<AjusteSubTipo>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar subtipos de ajuste.");
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

        public async Task<BaseResponseGeneric<AjusteSubTipo>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<AjusteSubTipo>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new AjusteSubTipo();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteSubTipo request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TRANSACCIONES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar subtipos de ajuste.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new AjusteSubTipo
                {
                    Id = id,
                    AjusteConfig = request.AjusteConfig,
                    SubTipo = request.SubTipo,
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