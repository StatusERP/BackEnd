using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class UsuarioAjusteInvService : IUsuarioAjusteInvService
    {
        private readonly IUsuarioAjusteInvRepository _repository;
        private readonly ILogger<UsuarioAjusteInvService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public UsuarioAjusteInvService(IUsuarioAjusteInvRepository repository, ILogger<UsuarioAjusteInvService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoUsuarioAjusteInv request, string userId, string usuario, string ajusteConfig)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUPADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para asignar usuarios a ajustes de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarUsuarioAjusteInv = await _repository.BuscarUsuarioAjusteInvAsync(usuario, ajusteConfig);
                if (buscarUsuarioAjusteInv != null)
                {
                    throw new Exception($"El usuario {buscarUsuarioAjusteInv.Usuario} ya está asignado al código de ajuste {buscarUsuarioAjusteInv.AjusteConfig}.");
                }
                response.Result = await _repository.CreateAsync(new UsuarioAjusteInv
                {
                    Usuario = request.Usuario,
                    AjusteConfig = request.AjusteConfig,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUPDEL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar usuarios autorizados a ajustes de inventarios.");
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

        public async Task<BaseResponseGeneric<ICollection<UsuarioAjusteInv>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<UsuarioAjusteInv>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_TAJUPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar asignaciones de usuarios a ajustes de inventario.");
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

        public async Task<BaseResponseGeneric<UsuarioAjusteInv>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<UsuarioAjusteInv>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new UsuarioAjusteInv();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUsuarioAjusteInv request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONSPRIV", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar asignaciones de usuarios a ajustes de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new UsuarioAjusteInv
                {
                    Id = id,
                    Usuario = request.Usuario,
                    AjusteConfig = request.AjusteConfig,
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

