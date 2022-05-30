using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class MovInventarioDetService : IMovInventarioDetService
    {
        private readonly IMovInventarioDetRepository _repository;
        private readonly ILogger<MovInventarioDetService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
        private readonly IExistenciaBodegaRepository _ebRepository;
        private readonly IExistenciaLoteRepository _elRepository;

        public MovInventarioDetService(IMovInventarioDetRepository repository, ILogger<MovInventarioDetService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository, IExistenciaBodegaRepository ebRepository, IExistenciaLoteRepository elRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _ebRepository = ebRepository;
            _elRepository = elRepository;
        }

        //public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioDet request, DtoExistenciaBodega ebrequest, DtoExistenciaLote elrequest, DtoArticulo arequest, string userId, int movInventarioEncId, int consecutivo)
        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioDet request, string userId, int movInventarioEncId, int consecutivo)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_DET", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear detalle de movimientos de inventario.");
                    response.Success = false;
                    return response;
                }

                var buscarMovInventarioDet = await _repository.BuscarMovInventarioDetAsync(movInventarioEncId, consecutivo);
                if (buscarMovInventarioDet != null)
                {
                    throw new Exception($"El consecutivo {buscarMovInventarioDet.Consecutivo} ya existe para el movimiento {buscarMovInventarioDet.MovInventarioEncId}");
                }

                // Creación de registro en Detalle de Movimiento de Inventario
                response.Result = await _repository.CreateAsync(new MovInventarioDet
                {
                    MovInventarioEncId = request.MovInventarioEncId,
                    Consecutivo = request.Consecutivo,
                    FechaHoraTransac = request.FechaHoraTransac,
                    DocTributarioId = request.DocTributarioId,
                    AjusteConfigId = request.AjusteConfigId,
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
                    Tipo = request.Tipo,
                    Subtipo = request.Subtipo,
                    Subsubtipo = request.Subsubtipo,
                    Naturaleza = request.Naturaleza,
                    Cantidad = request.Cantidad,
                    CostoTotLoc = request.CostoTotLoc, 
                    CostoTotDol = request.CostoTotDol,
                    PrecioTotalLocal = request.PrecioTotalLocal,
                    PrecioTotalDolar = request.PrecioTotalDolar,
                    Contabilizada = request.Contabilizada,
                    Fecha = request.Fecha,
                    CentroCuentaId = request.CentroCuentaId,
                    UnidadDistribucionId = request.UnidadDistribucionId,
                    AsientoCardex = request.AsientoCardex,
                    DocFiscal = request.DocFiscal,
                    TipoOperacionId = request.TipoOperacionId,
                    TipoPagoId = request.TipoPagoId,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now
                });

                //Creación de registro en Existencia Bodega
                //var ebresponse = new BaseResponseGeneric<int>();
                //ebresponse.Result = await _ebRepository.CreateAsync(new ExistenciaBodega
                //{
                //    ArticuloId = ebrequest.ArticuloId,
                //    BodegaId = ebrequest.BodegaId,
                //    ExistenciaMinima = ebrequest.ExistenciaMinima,
                //    ExistenciaMaxima = ebrequest.ExistenciaMaxima,
                //    PuntoDeOrden = ebrequest.PuntoDeOrden,
                //    CantDisponible = ebrequest.CantDisponible + request.Cantidad,
                //    CantReservada = ebrequest.CantReservada,
                //    CantNoAprobada = ebrequest.CantNoAprobada,
                //    CantVencida = ebrequest.CantVencida,
                //    CantTransito = ebrequest.CantTransito,
                //    CantProduccion = ebrequest.CantProduccion,
                //    CantPedida = ebrequest.CantPedida,
                //    CantRemitida = ebrequest.CantRemitida,
                //    Congelado = ebrequest.Congelado,
                //    FechaCong = ebrequest.FechaCong,
                //    BloqueaTrans = ebrequest.BloqueaTrans,
                //    FechaDescong = ebrequest.FechaDescong,
                //    CostoUntPromedioLoc = ebrequest.CostoUntPromedioLoc,
                //    CostoUntPromedioDol = ebrequest.CostoUntPromedioDol,
                //    IsDeleted = false,
                //    Updatedby = userId,
                //    UpdateDate = DateTime.Now,
                //    Createdby = userId,
                //    CreateDate = DateTime.Now
                //});



                //1. Comprobar si el artículo utiliza lotes.



                //Creación de registro en Existencia Lote
                //    var elresponse = new BaseResponseGeneric<int>();
                //    response.Result = await _elRepository.CreateAsync(new ExistenciaLote
                //    {
                //        BodegaId = elrequest.BodegaId,
                //        ArticuloId = elrequest.ArticuloId,
                //        LocalizacionId = elrequest.LocalizacionId,
                //        LoteId = elrequest.LoteId,
                //        IsDeleted = false,
                //        Updatedby = userId,
                //        UpdateDate = DateTime.Now,
                //        Createdby = userId,
                //        CreateDate = DateTime.Now
                //    });

                //    response.Success = true;

                   
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_DET", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar detalle de movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<MovInventarioDet>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<MovInventarioDet>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_DET", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar detalle de movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<MovInventarioDet>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<MovInventarioDet>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new MovInventarioDet();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioDet request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_DET", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar detalle de movimientos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new MovInventarioDet
                {
                    Id = id,
                    MovInventarioEncId = request.MovInventarioEncId,
                    Consecutivo = request.Consecutivo,
                    FechaHoraTransac = request.FechaHoraTransac,
                    DocTributarioId = request.DocTributarioId,
                    AjusteConfigId = request.AjusteConfigId,
                    ArticuloId = request.ArticuloId,
                    BodegaId = request.BodegaId,
                    LocalizacionId = request.LocalizacionId,
                    LoteId = request.LoteId,
                    Tipo = request.Tipo,
                    Subtipo = request.Subtipo,
                    Subsubtipo = request.Subsubtipo,
                    Naturaleza = request.Naturaleza,
                    Cantidad = request.Cantidad,
                    CostoTotLoc = request.CostoTotLoc,
                    CostoTotDol = request.CostoTotDol,
                    PrecioTotalLocal = request.PrecioTotalLocal,
                    PrecioTotalDolar = request.PrecioTotalDolar,
                    Contabilizada = request.Contabilizada,
                    Fecha = request.Fecha,
                    CentroCuentaId = request.CentroCuentaId,
                    UnidadDistribucionId = request.UnidadDistribucionId,
                    AsientoCardex = request.AsientoCardex,
                    DocFiscal = request.DocFiscal,
                    TipoOperacionId = request.TipoOperacionId,
                    TipoPagoId = request.TipoPagoId,
                    IsDeleted = false,
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

