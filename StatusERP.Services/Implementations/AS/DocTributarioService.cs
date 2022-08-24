using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS
{
    public class DocTributarioService : IDocTributarioService
    {
        private readonly IDocTributarioRepository _repository;
        private readonly ILogger<DocTributarioService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public DocTributarioService(IDocTributarioRepository repository, ILogger<DocTributarioService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDocTributario request, string userId, string numDocTributario)

        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_NITADD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear documentos tributarios.");
                    response.Success = false;
                    return response;
                }

                var buscarDocTributario = await _repository.BuscarNumDocTributarioAsync(numDocTributario);
                if (buscarDocTributario != null)
                {
                    throw new Exception($"El número de documento tributario {buscarDocTributario.NumDocTributario} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new DocTributario
                {
                    NumDocTributario = request.NumDocTributario,
                    RazonSocial = request.RazonSocial,
                    Alias = request.Alias,
                    Activo = request.Activo,
                    Notas = request.Notas,
                    TipoDocTributarioId = request.TipoDocTributarioId,
                    DigitoVerificador = request.DigitoVerificador,
                    TipoContribuyente = request.TipoContribuyente,
                    NRC = request.NRC,
                    Giro = request.Giro,
                    Categoria = request.Categoria,
                    DUI = request.DUI,
                    Pasaporte = request.Pasaporte,
                    Carnet = request.Carnet,
                    Otro = request.Otro,
                    InfoLegal = request.InfoLegal,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_NITDEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar documentos tributarios.");
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

        public async Task<BaseResponseGeneric<ICollection<DocTributario>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<DocTributario>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_NITS", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar documentos tributarios.");
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

        public async Task<BaseResponseGeneric<DocTributario>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<DocTributario>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new DocTributario();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocTributario request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_NITMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar documentos tributarios.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new DocTributario
                {
                    Id = id,
                    NumDocTributario = request.NumDocTributario,
                    RazonSocial = request.RazonSocial,
                    Alias = request.Alias,
                    Activo = request.Activo,
                    Notas = request.Notas,
                    TipoDocTributarioId = request.TipoDocTributarioId,
                    DigitoVerificador = request.DigitoVerificador,
                    TipoContribuyente = request.TipoContribuyente,
                    NRC = request.NRC,
                    Giro = request.Giro,
                    Categoria = request.Categoria,
                    DUI = request.DUI,
                    Pasaporte = request.Pasaporte,
                    Carnet = request.Carnet,
                    Otro = request.Otro,
                    InfoLegal = request.InfoLegal,
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