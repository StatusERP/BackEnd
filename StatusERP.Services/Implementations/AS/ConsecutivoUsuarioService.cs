using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class ConsecutivoUsuarioService:IConsecutivoUsuarioService
{
    private readonly IConsecutivoUsuarioRepository _repository;
    private readonly ILogger<ConsecutivoUsuarioService> _logger;

    public ConsecutivoUsuarioService( IConsecutivoUsuarioRepository repository,ILogger<ConsecutivoUsuarioService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<ConsecutivoUsuario>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<ConsecutivoUsuario>>();
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

    public async Task<BaseResponseGeneric<ConsecutivoUsuario>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<ConsecutivoUsuario>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new ConsecutivoUsuario();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoUsuario request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.CreateAsync(new ConsecutivoUsuario
            {
                CodConsecutivo = request.CodConsecutivo,
                Usuario = userId,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoUsuario request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new ConsecutivoUsuario
            {
                Id = id,
                CodConsecutivo = request.CodConsecutivo,
                Usuario = userId,
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