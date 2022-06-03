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
        private readonly IArticuloRepository _aRepository;

        public MovInventarioDetService(IMovInventarioDetRepository repository, ILogger<MovInventarioDetService> logger, 
            IPrivilegioUsuarioRepository privilegioUsuarioRepository, IExistenciaBodegaRepository ebRepository, 
            IExistenciaLoteRepository elRepository, IArticuloRepository aRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _ebRepository = ebRepository;
            _elRepository = elRepository;
            _aRepository = aRepository;
        
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



                var buscarArticulo = await _aRepository.GetByIdAsync(request.ArticuloId);

                // El artículo existe?.
                if (buscarArticulo == null)
                {
                    throw new Exception($"El artículo {buscarArticulo.CodArticulo} no existe.");
                }
                else
                {   // El artículo es de tipo "servicio" o de tipo "kit", no se realiza cambio alguno en tablas de existencias.
                    if (buscarArticulo.Tipo  == "V" || buscarArticulo.Tipo == "K")
                    {
                        throw new Exception($"El artículo {buscarArticulo.CodArticulo} es de tipo SERVICIO.");
                    }

                    // Si llegó hasta acá es porque el artículo NO es de tipo servicio ni kit.
                    // Por lo que se crea el registro en ExistenciaBodega, independientemente de si usa lotes o no.
                    var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(request.ArticuloId, (int) request.BodegaId);

                    if (buscarIdExistenciaBodega != null)
                    {
                        //el registro existe, poner aquí la actualización de campos para Existencia Bodega

                        //******* Revisar AjusteConfig

                        var ebresponse = new BaseResponseGeneric<int>();
                        ebresponse.Result = await _ebRepository.CreateAsync(new ExistenciaBodega
                        {
                            ArticuloId = request.ArticuloId,
                            BodegaId = (int)request.BodegaId,
                            CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + request.Cantidad,
                            CantReservada = buscarIdExistenciaBodega.CantReservada,
                            CantNoAprobada = buscarIdExistenciaBodega.CantNoAprobada,
                            CantVencida = buscarIdExistenciaBodega.CantVencida,
                            CantTransito = buscarIdExistenciaBodega.CantTransito,
                            CantProduccion = buscarIdExistenciaBodega.CantProduccion,
                            CantPedida = buscarIdExistenciaBodega.CantPedida,
                            CantRemitida = buscarIdExistenciaBodega.CantRemitida,
                            CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                            CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
                            IsDeleted = false,
                            Updatedby = userId,
                            UpdateDate = DateTime.Now,
                            Createdby = userId,
                            CreateDate = DateTime.Now
                        });

                    }
                    else
                    {
                        throw new Exception($"No existe registro de existencias del artículo {request.ArticuloId} para la bodega {request.BodegaId}.");
                    }    


                   



                    // Usa lotes?
                    if (buscarArticulo.UsaLotes == false)
                    {
                        throw new Exception($"El artículo {buscarArticulo.CodArticulo} no utiliza lotes.");
                    }
                    else
                    {
                        
                        // El registro ya existe, sólo se va a actualizar,
                        // si no existiera, debe crear en el mantenimiento de lotes.

                        var elresponse = new BaseResponseGeneric<int>();
                        var CostoUnitLoc = decimal.Round((request.CostoTotLoc / request.Cantidad), 8);
                        var CostoUnitDol = decimal.Round((request.CostoTotDol / request.Cantidad), 8);
                        response.Result = await _elRepository.CreateAsync(new ExistenciaLote
                         {
                            BodegaId = (int)request.BodegaId,
                            ArticuloId = request.ArticuloId,
                            LocalizacionId = (int)request.LocalizacionId,
                            LoteId = (int)request.LoteId,
                            CantDisponible = request.Cantidad,
                            CantReservada = 0,
                            CantNoAprobada = 0,
                            CantVencida = 0,
                            CantRemitida = 0,
                            CostoUntLoc = CostoUnitLoc,
                            CostoUntDol = CostoUnitDol,
                            IsDeleted = false,
                            Updatedby = userId,
                            UpdateDate = DateTime.Now,
                            Createdby = userId,
                            CreateDate = DateTime.Now
                        });

                        response.Success = true;
                    }
            }





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

