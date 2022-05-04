using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class LoteService : ILoteService
    {
        private readonly ILoteRepository _repository;
        private readonly ILogger<LoteService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public LoteService(ILoteRepository repository, ILogger<LoteService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoLote request, string userId, string codLote)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear lotes.");
                    response.Success = false;
                    return response;
                }

                var buscarCodLote = await _repository.BuscarCodLoteAsync(codLote);
                if (buscarCodLote != null)
                {
                    throw new Exception($"El codigo de lote {buscarCodLote.CodLote} ya existe");
                }
                response.Result = await _repository.CreateAsync(new Lote
                {
                    CodLote = request.CodLote,
                    ArticuloId = request.ArticuloId,
                    ProveedorId = request.ProveedorId,
                    LoteProveedor = request.LoteProveedor,
                    FechaEntrada = request.FechaEntrada,
                    FechaVencimiento = request.FechaVencimiento,
                    FechaCuarentena = request.FechaCuarentena,
                    CantidadIngresada = request.CantidadIngresada,
                    Estado = request.Estado,
                    TipoIngreso = request.TipoIngreso,
                    Notas = request.Notas,
                    UltimoIngreso = request.UltimoIngreso,
                    FechaFabricacion = request.FechaFabricacion,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTESBORRA", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar lotes.");
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

        public async Task<BaseResponseGeneric<ICollection<Lote>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Lote>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTES", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar lotes.");
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

        public async Task<BaseResponseGeneric<Lote>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Lote>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Lote();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoLote request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_LOTESMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar lotes.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new Lote
                {
                    Id = id,
                    CodLote = request.CodLote,
                    ArticuloId = request.ArticuloId,
                    ProveedorId = request.ProveedorId,
                    LoteProveedor = request.LoteProveedor,
                    FechaEntrada = request.FechaEntrada,
                    FechaVencimiento = request.FechaVencimiento,
                    FechaCuarentena = request.FechaCuarentena,
                    CantidadIngresada = request.CantidadIngresada,
                    Estado = request.Estado,
                    TipoIngreso = request.TipoIngreso,
                    Notas = request.Notas,
                    UltimoIngreso = request.UltimoIngreso,
                    FechaFabricacion = request.FechaFabricacion,
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

