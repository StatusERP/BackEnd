using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class PedidoEncRepository:StatusERPContextBase<PedidoEnc>,IPedidoEncRepository
{
    public PedidoEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<PedidoEnc>> GetCollectionAsync()
    {
        return await _dbContext.PedidoEncs
         .Include(p => p.bodega)
         .Include(p => p.cliente)
         .Include(p => p.clienteCorporac)
         .Include(p => p.clienteDireccion)
         .Include(p => p.clienteOrigen)
         .Include(p => p.cobrador)
         .Include(p => p.condicionPago)
         .Include(p => p.versionNivelPrecio)
         .Include(p => p.pais)
         .Include(p => p.ruta)
         .Include(p => p.subTipoDocCC)
         .Include(p => p.vendedor)
         .Include(p => p.zona)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<PedidoEnc?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<PedidoEnc>(id);
    }

    public async Task<int> CreateAsync(PedidoEnc pedidoEnc)
    {
        return await _dbContext.InsertAsync(pedidoEnc);
    }

    public async Task<int> UpdateAsync(PedidoEnc pedidoEnc)
    {

        try
        {
            var registro = await _dbContext.Set<PedidoEnc>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == pedidoEnc.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = pedidoEnc.Id;
            registro.Pedido = pedidoEnc.Pedido;
            registro.Estado = pedidoEnc.Estado;
            registro.FechaPedido = pedidoEnc.FechaPedido;
            registro.Fecha_Prometida = pedidoEnc.Fecha_Prometida;
            registro.FechaProxEmbarqu = pedidoEnc.FechaProxEmbarqu;
            registro.FechaUltEmbarque = pedidoEnc.FechaUltEmbarque;
            registro.FechaUltCancelac = pedidoEnc.FechaUltCancelac;
            registro.OrdenCompra = pedidoEnc.OrdenCompra;
            registro.FechaOrden = pedidoEnc.FechaOrden;
            registro.TarjetaCredito = pedidoEnc.TarjetaCredito;
            registro.EmbarcarA = pedidoEnc.EmbarcarA;
            registro.DirecEmbarque = pedidoEnc.DirecEmbarque;
            registro.Rubro1 = pedidoEnc.Rubro1;
            registro.Rubro2 = pedidoEnc.Rubro2;
            registro.Rubro3 = pedidoEnc.Rubro3;
            registro.Rubro4 = pedidoEnc.Rubro4;
            registro.Rubro5 = pedidoEnc.Rubro5;
            registro.Observaciones = pedidoEnc.Observaciones;
            registro.ComentarioCXC = pedidoEnc.ComentarioCXC;
            registro.TotalMercaderia = pedidoEnc.TotalMercaderia;
            registro.MontoAnticipo = pedidoEnc.MontoAnticipo;
            registro.MontoFlete = pedidoEnc.MontoFlete;
            registro.MontoSeguro = pedidoEnc.MontoSeguro;
            registro.MontoDocumentacio = pedidoEnc.MontoDocumentacio;
            registro.TipoDescuento1 = pedidoEnc.TipoDescuento1;
            registro.TipoDescuento2 = pedidoEnc.TipoDescuento2;
            registro.MontoDescuento1 = pedidoEnc.MontoDescuento1;
            registro.MontoDescuento2 = pedidoEnc.MontoDescuento2;
            registro.PorcDescuento1 = pedidoEnc.PorcDescuento1;
            registro.PorcDescuento2 = pedidoEnc.PorcDescuento2;
            registro.TotalImpuesto1 = pedidoEnc.TotalImpuesto1;
            registro.TotalImpuesto2 = pedidoEnc.TotalImpuesto2;
            registro.TotalAFacturar = pedidoEnc.TotalAFacturar;
            registro.PorcComiVendedor = pedidoEnc.PorcComiVendedor;
            registro.PorcComiCobrador = pedidoEnc.PorcComiCobrador;
            registro.TotalCancelado = pedidoEnc.TotalCancelado;
            registro.TotalUnidades = pedidoEnc.TotalUnidades;
            registro.Impreso = pedidoEnc.Impreso;
            registro.FechaHora = pedidoEnc.FechaHora;
            registro.DescuentoVolumen = pedidoEnc.DescuentoVolumen;
            registro.TipoPedido = pedidoEnc.TipoPedido;
            registro.MonedaPedido = pedidoEnc.MonedaPedido;
            registro.VersionNivelPrecioId = pedidoEnc.VersionNivelPrecioId;
            registro.Autorizado = pedidoEnc.Autorizado;
            registro.DocAGenerar = pedidoEnc.DocAGenerar;
            registro.ClasePedido = pedidoEnc.ClasePedido;
            registro.CobradorId = pedidoEnc.CobradorId;
            registro.RutaId = pedidoEnc.RutaId;
            registro.Usuario = pedidoEnc.Usuario;
            registro.CondicionPagoId = pedidoEnc.CondicionPagoId;
            registro.BodegaId = pedidoEnc.BodegaId;
            registro.ZonaId = pedidoEnc.ZonaId;
            registro.VendedorId = pedidoEnc.VendedorId;
            registro.ClienteId = pedidoEnc.ClienteId;
            registro.CodCliente = pedidoEnc.CodCliente;
            registro.ClienteDireccionId = pedidoEnc.ClienteDireccionId;
            registro.ClienteCorporacId = pedidoEnc.ClienteCorporacId;
            registro.ClienteOrigenId = pedidoEnc.ClienteOrigenId;
            registro.PaisId = pedidoEnc.PaisId;
            registro.SubTipoDocCCId = pedidoEnc.SubTipoDocCCId;
            registro.Backorder = pedidoEnc.Backorder;
            registro.PorcIntCte = pedidoEnc.PorcIntCte;
            registro.DescuentoCascada = pedidoEnc.DescuentoCascada;
            registro.DireccionFactura = pedidoEnc.DireccionFactura;
            registro.TipoCambio = pedidoEnc.TipoCambio;
            registro.FijarTipoCambio = pedidoEnc.FijarTipoCambio;
            registro.OrigenPedido = pedidoEnc.OrigenPedido;
            registro.DescDirecEmbarque = pedidoEnc.DescDirecEmbarque;
            registro.DivisionGeografica1 = pedidoEnc.DivisionGeografica1;
            registro.DivisionGeografica2 = pedidoEnc.DivisionGeografica2;
            registro.BaseImpuesto1 = pedidoEnc.BaseImpuesto1;
            registro.BaseImpuesto2 = pedidoEnc.BaseImpuesto2;
            registro.NombreCliente = pedidoEnc.NombreCliente;
            registro.FechaProyectada = pedidoEnc.FechaProyectada;
            registro.FechaAprobacion = pedidoEnc.FechaAprobacion;
            registro.TipoDocumento = pedidoEnc.TipoDocumento;
            registro.VersionCotizacion = pedidoEnc.VersionCotizacion;
            registro.RazonCancelaCoti = pedidoEnc.RazonCancelaCoti;
            registro.DesCancelaCoti = pedidoEnc.DesCancelaCoti;
            registro.CambiosCoti = pedidoEnc.CambiosCoti;
            registro.CotizacionPadre = pedidoEnc.CotizacionPadre;
            registro.TasaImpositiva = pedidoEnc.TasaImpositiva;
            registro.TasaImpositivaPorc = pedidoEnc.TasaImpositivaPorc;
            registro.TasaCree1 = pedidoEnc.TasaCree1;
            registro.TasaCree1Porc = pedidoEnc.TasaCree1Porc;
            registro.TasaCree2 = pedidoEnc.TasaCree2;
            registro.TasaCree2Porc = pedidoEnc.TasaCree2Porc;
            registro.TasaGanOcasionalPorc = pedidoEnc.TasaGanOcasionalPorc;
            registro.UsrNoAprueba = pedidoEnc.UsrNoAprueba;
            registro.FechaNoAprueba = pedidoEnc.FechaNoAprueba;
            registro.RazonDesaprueba = pedidoEnc.RazonDesaprueba;
            registro.Modulo = pedidoEnc.Modulo;
            registro.CorreosEnvio = pedidoEnc.CorreosEnvio;
            registro.Incoterms = pedidoEnc.Incoterms;
            registro.TipoOperacion = pedidoEnc.TipoOperacion;
            registro.ActividadComercial = pedidoEnc.ActividadComercial;
            registro.MontoOtroCargo = pedidoEnc.MontoOtroCargo;
            registro.TieneRelacionados = pedidoEnc.TieneRelacionados;
            registro.EsFacturaReemplazo = pedidoEnc.EsFacturaReemplazo;
            registro.FacturaOriginalReemplazo = pedidoEnc.FacturaOriginalReemplazo;
            registro.ConsecutivoFTC = pedidoEnc.ConsecutivoFTC;
            registro.NumeroFTC = pedidoEnc.NumeroFTC;
            registro.NITTransportador = pedidoEnc.NITTransportador;
            registro.NumOCExenta = pedidoEnc.NumOCExenta;
            registro.IsDeleted = pedidoEnc.IsDeleted;
            registro.Updatedby = pedidoEnc.Updatedby;
            registro.UpdateDate = pedidoEnc.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<PedidoEnc>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return pedidoEnc.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new PedidoEnc
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<PedidoEnc?> BuscarPedidoAsync(string pedido)
    {
        return await _dbContext.PedidoEncs
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Pedido == pedido);
    }
}