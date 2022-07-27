using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;


namespace StatusERP.Services.Implementations.CI
{
    public class MovInventarioEncService : IMovInventarioEncService
    {
        private readonly IMovInventarioEncRepository _repository;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
        private readonly IMovInventarioDetRepository _detRepository;
        private readonly IConsecutivoInvRepository _ciRepository;
        private readonly IExistenciaBodegaRepository _ebRepository;
        private readonly IExistenciaBodegaRepository _ebDestRepository;
        private readonly IExistenciaLoteRepository _elRepository;
        private readonly IExistenciaLoteRepository _elDestRepository;
        private readonly IArticuloRepository _aRepository;
        private readonly IAjusteConfigRepository _ajRepository;
        private readonly ILogger<MovInventarioEncService> _logger;
        private readonly ILogger<MovInventarioDetService> _detlogger;

        int CorrelativoLinea;
        string? AplicacionDocActual;

        string? strTipoAjusteConfig;
        string? strSubtipo;
        string? strSubsubtipo;
        string? strNaturaleza;
        decimal decExistenciaTotal;

        //Costos Promedio únicamente de la transacción actual
        decimal CostoUnitUltimoLoc;
        decimal CostoUnitUltimoDol;

        //Costos Promedio del artículo tomando en cuenta la transacción actual
        decimal CostoPromLocArt;
        decimal CostoPromDolArt;
        //Costo recalculado para ExistenciaBodega y ExistenciaLote, que será igual a cero si la cantidad disponible de la línea es igual a cero.
        decimal CostoExistenciaBodegaLoc;
        decimal CostoExistenciaBodegaDol;
        decimal CostoExistenciaLoteLoc;
        decimal CostoExistenciaLoteDol;



        public MovInventarioEncService(IMovInventarioEncRepository repository, ILogger<MovInventarioEncService> logger, ILogger<MovInventarioDetService> detlogger,
            IPrivilegioUsuarioRepository privilegioUsuarioRepository, IMovInventarioDetRepository detRepository, IConsecutivoInvRepository ciRepository, 
            IExistenciaBodegaRepository ebRepository, IExistenciaBodegaRepository ebDestRepository, IExistenciaLoteRepository elRepository, IExistenciaLoteRepository elDestRepository,
            IArticuloRepository aRepository, IAjusteConfigRepository ajRepository)
                 
        {
            _repository = repository;
            _logger = logger;
            _detlogger = detlogger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _ciRepository = ciRepository;
            _detRepository = detRepository;
            _aRepository = aRepository;
            _ebRepository = ebRepository;
            _ebDestRepository = ebDestRepository;
            _elRepository = elRepository;
            _elDestRepository = elDestRepository;
            _ajRepository = ajRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioEnc request, string userId, int id)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //Comprobación de privilegio para crear encabezados de movimientos de inventario
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear movimientos de inventario.");
                    response.Success = false;
                    return response;
                }

                //Actualización de consecutivo
                if (request.ConsecutivoId != null)
                {
                    int _consecutivoId;
                    _consecutivoId = (int)request.ConsecutivoId;
                    var BuscarIdConsecutivo = await _ciRepository.GetByIdAsync(_consecutivoId);
                    AplicacionDocActual = BuscarIdConsecutivo.SiguienteConsec;
                    var ciresponse = new BaseResponseGeneric<int>();

                    try
                    {
                        ciresponse.Result = await _ciRepository.UpdateAsync(new ConsecutivoInv
                        {
                            Id = BuscarIdConsecutivo.Id,
                            CodConsecutivo = BuscarIdConsecutivo.CodConsecutivo,
                            UltimoUsuario = BuscarIdConsecutivo.UltimoUsuario,
                            Descripcion = BuscarIdConsecutivo.Descripcion,
                            Mascara = BuscarIdConsecutivo.Mascara,
                            SiguienteConsec = SigConsecutivo(BuscarIdConsecutivo.SiguienteConsec),
                            Editable = BuscarIdConsecutivo.Editable,
                            MultiplesTrans = BuscarIdConsecutivo.MultiplesTrans,
                            FormatoImp = BuscarIdConsecutivo.FormatoImp,
                            UltFechaHora = BuscarIdConsecutivo.UltFechaHora,
                            TodasTrans = BuscarIdConsecutivo.TodasTrans,
                            Tipo = BuscarIdConsecutivo.Tipo,
                            UsaTraslado = BuscarIdConsecutivo.UsaTraslado,
                            EmailCFDI = BuscarIdConsecutivo.EmailCFDI,
                            IsDeleted = BuscarIdConsecutivo.IsDeleted,
                            Updatedby = userId,
                            UpdateDate = DateTime.Now,
                            Createdby = BuscarIdConsecutivo.Createdby,
                            CreateDate = BuscarIdConsecutivo.CreateDate,
                        });

                        ciresponse.Success = true;

                    }  //Fin del try del consecutivo

                    catch (Exception ex)
                    {
                        _logger.LogCritical(ex.StackTrace);
                        ciresponse.Success = false;
                        ciresponse.Errors.Add(ex.Message);
                    }  //Fin del catch del consecutivo

                } //Fin del if (ConsecutivoId != null)

                //Comprobación de que el código de movimiento a utilizar no ha sido utilizado aún.
                var buscarIdMovInventarioEnc = await _repository.BuscarIdMovInventarioEncAsync(id) ;
                if (buscarIdMovInventarioEnc != null)
                {
                    throw new Exception($"El código de movimiento de inventario {buscarIdMovInventarioEnc.Id} ya existe.");
                }

                // Ejecución de la inserción del registro en la tabla de encabezados de movimientos.
                response.Result = await _repository.CreateAsync(new MovInventarioEnc
                {
                    Id = request.Id,
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Aplicacion = AplicacionDocActual,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento, 
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now
                });
                response.Success = true;


                //***************************Inserción detalle de movimientos ********************************************************
                CorrelativoLinea = 0;


                foreach (var linea in request.Detalle)
                {
                    var buscarArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);

                    // Si el artículo no es de tipo servicio, ni kit, se realizan los cambios.
                    if (buscarArticulo.Tipo == "V" || buscarArticulo.Tipo == "K")
                    {
                        //throw new Exception($"El artículo {buscarArticulo.CodArticulo} es de tipo SERVICIO o KIT.");
                    }

                    CostoUnitUltimoLoc = decimal.Round((linea.CostoTotLoc / linea.Cantidad), 8);
                    CostoUnitUltimoDol = decimal.Round((linea.CostoTotDol / linea.Cantidad), 8);

                    // Si llegó hasta acá es porque el artículo NO es de tipo servicio ni kit.
                    // Por lo que se inicia la validación del tipo de AjusteConfig dentro de un switch.

                    var buscarTipoAjusteConfig = await _ajRepository.GetByIdAsync((int)linea.AjusteConfigId);
                    strTipoAjusteConfig = buscarTipoAjusteConfig.AjusteBase;
                    strSubtipo = linea.Subtipo;
                    strSubsubtipo = linea.Subsubtipo;
                    strNaturaleza = linea.Naturaleza;

