using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN;

public class ParentescoService :IParentescoService
{
    private readonly IParentescoRepository _repository;
    private readonly ILogger<ParentescoService> _logger;

    public ParentescoService( IParentescoRepository repository,ILogger<ParentescoService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<Parentesco>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<Parentesco>>();
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

    public async Task<BaseResponseGeneric<Parentesco>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Parentesco>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new Parentesco();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoParentesco request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new Parentesco
            {
                AccionId = request.AccionId,
                Padre = request.Padre,
                NumeroHermano = request.NumeroHermano,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoParentesco request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new Parentesco
            {
                Id = id,
                AccionId = request.AccionId,
                Padre = request.Padre,
                NumeroHermano = request.NumeroHermano,
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