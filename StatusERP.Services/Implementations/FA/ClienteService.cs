using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly ILogger<ClienteService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public ClienteService(IClienteRepository repository, ILogger<ClienteService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCliente request, string userId, string codCliente)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_CLIENTESADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Clientes.");
                response.Success = false;
                return response;
            }

            var buscarCodCliente = await _repository.BuscarCodClienteAsync(codCliente);
            if (buscarCodCliente != null)
            {
                throw new Exception($"El código de Cliente {buscarCodCliente.CodCliente} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new Cliente
            {
                CodCliente = request.CodCliente,
                Nombre = request.Nombre,
                Alias = request.Alias,
                Contacto = request.Contacto,
                Cargo = request.Cargo,
                Direccion = request.Direccion,
                DirEmbarqueDefault = request.DirEmbarqueDefault,
                Telefono1 = request.Telefono1,
                Telefono2 = request.Telefono2,
                FechaIngreso = request.FechaIngreso,
                Multimoneda = request.Multimoneda,
                Saldo = request.Saldo,
                SaldoLocal = request.SaldoLocal,
                SaldoDolar = request.SaldoDolar,
                SaldoCredito = request.SaldoCredito,
                SaldoNoCargos = request.SaldoNoCargos,
                LimiteCredito = request.LimiteCredito,
                ExcederLimite = request.ExcederLimite,
                TasaInteres = request.TasaInteres,
                TasaInteresesMora = request.TasaInteresesMora,
                FechaUltMora = request.FechaUltMora,
                FechaUltMov = request.FechaUltMov,
                Descuento = request.Descuento,
                AceptaBackorder = request.AceptaBackorder,
                AceptaFracciones = request.AceptaFracciones,
                Activo = request.Activo,
                ExentoImpuestos = request.ExentoImpuestos,
                ExencionImp1 = request.ExencionImp1,
                ExencionImp2 = request.ExencionImp2,
                CobroJudicial = request.CobroJudicial,
                ClaseABC = request.ClaseABC,
                DiasAbastecimien = request.DiasAbastecimien,
                UsaTarjeta = request.UsaTarjeta,
                TarjetaCredito = request.TarjetaCredito,
                FechaVenceTar = request.FechaVenceTar,
                Email = request.Email,
                RequiereOC = request.RequiereOC,
                EsCorporacion = request.EsCorporacion,
                XSLTPersonalizadoCredito = request.XSLTPersonalizadoCredito,
                RegistrarDocsACorp = request.RegistrarDocsACorp,
                UsarDirEmbCorp = request.UsarDirEmbCorp,
                AplicacAbiertas = request.AplicacAbiertas,
                VerifLimCredCorp = request.VerifLimCredCorp,
                UsarDescCorp = request.UsarDescCorp,
                DocAGenerar = request.DocAGenerar,
                Rubro1Cliente = request.Rubro1Cliente,
                Rubro2Cliente = request.Rubro2Cliente,
                Rubro3Cliente = request.Rubro3Cliente,
                TieneConvenio = request.TieneConvenio,
                Notas = request.Notas,
                DiasPromedAtraso = request.DiasPromedAtraso,
                Rubro1Cli = request.Rubro1Cli,
                Rubro2Cli = request.Rubro2Cli,
                Rubro3Cli = request.Rubro3Cli,
                Rubro4Cli = request.Rubro4Cli,
                Rubro5Cli = request.Rubro5Cli,
                AsocObligContFact = request.AsocObligContFact,
                Rubro4Cliente = request.Rubro4Cliente,
                Rubro5Cliente = request.Rubro5Cliente,
                Rubro6Cliente = request.Rubro6Cliente,
                Rubro7Cliente = request.Rubro7Cliente,
                Rubro8Cliente = request.Rubro8Cliente,
                Rubro9Cliente = request.Rubro9Cliente,
                Rubro10Cliente = request.Rubro10Cliente,
                UsarPreciosCorp = request.UsarPreciosCorp,
                UsarExencImpCorp = request.UsarExencImpCorp,
                DiasDeCobro = request.DiasDeCobro,
                AjusteFechaCobro = request.AjusteFechaCobro,
                Ubicacion = request.Ubicacion,
                ClaseDocumento = request.ClaseDocumento,
                Local = request.Local,
                TipoContribuyente = request.TipoContribuyente,
                Rubro11Cliente = request.Rubro11Cliente,
                Rubro12Cliente = request.Rubro12Cliente,
                Rubro13Cliente = request.Rubro13Cliente,
                Rubro14Cliente = request.Rubro14Cliente,
                Rubro15Cliente = request.Rubro15Cliente,
                Rubro16Cliente = request.Rubro16Cliente,
                Rubro17Cliente = request.Rubro17Cliente,
                Rubro18Cliente = request.Rubro18Cliente,
                Rubro19Cliente = request.Rubro19Cliente,
                Rubro20Cliente = request.Rubro20Cliente,
                AceptaDocElectronico = request.AceptaDocElectronico,
                ConfirmaDocElectronico = request.ConfirmaDocElectronico,
                EmailDocElectronico = request.EmailDocElectronico,
                EmailPedEDI = request.EmailPedEDI,
                AceptaDocEDI = request.AceptaDocEDI,
                NotificarErrorEDI = request.NotificarErrorEDI,
                EmailErrorPedEDI = request.EmailErrorPedEDI,
                DivisionGeografica1 = request.DivisionGeografica1,
                DivisionGeografica2 = request.DivisionGeografica2,
                Moroso = request.Moroso,
                ModifNombEnFac = request.ModifNombEnFac,
                SaldoTrans = request.SaldoTrans,
                SaldoTransLocal = request.SaldoTransLocal,
                SaldoTransDolar = request.SaldoTransDolar,
                ParticipaFlujoCaja = request.ParticipaFlujoCaja,
                UsuarioCreacion = request.UsuarioCreacion,
                FechaHoraCreacion = request.FechaHoraCreacion,
                UsuarioUltMod = request.UsuarioUltMod,
                FchHoraUltMod = request.FchHoraUltMod,
                EmailDocElectronicoCopia = request.EmailDocElectronicoCopia,
                DetallarKits = request.DetallarKits,
                XSLTPersonalizado = request.XSLTPersonalizado,
                NombreAddenda = request.NombreAddenda,
                GeoLatitud = request.GeoLatitud,
                GeoLongitud = request.GeoLongitud,
                SubTipoDoc = request.SubTipoDoc,
                EsBuenContribuyente = request.EsBuenContribuyente,
                EsExtranjero = request.EsExtranjero,
                TipoGenerar = request.TipoGenerar,
                TipoPersoneria = request.TipoPersoneria,
                EsAgentePercepcion = request.EsAgentePercepcion,
                ZonaId = request.ZonaId,
                DocTributarioId = request.DocTributarioId,
                CategoriaClienteId = request.CategoriaClienteId,
                CliCorporacAsocId = request.CliCorporacAsocId,
                CobradorId = request.CobradorId,
                CondicionPagoId = request.CondicionPagoId,
                DetalleDireccionId = request.DetalleDireccionId,
                ImpuestoId = request.ImpuestoId,
                MetodoPagoId = request.MetodoPagoId,
                MonedaId = request.MonedaId,
                NivelPrecioId = request.NivelPrecioId,
                PaisId = request.PaisId,
                RutaId = request.RutaId,
                TipoImpuestoId = request.TipoImpuestoId,
                TipoTarjetaId = request.TipoTarjetaId,
                VendedorId = request.VendedorId,
                PassAPIRecepcion = request.PassAPIRecepcion,
                IsDeleted = false,
                Updatedby = userId, 
                UpdateDate = DateTime.Now,
                Createdby = userId,
                CreateDate = DateTime.Now
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {

        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_CLIENTESDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Clientes.");
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

    public async Task<BaseResponseGeneric<ICollection<Cliente>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<Cliente>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_CLIENTES", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Clientes.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.GetCollectionAsync();
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

    public async Task<BaseResponseGeneric<Cliente>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Cliente>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Cliente();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCliente request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_CLIENTESMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Clientes.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new Cliente
            {
                Id = id,
                CodCliente = request.CodCliente,
                Nombre = request.Nombre,
                Alias = request.Alias,
                Contacto = request.Contacto,
                Cargo = request.Cargo,
                Direccion = request.Direccion,
                DirEmbarqueDefault = request.DirEmbarqueDefault,
                Telefono1 = request.Telefono1,
                Telefono2 = request.Telefono2,
                FechaIngreso = request.FechaIngreso,
                Multimoneda = request.Multimoneda,
                Saldo = request.Saldo,
                SaldoLocal = request.SaldoLocal,
                SaldoDolar = request.SaldoDolar,
                SaldoCredito = request.SaldoCredito,
                SaldoNoCargos = request.SaldoNoCargos,
                LimiteCredito = request.LimiteCredito,
                ExcederLimite = request.ExcederLimite,
                TasaInteres = request.TasaInteres,
                TasaInteresesMora = request.TasaInteresesMora,
                FechaUltMora = request.FechaUltMora,
                FechaUltMov = request.FechaUltMov,
                Descuento = request.Descuento,
                AceptaBackorder = request.AceptaBackorder,
                AceptaFracciones = request.AceptaFracciones,
                Activo = request.Activo,
                ExentoImpuestos = request.ExentoImpuestos,
                ExencionImp1 = request.ExencionImp1,
                ExencionImp2 = request.ExencionImp2,
                CobroJudicial = request.CobroJudicial,
                ClaseABC = request.ClaseABC,
                DiasAbastecimien = request.DiasAbastecimien,
                UsaTarjeta = request.UsaTarjeta,
                TarjetaCredito = request.TarjetaCredito,
                FechaVenceTar = request.FechaVenceTar,
                Email = request.Email,
                RequiereOC = request.RequiereOC,
                EsCorporacion = request.EsCorporacion,
                XSLTPersonalizadoCredito = request.XSLTPersonalizadoCredito,
                RegistrarDocsACorp = request.RegistrarDocsACorp,
                UsarDirEmbCorp = request.UsarDirEmbCorp,
                AplicacAbiertas = request.AplicacAbiertas,
                VerifLimCredCorp = request.VerifLimCredCorp,
                UsarDescCorp = request.UsarDescCorp,
                DocAGenerar = request.DocAGenerar,
                Rubro1Cliente = request.Rubro1Cliente,
                Rubro2Cliente = request.Rubro2Cliente,
                Rubro3Cliente = request.Rubro3Cliente,
                TieneConvenio = request.TieneConvenio,
                Notas = request.Notas,
                DiasPromedAtraso = request.DiasPromedAtraso,
                Rubro1Cli = request.Rubro1Cli,
                Rubro2Cli = request.Rubro2Cli,
                Rubro3Cli = request.Rubro3Cli,
                Rubro4Cli = request.Rubro4Cli,
                Rubro5Cli = request.Rubro5Cli,
                AsocObligContFact = request.AsocObligContFact,
                Rubro4Cliente = request.Rubro4Cliente,
                Rubro5Cliente = request.Rubro5Cliente,
                Rubro6Cliente = request.Rubro6Cliente,
                Rubro7Cliente = request.Rubro7Cliente,
                Rubro8Cliente = request.Rubro8Cliente,
                Rubro9Cliente = request.Rubro9Cliente,
                Rubro10Cliente = request.Rubro10Cliente,
                UsarPreciosCorp = request.UsarPreciosCorp,
                UsarExencImpCorp = request.UsarExencImpCorp,
                DiasDeCobro = request.DiasDeCobro,
                AjusteFechaCobro = request.AjusteFechaCobro,
                Ubicacion = request.Ubicacion,
                ClaseDocumento = request.ClaseDocumento,
                Local = request.Local,
                TipoContribuyente = request.TipoContribuyente,
                Rubro11Cliente = request.Rubro11Cliente,
                Rubro12Cliente = request.Rubro12Cliente,
                Rubro13Cliente = request.Rubro13Cliente,
                Rubro14Cliente = request.Rubro14Cliente,
                Rubro15Cliente = request.Rubro15Cliente,
                Rubro16Cliente = request.Rubro16Cliente,
                Rubro17Cliente = request.Rubro17Cliente,
                Rubro18Cliente = request.Rubro18Cliente,
                Rubro19Cliente = request.Rubro19Cliente,
                Rubro20Cliente = request.Rubro20Cliente,
                AceptaDocElectronico = request.AceptaDocElectronico,
                ConfirmaDocElectronico = request.ConfirmaDocElectronico,
                EmailDocElectronico = request.EmailDocElectronico,
                EmailPedEDI = request.EmailPedEDI,
                AceptaDocEDI = request.AceptaDocEDI,
                NotificarErrorEDI = request.NotificarErrorEDI,
                EmailErrorPedEDI = request.EmailErrorPedEDI,
                DivisionGeografica1 = request.DivisionGeografica1,
                DivisionGeografica2 = request.DivisionGeografica2,
                Moroso = request.Moroso,
                ModifNombEnFac = request.ModifNombEnFac,
                SaldoTrans = request.SaldoTrans,
                SaldoTransLocal = request.SaldoTransLocal,
                SaldoTransDolar = request.SaldoTransDolar,
                ParticipaFlujoCaja = request.ParticipaFlujoCaja,
                UsuarioCreacion = request.UsuarioCreacion,
                FechaHoraCreacion = request.FechaHoraCreacion,
                UsuarioUltMod = request.UsuarioUltMod,
                FchHoraUltMod = request.FchHoraUltMod,
                EmailDocElectronicoCopia = request.EmailDocElectronicoCopia,
                DetallarKits = request.DetallarKits,
                XSLTPersonalizado = request.XSLTPersonalizado,
                NombreAddenda = request.NombreAddenda,
                GeoLatitud = request.GeoLatitud,
                GeoLongitud = request.GeoLongitud,
                SubTipoDoc = request.SubTipoDoc,
                EsBuenContribuyente = request.EsBuenContribuyente,
                EsExtranjero = request.EsExtranjero,
                TipoGenerar = request.TipoGenerar,
                TipoPersoneria = request.TipoPersoneria,
                EsAgentePercepcion = request.EsAgentePercepcion,
                ZonaId = request.ZonaId,
                DocTributarioId = request.DocTributarioId,
                CategoriaClienteId = request.CategoriaClienteId,
                CliCorporacAsocId = request.CliCorporacAsocId,
                CobradorId = request.CobradorId,
                CondicionPagoId = request.CondicionPagoId,
                DetalleDireccionId = request.DetalleDireccionId,
                ImpuestoId = request.ImpuestoId,
                MetodoPagoId = request.MetodoPagoId,
                MonedaId = request.MonedaId,
                NivelPrecioId = request.NivelPrecioId,
                PaisId = request.PaisId,
                RutaId = request.RutaId,
                TipoImpuestoId = request.TipoImpuestoId,
                TipoTarjetaId = request.TipoTarjetaId,
                VendedorId = request.VendedorId,
                PassAPIRecepcion = request.PassAPIRecepcion,
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