using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS
{
    public class TipoDocTributarioService : ITipoDocTributarioService
    {
        private readonly ITipoDocTributarioRepository _repository;
        private readonly ILogger<TipoDocTributarioService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public TipoDocTributarioService(ITipoDocTributarioRepository repository, ILogger<TipoDocTributarioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoDocTributario request, string userId, string codTipoDT)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONS_TIPNIT_ADD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear tipos de documentos tributarios.");
                    response.Success = false;
                    return response;
                }

                var buscarTipoDocTributario = await _repository.BuscarTipoDocTributarioAsync(codTipoDT);
                if (buscarTipoDocTributario != null)
                {
                    throw new Exception($"El código de tipo de documento tributario {buscarTipoDocTributario.CodTipoDT} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new TipoDocTributario
                {
                    CodTipoDT = request.CodTipoDT,
                    Descripcion = request.Descripcion,
                    Mascara = request.Mascara,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONS_TIPNIT_DEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar tipos de documentos tributarios.");
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

        public async Task<BaseResponseGeneric<ICollection<TipoDocTributario>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<TipoDocTributario>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONS_TIPNIT", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar tipos de documentos tributarios.");
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

        public async Task<BaseResponseGeneric<TipoDocTributario>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<TipoDocTributario>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new TipoDocTributario();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoDocTributario request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONS_TIPNIT_MOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar tipos de documentos tributarios.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new TipoDocTributario
                {
                    Id = id,
                    CodTipoDT = request.CodTipoDT,
                    Descripcion = request.Descripcion,
                    Mascara = request.Mascara,
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