                    CorrelativoLinea++;

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
                        { 
                            switch (strSubtipo)
                            {
                                case "C": // Cuarentena
                                    throw new Exception($"El ajuste es de tipo Físico, Cuarentena.");
                                case "D": // Disponible
                                    { 
                                        if (strNaturaleza == "E")  // Es entrada
                                        {

                                                // 1/4 Creación de registro en Detalle de Movimiento de Inventario 
                                                var detresponse = new BaseResponseGeneric<int>();
                                                detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                {
                                                    MovInventarioEncId = response.Result,
                                                    Consecutivo = CorrelativoLinea,
                                                    FechaHoraTransac = DateTime.Now,
                                                    DocTributarioId = linea.DocTributarioId,
                                                    AjusteConfigId = linea.AjusteConfigId,
                                                    ArticuloId = linea.ArticuloId,
                                                    BodegaId = linea.BodegaId,
                                                    LocalizacionId = linea.LocalizacionId,
                                                    LoteId = linea.LoteId,
                                                    Tipo = linea.Tipo,
                                                    Subtipo = linea.Subtipo,
                                                    Subsubtipo = linea.Subsubtipo,
                                                    Naturaleza = linea.Naturaleza,
                                                    Cantidad = linea.Cantidad,
                                                    CostoTotLoc = linea.CostoTotLoc,
                                                    CostoTotDol = linea.CostoTotDol,
                                                    PrecioTotalLocal = linea.PrecioTotalLocal,
                                                    PrecioTotalDolar = linea.PrecioTotalDolar,
                                                    Contabilizada = linea.Contabilizada,
                                                    Fecha = linea.Fecha,
                                                    CentroCuentaId = linea.CentroCuentaId,
                                                    UnidadDistribucionId = linea.UnidadDistribucionId,
                                                    AsientoCardex = linea.AsientoCardex,
                                                    DocFiscal = linea.DocFiscal,
                                                    TipoOperacionId = linea.TipoOperacionId,
                                                    TipoPagoId = linea.TipoPagoId,
                                                    IsDeleted = false,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    Createdby = userId,
                                                    CreateDate = DateTime.Now
                                                });  //Fin del create en la tabla MovsInventarioDet - Físico, Entrada.

                                                detresponse.Success = true;

                                                // 2/4 Se actualiza el registro correspondiente en la tabla Articulos


                                                var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                var aresponse = new BaseResponseGeneric<int>();


                                                try  //Inicio try del Articulo
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
                                                        CostoLoc = buscarIdArticulo.CostoLoc,
                                                        CostoDol = buscarIdArticulo.CostoDol,
                                                        CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                        CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
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
                                                var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                var ebresponse = new BaseResponseGeneric<int>();
                                                try  // Inicio try de ExistenciaBodega
                                                {
                                                    ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                    {
                                                        Id = buscarIdExistenciaBodega.Id,
                                                        ArticuloId = linea.ArticuloId,
                                                        BodegaId = (int)linea.BodegaId,
                                                        CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + linea.Cantidad,
                                                        CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                                                        CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
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
                                                } // Fin del catch-try de ExistenciaBodega

                                                // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote
                                                if (buscarArticulo.UsaLotes)
                                                {
                                                    var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                    var elresponse = new BaseResponseGeneric<int>();
                                                    try  //Inicio del try de ExistenciaLote
                                                    {

                                                        elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                        {
                                                            Id = buscarExistenciaLote.Id,
                                                            BodegaId = buscarExistenciaLote.BodegaId,
                                                            ArticuloId = buscarExistenciaLote.ArticuloId,
                                                            LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                            LoteId = buscarExistenciaLote.LoteId,
                                                            CantDisponible = buscarExistenciaLote.CantDisponible + linea.Cantidad,
                                                            CantReservada = buscarExistenciaLote.CantReservada,
                                                            CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                            CantRemitida = buscarExistenciaLote.CantRemitida,
                                                            CantVencida = buscarExistenciaLote.CantVencida,
                                                            CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                                            CostoUntDol = buscarExistenciaLote.CostoUntDol,
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
                                                    }  // Fin del catch-try de ExistenciaLote

                                                } // Fin del if UsaLotes
                                            } // Fin del if es Naturaleza = E

                                            else  // Es salida (Físico)
                                            {

                                                // 1/4 Creación de registro en Detalle de Movimiento de Inventario 
                                                var detresponse = new BaseResponseGeneric<int>();
                                                detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                {
                                                    MovInventarioEncId = response.Result,
                                                    Consecutivo = CorrelativoLinea,
                                                    FechaHoraTransac = DateTime.Now,
                                                    DocTributarioId = linea.DocTributarioId,
                                                    AjusteConfigId = linea.AjusteConfigId,
                                                    ArticuloId = linea.ArticuloId,
                                                    BodegaId = linea.BodegaId,
                                                    LocalizacionId = linea.LocalizacionId,
                                                    LoteId = linea.LoteId,
                                                    Tipo = linea.Tipo,
                                                    Subtipo = linea.Subtipo,
                                                    Subsubtipo = linea.Subsubtipo,
                                                    Naturaleza = linea.Naturaleza,
                                                    Cantidad = linea.Cantidad * -1,
                                                    CostoTotLoc = linea.CostoTotLoc,
                                                    CostoTotDol = linea.CostoTotDol,
                                                    PrecioTotalLocal = linea.PrecioTotalLocal,
                                                    PrecioTotalDolar = linea.PrecioTotalDolar,
                                                    Contabilizada = linea.Contabilizada,
                                                    Fecha = linea.Fecha,
                                                    CentroCuentaId = linea.CentroCuentaId,
                                                    UnidadDistribucionId = linea.UnidadDistribucionId,
                                                    AsientoCardex = linea.AsientoCardex,
                                                    DocFiscal = linea.DocFiscal,
                                                    TipoOperacionId = linea.TipoOperacionId,
                                                    TipoPagoId = linea.TipoPagoId,
                                                    IsDeleted = false,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    Createdby = userId,
                                                    CreateDate = DateTime.Now
                                                });  //Fin del create en la tabla MovsInventarioDet - Físico, Entrada.

                                                detresponse.Success = true;

                                                // 2/4 Se actualiza el registro correspondiente en la tabla Articulos


                                                var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                var aresponse = new BaseResponseGeneric<int>();


                                                try  //Inicio try del Articulo
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
                                                        CostoLoc = buscarIdArticulo.CostoLoc,
                                                        CostoDol = buscarIdArticulo.CostoDol,
                                                        CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                        CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
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
                                                var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                var ebresponse = new BaseResponseGeneric<int>();
                                                try  // Inicio try de ExistenciaBodega
                                                {
                                                    ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                    {
                                                        Id = buscarIdExistenciaBodega.Id,
                                                        ArticuloId = linea.ArticuloId,
                                                        BodegaId = (int)linea.BodegaId,
                                                        CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible - linea.Cantidad,
                                                        CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                                                        CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
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
                                                } // Fin del catch-try de ExistenciaBodega

                                                // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote
                                                if (buscarArticulo.UsaLotes)
                                                {
                                                    var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                    var elresponse = new BaseResponseGeneric<int>();
                                                    try  //Inicio del try de ExistenciaLote
                                                    {

                                                        elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                        {
                                                            Id = buscarExistenciaLote.Id,
                                                            BodegaId = buscarExistenciaLote.BodegaId,
                                                            ArticuloId = buscarExistenciaLote.ArticuloId,
                                                            LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                            LoteId = buscarExistenciaLote.LoteId,
                                                            CantDisponible = buscarExistenciaLote.CantDisponible - linea.Cantidad,
                                                            CantReservada = buscarExistenciaLote.CantReservada,
                                                            CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                            CantRemitida = buscarExistenciaLote.CantRemitida,
                                                            CantVencida = buscarExistenciaLote.CantVencida,
                                                            CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                                            CostoUntDol = buscarExistenciaLote.CostoUntDol,
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
                                                    }  // Fin del catch-try de ExistenciaLote

                                                } // Fin del if UsaLotes

                                            }
                                    }
                                    break;

                                case "I": // Remitida
                                    throw new Exception($"El ajuste es de tipo Físico, Remitida.");
                                case "V":  //Vencida
                                    throw new Exception($"El ajuste es de tipo Físico, Vencida.");
                            };

                            break;

                        };


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
                                                var detresponse = new BaseResponseGeneric<int>();
                                                detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                {
                                                    MovInventarioEncId = response.Result,
                                                    Consecutivo = CorrelativoLinea,
                                                    FechaHoraTransac = DateTime.Now,
                                                    DocTributarioId = linea.DocTributarioId,
                                                    AjusteConfigId = linea.AjusteConfigId,
                                                    ArticuloId = linea.ArticuloId,
                                                    BodegaId = linea.BodegaId,
                                                    LocalizacionId = linea.LocalizacionId,
                                                    LoteId = linea.LoteId,
                                                    Tipo = linea.Tipo,
                                                    Subtipo = linea.Subtipo,
                                                    Subsubtipo = linea.Subsubtipo,
                                                    Naturaleza = linea.Naturaleza,
                                                    Cantidad = linea.Cantidad,
                                                    CostoTotLoc = linea.CostoTotLoc,
                                                    CostoTotDol = linea.CostoTotDol,
                                                    PrecioTotalLocal = linea.PrecioTotalLocal,
                                                    PrecioTotalDolar = linea.PrecioTotalDolar,
                                                    Contabilizada = linea.Contabilizada,
                                                    Fecha = linea.Fecha,
                                                    CentroCuentaId = linea.CentroCuentaId,
                                                    UnidadDistribucionId = linea.UnidadDistribucionId,
                                                    AsientoCardex = linea.AsientoCardex,
                                                    DocFiscal = linea.DocFiscal,
                                                    TipoOperacionId = linea.TipoOperacionId,
                                                    TipoPagoId = linea.TipoPagoId,
                                                    IsDeleted = false,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    Createdby = userId,
                                                    CreateDate = DateTime.Now
                                                });  //Fin del create en la tabla MovsInventarioDet - Compras Locales

                                                detresponse.Success = true;


                                                // 2/4 Se actualiza el registro correspondiente en la tabla Articulos
                                                var Existencias = await _ebRepository.BuscarExistenciaXArticulo(linea.ArticuloId);
                                                decExistenciaTotal = 0;
                                                foreach (var Existencia in Existencias)
                                                {
                                                    decExistenciaTotal += Existencia.CantDisponible;
                                                }

                                                var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                var aresponse = new BaseResponseGeneric<int>();
                                                     
                                                CostoPromLocArt = DecCostoPromLocArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoLoc, CostoUnitUltimoLoc);
                                                CostoPromDolArt = DecCostoPromDolArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoDol, CostoUnitUltimoDol);

                                                try  //Inicio try del Articulo
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
                                                var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                var ebresponse = new BaseResponseGeneric<int>();
                                                try  // Inicio try de ExistenciaBodega
                                                {
                                                    ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                    {
                                                        Id = buscarIdExistenciaBodega.Id,
                                                        ArticuloId = linea.ArticuloId,
                                                        BodegaId = (int)linea.BodegaId,
                                                        CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + linea.Cantidad,
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
                                                } // Fin del catch-try de ExistenciaBodega


                                                // 3b/4 Actualización de costo promedio en todos los registros de ExistenciaBodega que corresponden al artículo
                                                foreach (var Existencia in Existencias)
                                                {
                                                    if (Existencia.CantDisponible == 0)
                                                    {
                                                        CostoExistenciaBodegaLoc = 0;
                                                        CostoExistenciaBodegaDol = 0;
                                                    }
                                                    else
                                                    {
                                                        CostoExistenciaBodegaLoc = CostoPromLocArt;
                                                        CostoExistenciaBodegaDol = CostoPromDolArt;
                                                    }

                                                    var ExisArticuloResponse = new BaseResponseGeneric<int>();

                                                    try  // Inicio try de ExistenciaBodega
                                                    {
                                                        ExisArticuloResponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                        {
                                                            Id = Existencia.Id,
                                                            ArticuloId = Existencia.ArticuloId,
                                                            BodegaId = Existencia.BodegaId,
                                                            CantDisponible = Existencia.CantDisponible,
                                                            CostoUntPromedioLoc = CostoExistenciaBodegaLoc,
                                                            CostoUntPromedioDol = CostoPromDolArt,
                                                            Updatedby = userId,
                                                            UpdateDate = DateTime.Now,
                                                            FechaCong = Existencia.FechaCong,
                                                            ExistenciaMinima = Existencia.ExistenciaMinima,
                                                            ExistenciaMaxima = Existencia.ExistenciaMaxima,
                                                            PuntoDeOrden = Existencia.PuntoDeOrden,
                                                            CantReservada = Existencia.CantReservada,
                                                            CantNoAprobada = Existencia.CantNoAprobada,
                                                            CantVencida = Existencia.CantVencida,
                                                            CantTransito = Existencia.CantTransito,
                                                            CantProduccion = Existencia.CantProduccion,
                                                            CantPedida = Existencia.CantPedida,
                                                            CantRemitida = Existencia.CantRemitida,
                                                            Congelado = Existencia.Congelado,
                                                            BloqueaTrans = Existencia.BloqueaTrans,
                                                            FechaDescong = Existencia.FechaDescong,
                                                            IsDeleted = Existencia.IsDeleted,
                                                            Createdby = Existencia.Createdby,
                                                            CreateDate = Existencia.CreateDate,

                                                        });

                                                        ExisArticuloResponse.Success = true;
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        _logger.LogCritical(ex.StackTrace);
                                                        ExisArticuloResponse.Success = false;
                                                        ExisArticuloResponse.Errors.Add(ex.Message);
                                                    }
                                                }

                                                // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote
                                                if (buscarArticulo.UsaLotes)
                                                {
                                                    var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                    var elresponse = new BaseResponseGeneric<int>();
                                                    try  //Inicio del try de ExistenciaLote
                                                    {

                                                        elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                        {
                                                            Id = buscarExistenciaLote.Id,
                                                            BodegaId = buscarExistenciaLote.BodegaId,
                                                            ArticuloId = buscarExistenciaLote.ArticuloId,
                                                            LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                            LoteId = buscarExistenciaLote.LoteId,
                                                            CantDisponible = buscarExistenciaLote.CantDisponible + linea.Cantidad,
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

                                                    // 4b/4 Actualizar el costo promedio en los registros de ExistenciaLote que corresponden al artículo
                                                    var LoteExistencias = await _elRepository.BuscarExistenciaXArticulo(linea.ArticuloId);
                                                    var LoteExisResponse = new BaseResponseGeneric<int>();
                                                    foreach (var LoteExistencia in LoteExistencias)
                                                    {

                                                        try  //Inicio del try para actualizar todos los registros de ExistenciaLote que corresponden al artículo
                                                        {
                                                            if (LoteExistencia.CantDisponible == 0)
                                                            {
                                                                CostoExistenciaLoteLoc = 0;
                                                                CostoExistenciaLoteDol = 0;
                                                            }
                                                            else
                                                            {
                                                                CostoExistenciaLoteLoc = CostoPromLocArt;
                                                                CostoExistenciaLoteDol = CostoPromDolArt;
                                                            }

                                                            LoteExisResponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                            {
                                                                Id = LoteExistencia.Id,
                                                                BodegaId = LoteExistencia.BodegaId,
                                                                ArticuloId = LoteExistencia.ArticuloId,
                                                                LocalizacionId = LoteExistencia.LocalizacionId,
                                                                LoteId = LoteExistencia.LoteId,
                                                                CantDisponible = LoteExistencia.CantDisponible ,
                                                                CantReservada = LoteExistencia.CantReservada,
                                                                CantNoAprobada = LoteExistencia.CantNoAprobada,
                                                                CantRemitida = LoteExistencia.CantRemitida,
                                                                CantVencida = LoteExistencia.CantVencida,
                                                                CostoUntLoc = CostoExistenciaLoteLoc,
                                                                CostoUntDol = CostoExistenciaLoteDol,
                                                                IsDeleted = LoteExistencia.IsDeleted,
                                                                Updatedby = userId,
                                                                UpdateDate = DateTime.Now,
                                                                Createdby = LoteExistencia.Createdby,
                                                                CreateDate = LoteExistencia.CreateDate
                                                            });
                                                            LoteExisResponse.Success = true;
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            _logger.LogCritical(ex.StackTrace);
                                                            LoteExisResponse.Success = false;
                                                            LoteExisResponse.Errors.Add(ex.Message);
                                                        }  // Fin del catch-try para actualización de todos los registros en ExistenciaLote que corresponden al artículo
                                                    } //Fin del foreach para barrer la collection de ExistenciaLote que corresponde al artículo
                                                }  //Fin del if "usa lotes"

                                                break;

                                            }  //Fin del if "Naturaleza = "E"

                                            else // Es salida
                                            {

                                                // **** DEVOLUCION DE COMPRA LOCAL

                                                // 1/4 Creación de registro en Detalle de Movimiento de Inventario
                                                var detresponse = new BaseResponseGeneric<int>();
                                                detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                {
                                                    MovInventarioEncId = response.Result,
                                                    Consecutivo = CorrelativoLinea,
                                                    FechaHoraTransac = DateTime.Now,
                                                    DocTributarioId = linea.DocTributarioId,
                                                    AjusteConfigId = linea.AjusteConfigId,
                                                    ArticuloId = linea.ArticuloId,
                                                    BodegaId = linea.BodegaId,
                                                    LocalizacionId = linea.LocalizacionId,
                                                    LoteId = linea.LoteId,
                                                    Tipo = linea.Tipo,
                                                    Subtipo = linea.Subtipo,
                                                    Subsubtipo = linea.Subsubtipo,
                                                    Naturaleza = linea.Naturaleza,
                                                    Cantidad = linea.Cantidad * -1,
                                                    CostoTotLoc = linea.CostoTotLoc,
                                                    CostoTotDol = linea.CostoTotDol,
                                                    PrecioTotalLocal = linea.PrecioTotalLocal,
                                                    PrecioTotalDolar = linea.PrecioTotalDolar,
                                                    Contabilizada = linea.Contabilizada,
                                                    Fecha = linea.Fecha,
                                                    CentroCuentaId = linea.CentroCuentaId,
                                                    UnidadDistribucionId = linea.UnidadDistribucionId,
                                                    AsientoCardex = linea.AsientoCardex,
                                                    DocFiscal = linea.DocFiscal,
                                                    TipoOperacionId = linea.TipoOperacionId,
                                                    TipoPagoId = linea.TipoPagoId,
                                                    IsDeleted = false,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    Createdby = userId,
                                                    CreateDate = DateTime.Now
                                                });  //Fin del create en la tabla MovsInventarioDet

                                                detresponse.Success = true;

                                                // 2/4 Se actualiza el registro correspondiente en la tabla Articulos
                                                var Existencias = await _ebRepository.BuscarExistenciaXArticulo(linea.ArticuloId);
                                                decExistenciaTotal = 0;
                                                foreach (var Existencia in Existencias)
                                                {
                                                    decExistenciaTotal += Existencia.CantDisponible;
                                                }

                                                var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                var aresponse = new BaseResponseGeneric<int>();

                                                CostoPromLocArt = DecCostoPromLocArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoLoc, CostoUnitUltimoLoc);
                                                CostoPromDolArt = DecCostoPromDolArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoDol, CostoUnitUltimoDol);

                                                try  //Inicio try del Articulo
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
                                                        Bultos = buscarIdArticulo.Bultos,
                                                        CostoLoc = buscarIdArticulo.CostoLoc,
                                                        CostoDol = buscarIdArticulo.CostoDol,
                                                        CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                        CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
                                                        UltimoIngreso = buscarIdArticulo.UltimoIngreso,
                                                        UltimaSalida = DateTime.Now,
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
                                                var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                if (buscarIdExistenciaBodega.CantDisponible - linea.Cantidad == 0)
                                                {
                                                    CostoExistenciaBodegaLoc = 0;
                                                    CostoExistenciaBodegaDol = 0;
                                                }
                                                else
                                                {
                                                    CostoExistenciaBodegaLoc = CostoPromLocArt;
                                                    CostoExistenciaBodegaDol = CostoPromDolArt;
                                                }

                                                var ebresponse = new BaseResponseGeneric<int>();
                                                try  // Inicio try de ExistenciaBodega
                                                {
                                                    ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                    {
                                                        Id = buscarIdExistenciaBodega.Id,
                                                        ArticuloId = linea.ArticuloId,
                                                        BodegaId = (int)linea.BodegaId,
                                                        CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible - linea.Cantidad,
                                                        CostoUntPromedioLoc = CostoExistenciaBodegaLoc,
                                                        CostoUntPromedioDol = CostoExistenciaBodegaDol,
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
                                                } // Fin del catch-try de ExistenciaBodega

                                                // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote
                                                if (buscarArticulo.UsaLotes)
                                                {
                                                    var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                    var elresponse = new BaseResponseGeneric<int>();
                                                    try  //Inicio del try de ExistenciaLote
                                                    {
                                                        if (buscarExistenciaLote.CantDisponible - linea.Cantidad == 0)
                                                        {
                                                            CostoExistenciaLoteLoc = 0;
                                                            CostoExistenciaLoteDol = 0;
                                                        }
                                                        else
                                                        {
                                                            CostoExistenciaLoteLoc = CostoPromLocArt;
                                                            CostoExistenciaLoteDol = CostoPromDolArt;
                                                        }

                                                        elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                        {
                                                            Id = buscarExistenciaLote.Id,
                                                            BodegaId = buscarExistenciaLote.BodegaId,
                                                            ArticuloId = buscarExistenciaLote.ArticuloId,
                                                            LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                            LoteId = buscarExistenciaLote.LoteId,
                                                            CantDisponible = buscarExistenciaLote.CantDisponible - linea.Cantidad,
                                                            CantReservada = buscarExistenciaLote.CantReservada,
                                                            CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                            CantRemitida = buscarExistenciaLote.CantRemitida,
                                                            CantVencida = buscarExistenciaLote.CantVencida,
                                                            CostoUntLoc = CostoExistenciaLoteLoc,
                                                            CostoUntDol = CostoExistenciaLoteDol,
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
                                                }  //Fin del if "Usa Lotes" (Compras-Dev)
                                                break;
                                            }  //Fin del else-if "Naturaleza = "E"


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

                            }  //Termina el case para TipoAjuste= "O"

                        // 9/13 - Producción
                        case "P":
                            throw new Exception($"El ajuste es de tipo Producción.");

                        // 10/13 - Reservación
                        case "R":
                            throw new Exception($"El ajuste es de tipo Reservación.");

                        // 11/13 - Costo ****************
                        case "S":
  
                            // 1/4 Creación de registro en Detalle de Movimiento de Inventario - Costo
                            var detresponseCosto = new BaseResponseGeneric<int>();
                            detresponseCosto.Result = await _detRepository.CreateAsync(new MovInventarioDet
                            {
                                MovInventarioEncId = response.Result,
                                Consecutivo = CorrelativoLinea,
                                FechaHoraTransac = DateTime.Now,
                                DocTributarioId = linea.DocTributarioId,
                                AjusteConfigId = linea.AjusteConfigId,
                                ArticuloId = linea.ArticuloId,
                                BodegaId = linea.BodegaId,
                                LocalizacionId = linea.LocalizacionId,
                                LoteId = linea.LoteId,
                                Tipo = linea.Tipo,
                                Subtipo = linea.Subtipo,
                                Subsubtipo = linea.Subsubtipo,
                                Naturaleza = linea.Naturaleza,
                                Cantidad = 1,
                                CostoTotLoc = linea.CostoTotLoc,
                                CostoTotDol = linea.CostoTotDol,
                                PrecioTotalLocal = linea.PrecioTotalLocal,
                                PrecioTotalDolar = linea.PrecioTotalDolar,
                                Contabilizada = linea.Contabilizada,
                                Fecha = linea.Fecha,
                                CentroCuentaId = linea.CentroCuentaId,
                                UnidadDistribucionId = linea.UnidadDistribucionId,
                                AsientoCardex = linea.AsientoCardex,
                                DocFiscal = linea.DocFiscal,
                                TipoOperacionId = linea.TipoOperacionId,
                                TipoPagoId = linea.TipoPagoId,
                                IsDeleted = false,
                                Updatedby = userId,
                                UpdateDate = DateTime.Now,
                                Createdby = userId,
                                CreateDate = DateTime.Now
                            });  //Fin del create en la tabla MovsInventarioDet - Costo

                            detresponseCosto.Success = true;

                            var aresponseCosto = new BaseResponseGeneric<int>();
                            try  //Inicio try del Articulo - Costo
                            {
                                var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                aresponseCosto.Result = await _aRepository.UpdateAsync(new Articulo
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
                                    Bultos = buscarIdArticulo.Bultos,
                                    CostoLoc = buscarIdArticulo.CostoLoc,
                                    CostoDol = buscarIdArticulo.CostoDol,
                                    CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                    CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
                                    UltimoIngreso = buscarIdArticulo.UltimoIngreso,
                                    UltimoMovimiento = buscarIdArticulo.UltimoMovimiento,
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

                                aresponseCosto.Success = true;
                            }
                            catch (Exception ex)
                            {
                                _logger.LogCritical(ex.StackTrace);
                                aresponseCosto.Success = false;
                                aresponseCosto.Errors.Add(ex.Message);

                            }  // Fin del try del Articulo - Costo


                            // 3/4 Se actualiza el registro existente en la tabla ExistenciaBodega  - Costo
                            var EBCosto = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                            var ebresponseCosto = new BaseResponseGeneric<int>();
                            try  // Inicio try de ExistenciaBodega
                            {
                                ebresponseCosto.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                {
                                    Id = EBCosto.Id,
                                    ArticuloId = linea.ArticuloId,
                                    BodegaId = (int)linea.BodegaId,
                                    CantDisponible = EBCosto.CantDisponible,
                                    CostoUntPromedioLoc = EBCosto.CostoUntPromedioLoc,
                                    CostoUntPromedioDol = EBCosto.CostoUntPromedioDol,
                                    Updatedby = userId,
                                    UpdateDate = DateTime.Now,
                                    FechaCong = EBCosto.FechaCong,
                                    ExistenciaMinima = EBCosto.ExistenciaMinima,
                                    ExistenciaMaxima = EBCosto.ExistenciaMaxima,
                                    PuntoDeOrden = EBCosto.PuntoDeOrden,
                                    CantReservada = EBCosto.CantReservada,
                                    CantNoAprobada = EBCosto.CantNoAprobada,
                                    CantVencida = EBCosto.CantVencida,
                                    CantTransito = EBCosto.CantTransito,
                                    CantProduccion = EBCosto.CantProduccion,
                                    CantPedida = EBCosto.CantPedida,
                                    CantRemitida = EBCosto.CantRemitida,
                                    Congelado = EBCosto.Congelado,
                                    BloqueaTrans = EBCosto.BloqueaTrans,
                                    FechaDescong = EBCosto.FechaDescong,
                                    IsDeleted = EBCosto.IsDeleted,
                                    Createdby = EBCosto.Createdby,
                                    CreateDate = EBCosto.CreateDate,

                                });

                                ebresponseCosto.Success = true;
                            }
                            catch (Exception ex)
                            {
                                _logger.LogCritical(ex.StackTrace);
                                ebresponseCosto.Success = false;
                                ebresponseCosto.Errors.Add(ex.Message);
                            } // Fin del catch-try de ExistenciaBodega - Costo

                            // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote - Costo
                            if (buscarArticulo.UsaLotes)
                            {
                                var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                var elresponse = new BaseResponseGeneric<int>();
                                try  //Inicio del try de ExistenciaLote
                                {

                                    elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                    {
                                        Id = buscarExistenciaLote.Id,
                                        BodegaId = buscarExistenciaLote.BodegaId,
                                        ArticuloId = buscarExistenciaLote.ArticuloId,
                                        LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                        LoteId = buscarExistenciaLote.LoteId,
                                        CantDisponible = buscarExistenciaLote.CantDisponible,
                                        CantReservada = buscarExistenciaLote.CantReservada,
                                        CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                        CantRemitida = buscarExistenciaLote.CantRemitida,
                                        CantVencida = buscarExistenciaLote.CantVencida,
                                        CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                        CostoUntDol = buscarExistenciaLote.CostoUntDol,
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
                                }  // Fin del catch-try de ExistenciaLote - Costo
                            }  // Fin del if UsaLotes - Costo
                            
                            break;

                        // 12/13 - Traslado ****************
                        case "T":
                        { 
                            switch (strSubsubtipo)
                            {
                                    case "D": // Disponible
                                     //throw new Exception($"El ajuste es de tipo Traslado, Disponible.");

                                    // 1a/4 Creación de registro de salida en Detalle de Movimiento de Inventario - Traslado
                                        var detresponseSalida = new BaseResponseGeneric<int>();
                                        detresponseSalida.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                        {
                                            MovInventarioEncId = response.Result,
                                            Consecutivo = CorrelativoLinea,
                                            FechaHoraTransac = DateTime.Now,
                                            DocTributarioId = linea.DocTributarioId,
                                            AjusteConfigId = linea.AjusteConfigId,
                                            ArticuloId = linea.ArticuloId,
                                            BodegaId = linea.BodegaId,
                                            LocalizacionId = linea.LocalizacionId,
                                            LoteId = linea.LoteId,
                                            Tipo = linea.Tipo,
                                            Subtipo = linea.Subtipo,
                                            Subsubtipo = linea.Subsubtipo,
                                            Naturaleza = linea.Naturaleza,
                                            Cantidad = linea.Cantidad * -1,
                                            CostoTotLoc = linea.CostoTotLoc,
                                            CostoTotDol = linea.CostoTotDol,
                                            PrecioTotalLocal = linea.PrecioTotalLocal,
                                            PrecioTotalDolar = linea.PrecioTotalDolar,
                                            Contabilizada = linea.Contabilizada,
                                            Fecha = linea.Fecha,
                                            CentroCuentaId = linea.CentroCuentaId,
                                            UnidadDistribucionId = linea.UnidadDistribucionId,
                                            AsientoCardex = linea.AsientoCardex,
                                            DocFiscal = linea.DocFiscal,
                                            TipoOperacionId = linea.TipoOperacionId,
                                            TipoPagoId = linea.TipoPagoId,
                                            IsDeleted = false,
                                            Updatedby = userId,
                                            UpdateDate = DateTime.Now,
                                            Createdby = userId,
                                            CreateDate = DateTime.Now
                                        });  //Fin del create en la tabla MovsInventarioDet - Traslado, Salida.

                                        // 1b/4 Creación de registro de entrada en Detalle de Movimiento de Inventario - Traslado
                                        var detresponseEntrada = new BaseResponseGeneric<int>();
                                        detresponseEntrada.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                        {
                                            MovInventarioEncId = response.Result,
                                            Consecutivo = CorrelativoLinea,
                                            FechaHoraTransac = DateTime.Now,
                                            DocTributarioId = linea.DocTributarioId,
                                            AjusteConfigId = linea.AjusteConfigId,
                                            ArticuloId = linea.ArticuloId,
                                            BodegaId = linea.BodegaDestinoId,
                                            LocalizacionId = linea.LocDestinoId,
                                            LoteId = linea.LoteDestinoId,
                                            Tipo = linea.Tipo,
                                            Subtipo = linea.Subtipo,
                                            Subsubtipo = linea.Subsubtipo,
                                            Naturaleza = linea.Naturaleza,
                                            Cantidad = linea.Cantidad,
                                            CostoTotLoc = linea.CostoTotLoc,
                                            CostoTotDol = linea.CostoTotDol,
                                            PrecioTotalLocal = linea.PrecioTotalLocal,
                                            PrecioTotalDolar = linea.PrecioTotalDolar,
                                            Contabilizada = linea.Contabilizada,
                                            Fecha = linea.Fecha,
                                            CentroCuentaId = linea.CentroCuentaId,
                                            UnidadDistribucionId = linea.UnidadDistribucionId,
                                            AsientoCardex = linea.AsientoCardex,
                                            DocFiscal = linea.DocFiscal,
                                            TipoOperacionId = linea.TipoOperacionId,
                                            TipoPagoId = linea.TipoPagoId,
                                            IsDeleted = false,
                                            Updatedby = userId,
                                            UpdateDate = DateTime.Now,
                                            Createdby = userId,
                                            CreateDate = DateTime.Now
                                        });  //Fin del create en la tabla MovsInventarioDet - Traslado, Entrada.


                                        // 2/4 Se actualiza el registro correspondiente en la tabla Articulos

                                        var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                        var aresponse = new BaseResponseGeneric<int>();

                                                         try  //Inicio try del Articulo
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
                                                Bultos = buscarIdArticulo.Bultos,
                                                CostoLoc = buscarIdArticulo.CostoLoc,
                                                CostoDol = buscarIdArticulo.CostoDol,
                                                CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
                                                UltimoIngreso = buscarIdArticulo.UltimoIngreso,
                                                UltimaSalida = buscarIdArticulo.UltimaSalida,
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
                                        }  // Fin del try del Articulo - Traslado


                                        // 3a/4 Se actualiza el registro existente en la tabla ExistenciaBodega - Traslado, Bodega Origen

                                        var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                        if (buscarIdExistenciaBodega.CantDisponible - linea.Cantidad == 0)
                                        {
                                            CostoExistenciaBodegaLoc = 0;
                                            CostoExistenciaBodegaDol = 0;
                                        }
                                        else
                                        {
                                            CostoExistenciaBodegaLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc;
                                            CostoExistenciaBodegaDol = buscarIdExistenciaBodega.CostoUntPromedioDol;
                                        }

                                        var ebresponse = new BaseResponseGeneric<int>();
                                        try  // Inicio try de ExistenciaBodega
                                        {
                                            ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                            {
                                                Id = buscarIdExistenciaBodega.Id,
                                                ArticuloId = linea.ArticuloId,
                                                BodegaId = (int)linea.BodegaId,
                                                CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible - linea.Cantidad,
                                                CostoUntPromedioLoc = CostoExistenciaBodegaLoc,
                                                CostoUntPromedioDol = CostoExistenciaBodegaDol,
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
                                        } // Fin del catch-try de ExistenciaBodega - Traslado, Bodega Origen.


                                        // 3b/4 Se actualiza el registro existente en la tabla ExistenciaBodega - Traslado, Bodega Destino

                                        var buscarIdExistenciaBodegaDestino = await _ebDestRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaDestinoId);


                                        var ebDestinoresponse = new BaseResponseGeneric<int>();
                                        try  // Inicio try de ExistenciaBodega
                                        {
                                            ebDestinoresponse.Result = await _ebDestRepository.UpdateAsync(new ExistenciaBodega
                                            {
                                                Id = buscarIdExistenciaBodegaDestino.Id,
                                                ArticuloId = linea.ArticuloId,
                                                BodegaId = (int)linea.BodegaId,
                                                CantDisponible = (decimal)buscarIdExistenciaBodegaDestino.CantDisponible + linea.Cantidad,
                                                CostoUntPromedioLoc = buscarIdExistenciaBodegaDestino.CostoUntPromedioLoc,
                                                CostoUntPromedioDol = buscarIdExistenciaBodegaDestino.CostoUntPromedioDol,
                                                Updatedby = userId,
                                                UpdateDate = DateTime.Now,
                                                FechaCong = buscarIdExistenciaBodegaDestino.FechaCong,
                                                ExistenciaMinima = buscarIdExistenciaBodegaDestino.ExistenciaMinima,
                                                ExistenciaMaxima = buscarIdExistenciaBodegaDestino.ExistenciaMaxima,
                                                PuntoDeOrden = buscarIdExistenciaBodegaDestino.PuntoDeOrden,
                                                CantReservada = buscarIdExistenciaBodegaDestino.CantReservada,
                                                CantNoAprobada = buscarIdExistenciaBodegaDestino.CantNoAprobada,
                                                CantVencida = buscarIdExistenciaBodegaDestino.CantVencida,
                                                CantTransito = buscarIdExistenciaBodegaDestino.CantTransito,
                                                CantProduccion = buscarIdExistenciaBodegaDestino.CantProduccion,
                                                CantPedida = buscarIdExistenciaBodegaDestino.CantPedida,
                                                CantRemitida = buscarIdExistenciaBodegaDestino.CantRemitida,
                                                Congelado = buscarIdExistenciaBodegaDestino.Congelado,
                                                BloqueaTrans = buscarIdExistenciaBodegaDestino.BloqueaTrans,
                                                FechaDescong = buscarIdExistenciaBodegaDestino.FechaDescong,
                                                IsDeleted = buscarIdExistenciaBodegaDestino.IsDeleted,
                                                Createdby = buscarIdExistenciaBodegaDestino.Createdby,
                                                CreateDate = buscarIdExistenciaBodegaDestino.CreateDate,
                                            });

                                            ebDestinoresponse.Success = true;
                                        }
                                        catch (Exception ex)
                                        {
                                            _logger.LogCritical(ex.StackTrace);
                                            ebDestinoresponse.Success = false;
                                            ebDestinoresponse.Errors.Add(ex.Message);
                                        } // Fin del catch-try de ExistenciaBodega - Traslado, Bodega Destino.


                                        // 4/4 Si el artículo usa lotes, se actualiza el registro en la tabla ExistenciaLote, tanto para Origen como para Destino
                                        if (buscarArticulo.UsaLotes)
                                        {
                                            var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                            var elresponse = new BaseResponseGeneric<int>();
                                            try  //Inicio del try de ExistenciaLote - Origen
                                            {

                                                elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                {
                                                    Id = buscarExistenciaLote.Id,
                                                    BodegaId = buscarExistenciaLote.BodegaId,
                                                    ArticuloId = buscarExistenciaLote.ArticuloId,
                                                    LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                    LoteId = buscarExistenciaLote.LoteId,
                                                    CantDisponible = buscarExistenciaLote.CantDisponible - linea.Cantidad,
                                                    CantReservada = buscarExistenciaLote.CantReservada,
                                                    CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                    CantRemitida = buscarExistenciaLote.CantRemitida,
                                                    CantVencida = buscarExistenciaLote.CantVencida,
                                                    CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                                    CostoUntDol = buscarExistenciaLote.CostoUntDol,
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
                                            }  // Fin del catch-try de ExistenciaLote - Traslado, Origen


                                            var buscarExistenciaLoteDestino = await _elDestRepository.BuscarExistenciaLoteAsync((int)linea.BodegaDestinoId, linea.ArticuloId, (int)linea.LocDestinoId, (int)linea.LocDestinoId);
                                            var elDestresponse = new BaseResponseGeneric<int>();

                                            try  //Inicio del try de ExistenciaLote - Destino
                                            {

                                                elDestresponse.Result = await _elDestRepository.UpdateAsync(new ExistenciaLote
                                                {
                                                    Id = buscarExistenciaLoteDestino.Id,
                                                    BodegaId = buscarExistenciaLoteDestino.BodegaId,
                                                    ArticuloId = buscarExistenciaLoteDestino.ArticuloId,
                                                    LocalizacionId = buscarExistenciaLoteDestino.LocalizacionId,
                                                    LoteId = buscarExistenciaLoteDestino.LoteId,
                                                    CantDisponible = buscarExistenciaLoteDestino.CantDisponible + linea.Cantidad,
                                                    CantReservada = buscarExistenciaLoteDestino.CantReservada,
                                                    CantNoAprobada = buscarExistenciaLoteDestino.CantNoAprobada,
                                                    CantRemitida = buscarExistenciaLoteDestino.CantRemitida,
                                                    CantVencida = buscarExistenciaLoteDestino.CantVencida,
                                                    CostoUntLoc = buscarExistenciaLoteDestino.CostoUntLoc,
                                                    CostoUntDol = buscarExistenciaLoteDestino.CostoUntDol,
                                                    IsDeleted = buscarExistenciaLoteDestino.IsDeleted,
                                                    Updatedby = userId,
                                                    UpdateDate = DateTime.Now,
                                                    Createdby = buscarExistenciaLoteDestino.Createdby,
                                                    CreateDate = buscarExistenciaLoteDestino.CreateDate
                                                });
                                                elDestresponse.Success = true;
                                            }
                                            catch (Exception ex)
                                            {
                                                _logger.LogCritical(ex.StackTrace);
                                                elDestresponse.Success = false;
                                                elDestresponse.Errors.Add(ex.Message);
                                            }  // Fin del catch-try de ExistenciaLote - Traslado, Destino

                                        } // Fin del if UsaLotes - Traslado, ambas bodegas

                                       break;

                                    case "C": // Cuarentena
                                        throw new Exception($"El ajuste es de tipo Traslado, Cuarentena.");
                                    
                                    case "R": // Reservada
                                        throw new Exception($"El ajuste es de tipo Traslado, Reservada.");

                                    case "I": // Remitida
                                        throw new Exception($"El ajuste es de tipo Traslado, Remitida.");
                                    
                                    case "V":  //Vencida
                                        throw new Exception($"El ajuste es de tipo Traslado, Vencida.");

                            }
                            
                            break;
                        }



                        // 13/13 - Venta ******************
                        case "V":
                        { 
                            switch (strSubtipo)
                            {
                                case "D": // Disponible
                                    switch (strSubsubtipo)
                                    {
                                        case "L":  // ****Ventas Locales
                                        { 
                                            if (strNaturaleza == "S")
                                            {
                                                    // 1/4 Creación de registro en Detalle de Movimiento de Inventario
                                                    var detresponse = new BaseResponseGeneric<int>();
                                                    detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                    {
                                                        MovInventarioEncId = response.Result,
                                                        Consecutivo = CorrelativoLinea,
                                                        FechaHoraTransac = DateTime.Now,
                                                        DocTributarioId = linea.DocTributarioId,
                                                        AjusteConfigId = linea.AjusteConfigId,
                                                        ArticuloId = linea.ArticuloId,
                                                        BodegaId = linea.BodegaId,
                                                        LocalizacionId = linea.LocalizacionId,
                                                        LoteId = linea.LoteId,
                                                        Tipo = linea.Tipo,
                                                        Subtipo = linea.Subtipo,
                                                        Subsubtipo = linea.Subsubtipo,
                                                        Naturaleza = linea.Naturaleza,
                                                        Cantidad = linea.Cantidad,
                                                        CostoTotLoc = linea.CostoTotLoc,
                                                        CostoTotDol = linea.CostoTotDol,
                                                        PrecioTotalLocal = linea.PrecioTotalLocal,
                                                        PrecioTotalDolar = linea.PrecioTotalDolar,
                                                        Contabilizada = linea.Contabilizada,
                                                        Fecha = linea.Fecha,
                                                        CentroCuentaId = linea.CentroCuentaId,
                                                        UnidadDistribucionId = linea.UnidadDistribucionId,
                                                        AsientoCardex = linea.AsientoCardex,
                                                        DocFiscal = linea.DocFiscal,
                                                        TipoOperacionId = linea.TipoOperacionId,
                                                        TipoPagoId = linea.TipoPagoId,
                                                        IsDeleted = false,
                                                        Updatedby = userId,
                                                        UpdateDate = DateTime.Now,
                                                        Createdby = userId,
                                                        CreateDate = DateTime.Now
                                                    });  //Fin del create en la tabla MovsInventarioDet - Ventas Locales

                                                    detresponse.Success = true;

                                                    // 2/4 Se actualiza el registro correspondiente en la tabla Articulos - Ventas Locales
                                                    var Existencias = await _ebRepository.BuscarExistenciaXArticulo(linea.ArticuloId);
                                                    decExistenciaTotal = 0;
                                                    foreach (var Existencia in Existencias)
                                                    {
                                                        decExistenciaTotal += Existencia.CantDisponible;
                                                    }

                                                    var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                    var aresponse = new BaseResponseGeneric<int>();

                                                    CostoPromLocArt = DecCostoPromLocArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoLoc, CostoUnitUltimoLoc);
                                                    CostoPromDolArt = DecCostoPromDolArt(decExistenciaTotal, linea.Cantidad, buscarIdArticulo.CostoDol, CostoUnitUltimoDol);

                                                    try  //Inicio try del Articulo
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
                                                            Bultos = buscarIdArticulo.Bultos,
                                                            CostoLoc = buscarIdArticulo.CostoLoc,
                                                            CostoDol = buscarIdArticulo.CostoDol,
                                                            CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                            CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
                                                            UltimoIngreso = buscarIdArticulo.UltimoIngreso,
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
                                                            UltimaSalida = DateTime.Now,
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
                                                    }  // Fin del try del Articulo - Ventas Locales


                                                    // 3/4 Se actualiza el registro existente en la tabla ExistenciaBodega  - Ventas Locales
                                                    var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                    var ebresponse = new BaseResponseGeneric<int>();
                                                    try  // Inicio try de ExistenciaBodega
                                                    {
                                                        ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                        {
                                                            Id = buscarIdExistenciaBodega.Id,
                                                            ArticuloId = linea.ArticuloId,
                                                            BodegaId = (int)linea.BodegaId,
                                                            CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible - linea.Cantidad,
                                                            CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                                                            CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
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
                                                    } // Fin del catch-try de ExistenciaBodega - Ventas Locales

                                                    // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote - Ventas Locales
                                                    if (buscarArticulo.UsaLotes)
                                                    {
                                                        var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                        var elresponse = new BaseResponseGeneric<int>();
                                                        try  //Inicio del try de ExistenciaLote
                                                        {

                                                            elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                            {
                                                                Id = buscarExistenciaLote.Id,
                                                                BodegaId = buscarExistenciaLote.BodegaId,
                                                                ArticuloId = buscarExistenciaLote.ArticuloId,
                                                                LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                                LoteId = buscarExistenciaLote.LoteId,
                                                                CantDisponible = buscarExistenciaLote.CantDisponible - linea.Cantidad,
                                                                CantReservada = buscarExistenciaLote.CantReservada,
                                                                CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                                CantRemitida = buscarExistenciaLote.CantRemitida,
                                                                CantVencida = buscarExistenciaLote.CantVencida,
                                                                CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                                                CostoUntDol = buscarExistenciaLote.CostoUntDol,
                                                                IsDeleted = buscarExistenciaLote.IsDeleted,
                                                                Updatedby = userId,
                                                                UpdateDate = DateTime.Now,
                                                                Createdby = buscarExistenciaLote.Createdby,
                                                                CreateDate = buscarExistenciaLote.CreateDate
                                                            });
                                                            elresponse.Success = true;
                                                            break;
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            _logger.LogCritical(ex.StackTrace);
                                                            elresponse.Success = false;
                                                            elresponse.Errors.Add(ex.Message);
                                                            break;
                                                        }  // Fin del catch-try de ExistenciaLote - Ventas Locales
                                                    } // Fin del if "UsaLotes" - Ventas Locales
                                            }  // Fin del if strNaturaleza = 'S'
                                            else  // Devolución de venta local - Naturaleza E
                                            {
                                                    // 1/4 Creación de registro en Detalle de Movimiento de Inventario - Devolución de Venta Local
                                                    var detresponse = new BaseResponseGeneric<int>();
                                                    detresponse.Result = await _detRepository.CreateAsync(new MovInventarioDet
                                                    {
                                                         MovInventarioEncId = response.Result,
                                                         Consecutivo = CorrelativoLinea,
                                                         FechaHoraTransac = DateTime.Now,
                                                         DocTributarioId = linea.DocTributarioId,
                                                         AjusteConfigId = linea.AjusteConfigId,
                                                         ArticuloId = linea.ArticuloId,
                                                         BodegaId = linea.BodegaId,
                                                         LocalizacionId = linea.LocalizacionId,
                                                         LoteId = linea.LoteId,
                                                         Tipo = linea.Tipo,
                                                         Subtipo = linea.Subtipo,
                                                         Subsubtipo = linea.Subsubtipo,
                                                         Naturaleza = linea.Naturaleza,
                                                         Cantidad = linea.Cantidad * -1,
                                                         CostoTotLoc = linea.CostoTotLoc,
                                                         CostoTotDol = linea.CostoTotDol,
                                                         PrecioTotalLocal = linea.PrecioTotalLocal,
                                                         PrecioTotalDolar = linea.PrecioTotalDolar,
                                                         Contabilizada = linea.Contabilizada,
                                                         Fecha = linea.Fecha,
                                                         CentroCuentaId = linea.CentroCuentaId,
                                                         UnidadDistribucionId = linea.UnidadDistribucionId,
                                                         AsientoCardex = linea.AsientoCardex,
                                                         DocFiscal = linea.DocFiscal,
                                                         TipoOperacionId = linea.TipoOperacionId,
                                                         TipoPagoId = linea.TipoPagoId,
                                                         IsDeleted = false,
                                                         Updatedby = userId,
                                                         UpdateDate = DateTime.Now,
                                                         Createdby = userId,
                                                         CreateDate = DateTime.Now
                                                    });  //Fin del create en la tabla MovsInventarioDet - Devolucion de Ventas Locales

                                                        detresponse.Success = true;

                                                        // 2/4 Se actualiza el registro correspondiente en la tabla Articulos - Ventas Locales
                                            
                                                        var buscarIdArticulo = await _aRepository.GetByIdAsync(linea.ArticuloId);
                                                        var aresponse = new BaseResponseGeneric<int>();


                                                        try  //Inicio try del Articulo
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
                                                                Bultos = buscarIdArticulo.Bultos,
                                                                CostoLoc = buscarIdArticulo.CostoLoc,
                                                                CostoDol = buscarIdArticulo.CostoDol,
                                                                CostoPromUltimoLoc = buscarIdArticulo.CostoPromUltimoLoc,
                                                                CostoPromUltimoDol = buscarIdArticulo.CostoPromUltimoDol,
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
                                                        }  // Fin del try del Articulo - Devolución de Venta Local


                                                        // 3/4 Se actualiza el registro existente en la tabla ExistenciaBodega  - Ventas Locales
                                                        var buscarIdExistenciaBodega = await _ebRepository.BuscarIdExistenciaBodegaAsync(linea.ArticuloId, (int)linea.BodegaId);

                                                        var ebresponse = new BaseResponseGeneric<int>();
                                                        try  // Inicio try de ExistenciaBodega
                                                        {
                                                            ebresponse.Result = await _ebRepository.UpdateAsync(new ExistenciaBodega
                                                            {
                                                                Id = buscarIdExistenciaBodega.Id,
                                                                ArticuloId = linea.ArticuloId,
                                                                BodegaId = (int)linea.BodegaId,
                                                                CantDisponible = (decimal)buscarIdExistenciaBodega.CantDisponible + linea.Cantidad,
                                                                CostoUntPromedioLoc = buscarIdExistenciaBodega.CostoUntPromedioLoc,
                                                                CostoUntPromedioDol = buscarIdExistenciaBodega.CostoUntPromedioDol,
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
                                                        } // Fin del catch-try de ExistenciaBodega - Devolución de Venta Local

                                                        // 4/4 Si el artículo usa lotes, se actualiza el registro correspondiente en la tabla ExistenciaLote - Ventas Locales
                                                        if (buscarArticulo.UsaLotes)
                                                        {
                                                            var buscarExistenciaLote = await _elRepository.BuscarExistenciaLoteAsync((int)linea.BodegaId, linea.ArticuloId, (int)linea.LocalizacionId, (int)linea.LoteId);
                                                            var elresponse = new BaseResponseGeneric<int>();
                                                            try  //Inicio del try de ExistenciaLote
                                                            {

                                                                elresponse.Result = await _elRepository.UpdateAsync(new ExistenciaLote
                                                                {
                                                                    Id = buscarExistenciaLote.Id,
                                                                    BodegaId = buscarExistenciaLote.BodegaId,
                                                                    ArticuloId = buscarExistenciaLote.ArticuloId,
                                                                    LocalizacionId = buscarExistenciaLote.LocalizacionId,
                                                                    LoteId = buscarExistenciaLote.LoteId,
                                                                    CantDisponible = buscarExistenciaLote.CantDisponible + linea.Cantidad,
                                                                    CantReservada = buscarExistenciaLote.CantReservada,
                                                                    CantNoAprobada = buscarExistenciaLote.CantNoAprobada,
                                                                    CantRemitida = buscarExistenciaLote.CantRemitida,
                                                                    CantVencida = buscarExistenciaLote.CantVencida,
                                                                    CostoUntLoc = buscarExistenciaLote.CostoUntLoc,
                                                                    CostoUntDol = buscarExistenciaLote.CostoUntDol,
                                                                    IsDeleted = buscarExistenciaLote.IsDeleted,
                                                                    Updatedby = userId,
                                                                    UpdateDate = DateTime.Now,
                                                                    Createdby = buscarExistenciaLote.Createdby,
                                                                    CreateDate = buscarExistenciaLote.CreateDate
                                                                });
                                                                elresponse.Success = true;
                                                                break;
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                _logger.LogCritical(ex.StackTrace);
                                                                elresponse.Success = false;
                                                                elresponse.Errors.Add(ex.Message);
                                                                break;
                                                            }  // Fin del catch-try de ExistenciaLote - Devolución de Venta Local
                                                        } // Fin del if "UsaLotes" - Devolución de Venta Local
                                                    }

                                            break;
                                        }  // Fin de Subsubtipo = "L"

                                        case "E":  // Exportaciones
                                                throw new Exception($"Ventas, Disponible, Exportaciones.");

                                    }
                                    throw new Exception($"Ventas, Disponible.");

                                case "I":
                                    throw new Exception($"Ventas, Remitidas.");

                                case "R":
                                    throw new Exception($"Ventas, Reservadas.");
                            }
                            break;

                        }  //Termina el case para TipoAjuste= "V"

                    };  // Fin del switch strTipoAjusteConfig

                }  //Fin del foreach

                response.Success = true;

            } //Fin del try del CreateAsync principal

            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            } // Fin del catch-try del CreateAsync principal

            return response;

         }  //Fin del CreateAsyn principal


        public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
        {

            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<MovInventarioEnc>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<MovInventarioEnc>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<MovInventarioEnc>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<MovInventarioEnc>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new MovInventarioEnc();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioEnc request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar movimientos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new MovInventarioEnc
                {
                    Id = id,
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento,
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
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


        public static string SigConsecutivo(string consecutivoActual)
        {
            string ConsecCompleto = consecutivoActual;
            var elements = ConsecCompleto.Split('-');
            var element2 = elements[0];
            string element1 = elements[1];
            Int32 ParteNumerica = Convert.ToInt32(element1) + 1;
            string SigConsec = element2 + "-" + ParteNumerica.ToString("0000");

            return SigConsec;

        }


        public static decimal DecCostoPromLocArt(decimal ExistenciaActual, decimal ExistenciaMov, decimal CostoPromActual, decimal CostoPromMov)
        {
            decimal CostoPromLocalArt = ((ExistenciaActual * CostoPromActual) + (ExistenciaMov * CostoPromMov)) / (ExistenciaActual + ExistenciaMov);
            return CostoPromLocalArt;
        }



        public static decimal DecCostoPromDolArt(decimal ExistenciaActual, decimal ExistenciaMov, decimal CostoPromActual, decimal CostoPromMov)
        {
            decimal CostoPromDolarArt = ((ExistenciaActual * CostoPromActual) + (ExistenciaMov * CostoPromMov)) / (ExistenciaActual + ExistenciaMov);
            return CostoPromDolarArt;
        }

    }  // Fin public class
}  // Fin del namespace
