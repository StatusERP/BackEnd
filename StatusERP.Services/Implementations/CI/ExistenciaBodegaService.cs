using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ExistenciaBodegaService : IExistenciaBodegaService
    {
        private readonly IExistenciaBodegaRepository _repository;
        private readonly ILogger<ExistenciaBodegaService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ExistenciaBodegaService(IExistenciaBodegaRepository repository, ILogger<ExistenciaBodegaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoExistenciaBodega request, string userId, int articuloId, int bodegaId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarIdExistenciaBodega = await _repository.BuscarIdExistenciaBodegaAsync(articuloId, bodegaId);
                if (buscarIdExistenciaBodega != null)
                {
                    throw new Exception($"Ya existe registro para el artículo {buscarIdExistenciaBodega.ArticuloId} en la bodega {buscarIdExistenciaBodega.BodegaId}.");
                }
                response.Result = await _repository.CreateAsync(new ExistenciaBodega
                {
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    ExistenciaMinima = request.ExistenciaMinima,
                    ExistenciaMaxima = request.ExistenciaMaxima,
                    PuntoDeOrden = request.PuntoDeOrden,
                    CantDisponible = 0,
                    CantReservada = 0,
                    CantNoAprobada = 0,
                    CantVencida = 0,
                    CantTransito = 0,
                    CantProduccion = 0,
                    CantPedida = 0,
                    CantRemitida = 0,
                    Congelado = false,
                    FechaCong = new DateTime(1980, 1, 1),
                    BloqueaTrans = false,
                    FechaDescong = new DateTime(1980, 1, 1),
                    CostoUntPromedioLoc = 0,
                    CostoUntPromedioDol = 0,
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

        public async Task<BaseResponseGeneric<ICollection<ExistenciaBodega>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<ExistenciaBodega>>();
            try
            {

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

        public async Task<BaseResponseGeneric<ICollection<ExistenciaBodega>>> GetByIdArticuloAsync(int articuloId)
        {
           var response=new BaseResponseGeneric<ICollection<ExistenciaBodega>>();
            try
            {
                response.Result=await _repository.BuscarExistenciaXArticulo(articuloId);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success= false;
                response.Errors.Add(ex.Message);
                
            }
            return response;
        }

        public async Task<BaseResponseGeneric<ExistenciaBodega>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<ExistenciaBodega>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new ExistenciaBodega();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoExistenciaBodega request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                response.Result = await _repository.UpdateAsync(new ExistenciaBodega
                {
                    Id = id,
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    ExistenciaMinima = request.ExistenciaMinima,
                    ExistenciaMaxima = request.ExistenciaMaxima,
                    PuntoDeOrden = request.PuntoDeOrden,
                    CantDisponible = request.CantDisponible,
                    CantReservada = request.CantReservada,
                    CantNoAprobada = request.CantNoAprobada,
                    CantVencida = request.CantVencida,
                    CantTransito = request.CantTransito,
                    CantProduccion = request.CantProduccion,
                    CantPedida = request.CantPedida,
                    CantRemitida = request.CantRemitida,
                    Congelado = request.Congelado,
                    FechaCong = request.FechaCong,
                    BloqueaTrans = request.BloqueaTrans,
                    FechaDescong = request.FechaDescong,
                    CostoUntPromedioLoc = request.CostoUntPromedioLoc,
                    CostoUntPromedioDol = request.CostoUntPromedioDol,
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


