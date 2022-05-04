using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class ArticuloService : IArticuloService
    {
        private readonly IArticuloRepository _repository;
        private readonly ILogger<ArticuloService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ArticuloService(IArticuloRepository repository, ILogger<ArticuloService> logger,IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoArticulo request, string userId, string codArticulo)
        {
            var response = new BaseResponseGeneric<int>(); 
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ARTICULOADD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear artículos.");
                    response.Success = false;
                    return response;
                }

                var buscarCodArticulo = await _repository.BuscarCodArticuloAsync(codArticulo);
                if (buscarCodArticulo != null)
                {
                    response.Errors.Add($"El codigo de artículo {buscarCodArticulo.CodArticulo} ya existe");
                    response.Success = false;
                    return response;
                }
                response.Result = await _repository.CreateAsync(new Articulo
                {
                    CodArticulo  = request.CodArticulo,
                    Descripcion = request.Descripcion,
                    Clasificacion1Id = request.Clasificacion1Id,
                    Clasificacion2Id=request.Clasificacion2Id,
                    Clasificacion3Id=request.Clasificacion3Id,
                    Clasificacion4Id=request.Clasificacion4Id,
                    Clasificacion5Id=request.Clasificacion5Id,
                    Clasificacion6Id=request.Clasificacion6Id,
                    FactorConver1 = request.FactorConver1,  
                    FactorConver2 = request.FactorConver2,
                    FactorConver3 = request.FactorConver3,
                    FactorConver4 = request.FactorConver4,
                    FactorConver5 = request.FactorConver5,
                    FactorConver6 = request.FactorConver6,
                    Tipo = request.Tipo,
                    TiendaEnLinea = request.TiendaEnLinea,
                    VentaTarjetaCredito = request.VentaTarjetaCredito,
                    PesoNeto = request.PesoNeto,
                    PesoBruto = request.PesoBruto,
                    Volumen=request.Volumen,
                    Bultos=request.Bultos,
                    CategoriaArticuloId=request.CategoriaArticuloId1,
                    FactorEmpaque=request.FactorEmpaque,
                    FactorVenta=request.FactorVenta,
                    ExistenciaMínima=request.ExistenciaMínima,
                    ExistenciaMáxima=request.ExistenciaMáxima,
                    PuntoDeOrden=request.PuntoDeOrden,
                    CostoLoc=request.CostoLoc,
                    CostoDol=request.CostoDol,
                    PrecioBaseLocal=request.PrecioBaseLocal,
                    PrecioBaseDol=request.PrecioBaseDol,
                    UltimaSalida=request.UltimaSalida,
                    UltimoMovimiento=request.UltimoMovimiento,
                    UltimoIngreso=request.UltimoIngreso,
                    UltimoInventario=request.UltimoInventario,
                    ClaseABC = request.ClaseABC,
                    FrecuenciaConteo=request.FrecuenciaConteo,
                    CodigoBarrasVent=request.CodigoBarrasVent,
                    CodigoBarrasInvt=request.CodigoBarrasInvt,
                    Activo=request.Activo,
                    UsaLotes=request.UsaLotes,
                    ObligaCuarentena=request.ObligaCuarentena,
                    MinVidaCompra=request.MinVidaCompra,
                    MinVidaConsumo=request.MinVidaConsumo,
                    MinVidaVenta=request.MinVidaVenta,
                    VidaUtilPromedio=request.VidaUtilPromedio,
                    DiasCuarentena= request.DiasCuarentena,
                    ArticuloDelProv=request.ArticuloDelProv,
                    OrdenMinima=request.OrdenMinima,
                    PlazoReabast=request.PlazoReabast,
                    LoteMultiplo=request.LoteMultiplo,
                    Notas=request.Notas,
                    UsuarioCreacion=request.UsuarioCreacion,
                    FechaHoraCreacion=request.FechaHoraCreacion,
                    UsuarioUltModif=request.UsuarioUltModif,
                    FechaHoraUltModif= request.FechaHoraUltModif,
                    UsaNumerosSerie=request.UsaNumerosSerie,
                    ModalidadInvFis=request.ModalidadInvFis,
                    TipoCodBarraDet=request.TipoCodBarraDet,
                    TipoCodBarraAlm=request.TipoCodBarraAlm,
                    UsaReglasLocales=request.UsaReglasLocales,
                    UnidadAlmacenId=request.UnidadAlmacenId,
                    UnidadVentaId=request.UnidadVentaId,
                    Perecedero=request.Perecedero,
                    Manufacturador=request.Manufacturador,
                    CodigoRetencion=request.CodigoRetencion,
                    RetencionVenta=request.RetencionVenta,
                    RetencionCompra=request.RetencionCompra,
                    ModeloRetencion=request.ModeloRetencion,
                    Estilo=request.Estilo,
                    Talla=request.Talla,
                    Color=request.Color,
                    TipoCosto = request.TipoCosto,
                    CostoPromUltimoLoc=request.CostoPromUltimoLoc,
                    CostoPromUltimoDol=request.CostoPromUltimoDol,
                    EsImpuesto=request.EsImpuesto,
                    TipoDocIVA=request.TipoDocIVA,
                    SugiereMin=request.SugiereMin,
                    CalculaPercep=request.CalculaPercep,
                    PorcPercep=request.PorcPercep,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now,
                    ImpuestoId=request.ImpuestoId,
                    UnidadEmpaqueId=request.UnidadEmpaqueId,
                    ProveedorId=request.ProveedorId,
                    urlimagen = request.urlimagen
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


        //Clasificacion1Id = request.Clasificacion1Id,
        //Clasificacion2Id = request.Clasificacion2Id,
        //Clasificacion3Id = request.Clasificacion3Id,
        //Clasificacion4Id = request.Clasificacion4Id,
        //Clasificacion5Id = request.Clasificacion5Id,
        //Clasificacion6Id = request.Clasificacion6Id,
        //FactorConver1 = request.FactorConver1,
        //FactorConver2 = request.FactorConver2,
        //FactorConver3 = request.FactorConver3,
        //FactorConver4 = request.FactorConver4,
        //FactorConver5 = request.FactorConver5,
        //FactorConver6 = request.FactorConver6,
        //TiendaEnLinea = request.TiendaEnLinea,
        //VentaTarjetaCredito = request.VentaTarjetaCredito,
        //PesoNeto = request.PesoNeto,
        //PesoBruto = request.PesoBruto,
        //Volumen = request.Volumen,
        //Bultos = request.Bultos,
        //CategoriaArticulo = request.CategoriaArticulo,
        //ImpuestoId = request.ImpuestoId,
        //FactorEmpaque = request.FactorEmpaque,
        //FactorVenta = request.FactorVenta,
        //ExistenciaMínima = request.ExistenciaMínima,
        //ExistenciaMáxima = request.ExistenciaMáxima,
        //PuntoDeOrden = request.PuntoDeOrden,
        //CostoLoc = request.CostoLoc,
        //CostoDol = request.CostoDol,
        //PrecioBaseLocal = request.PrecioBaseLocal,
        //PrecioBaseDol = request.PrecioBaseDol,
        //UltimaSalida = request.UltimaSalida,
        //UltimoMovimiento = request.UltimoMovimiento,
        //UltimoIngreso= request.UltimoIngreso,
        //UltimoInventario= request.UltimoInventario,

        //FrecuenciaConteo= request.FrecuenciaConteo,
        //CodigoBarrasVent= request.CodigoBarrasVent,
        //CodigoBarrasInvt= request.CodigoBarrasInvt,
        //Activo= request.Activo,
        //UsaLotes= request.UsaLotes,
        //ObligaCuarentena= request.ObligaCuarentena,
        //MinVidaCompra= request.MinVidaCompra,
        //MinVidaConsumo= request.MinVidaConsumo,
        //MinVidaVenta= request.MinVidaVenta,
        //VidaUtilPromedio= request.VidaUtilPromedio,
        //DiasCuarentena= request.DiasCuarentena,
        //Proveedor= request.Proveedor,
        //ArticuloDelProv= request.ArticuloDelProv,
        //OrdenMinima= request.OrdenMinima,
        //PlazoReabast= request.PlazoReabast,
        //LoteMultiplo= request.LoteMultiplo,
        //UsuarioCreacion= request.UsuarioCreacion,
        //FechaHoraCreacion=request.FechaHoraCreacion,
        //UsuarioUltModif= request.UsuarioUltModif,
        //FechaHoraUltModif= request.FechaHoraUltModif,  
        //UsaNumerosSerie= request.UsaNumerosSerie,
        //ModalidadInvFis= request.ModalidadInvFis,
        //TipoCodBarraDet= request.TipoCodBarraDet,
        //TipoCodBarraAlm= request.TipoCodBarraAlm,
        //UsaReglasLocales= request.UsaReglasLocales,
        //UnidadAlmacenId = request.UnidadAlmacenId,
        //UnidadEmpaqueId= request.UnidadEmpaqueId,
        //UnidadVentaId = request.UnidadVentaId,
        //Perecedero= request.Perecedero,
        //Manufacturador= request.Manufacturador,
        //CodigoRetencion= request.CodigoRetencion,
        //RetencionVenta= request.RetencionVenta,
        //RetencionCompra= request.RetencionCompra,
        //ModeloRetencion= request.ModeloRetencion,
        //Estilo= request.Estilo,
        //Talla= request.Talla,
        //Color= request.Color,

        //CostoPromUltimoLoc= request.CostoPromUltimoLoc,
        //CostoPromUltimoDol= request.CostoPromUltimoDol,
        //EsImpuesto= request.EsImpuesto, 
        //TipoDocIVA= request.TipoDocIVA, 
        //SugiereMin= request.SugiereMin,
        //CalculaPercep= request.CalculaPercep,
        //PorcPercep= request.PorcPercep,
        //Notas = request.Notas,

        public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
        {
      
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ARTICULODEL", 9, userId);

                if (buscarPrivilegio == null)
                {      
                    response.Errors.Add($"No tiene privilegios para eliminar artículos.");
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

        public async Task<BaseResponseGeneric<ICollection<Articulo>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Articulo>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ARTICULO", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar artículos.");
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

        public async Task<BaseResponseGeneric<Articulo>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Articulo>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Articulo();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoArticulo request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_ARTICULOMOD", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar artículos.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new Articulo
                {
                    Id = id,
                    CodArticulo = request.CodArticulo,
                    Descripcion = request.Descripcion,
                    Clasificacion1Id = request.Clasificacion1Id,
                    Clasificacion2Id = request.Clasificacion2Id,
                    Clasificacion3Id = request.Clasificacion3Id,
                    Clasificacion4Id = request.Clasificacion4Id,
                    Clasificacion5Id = request.Clasificacion5Id,
                    Clasificacion6Id = request.Clasificacion6Id,
                    FactorConver1 = request.FactorConver1,
                    FactorConver2 = request.FactorConver2,
                    FactorConver3 = request.FactorConver3,
                    FactorConver4 = request.FactorConver4,
                    FactorConver5 = request.FactorConver5,
                    FactorConver6 = request.FactorConver6,
                    Tipo = request.Tipo,
                    TiendaEnLinea = request.TiendaEnLinea,
                    VentaTarjetaCredito = request.VentaTarjetaCredito,
                    PesoNeto = request.PesoNeto,
                    PesoBruto = request.PesoBruto,
                    Volumen = request.Volumen,
                    Bultos = request.Bultos,
                   // CategoriaArticulo = request.CategoriaArticulo,
                    ImpuestoId = request.ImpuestoId,
                    FactorEmpaque = request.FactorEmpaque,
                    FactorVenta = request.FactorVenta,
                    ExistenciaMínima = request.ExistenciaMínima,
                    ExistenciaMáxima = request.ExistenciaMáxima,
                    PuntoDeOrden = request.PuntoDeOrden,
                    CostoLoc = request.CostoLoc,
                    CostoDol = request.CostoDol,
                    PrecioBaseLocal = request.PrecioBaseLocal,
                    PrecioBaseDol = request.PrecioBaseDol,
                    UltimaSalida = request.UltimaSalida,
                    UltimoMovimiento = request.UltimoMovimiento,
                    UltimoIngreso = request.UltimoIngreso,
                    UltimoInventario = request.UltimoInventario,
                    ClaseABC = request.ClaseABC,
                    FrecuenciaConteo = request.FrecuenciaConteo,
                    CodigoBarrasVent = request.CodigoBarrasVent,
                    CodigoBarrasInvt = request.CodigoBarrasInvt,
                    Activo = request.Activo,
                    UsaLotes = request.UsaLotes,
                    ObligaCuarentena = request.ObligaCuarentena,
                    MinVidaCompra = request.MinVidaCompra,
                    MinVidaConsumo = request.MinVidaConsumo,
                    MinVidaVenta = request.MinVidaVenta,
                    VidaUtilPromedio = request.VidaUtilPromedio,
                    DiasCuarentena = request.DiasCuarentena,
                    //Proveedor = request.Proveedor,
                    ArticuloDelProv = request.ArticuloDelProv,
                    OrdenMinima = request.OrdenMinima,
                    PlazoReabast = request.PlazoReabast,
                    LoteMultiplo = request.LoteMultiplo,
                    UsuarioCreacion = request.UsuarioCreacion,
                    FechaHoraCreacion = request.FechaHoraCreacion,
                    UsuarioUltModif = request.UsuarioUltModif,
                    FechaHoraUltModif = request.FechaHoraUltModif,
                    UsaNumerosSerie = request.UsaNumerosSerie,
                    ModalidadInvFis = request.ModalidadInvFis,
                    TipoCodBarraDet = request.TipoCodBarraDet,
                    TipoCodBarraAlm = request.TipoCodBarraAlm,
                    UsaReglasLocales = request.UsaReglasLocales,
                    UnidadAlmacenId = request.UnidadAlmacenId,
                    UnidadEmpaqueId = request.UnidadEmpaqueId,
                    UnidadVentaId = request.UnidadVentaId,
                    Perecedero = request.Perecedero,
                    Manufacturador = request.Manufacturador,
                    CodigoRetencion = request.CodigoRetencion,
                    RetencionVenta = request.RetencionVenta,
                    RetencionCompra = request.RetencionCompra,
                    ModeloRetencion = request.ModeloRetencion,
                    Estilo = request.Estilo,
                    Talla = request.Talla,
                    Color = request.Color,
                    TipoCosto = request.TipoCosto,
                    CostoPromUltimoLoc = request.CostoPromUltimoLoc,
                    CostoPromUltimoDol = request.CostoPromUltimoDol,
                    EsImpuesto = request.EsImpuesto,
                    TipoDocIVA = request.TipoDocIVA,
                    SugiereMin = request.SugiereMin,
                    CalculaPercep = request.CalculaPercep,
                    PorcPercep = request.PorcPercep,
                    Notas = request.Notas,
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
