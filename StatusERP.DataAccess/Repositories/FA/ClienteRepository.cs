using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class ClienteRepository : StatusERPContextBase<Cliente>, IClienteRepository
{
    public ClienteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Cliente>> GetCollectionAsync()
    {
        return await _dbContext.Clientes
         .Include(p => p.CategoriaCliente)
         .Include(p => p.CliCorporacAsoc)
         .Include(p => p.Cobrador)
         .Include(p => p.CondicionPago)
         .Include(p => p.detalleDireccion)
         .Include(p => p.DocTributario)
         .Include(p => p.Impuesto)
         .Include(p => p.MetodoPago)
         .Include(p => p.Moneda)
         .Include(p => p.NivelPrecio)
         .Include(p => p.Pais)
         .Include(p => p.Ruta)
         .Include(p => p.TipoImpuesto)
         .Include(p => p.TipoTarjeta)
         .Include(p => p.Vendedor)
         .Include(p => p.Zona)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<Cliente?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Cliente>(id);
    }

    public async Task<int> CreateAsync(Cliente cliente)
    {
        return await _dbContext.InsertAsync(cliente);
    }

    public async Task<int> UpdateAsync(Cliente cliente)
    {
        //await _dbContext.UpdateAsync(Cliente,Mapper);
        //return Cliente.Id;

        try
        {
            var registro = await _dbContext.Set<Cliente>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == cliente.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }
            registro.Id = cliente.Id;
            registro.CodCliente = cliente.CodCliente;
            registro.Nombre = cliente.Nombre;
            registro.Alias = cliente.Alias;
            registro.Contacto = cliente.Contacto;
            registro.Cargo = cliente.Cargo;
            registro.Direccion = cliente.Direccion;
            registro.DirEmbarqueDefault = cliente.DirEmbarqueDefault;
            registro.Telefono1 = cliente.Telefono1;
            registro.Telefono2 = cliente.Telefono2;
            registro.FechaIngreso = cliente.FechaIngreso;
            registro.Multimoneda = cliente.Multimoneda;
            registro.Saldo = cliente.Saldo;
            registro.SaldoLocal = cliente.SaldoLocal;
            registro.SaldoDolar = cliente.SaldoDolar;
            registro.SaldoCredito = cliente.SaldoCredito;
            registro.SaldoNoCargos = cliente.SaldoNoCargos;
            registro.LimiteCredito = cliente.LimiteCredito;
            registro.ExcederLimite = cliente.ExcederLimite;
            registro.TasaInteres = cliente.TasaInteres;
            registro.TasaInteresesMora = cliente.TasaInteresesMora;
            registro.FechaUltMora = cliente.FechaUltMora;
            registro.FechaUltMov = cliente.FechaUltMov;
            registro.Descuento = cliente.Descuento;
            registro.AceptaBackorder = cliente.AceptaBackorder;
            registro.AceptaFracciones = cliente.AceptaFracciones;
            registro.Activo = cliente.Activo;
            registro.ExentoImpuestos = cliente.ExentoImpuestos;
            registro.ExencionImp1 = cliente.ExencionImp1;
            registro.ExencionImp2 = cliente.ExencionImp2;
            registro.CobroJudicial = cliente.CobroJudicial;
            registro.ClaseABC = cliente.ClaseABC;
            registro.DiasAbastecimien = cliente.DiasAbastecimien;
            registro.UsaTarjeta = cliente.UsaTarjeta;
            registro.TarjetaCredito = cliente.TarjetaCredito;
            registro.FechaVenceTar = cliente.FechaVenceTar;
            registro.Email = cliente.Email;
            registro.RequiereOC = cliente.RequiereOC;
            registro.EsCorporacion = cliente.EsCorporacion;
            registro.XSLTPersonalizadoCredito = cliente.XSLTPersonalizadoCredito;
            registro.RegistrarDocsACorp = cliente.RegistrarDocsACorp;
            registro.UsarDirEmbCorp = cliente.UsarDirEmbCorp;
            registro.AplicacAbiertas = cliente.AplicacAbiertas;
            registro.VerifLimCredCorp = cliente.VerifLimCredCorp;
            registro.UsarDescCorp = cliente.UsarDescCorp;
            registro.DocAGenerar = cliente.DocAGenerar;
            registro.Rubro1Cliente = cliente.Rubro1Cliente;
            registro.Rubro2Cliente = cliente.Rubro2Cliente;
            registro.Rubro3Cliente = cliente.Rubro3Cliente;
            registro.TieneConvenio = cliente.TieneConvenio;
            registro.Notas = cliente.Notas;
            registro.DiasPromedAtraso = cliente.DiasPromedAtraso;
            registro.Rubro1Cli = cliente.Rubro1Cli;
            registro.Rubro2Cli = cliente.Rubro2Cli;
            registro.Rubro3Cli = cliente.Rubro3Cli;
            registro.Rubro4Cli = cliente.Rubro4Cli;
            registro.Rubro5Cli = cliente.Rubro5Cli;
            registro.AsocObligContFact = cliente.AsocObligContFact;
            registro.Rubro4Cliente = cliente.Rubro4Cliente;
            registro.Rubro5Cliente = cliente.Rubro5Cliente;
            registro.Rubro6Cliente = cliente.Rubro6Cliente;
            registro.Rubro7Cliente = cliente.Rubro7Cliente;
            registro.Rubro8Cliente = cliente.Rubro8Cliente;
            registro.Rubro9Cliente = cliente.Rubro9Cliente;
            registro.Rubro10Cliente = cliente.Rubro10Cliente;
            registro.UsarPreciosCorp = cliente.UsarPreciosCorp;
            registro.UsarExencImpCorp = cliente.UsarExencImpCorp;
            registro.DiasDeCobro = cliente.DiasDeCobro;
            registro.AjusteFechaCobro = cliente.AjusteFechaCobro;
            registro.Ubicacion = cliente.Ubicacion;
            registro.ClaseDocumento = cliente.ClaseDocumento;
            registro.Local = cliente.Local;
            registro.TipoContribuyente = cliente.TipoContribuyente;
            registro.Rubro11Cliente = cliente.Rubro11Cliente;
            registro.Rubro12Cliente = cliente.Rubro12Cliente;
            registro.Rubro13Cliente = cliente.Rubro13Cliente;
            registro.Rubro14Cliente = cliente.Rubro14Cliente;
            registro.Rubro15Cliente = cliente.Rubro15Cliente;
            registro.Rubro16Cliente = cliente.Rubro16Cliente;
            registro.Rubro17Cliente = cliente.Rubro17Cliente;
            registro.Rubro18Cliente = cliente.Rubro18Cliente;
            registro.Rubro19Cliente = cliente.Rubro19Cliente;
            registro.Rubro20Cliente = cliente.Rubro20Cliente;
            registro.AceptaDocElectronico = cliente.AceptaDocElectronico;
            registro.ConfirmaDocElectronico = cliente.ConfirmaDocElectronico;
            registro.EmailDocElectronico = cliente.EmailDocElectronico;
            registro.EmailPedEDI = cliente.EmailPedEDI;
            registro.AceptaDocEDI = cliente.AceptaDocEDI;
            registro.NotificarErrorEDI = cliente.NotificarErrorEDI;
            registro.EmailErrorPedEDI = cliente.EmailErrorPedEDI;
            registro.DivisionGeografica1 = cliente.DivisionGeografica1;
            registro.DivisionGeografica2 = cliente.DivisionGeografica2;
            registro.Moroso = cliente.Moroso;
            registro.ModifNombEnFac = cliente.ModifNombEnFac;
            registro.SaldoTrans = cliente.SaldoTrans;
            registro.SaldoTransLocal = cliente.SaldoTransLocal;
            registro.SaldoTransDolar = cliente.SaldoTransDolar;
            registro.ParticipaFlujoCaja = cliente.ParticipaFlujoCaja;
            registro.UsuarioCreacion = cliente.UsuarioCreacion;
            registro.FechaHoraCreacion = cliente.FechaHoraCreacion;
            registro.UsuarioUltMod = cliente.UsuarioUltMod;
            registro.FchHoraUltMod = cliente.FchHoraUltMod;
            registro.EmailDocElectronicoCopia = cliente.EmailDocElectronicoCopia;
            registro.DetallarKits = cliente.DetallarKits;
            registro.XSLTPersonalizado = cliente.XSLTPersonalizado;
            registro.NombreAddenda = cliente.NombreAddenda;
            registro.GeoLatitud = cliente.GeoLatitud;
            registro.GeoLongitud = cliente.GeoLongitud;
            registro.SubTipoDoc = cliente.SubTipoDoc;
            registro.EsBuenContribuyente = cliente.EsBuenContribuyente;
            registro.EsExtranjero = cliente.EsExtranjero;
            registro.TipoGenerar = cliente.TipoGenerar;
            registro.TipoPersoneria = cliente.TipoPersoneria;
            registro.EsAgentePercepcion = cliente.EsAgentePercepcion;
            registro.ZonaId = cliente.ZonaId;
            registro.DocTributarioId = cliente.DocTributarioId;
            registro.CategoriaClienteId = cliente.CategoriaClienteId;
            registro.CliCorporacAsocId = cliente.CliCorporacAsocId;
            registro.CobradorId = cliente.CobradorId;
            registro.CondicionPagoId = cliente.CondicionPagoId;
            registro.DetalleDireccionId = cliente.DetalleDireccionId;
            registro.ImpuestoId = cliente.ImpuestoId;
            registro.MetodoPagoId = cliente.MetodoPagoId;
            registro.MonedaId = cliente.MonedaId;
            registro.NivelPrecioId = cliente.NivelPrecioId;
            registro.PaisId = cliente.PaisId;
            registro.RutaId = cliente.RutaId;
            registro.TipoImpuestoId = cliente.TipoImpuestoId;
            registro.TipoTarjetaId = cliente.TipoTarjetaId;
            registro.VendedorId = cliente.VendedorId;
            registro.PassAPIRecepcion = cliente.PassAPIRecepcion;
            registro.IsDeleted = cliente.IsDeleted;
            registro.Updatedby = cliente.Updatedby;
            registro.UpdateDate = cliente.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<Cliente>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return cliente.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Cliente
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<Cliente?> BuscarCodClienteAsync(string codCliente)
    {
        return await _dbContext.Clientes
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCliente == codCliente);
    }
}
