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
        private readonly IAjusteConfigRepository _ajRepository;

        string TipoAjusteConfig;

        public MovInventarioDetService(IMovInventarioDetRepository repository, ILogger<MovInventarioDetService> logger,
            IPrivilegioUsuarioRepository privilegioUsuarioRepository, IExistenciaBodegaRepository ebRepository,
            IExistenciaLoteRepository elRepository, IArticuloRepository aRepository, IAjusteConfigRepository ajRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _ebRepository = ebRepository;
            _elRepository = elRepository;
            _aRepository = aRepository;
            _ajRepository = ajRepository;
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

        //********************** COMIENZAN LAS VALIDACIONES

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
                        throw new Exception($"El artículo {buscarArticulo.CodArticulo} es de tipo SERVICIO o KIT.");
                    }

                    // Si llegó hasta acá es porque el artículo NO es de tipo servicio ni kit.
                    // Por lo que se inicia la validación del tipo de AjusteConfig dentro de un switch.

                   //******* Revisar AjusteConfig (ir a la tabla AjusteConfig con el Id y luego ingresar en una variable el campo CodAjusteConfig, desde un case.

                   var buscarTipoAjusteConfig = await _ajRepository.GetByIdAsync((int) request.AjusteConfigId);
                   if (buscarTipoAjusteConfig != null)
                   {
                       TipoAjusteConfig = buscarTipoAjusteConfig.CodAjusteConfig;
                        
                       switch (TipoAjusteConfig)
                       {
                           // 1/13 - Aprobación
                           case "~AA~":
                               throw new Exception($"El ajuste es de tipo Aprobación.");

                           // 2/13 - Consumo
                            case "~CC~":
                                 throw new Exception($"El ajuste es de tipo Consumo.");

                           // 3/13 - Físico *******************
                           case "~FF~":
                                 throw new Exception($"El ajuste es de tipo Físico.");

                           // 4/13 - Remisión
                           case "~II~":
                                 throw new Exception($"El ajuste es de tipo Remisión.");

                           // 5/13 - Traslado 2F
                           case "~LL~":
                                 throw new Exception($"El ajuste es de tipo Traslado 2F.");

                           // 6/13 - Misceláneo
                           case "~MM~":
                                  throw new Exception($"El ajuste es de tipo Misceláneo.");

                           // 7/13 - Vencimiento
                           case "~NN~":
                                  throw new Exception($"El ajuste es de tipo Vencimiento.");

                            // 8/13 - Compra ***************
                            case "~OO~":
                           {
                                //throw new Exception($"El ajuste es de tipo Compra.");    
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

                                 var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(request.ArticuloId, (int)request.BodegaId);
                                    
                                 if (buscarIdExistenciaBodega != null)
                                 { 
                                    
                                     //Se actualiza el registro existente en la tabla ExistenciaBodega
                                     var ebresponse = new BaseResponseGeneric<int>();
                                     try
                                     { 
                                         ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                         {
                                               ArticuloId = request.ArticuloId,
                                               BodegaId = (int)request.BodegaId,
                                               CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + request.Cantidad,
                                               CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                                               CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
                                               Updatedby = userId,
                                               UpdateDate = DateTime.Now,

                                         });
                                         ebresponse.Success = true;
                                     }
                                     catch (Exception ex)
                                     {
                                          _logger.LogCritical(ex.StackTrace);
                                          ebresponse.Success = false;
                                          ebresponse.Errors.Add(ex.Message);
                                     }
                                     return ebresponse;
                                 }
                                 else
                                 {
                                      throw new Exception($"No existe registro de existencias del artículo {request.ArticuloId} para la bodega {request.BodegaId}.  No se puede crear el movimiento");
                                      //Poner rollback para la transacción
                                 }

                                // Usa lotes?
                                if (buscarArticulo.UsaLotes)
                                {
                                // El registro ya existe, sólo se va a actualizar, si no existiera, debe crear en el mantenimiento de lotes.

                                   var elresponse = new BaseResponseGeneric<int>();
                                   var CostoUnitLoc = decimal.Round((request.CostoTotLoc / request.Cantidad), 8);
                                   var CostoUnitDol = decimal.Round((request.CostoTotDol / request.Cantidad), 8);
                                   elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                   {
                                            CantDisponible = request.Cantidad,
                                            CostoUntLoc = CostoUnitLoc,
                                            CostoUntDol = CostoUnitDol,
                                            Updatedby = userId,
                                            UpdateDate = DateTime.Now,
                                   });

                                    elresponse.Success = true;
                                }
                           };
                            
                           // 9/13 - Producción
                           case "~PP~":
                                throw new Exception($"El ajuste es de tipo Producción.");
                                
                           // 10/13 - Reservación
                           case "~RR~":
                                throw new Exception($"El ajuste es de tipo Reservación.");

                           // 11/13 - Costo ****************
                           case "~SS~":
                                throw new Exception($"El ajuste es de tipo Costo.");

                           // 12/13 - Traslado ****************
                           case "~TT~":
                                throw new Exception($"El ajuste es de tipo Traslado.");

                            // 13/13 - Venta ******************
                            case "~VV~":
                                throw new Exception($"El ajuste es de tipo Venta.");
                       };  // Fin del switch
                   };  // Fin de la validación null del AjusteConfig
                }; //Fin de la validación null del Articulo
            } //Fin del try

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

