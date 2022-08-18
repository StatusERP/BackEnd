using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Interfaces.CG;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.CG
{
    public class TipoPartidaService : ITipoPartidaService
    {
        private readonly ITipoPartidaRepository _repository;
        private readonly ILogger<TipoPartidaService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public TipoPartidaService(ITipoPartidaRepository repository, ILogger<TipoPartidaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_ADMIN_TASNT", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear tipos de partida.");
                    response.Success = false;
                    return response;
                }

                var buscarCodTipoPartida = await _repository.BuscarCodTipoPartidaAsync(codTipoPartida);
                if (buscarCodTipoPartida != null)
                {
                    throw new Exception($"El código de tipo de partida {buscarCodTipoPartida.CodTipoPartida} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new TipoPartida
                {
                    CodTipoPartida = request.CodTipoPartida,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_ADMIN_TASNT", Constants.EmpresaId, userId);

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

        public async Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<TipoPartida>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_ADMIN_TASNT", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar tipos de partida.");
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

        public async Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<TipoPartida>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new TipoPartida();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_ADMIN_TASNT", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar tipos de partida.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new TipoPartida
                {
                    Id = id,
                    CodTipoPartida = request.CodTipoPartida,
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
