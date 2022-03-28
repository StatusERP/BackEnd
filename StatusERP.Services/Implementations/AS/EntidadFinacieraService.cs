using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class EntidadFinacieraService:IEntidadFinacieraService
{
    private readonly IEntidadFinacieraRepository _repository;
    private readonly ILogger<EntidadFinanciera> _logger;

    public EntidadFinacieraService(IEntidadFinacieraRepository repository,ILogger<EntidadFinanciera> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public  async Task<BaseResponseGeneric<ICollection<EntidadFinanciera>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<EntidadFinanciera>>();
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

    public async Task<BaseResponseGeneric<EntidadFinanciera>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<EntidadFinanciera>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new EntidadFinanciera();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoEntidadFinaciera request, string userId,string codEntFinaciera)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodDocTributario = await _repository.BuscarCodEntidadFinacieraAsync(codEntFinaciera);
            if (buscarCodDocTributario != null)
            {
                throw new Exception($"El codigo de Entidad Finaciera {buscarCodDocTributario.CodEntidadFinanciera} ya Existe");
            }
            
            response.Result = await _repository.CreateAsync(new EntidadFinanciera
            {
                CodEntidadFinanciera = request.CodEntidadFinaciera,
                Descripcion = request.Descripcion,
                CodElectronico = request.CodEletronico,
                DocTributarioId = request.DocTributarioId,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEntidadFinaciera request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new EntidadFinanciera
            {
                Id = id,
                CodEntidadFinanciera = request.CodEntidadFinaciera,
                Descripcion = request.Descripcion,
                CodElectronico = request.CodEletronico,
                DocTributarioId = request.DocTributarioId,
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
        var response = new BaseCollectionResponse<int>();
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