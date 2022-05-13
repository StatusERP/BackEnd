using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ConsecutivoInvService : IConsecutivoInvService
    {
        private readonly IConsecutivoInvRepository _repository;
        private readonly ILogger<ConsecutivoInvService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ConsecutivoInvService(IConsecutivoInvRepository repository, ILogger<ConsecutivoInvService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoInv request, string userId, string codConsecutivo)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONS_ADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear consecutivos de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarCodConsecutivo = await _repository.BuscarCodConsecutivoInvAsync(codConsecutivo);
                if (buscarCodConsecutivo != null)
                {
                    throw new Exception($"El codigo de consecutivo {buscarCodConsecutivo.CodConsecutivo} ya existe");
                }
                response.Result = await _repository.CreateAsync(new ConsecutivoInv
                {
                    CodConsecutivo = request.CodConsecutivo,
                    UltimoUsuario = request.UltimoUsuario,
                    Descripcion = request.Descripcion,
                    Mascara = request.Mascara,
                    SiguienteConsec = request.SiguienteConsec,
                    Editable = request.Editable,
                    MultiplesTrans = request.MultiplesTrans,
                    FormatoImp = request.FormatoImp,
                    UltFechaHora = request.UltFechaHora,
                    TodasTrans = request.TodasTrans,
                    Tipo = request.Tipo,
                    EmailCFDI = request.EmailCFDI,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONS_DEL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar consecutivos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<ConsecutivoInv>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ConsecutivoInv>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CONSEC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar consecutivos de inventario.");
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

        public async Task<BaseResponseGeneric<ConsecutivoInv>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ConsecutivoInv>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ConsecutivoInv();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoInv request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADM_CONS_MOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar consecutivos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new ConsecutivoInv
                {
                    Id = id,
                    CodConsecutivo = request.CodConsecutivo,
                    UltimoUsuario = request.UltimoUsuario,
                    Descripcion = request.Descripcion,
                    Mascara = request.Mascara,
                    SiguienteConsec = request.SiguienteConsec,
                    Editable = request.Editable,
                    MultiplesTrans = request.MultiplesTrans,
                    FormatoImp = request.FormatoImp,
                    UltFechaHora = request.UltFechaHora,
                    TodasTrans = request.TodasTrans,
                    Tipo = request.Tipo,
                    EmailCFDI = request.EmailCFDI,
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