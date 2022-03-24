using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class DivGeografica1Service : IDivGeografica1Service
{
    private readonly IDivGeografica1Repository _repository;
    private readonly ILogger<DivGeografica1Service> _logger;

    public DivGeografica1Service( IDivGeografica1Repository repository,ILogger<DivGeografica1Service> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<DivGeografica1>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<DivGeografica1>>();
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

        return response; throw new NotImplementedException();
    }

    public async Task<BaseResponseGeneric<DivGeografica1>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<DivGeografica1>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new DivGeografica1();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDivGeografica1 request, string userId, string codDivGeografica)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodDivGeografica = await _repository.BuscarCodDivGeografica1Async(codDivGeografica);
            if (buscarCodDivGeografica != null)
            {
                throw new Exception($"El codigo de Division Geografica {buscarCodDivGeografica.CodDivGeografica1} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new DivGeografica1
            {
                PaisId = request.PaisId,
                CodDivGeografica1 = request.CodDivGeografica1,
                Nombre= request.Nombre,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDivGeografica1 request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new DivGeografica1
            {
                Id = id,
                PaisId = request.PaisId,
                CodDivGeografica1 = request.CodDivGeografica1,
                Nombre = request.Nombre,
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