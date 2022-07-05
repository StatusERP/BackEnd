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

        string ? strTipoAjusteConfig;
        string ? strSubtipo;
        string ? strSubsubtipo;
        string ? strNaturaleza;
        decimal decExistenciaTotal;

        //Costos Promedio únicamente de la transacción actual
        decimal CostoUnitUltimoLoc;
        decimal CostoUnitUltimoDol;
        //Costos Promedio del artículo tomando en cuenta la transacción actual
        decimal CostoPromLocArt;
        decimal CostoPromDolArt;
        

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

                // Si el artículo no es de tipo servicio, ni kit, se realizan los cambios.
                if (buscarArticulo.Tipo == "V" || buscarArticulo.Tipo == "K")
                {
                        //throw new Exception($"El artículo {buscarArticulo.CodArticulo} es de tipo SERVICIO o KIT.");
                }

                CostoUnitUltimoLoc = decimal.Round((request.CostoTotLoc / request.Cantidad), 8);
                CostoUnitUltimoDol = decimal.Round((request.CostoTotDol / request.Cantidad), 8);

                // Si llegó hasta acá es porque el artículo NO es de tipo servicio ni kit.
                // Por lo que se inicia la validación del tipo de AjusteConfig dentro de un switch.

               var buscarTipoAjusteConfig = await _ajRepository.GetByIdAsync((int) request.AjusteConfigId);
               strTipoAjusteConfig = buscarTipoAjusteConfig.AjusteBase;
               strSubtipo = request.Subtipo;
               strSubsubtipo = request.Subsubtipo;
               strNaturaleza = request.Naturaleza;
                        
               switch (strTipoAjusteConfig)
               {
                    // 1/13 - Aprobación
                     case "A":
                          throw new Exception($"El ajuste es de tipo Aprobación.");

                    // 2/13 - Consumo
                    case "C":
                           throw new Exception($"El ajuste es de tipo Consumo.");

                    // 3/13 - Físico *******************
                    case "F":
                            throw new Exception($"El ajuste es de tipo Físico.");

                    // 4/13 - Remisión
                    case "I":
                            throw new Exception($"El ajuste es de tipo Remisión.");

                    // 5/13 - Traslado 2F
                    //case "I":
                    //    throw new Exception($"El ajuste es de tipo Traslado 2F.");

                    // 6/13 - Misceláneo
                    case "M":
                          throw new Exception($"El ajuste es de tipo Misceláneo.");

                    // 7/13 - Vencimiento
                     case "N":
                           throw new Exception($"El ajuste es de tipo Vencimiento.");

                    // 8/13 - Compra ***************
                    case "O":
                    {
                         if (strSubtipo == "D")
                         {
                             switch (strSubsubtipo)
                             {
                                   case "L":
                                   // Compras Locales
                                        if (strNaturaleza == "E")  // Es entrada
                                        {
                                            // **** COMPRA LOCAL POSITIVA

                                            // 1/4 Creación de registro en Detalle de Movimiento de Inventario
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
                                            });  //Fin del create en la tabla MovsInventarioDet

                                           
                                            // 2/4 Se actualiza el registro correspondiente en la tabla Articulos
                                            var Existencias = await _ebRepository.BuscarExistenciaXArticulo(request.ArticuloId);
                                            decExistenciaTotal = 0;
                                            foreach (var Existencia in Existencias)
                                            {
                                                decExistenciaTotal = decExistenciaTotal + Existencia.CantDisponible;
                                            }

                                            var buscarIdArticulo = await _aRepository.GetByIdAsync(request.ArticuloId);
                                            var aresponse = new BaseResponseGeneric<int>();

                                            CostoPromLocArt = DecCostoPromLocArt(decExistenciaTotal, request.Cantidad, buscarIdArticulo.CostoLoc, CostoUnitUltimoLoc);
                                            CostoPromDolArt = DecCostoPromDolArt(decExistenciaTotal, request.Cantidad, buscarIdArticulo.CostoDol, CostoUnitUltimoDol);

                                            try
                                            {
                                                aresponse.Result = await _aRepository.UpdateAsync(new Articulo
                                                {
                                                    Id = buscarIdArticulo.Id,
                                                    CodArticulo = buscarIdArticulo.CodArticulo,
                                                    Descripcion = buscarIdArticulo.Descripcion,
                                                    Clasificacion1Id = buscarIdArticulo.Clasificacion1Id,
                                                    Clasificacion2Id = buscarIdArticulo.Clasificacion2Id,
                                                    Clasificacion3Id = buscarIdArticulo.Clasificacion3Id,
                                                    Clasificacion4Id = buscarIdArticulo.Clasificacion4Id,
                                                    Clasificacion5Id = buscarIdArticulo.Clasificacion5Id,
                                                    Clasificacion6Id = buscarIdArticulo.Clasificacion6Id,
                                                    FactorConver1 = buscarIdArticulo.FactorConver1,
                                                    FactorConver2 = buscarIdArticulo.FactorConver2,
                                                    FactorConver3 = buscarIdArticulo.FactorConver3,
                                                    FactorConver4 = buscarIdArticulo.FactorConver4,
                                                    FactorConver5 = buscarIdArticulo.FactorConver5,
                                                    FactorConver6 = buscarIdArticulo.FactorConver6,
                                                    Tipo = buscarIdArticulo.Tipo,
                                                    TiendaEnLinea = buscarIdArticulo.TiendaEnLinea,
                                                    VentaTarjetaCredito = buscarIdArticulo.VentaTarjetaCredito,
                                                    PesoNeto = buscarIdArticulo.PesoNeto,
                                                    PesoBruto = buscarIdArticulo.PesoBruto,
                                                    Volumen = buscarIdArticulo.Volumen,
                                                    Bultos = Convert.ToInt16(buscarIdArticulo.Bultos),
                                                    CostoLoc = CostoPromLocArt,
                                                    CostoDol = CostoPromDolArt,
                                                    CostoPromUltimoLoc = CostoUnitUltimoLoc,
                                                    CostoPromUltimoDol = CostoUnitUltimoDol,
                                                    UltimoIngreso = DateTime.Now,
                                                    UltimoMovimiento = DateTime.Now,
                                                    UsuarioUltModif = userId,
                                                    FechaHoraUltModif = DateTime.Now,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    CategoriaArticuloId = buscarIdArticulo.CategoriaArticuloId,
                                                    ImpuestoId = buscarIdArticulo.ImpuestoId,
                                                    FactorEmpaque = buscarIdArticulo.FactorEmpaque,
                                                    FactorVenta = buscarIdArticulo.FactorVenta,
                                                    ExistenciaMinima = buscarIdArticulo.ExistenciaMinima,
                                                    ExistenciaMaxima = buscarIdArticulo.ExistenciaMaxima,
                                                    PuntoDeOrden = buscarIdArticulo.PuntoDeOrden,
                                                    PrecioBaseLocal = buscarIdArticulo.PrecioBaseLocal,
                                                    PrecioBaseDol = buscarIdArticulo.PrecioBaseDol,
                                                    UltimaSalida = buscarIdArticulo.UltimaSalida,
                                                    UltimoInventario = buscarIdArticulo.UltimoInventario,
                                                    ClaseABC = buscarIdArticulo.ClaseABC,
                                                    FrecuenciaConteo = buscarIdArticulo.FrecuenciaConteo,
                                                    CodigoBarrasVent = buscarIdArticulo.CodigoBarrasVent,
                                                    CodigoBarrasInvt = buscarIdArticulo.CodigoBarrasInvt,
                                                    Activo = buscarIdArticulo.Activo,
                                                    UsaLotes = buscarIdArticulo.UsaLotes,
                                                    ObligaCuarentena = buscarIdArticulo.ObligaCuarentena,
                                                    MinVidaCompra = buscarIdArticulo.MinVidaCompra,
                                                    MinVidaConsumo = buscarIdArticulo.MinVidaConsumo,
                                                    MinVidaVenta = buscarIdArticulo.MinVidaVenta,
                                                    VidaUtilPromedio = buscarIdArticulo.VidaUtilPromedio,
                                                    DiasCuarentena = buscarIdArticulo.DiasCuarentena,
                                                    Proveedor = buscarIdArticulo.Proveedor,
                                                    ArticuloDelProv = buscarIdArticulo.ArticuloDelProv,
                                                    OrdenMinima = buscarIdArticulo.OrdenMinima,
                                                    PlazoReabast = buscarIdArticulo.PlazoReabast,
                                                    LoteMultiplo = buscarIdArticulo.LoteMultiplo,
                                                    UsuarioCreacion = buscarIdArticulo.UsuarioCreacion,
                                                    FechaHoraCreacion = buscarIdArticulo.FechaHoraCreacion,
                                                    UsaNumerosSerie = buscarIdArticulo.UsaNumerosSerie,
                                                    ModalidadInvFis = buscarIdArticulo.ModalidadInvFis,
                                                    TipoCodBarraDet = buscarIdArticulo.TipoCodBarraDet,
                                                    TipoCodBarraAlm = buscarIdArticulo.TipoCodBarraAlm,
                                                    UsaReglasLocales = buscarIdArticulo.UsaReglasLocales,
                                                    UnidadAlmacenId = buscarIdArticulo.UnidadAlmacenId,
                                                    UnidadEmpaqueId = buscarIdArticulo.UnidadEmpaqueId,
                                                    UnidadVentaId = buscarIdArticulo.UnidadVentaId,
                                                    Perecedero = buscarIdArticulo.Perecedero,
                                                    Manufacturador = buscarIdArticulo.Manufacturador,
                                                    CodigoRetencion = buscarIdArticulo.CodigoRetencion,
                                                    RetencionVenta = buscarIdArticulo.RetencionVenta,
                                                    RetencionCompra = buscarIdArticulo.RetencionCompra,
                                                    ModeloRetencion = buscarIdArticulo.ModeloRetencion,
                                                    Estilo = buscarIdArticulo.Estilo,
                                                    Talla = buscarIdArticulo.Talla,
                                                    Color = buscarIdArticulo.Color,
                                                    TipoCosto = buscarIdArticulo.TipoCosto,
                                                    EsImpuesto = buscarIdArticulo.EsImpuesto,
                                                    TipoDocIVA = buscarIdArticulo.TipoDocIVA,
                                                    SugiereMin = buscarIdArticulo.SugiereMin,
                                                    CalculaPercep = buscarIdArticulo.CalculaPercep,
                                                    PorcPercep = buscarIdArticulo.PorcPercep,
                                                    Notas = buscarIdArticulo.Notas,
                                                    IsDeleted = false,
                                                    Createdby = buscarIdArticulo.Createdby
                                                    
                                                });

                                                aresponse.Success = true;
                                            }
                                            catch (Exception ex)
                                            {
                                                _logger.LogCritical(ex.StackTrace);
                                                aresponse.Success = false;
                                                aresponse.Errors.Add(ex.Message);
                                            }  // Fin del try del Articulo


                                            // 3/4 Se actualiza el registro existente en la tabla ExistenciaBodega
                                            var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(request.ArticuloId, (int) request.BodegaId);

                                            var ebresponse = new BaseResponseGeneric<int>();
                                            try
                                            {
                                                ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                {
                                                    Id = buscarIdExistenciaBodega.Id,
                                                    ArticuloId = request.ArticuloId,
                                                    BodegaId = (int)request.BodegaId,
                                                    CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + request.Cantidad,
                                                    CostoUntPromedioLoc = CostoPromLocArt,
                                                    CostoUntPromedioDol = CostoPromDolArt, 
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    FechaCong = buscarIdExistenciaBodega.FechaCong,
                                                    ExistenciaMinima = buscarIdExistenciaBodega.ExistenciaMinima,
                                                    ExistenciaMaxima = buscarIdExistenciaBodega.ExistenciaMaxima,
                                                    PuntoDeOrden = buscarIdExistenciaBodega.PuntoDeOrden,
                                                    CantReservada = buscarIdExistenciaBodega.CantReservada,
                                                    CantNoAprobada = buscarIdExistenciaBodega.CantNoAprobada,
                                                    CantVencida = buscarIdExistenciaBodega.CantVencida,
                                                    CantTransito = buscarIdExistenciaBodega.CantTransito,
                                                    CantProduccion = buscarIdExistenciaBodega.CantProduccion,
                                                    CantPedida = buscarIdExistenciaBodega.CantPedida,
                                                    CantRemitida = buscarIdExistenciaBodega.CantRemitida,
                                                    Congelado = buscarIdExistenciaBodega.Congelado,
                                                    BloqueaTrans = buscarIdExistenciaBodega.BloqueaTrans,
                                                    FechaDescong = buscarIdExistenciaBodega.FechaDescong,
                                                    IsDeleted = buscarIdExistenciaBodega.IsDeleted,
                                                    Createdby = buscarIdExistenciaBodega.Createdby,
                                                    CreateDate = buscarIdExistenciaBodega.CreateDate,

                                                });

                                                ebresponse.Success = true;
                                            }
                                            catch (Exception ex)
                                            {
                                                _logger.LogCritical(ex.StackTrace);
                                                ebresponse.Success = false;
                                                ebresponse.Errors.Add(ex.Message);
                                            } // Fin del try de ExistenciaBodega


                                            // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote
                                            if (buscarArticulo.UsaLotes)
                                            {
                                                var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)request.BodegaId, request.ArticuloId, (int)request.LocalizacionId, (int) request.LoteId);
                                                var elresponse = new BaseResponseGeneric<int>();
                                                try
                                                {

                                                    elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                    {
                                                        Id = buscarExistenciaLote.Id,
                                                        BodegaId = buscarExistenciaLote.BodegaId,
                                                        ArticuloId = buscarExistenciaLote.ArticuloId,
                                                        LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                        LoteId = buscarExistenciaLote.LoteId,
                                                        CantDisponible = buscarExistenciaLote.CantDisponible + request.Cantidad,
                                                        CantReservada = buscarExistenciaLote.CantReservada,
                                                        CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                        CantRemitida = buscarExistenciaLote.CantRemitida,
                                                        CantVencida = buscarExistenciaLote.CantVencida,
                                                        CostoUntLoc = CostoPromLocArt,
                                                        CostoUntDol = CostoPromDolArt,
                                                        IsDeleted = buscarExistenciaLote.IsDeleted,
                                                        Updatedby = userId,
                                                        UpdateDate = DateTime.Now,
                                                        Createdby = buscarExistenciaLote.Createdby,
                                                        CreateDate = buscarExistenciaLote.CreateDate
                                                    });
                                                    elresponse.Success = true;
                                                }
                                                catch (Exception ex)
                                                {
                                                    _logger.LogCritical(ex.StackTrace);
                                                    elresponse.Success = false;
                                                    elresponse.Errors.Add(ex.Message);
                                                }  // Fin del try de ExistenciaLote
 
                                            }  //Fin del if "usa lotes"

                                            break;

                                        }  //Fin del if "Naturaleza = "E"

                                        else // Es salida
                                        {
                                            throw new Exception($"Devolución de compra en proceso.");

                                            // **** DEVOLUCION DE COMPRA LOCAL

                                        }  //Fin del if "Naturaleza = "E"
                                                                    
                        
                                        break;
                        

                                   case "I":
                                   // Importaciones
                                        throw new Exception($"Importación.");
                             } // Fin del switch strSubsubtipo   
                         } // Fin del if subTipo = D

                         else
                         {
                             throw new Exception($"El subtipo no es igual a 'Disponible'.");
                             //Poner aquí las instrucciones para los otros subtipos
                         }
                         break;

                    }   //Termina el case para TipoAjuste= "O"
                            
                    // 9/13 - Producción
                    case "P":
                         throw new Exception($"El ajuste es de tipo Producción.");
                                
                    // 10/13 - Reservación
                    case "R":
                          throw new Exception($"El ajuste es de tipo Reservación.");

                    // 11/13 - Costo ****************
                    case "S":
                          throw new Exception($"El ajuste es de tipo Costo.");

                    // 12/13 - Traslado ****************
                    case "T":
                          throw new Exception($"El ajuste es de tipo Traslado.");

                    // 13/13 - Venta ******************
                    case "V":
                          throw new Exception($"El ajuste es de tipo Venta.");
               };  // Fin del switch
               
               response.Success = true;

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


        public static decimal DecCostoPromLocArt(decimal ExistenciaActual, decimal ExistenciaMov, decimal CostoPromActual, decimal CostoPromMov)
        {
            decimal CostoPromLocalArt = ((ExistenciaActual * CostoPromActual) + (ExistenciaMov * CostoPromMov)) / (ExistenciaActual+ ExistenciaMov);
            return CostoPromLocalArt;
        }



        public static decimal DecCostoPromDolArt(decimal ExistenciaActual, decimal ExistenciaMov, decimal CostoPromActual, decimal CostoPromMov)
        {
            decimal CostoPromDolarArt = ((ExistenciaActual * CostoPromActual) + (ExistenciaMov * CostoPromMov)) / (ExistenciaActual + ExistenciaMov);
            return CostoPromDolarArt;
        }

    }
}

