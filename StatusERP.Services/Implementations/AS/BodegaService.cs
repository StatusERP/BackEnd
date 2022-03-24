using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class BodegaService:IBodegaService
{
    private readonly IBodegaRepository _repository;
    private readonly ILogger<BodegaService> _logger;

    public BodegaService(IBodegaRepository repository,ILogger<BodegaService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Bodega>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Bodega>>();
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

    public async Task<BaseResponseGeneric<Bodega>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Bodega>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Bodega();
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

    public  async Task<BaseResponseGeneric<int>> CreateAsync(DtoBodega request, string userId,string codBodega)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodBodega = await _repository.BuscarCodBodegaAsync(codBodega);
            if (buscarCodBodega != null)
            {
                throw new Exception($"El codigo de Bodega {buscarCodBodega.CodBodega} ya Existe");
            }
            
            response.Result = await _repository.CreateAsync(new Bodega
            {
                CodBodega = request.CodBodega,
                Nombre = request.Nombre,
                Tipo = request.Tipo,
                Activa = true,
                Telefono = request.Telefono,
                Direccion = request.Direccion,
                SucursalId = request.SucursalId,
                Createdby = userId,
                CreateDate = DateTime.Now,
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

    

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoBodega request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Bodega
            {
                Id = id,
                CodBodega = request.CodBodega,
                Nombre = request.Nombre,
                Tipo = request.Tipo,
                Activa = request.Activa,
                Direccion = request.Direccion,
                SucursalId = request.SucursalId,
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
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