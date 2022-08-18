using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS
{
    public class DireccionService : IDireccionService
    {
        private readonly IDireccionRepository _repository;
        private readonly ILogger<DireccionService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public DireccionService(IDireccionRepository repository, ILogger<DireccionService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDireccion request, string userId, string codDireccion)

        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONADD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear tipos de direcciones.");
                    response.Success = false;
                    return response;
                }

                var buscarDireccion = await _repository.BuscarDireccionAsync(codDireccion);
                if (buscarDireccion != null)
                {
                    throw new Exception($"El código de Direccion {buscarDireccion.CodDireccion} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new Direccion
                {
                    CodDireccion = request.CodDireccion,
                    Descripcion = request.Descripcion,
                    NombreCampo01 = request.NombreCampo01,
                    NombreCampo02 = request.NombreCampo02,
                    NombreCampo03 = request.NombreCampo03,
                    NombreCampo04 = request.NombreCampo04,
                    NombreCampo05 = request.NombreCampo05,
                    NombreCampo06 = request.NombreCampo06,
                    NombreCampo07 = request.NombreCampo07,
                    NombreCampo08 = request.NombreCampo08,
                    NombreCampo09 = request.NombreCampo09,
                    NombreCampo10 = request.NombreCampo10,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONDEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar tipos de direcciones.");
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

        public async Task<BaseResponseGeneric<ICollection<Direccion>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Direccion>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONES", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar tipos de direcciones.");
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

        public async Task<BaseResponseGeneric<Direccion>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Direccion>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Direccion();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDireccion request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_DIRECCIONMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar tipos de direcciones.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new Direccion
                {
                    Id = id,
                    CodDireccion = request.CodDireccion,
                    Descripcion = request.Descripcion,
                    NombreCampo01 = request.NombreCampo01,
                    NombreCampo02 = request.NombreCampo02,    
                    NombreCampo03 = request.NombreCampo03,
                    NombreCampo04 = request.NombreCampo04,
                    NombreCampo05 = request.NombreCampo05,
                    NombreCampo06 = request.NombreCampo06,
                    NombreCampo07 = request.NombreCampo07,
                    NombreCampo08 = request.NombreCampo08,
                    NombreCampo09 = request.NombreCampo09,
                    NombreCampo10 = request.NombreCampo10,
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