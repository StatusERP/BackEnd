using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ArticuloRepository : StatusERPContextBase<Articulo>, IArticuloRepository
    {

        public ArticuloRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Articulo?> BuscarCodArticuloAsync(string CodArticulo)
        {
            return await _dbContext.Articulos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodArticulo == CodArticulo);
        }

        public async Task<int> CreateAsync(Articulo articulo)
        {
            return await _dbContext.InsertAsync(articulo);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Articulo
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Articulo?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Articulo>(id);
        }

        public async Task<ICollection<Articulo>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Articulo>(page, rows);
        }

        public async Task<int> UpdateAsync(Articulo articulo)
        {
            //await _dbContext.UpdateAsync(Articulo,Mapper);
            //return Articulo.Id;

            try
            {
                var registro = await _dbContext.Set<Articulo>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == articulo.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.CodArticulo = articulo.CodArticulo;
                registro.Descripcion = articulo.Descripcion;
                registro.Clasificacion1Id = articulo.Clasificacion1Id;
                registro.Clasificacion2Id = articulo.Clasificacion2Id;
                registro.Clasificacion3Id = articulo.Clasificacion3Id;
                registro.Clasificacion4Id = articulo.Clasificacion4Id;
                registro.Clasificacion5Id = articulo.Clasificacion5Id;
                registro.Clasificacion6Id = articulo.Clasificacion6Id;
                registro.FactorConver1 = articulo.FactorConver1;
                registro.FactorConver2 = articulo.FactorConver2;
                registro.FactorConver3 = articulo.FactorConver3;
                registro.FactorConver4 = articulo.FactorConver4;
                registro.FactorConver5 = articulo.FactorConver5;
                registro.FactorConver6 = articulo.FactorConver6;
                registro.Tipo = articulo.Tipo;
                registro.TiendaEnLinea = articulo.TiendaEnLinea;
                registro.VentaTarjetaCredito = articulo.VentaTarjetaCredito;
                registro.PesoNeto = articulo.PesoNeto;
                registro.PesoBruto = articulo.PesoBruto;
                registro.Volumen = articulo.Volumen;
                registro.Bultos = articulo.Bultos;
                registro.CategoriaArticuloId = articulo.CategoriaArticuloId;
                registro.FactorEmpaque = articulo.FactorEmpaque;
                registro.FactorVenta = articulo.FactorVenta;
                registro.ExistenciaMinima = articulo.ExistenciaMinima;
                registro.ExistenciaMaxima = articulo.ExistenciaMaxima;
                registro.PuntoDeOrden = articulo.PuntoDeOrden;
                registro.CostoLoc = articulo.CostoLoc;
                registro.CostoDol = articulo.CostoDol;
                registro.PrecioBaseLocal = articulo.PrecioBaseLocal;
                registro.PrecioBaseDol = articulo.PrecioBaseDol;
                registro.UltimaSalida = articulo.UltimaSalida;
                registro.UltimoMovimiento = articulo.UltimoMovimiento;
                registro.UltimoIngreso = articulo.UltimoIngreso;
                registro.UltimoInventario = articulo.UltimoInventario;
                registro.ClaseABC = articulo.ClaseABC;
                registro.FrecuenciaConteo = articulo.FrecuenciaConteo;
                registro.CodigoBarrasVent = articulo.CodigoBarrasVent;
                registro.CodigoBarrasInvt = articulo.CodigoBarrasInvt;
                registro.Activo = articulo.Activo;
                registro.UsaLotes = articulo.UsaLotes;
                registro.ObligaCuarentena = articulo.ObligaCuarentena;
                registro.MinVidaCompra = articulo.MinVidaCompra;
                registro.MinVidaConsumo = articulo.MinVidaConsumo;
                registro.MinVidaVenta = articulo.MinVidaVenta;
                registro.VidaUtilPromedio = articulo.VidaUtilPromedio;
                registro.DiasCuarentena = articulo.DiasCuarentena;
                registro.ArticuloDelProv = articulo.ArticuloDelProv;
                registro.OrdenMinima = articulo.OrdenMinima;
                registro.PlazoReabast = articulo.PlazoReabast;
                registro.LoteMultiplo = articulo.LoteMultiplo;
                registro.Notas = articulo.Notas;
                registro.UsuarioCreacion = registro.UsuarioCreacion;
                registro.FechaHoraCreacion = registro.FechaHoraCreacion;
                registro.UsuarioUltModif = articulo.UsuarioUltModif;
                registro.FechaHoraUltModif = articulo.FechaHoraUltModif;
                registro.UsaNumerosSerie = articulo.UsaNumerosSerie;
                registro.ModalidadInvFis = articulo.ModalidadInvFis;
                registro.TipoCodBarraDet = articulo.TipoCodBarraDet;
                registro.TipoCodBarraAlm = articulo.TipoCodBarraAlm;
                registro.UsaReglasLocales = articulo.UsaReglasLocales;
                registro.UnidadAlmacenId = articulo.UnidadAlmacenId;
                registro.UnidadVentaId = articulo.UnidadVentaId;
                registro.Perecedero = articulo.Perecedero;
                registro.Manufacturador = articulo.Manufacturador;
                registro.CodigoRetencion = articulo.CodigoRetencion;
                registro.RetencionVenta = articulo.RetencionVenta;
                registro.RetencionCompra = articulo.RetencionCompra;
                registro.ModeloRetencion = articulo.ModeloRetencion;
                registro.Estilo = articulo.Estilo;
                registro.Talla = articulo.Talla;
                registro.Color = articulo.Color;
                registro.TipoCosto = articulo.TipoCosto;
                registro.CostoPromUltimoLoc = articulo.CostoPromUltimoLoc;
                registro.CostoPromUltimoDol = articulo.CostoPromUltimoDol;
                registro.EsImpuesto = articulo.EsImpuesto;
                registro.TipoDocIVA = articulo.TipoDocIVA;
                registro.SugiereMin = articulo.SugiereMin;
                registro.CalculaPercep = articulo.CalculaPercep;
                registro.PorcPercep = articulo.PorcPercep;
                registro.IsDeleted = false;
                registro.Updatedby = articulo.Updatedby;
                registro.UpdateDate = articulo.UpdateDate;
                registro.Createdby = articulo.Createdby;
                registro.CreateDate = articulo.CreateDate;
                registro.ImpuestoId = articulo.ImpuestoId;
                registro.UnidadEmpaqueId = articulo.UnidadEmpaqueId;
                registro.ProveedorId = articulo.ProveedorId;
                registro.urlimagen = articulo.urlimagen;
                
                _dbContext.Set<Articulo>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return articulo.Id;

        }
    }
}
