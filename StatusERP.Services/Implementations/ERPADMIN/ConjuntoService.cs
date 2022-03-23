using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN;

public class ConjuntoService:IConjuntoService
{
    private readonly IConjuntoRepository _repository;
    private readonly ILogger<ConjuntoService> _logger;

    public ConjuntoService( IConjuntoRepository repository,ILogger<ConjuntoService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Conjunto>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Conjunto>>();
        try
        {
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

    public async Task<BaseResponseGeneric<Conjunto>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Conjunto>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Conjunto();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConjunto request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new Conjunto
            {
                Compania = request.Conjunto,
                Nombre = request.Nombre,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                Logo = request.logo,
                DobleMoneda = request.DobleMoneda,
                DobleContabilidad = request.DobleContabilidad,
                UsaLotes = request.UsaLotes,
                UsaCentroCosto = request.UsaCentroCosto,
                UsuarioUltMod = userId,
                FechaUltMod = DateTime.Now,
                Notas = request.Notas,
                VersionBD = request.VersionDB,
                UsuarioModBd = userId,
                FechaHoraModBd = DateTime.Now,
                VersionInstalada = request.VersionInstalada,
                DocTributario = request.DocTributario,
                Pais = request.Pais,
                UsaSucursales = request.UsaSucrusales,
                MascaraSucursal = request.MascaraSucrusal,
                DireccionWeb = request.DireccionWeb,
                CorreoDocElectronico = request.CoreoDocEletronico,
                NumeroRegistro = request.NumeroRegistro,
                ActividadComercial = request.ActividadComercial,
                AgentePercepcion = request.AgentePercepcion,
                AgenteRetencion = request.AgenteRetencion,
                MembresiaId = request.MembresiaId,
                FechaVence = request.FechaVencimiento,
                Activa = true,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConjunto request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Conjunto
            {
                Id = id,
                Compania = request.Conjunto,
                Nombre = request.Nombre,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                Logo = request.logo,
                DobleMoneda = request.DobleMoneda,
                DobleContabilidad = request.DobleContabilidad,
                UsaLotes = request.UsaLotes,
                UsaCentroCosto = request.UsaCentroCosto,
                UsuarioUltMod = userId,
                FechaUltMod = DateTime.Now,
                Notas = request.Notas,
                VersionBD = request.VersionDB,
                UsuarioModBd = userId,
                FechaHoraModBd = DateTime.Now,
                VersionInstalada = request.VersionInstalada,
                DocTributario = request.DocTributario,
                Pais = request.Pais,
                UsaSucursales = request.UsaSucrusales,
                MascaraSucursal = request.MascaraSucrusal,
                DireccionWeb = request.DireccionWeb,
                CorreoDocElectronico = request.CoreoDocEletronico,
                NumeroRegistro = request.NumeroRegistro,
                ActividadComercial = request.ActividadComercial,
                AgentePercepcion = request.AgentePercepcion,
                AgenteRetencion = request.AgenteRetencion,
                MembresiaId = request.MembresiaId,
                FechaVence = request.FechaVencimiento,
                Activa = request.Activa ,
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

    public  async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
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
}