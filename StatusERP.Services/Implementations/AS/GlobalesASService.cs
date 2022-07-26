using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class GlobalesASService:IGlobalesASService
{
    private readonly IGlobalesAsRepository _repository;
    private readonly ILogger<GlobalesASService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public GlobalesASService(IGlobalesAsRepository repository,ILogger<GlobalesASService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }
     public async Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<GlobalesAS>>();
        try
        {
            //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_GLOBALES", 9, userId);


            //if (buscarPrivilegio == null)
            //{
            //    response.Errors.Add($"No tiene Privilegios para ver Globales AS");
            //    response.Success = false;
            //    return response;
            //}
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

    public async Task<BaseResponseGeneric<GlobalesAS>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<GlobalesAS>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new GlobalesAS();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesAS request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new GlobalesAS
            {
                FechaAdvIni = request.FechaAdvIni,
                FechaAdvFin = request.FechaAdvFin,
                FechaTrabajoIni = request.FechaTrabajoIni,
                FechaTrabajoFin = request.FechaTrabajoFin,
                NombreMoneda = request.NombreMoneda,
                SimboloMoneda = request.SimboloMoneda,
                Impuesto1Desc = request.Impuesto1Desc,
                Impuesto2Desc = request.Impuesto2Desc,
                PaisLocalId = request.PaisLocalId,
                MonedaDolarId = request.MonedaDolarId,
                MonedaLocalId = request.MonedaLocalId,
                TipoCambioId = request.TipoCambioId,
                PatronCeCo = request.PatronCeCo,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesAS request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new GlobalesAS
            {
                Id = id,
                FechaAdvIni = request.FechaAdvIni,
                FechaAdvFin = request.FechaAdvFin,
                FechaTrabajoIni = request.FechaTrabajoIni ,
                FechaTrabajoFin = request.FechaTrabajoFin,
                NombreMoneda = request.NombreMoneda,
                SimboloMoneda = request.SimboloMoneda,
                Impuesto1Desc = request.Impuesto1Desc ,
                Impuesto2Desc = request.Impuesto2Desc ,
                PaisLocalId = request.PaisLocalId,
                MonedaDolarId = request.MonedaDolarId,
                MonedaLocalId = request.MonedaLocalId,
                TipoCambioId = request.TipoCambioId,
                PatronCeCo = request.PatronCeCo,
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

    public async Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAllAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<GlobalesAS>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_GLOBALES", 9, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para ver Globales AS");
                response.Success = false;
                return response;
            }
            response.Result = await _repository.GetAllAsync();
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