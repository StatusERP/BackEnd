using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class FacturaEncRepository:StatusERPContextBase<FacturaEnc>,IFacturaEncRepository
{
    public FacturaEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<FacturaEnc>> GetCollectionAsync()
    {
        return await _dbContext.FacturaEncs
         .Include(p => p.movInventarioEnc)
         .Include(p => p.cliente)
         .Include(p => p.clienteCorporac)
         .Include(p => p.clienteDireccion)
         .Include(p => p.clienteOrigen)
         .Include(p => p.Cobrador)
         .Include(p => p.documentosCC)
         .Include(p => p.consecutivo)
         .Include(p => p.DivGeografica1)
         .Include(p => p.DivGeografica2)
         .Include(p => p.direccEmbarque)
         .Include(p => p.FacOriginalReemplazo)
         .Include(p => p.condicionPago)
         .Include(p => p.VersionNivelPrecio)
         .Include(p => p.pais)
         .Include(p => p.Ruta)
         .Include(p => p.subTipoDocCC)
         .Include(p => p.vendedor)
         .Include(p => p.zona)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<FacturaEnc?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<FacturaEnc>(id);
    }

    public async Task<int> CreateAsync(FacturaEnc facturaEnc)
    {
        return await _dbContext.InsertAsync(facturaEnc);
    }

    public async Task<int> UpdateAsync(FacturaEnc facturaEnc)
    {

        try
        {
            var registro = await _dbContext.Set<FacturaEnc>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == facturaEnc.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = facturaEnc.Id;
            registro.TipoDocumento = facturaEnc.TipoDocumento;
            registro.Factura = facturaEnc.Factura;
            registro.MovInventarioEncId = facturaEnc.MovInventarioEncId;
            registro.EnInvestigacion = facturaEnc.EnInvestigacion;
            registro.TransAdicionales = facturaEnc.TransAdicionales;
            registro.EstadoRemision = facturaEnc.EstadoRemision;
            registro.PartidaDocumento = facturaEnc.PartidaDocumento;
            registro.DescuentoVolumen = facturaEnc.DescuentoVolumen;
            registro.MonedaFactura = facturaEnc.MonedaFactura;
            registro.ComentarioCXC = facturaEnc.ComentarioCXC;
            registro.FechaDespacho = facturaEnc.FechaDespacho;
            registro.ClaseDocumento = facturaEnc.ClaseDocumento;
            registro.FechaRecibido = facturaEnc.FechaRecibido;
            registro.Pedido = facturaEnc.Pedido;
            registro.FacturaOriginal = facturaEnc.FacturaOriginal;
            registro.TipoOriginal = facturaEnc.TipoOriginal;
            registro.ComisionCobrador = facturaEnc.ComisionCobrador;
            registro.TarjetaCredito = facturaEnc.TarjetaCredito;
            registro.TotalVolumen = facturaEnc.TotalVolumen;
            registro.NumeroAutoriza = facturaEnc.NumeroAutoriza;
            registro.TotalPeso = facturaEnc.TotalPeso;
            registro.MontoCobrado = facturaEnc.MontoCobrado;
            registro.TotalImpuesto1 = facturaEnc.TotalImpuesto1;
            registro.Fecha = facturaEnc.Fecha;
            registro.FechaEntrega = facturaEnc.FechaEntrega;
            registro.TotalImpuesto2 = facturaEnc.TotalImpuesto2;
            registro.PorDescuento2 = facturaEnc.PorDescuento2;
            registro.MontoFlete = facturaEnc.MontoFlete;
            registro.MontoSeguro = facturaEnc.MontoSeguro;
            registro.MontoDocumentacio = facturaEnc.MontoDocumentacio;
            registro.TipoDescuento1 = facturaEnc.TipoDescuento1;
            registro.TipoDescuento2 = facturaEnc.TipoDescuento2;
            registro.MontoDescuento1 = facturaEnc.MontoDescuento1;
            registro.MontoDescuento2 = facturaEnc.MontoDescuento2;
            registro.PorcDescuento1 = facturaEnc.PorcDescuento1;
            registro.TotalFactura = facturaEnc.TotalFactura;
            registro.FechaPedido = facturaEnc.FechaPedido;
            registro.FechaHoraAnula = facturaEnc.FechaHoraAnula;
            registro.FechaOrden = facturaEnc.FechaOrden;
            registro.TotalMercaderia = facturaEnc.TotalMercaderia;
            registro.ComisionVendedor = facturaEnc.ComisionVendedor;
            registro.OrdenCompra = facturaEnc.OrdenCompra;
            registro.FechaHora = facturaEnc.FechaHora;
            registro.TotalUnidades = facturaEnc.TotalUnidades;
            registro.NumeroPaginas = facturaEnc.NumeroPaginas;
            registro.TipoCambio = facturaEnc.TipoCambio;
            registro.Anulada = facturaEnc.Anulada;
            registro.Modulo = facturaEnc.Modulo;
            registro.CargadoCG = facturaEnc.CargadoCG;
            registro.CargadoCXC = facturaEnc.CargadoCXC;
            registro.EmbarcarA = facturaEnc.EmbarcarA;
            registro.DirecEmbarque = facturaEnc.DirecEmbarque;
            registro.MultiplicadorEV = facturaEnc.MultiplicadorEV;
            registro.Observaciones = facturaEnc.Observaciones;
            registro.Rubro1 = facturaEnc.Rubro1;
            registro.Rubro2 = facturaEnc.Rubro2;
            registro.Rubro3 = facturaEnc.Rubro3;
            registro.Rubro4 = facturaEnc.Rubro4;
            registro.Rubro5 = facturaEnc.Rubro5;
            registro.VersionNPId = facturaEnc.VersionNPId;
            registro.CobradorId = facturaEnc.CobradorId;
            registro.RutaId = facturaEnc.RutaId;
            registro.Usuario = facturaEnc.Usuario;
            registro.UsuarioAnula = facturaEnc.UsuarioAnula;
            registro.CondicionPagoId = facturaEnc.CondicionPagoId;
            registro.ZonaId = facturaEnc.ZonaId;
            registro.VendedorId = facturaEnc.VendedorId;
            registro.DocCreditoCCId = facturaEnc.DocCreditoCCId;
            registro.ClienteDireccionId = facturaEnc.ClienteDireccionId;
            registro.ClienteCorporacId = facturaEnc.ClienteCorporacId;
            registro.ClienteOrigenId = facturaEnc.ClienteOrigenId;
            registro.ClienteId = facturaEnc.ClienteId;
            registro.PaisId = facturaEnc.PaisId;
            registro.SubTipoDocCCId = facturaEnc.SubTipoDocCCId;
            registro.MontoAnticipo = facturaEnc.MontoAnticipo;
            registro.TotalPesoNeto = facturaEnc.TotalPesoNeto;
            registro.FechaRige = facturaEnc.FechaRige;
            registro.PorcIntCte = facturaEnc.PorcIntCte;
            registro.Cobrada = facturaEnc.Cobrada;
            registro.DescuentoCascada = facturaEnc.DescuentoCascada;
            registro.DireccionFactura = facturaEnc.DireccionFactura;
            registro.DireccEmbarqueId = facturaEnc.DireccEmbarqueId;
            registro.ConsecutivoId = facturaEnc.ConsecutivoId;
            registro.Reimpreso = facturaEnc.Reimpreso;
            registro.DivisionGeografica1Id = facturaEnc.DivisionGeografica1Id;
            registro.DivisionGeografica2Id = facturaEnc.DivisionGeografica2Id;
            registro.BaseImpuesto1 = facturaEnc.BaseImpuesto1;
            registro.BaseImpuesto2 = facturaEnc.BaseImpuesto2;
            registro.NombreCliente = facturaEnc.NombreCliente;
            registro.DocFiscal = facturaEnc.DocFiscal;
            registro.NombreMaquina = facturaEnc.NombreMaquina;
            registro.SerieResolución = facturaEnc.SerieResolución;
            registro.ConsecResolucion = facturaEnc.ConsecResolucion;
            registro.GeneraDocFE = facturaEnc.GeneraDocFE;
            registro.TasaImpositiva = facturaEnc.TasaImpositiva;
            registro.TasaImpositivaPorc = facturaEnc.TasaImpositivaPorc;
            registro.TasaCree1 = facturaEnc.TasaCree1;
            registro.TasaCree1Porc = facturaEnc.TasaCree1Porc;
            registro.TasaCree2 = facturaEnc.TasaCree2;
            registro.TasaCree2Porc = facturaEnc.TasaCree2Porc;
            registro.AjusteRedondeo = facturaEnc.AjusteRedondeo;
            registro.FormaPago = facturaEnc.FormaPago;
            registro.JustiDevHaciend = facturaEnc.JustiDevHaciend;
            registro.Incoterms = facturaEnc.Incoterms;
            registro.MontoOtroCargo = facturaEnc.MontoOtroCargo;
            registro.MontoTotalIVADevuelto = facturaEnc.MontoTotalIVADevuelto;
            registro.Cancelacion = facturaEnc.Cancelacion;
            registro.EstadoCancelación = facturaEnc.EstadoCancelación;
            registro.TieneRelacionados = facturaEnc.TieneRelacionados;
            registro.Prefijo = facturaEnc.Prefijo;
            registro.FechaInicioResolucion = facturaEnc.FechaInicioResolucion;
            registro.FechaFinalResolucion = facturaEnc.FechaFinalResolucion;
            registro.ClaveTecnica = facturaEnc.ClaveTecnica;
            registro.MatriculaMercantil = facturaEnc.MatriculaMercantil;
            registro.EsFacturaReemplazo = facturaEnc.EsFacturaReemplazo;
            registro.FacOriginalReemplazoId = facturaEnc.FacOriginalReemplazoId;
            registro.ConsecutivoFTC = facturaEnc.ConsecutivoFTC;
            registro.NumeroFTC = facturaEnc.NumeroFTC;
            registro.NITTransportador = facturaEnc.NITTransportador;
            registro.NCFModificado = facturaEnc.NCFModificado;
            registro.NumOCExenta = facturaEnc.NumOCExenta;
            registro.IsDeleted = facturaEnc.IsDeleted;
            registro.Updatedby = facturaEnc.Updatedby;
            registro.UpdateDate = facturaEnc.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<FacturaEnc>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return facturaEnc.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new FacturaEnc
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<FacturaEnc?> BuscarFacturaEncAsync(string tipoDocumento, string factura)
    {
        return await _dbContext.FacturaEncs
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.TipoDocumento == tipoDocumento &&  t.Factura == factura);
    }
}