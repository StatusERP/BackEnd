using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Interfaces.CG;

namespace StatusERP.Services.Implementations.CG
{
    public class PaqueteContableService : IPaqueteContableService
    {
        private readonly IPaqueteContableRepository _repository;
        private readonly ILogger<PaqueteContableService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public PaqueteContableService(IPaqueteContableRepository repository, ILogger<PaqueteContableService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPaqueteContable request, string userId, string codPaquete)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear paquetes contables.");
                    response.Success = false;
                    return response;
                }

                var buscarPaqueteContable = await _repository.BuscarCodPaqueteContableAsync(codPaquete);
                if (buscarPaqueteContable != null)
                {
                    throw new Exception($"El código de Paquete Contable {buscarPaqueteContable.CodPaquete} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new PaqueteContable
                {
                    CodPaquete = request.CodPaquete,
                    Descripcion = request.Descripcion,
                    UsuarioCreador = userId,
                    UltimoUsuario = userId,
                    FechaUltAcceso = DateTime.Now,
                    UltimoAsiento = request.UltimoAsiento,
                    Marcado = request.Marcado,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar paquetes contables.");
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

        public async Task<BaseResponseGeneric<ICollection<PaqueteContable>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<PaqueteContable>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar paquetes contables.");
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

        public async Task<BaseResponseGeneric<PaqueteContable>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<PaqueteContable>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new PaqueteContable();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPaqueteContable request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar paquetes contables.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new PaqueteContable
                {
                    Id = id,
                    CodPaquete = request.CodPaquete,
                    Descripcion = request.Descripcion,
                    UsuarioCreador = userId,
                    UltimoUsuario = userId,
                    FechaUltAcceso = DateTime.Now,
                    UltimoAsiento = request.UltimoAsiento,
                    Marcado = request.Marcado,
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
