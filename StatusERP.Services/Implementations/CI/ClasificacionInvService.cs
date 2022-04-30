using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ClasificacionInvService : IClasificacionInvService
    {
        private readonly IClasificacionInvRepository _repository;
        private readonly ILogger<ClasificacionInvService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ClasificacionInvService(IClasificacionInvRepository repository, ILogger<ClasificacionInvService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoClasificacionInv request, string userId, string codClasificacion)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CLASIFADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear clasificaciones de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarCodArticulo = await _repository.BuscarCodClasificacionInvAsync(codClasificacion);
                if (buscarCodArticulo != null)
                {
                    throw new Exception($"El codigo de clasificación de inventario {buscarCodArticulo.CodClasificacion} ya existe");
                }
                response.Result = await _repository.CreateAsync(new ClasificacionInv
                {
                    CodClasificacion = request .CodClasificacion,
                    Descripcion = request .Descripcion,
                    Agrupacion = request.Agrupacion,
                    UsaNumerosSerie = request .UsaNumerosSerie,
                    PlantillaSerie= request.PlantillaSerie,
                    AporteCodigo = request.AporteCodigo,
                    TipoCodigoBarras = request.TipoCodigoBarras,
                    UnidadMedida = request.UnidadMedida,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CLASIFDEL", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar clasificaciones de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<ClasificacionInv>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ClasificacionInv>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CLASIF", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar clasificaciones de inventario.");
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

        public async Task<BaseResponseGeneric<ClasificacionInv>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ClasificacionInv>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ClasificacionInv();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoClasificacionInv request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ADMIN_CLASIFMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar clasificaciones de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new ClasificacionInv
                {
                    Id = id,
                    CodClasificacion = request.CodClasificacion,
                    Descripcion = request.Descripcion,
                    Agrupacion = request.Agrupacion,
                    UsaNumerosSerie = request.UsaNumerosSerie,
                    PlantillaSerie = request.PlantillaSerie,
                    AporteCodigo = request.AporteCodigo,
                    TipoCodigoBarras = request.TipoCodigoBarras,
                    UnidadMedida = request.UnidadMedida,
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
