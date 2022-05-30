using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class MovInventarioEncService : IMovInventarioEncService
    {
        private readonly IMovInventarioEncRepository _repository;
        private readonly ILogger<MovInventarioEncService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public MovInventarioEncService(IMovInventarioEncRepository repository, ILogger<MovInventarioEncService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioEnc request, string userId, int id)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //Comprobación de privilegio para crear encabezados de movimientos de inventario
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear movimientos de inventario.");
                    response.Success = false;
                    return response;
                }

                //Comprobación de que el código de movimiento a utilizar no ha sido utilizado aún.
                var buscarIdMovInventarioEnc = await _repository.BuscarIdMovInventarioEncAsync(id) ;
                if (buscarIdMovInventarioEnc != null)
                {
                    throw new Exception($"El código de movimiento de inventario {buscarIdMovInventarioEnc.Id} ya existe.");
                }

                // Ejecución de la inserción del registro
                response.Result = await _repository.CreateAsync(new MovInventarioEnc
                {
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Aplicacion = request.Aplicacion,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento, 
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<MovInventarioEnc>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<MovInventarioEnc>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<MovInventarioEnc>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<MovInventarioEnc>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new MovInventarioEnc();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioEnc request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar movimientos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new MovInventarioEnc
                {
                    Id = id,
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Aplicacion = request.Aplicacion,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento,
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now
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
