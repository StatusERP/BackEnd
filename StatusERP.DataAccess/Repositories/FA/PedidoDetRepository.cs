using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class PedidoDetRepository : StatusERPContextBase<PedidoDet>, IPedidoDetRepository
{
    public PedidoDetRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<PedidoDet>> GetCollectionAsync()
    {
        return await _dbContext.PedidoDets
         .Include(p => p.articulo)
         .Include(p => p.bodega)
         .Include(p => p.localizacion)
         .Include(p => p.lote)
         .Include(p => p.centroCuenta)
         .Include(p => p.unidadDistribucion)
         .Include(p => p.pedidoEnc)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<PedidoDet?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<PedidoDet>(id);
    }

    public async Task<int> CreateAsync(PedidoDet pedidoDet)
    {
        return await _dbContext.InsertAsync(pedidoDet);
    }

    public async Task<int> UpdateAsync(PedidoDet pedidoDet)
    {

        try
        {
            var registro = await _dbContext.Set<PedidoDet>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == pedidoDet.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }
            registro.Id = pedidoDet.Id;
            registro.PedidoEncId = pedidoDet.PedidoEncId;
            registro.PedidoLinea = pedidoDet.PedidoLinea;
            registro.BodegaId = pedidoDet.BodegaId;
            registro.LoteId = pedidoDet.LoteId;
            registro.LocalizacionId = pedidoDet.LocalizacionId;
            registro.ArticuloId = pedidoDet.ArticuloId;
            registro.Estado = pedidoDet.Estado;
            registro.FechaEntrega = pedidoDet.FechaEntrega;
            registro.LineaUsuario = pedidoDet.LineaUsuario;
            registro.PrecioUnitario = pedidoDet.PrecioUnitario;
            registro.CantidadPedida = pedidoDet.CantidadPedida;
            registro.CantidadAFacturar = pedidoDet.CantidadAFacturar;
            registro.CantidadFacturada = pedidoDet.CantidadFacturada;
            registro.CantidadReservada = pedidoDet.CantidadReservada;
            registro.CantidadBonificada = pedidoDet.CantidadBonificada;
            registro.CantidadCancelada = pedidoDet.CantidadCancelada;
            registro.TipoDescuento = pedidoDet.TipoDescuento;
            registro.MontoDescuento = pedidoDet.MontoDescuento;
            registro.PorcDescuento = pedidoDet.PorcDescuento;
            registro.Descripcion = pedidoDet.Descripcion;
            registro.Comentario = pedidoDet.Comentario;
            registro.PedidoLineaBonif = pedidoDet.PedidoLineaBonif;
            registro.UnidadDistribucionId = pedidoDet.UnidadDistribucionId;
            registro.FechaPrometida = pedidoDet.FechaPrometida;
            registro.LineaOrdenCompra = pedidoDet.LineaOrdenCompra;
            registro.CentroCuentaId = pedidoDet.CentroCuentaId;
            registro.RazonPerdida = pedidoDet.RazonPerdida;
            registro.TipoImpuesto1 = pedidoDet.TipoImpuesto1;
            registro.TipoTarifa1 = pedidoDet.TipoTarifa1;
            registro.TipoImpuesto2 = pedidoDet.TipoImpuesto2;
            registro.TipoTarifa2 = pedidoDet.TipoTarifa2;
            registro.PorcExoneracion = pedidoDet.PorcExoneracion;
            registro.MontoExoneracion = pedidoDet.MontoExoneracion;
            registro.PorcImpuesto1 = pedidoDet.PorcImpuesto1;
            registro.PorcImpuesto2 = pedidoDet.PorcImpuesto2;
            registro.EsOtroCargo = pedidoDet.EsOtroCargo;
            registro.EsCanastaBasica = pedidoDet.EsCanastaBasica;
            registro.PorcExoneracion2 = pedidoDet.PorcExoneracion2;
            registro.MontoExoneracion2 = pedidoDet.MontoExoneracion2;
            registro.PorcImp1Base = pedidoDet.PorcImp1Base;
            registro.PorcImp2Base = pedidoDet.PorcImp2Base;
            registro.IsDeleted = pedidoDet.IsDeleted;
            registro.Updatedby = pedidoDet.Updatedby;
            registro.UpdateDate = pedidoDet.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<PedidoDet>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return pedidoDet.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new PedidoDet
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<PedidoDet?> BuscarPedidoDetAsync(int pedidoId, Int16 pedidoLinea)
    {
        return await _dbContext.PedidoDets
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.PedidoEncId == pedidoId && t.PedidoLinea == pedidoLinea);
    }
}
