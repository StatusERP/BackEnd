using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class IngresoLoteService : IIngresoLoteService
    {
        private readonly IIngresoLoteRepository _repository;
        private readonly ILogger<IngresoLoteService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public IngresoLoteService(IIngresoLoteRepository repository, ILogger<IngresoLoteService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoIngresoLote request, string userId, int articulo, int lote, int secuenciaLote)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear ingresos de lotes.");
                    response.Success = false;
                    return response;
                }

                var buscarIngresoLote = await _repository.BuscarIngresoLoteAsync(articulo, lote, secuenciaLote);
                if (buscarIngresoLote != null)
                {
                    throw new Exception($"El ingreso de lote que corresponde al artículo {buscarIngresoLote.Articulo}, lote {buscarIngresoLote.Lote}, secuencia {buscarIngresoLote.SecuenciaLote} ya existe");
                }
                response.Result = await _repository.CreateAsync(new IngresoLote
                {
                    Articulo = request.Articulo,
                    Lote = request.Lote,
                    SecuenciaLote = request.SecuenciaLote,
                    FechaEntrada = request.FechaEntrada,
                    CantidadIngresada = request.CantidadIngresada,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar ingresos de lotes.");
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

        public async Task<BaseResponseGeneric<ICollection<IngresoLote>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<IngresoLote>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar ingresos de lotes.");
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

        public async Task<BaseResponseGeneric<IngresoLote>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<IngresoLote>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new IngresoLote();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoIngresoLote request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar ingresos de lotes.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new IngresoLote
                {
                    Id = id,
                    Articulo = request.Articulo,
                    Lote = request.Lote,
                    SecuenciaLote = request.SecuenciaLote,
                    FechaEntrada = request.FechaEntrada,
                    CantidadIngresada = request.CantidadIngresada,
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