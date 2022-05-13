using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class TipoOperacionService : ITipoOperacionService
    {
        private readonly ITipoOperacionRepository _repository;
        private readonly ILogger<TipoOperacionService> _logger;
        //private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public TipoOperacionService(ITipoOperacionRepository repository, ILogger<TipoOperacionService> logger)
        {
            _repository = repository;
            _logger = logger;
            //_privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoOperacion request, string userId, string codTipoOperacion)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoOperacionS", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para crear TipoOperacions.");
                //    response.Success = false;
                //    return response;
                //}

                var buscarCodTipoOperacion = await _repository.BuscarCodTipoOperacionAsync(codTipoOperacion);
                if (buscarCodTipoOperacion != null)
                {
                    throw new Exception($"El codigo de tipo de Operacion {buscarCodTipoOperacion.CodTipoOperacion} ya existe");
                }
                response.Result = await _repository.CreateAsync(new TipoOperacion
                {
                    CodTipoOperacion = request.CodTipoOperacion,
                    Descripcion = request.Descripcion,
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
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoOperacionSBORRA", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para eliminar TipoOperacions.");
                //    response.Success = false;
                //    return response;
                //}


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

        public async Task<BaseResponseGeneric<ICollection<TipoOperacion>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<TipoOperacion>>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoOperacionS", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para consultar TipoOperacions.");
                //    response.Success = false;
                //    return response;
                //}


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

        public async Task<BaseResponseGeneric<TipoOperacion>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<TipoOperacion>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new TipoOperacion();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoOperacion request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoOperacionSMOD", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para modificar TipoOperacions.");
                //    response.Success = false;
                //    return response;
                //}


                response.Result = await _repository.UpdateAsync(new TipoOperacion
                {
                    Id = id,
                    CodTipoOperacion = request.CodTipoOperacion,
                    Descripcion = request.Descripcion,
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