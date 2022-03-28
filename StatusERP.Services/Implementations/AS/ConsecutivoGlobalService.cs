using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class ConsecutivoGlobalService:IConsecutivoGlobalService
{
    private readonly IConsecutivoGlobalRepository _repository;
    private readonly ILogger<ConsecutivoGlobalService> _logger;

    public ConsecutivoGlobalService(IConsecutivoGlobalRepository repository,ILogger<ConsecutivoGlobalService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<ConsecutivoGlobal>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<ConsecutivoGlobal>>();
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

    public async Task<BaseResponseGeneric<ConsecutivoGlobal>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<ConsecutivoGlobal>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new ConsecutivoGlobal();
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

    public  async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoGlobal request, string userId,string codConsecutivoGlobal)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodConsecutivoGlobal = await _repository.BuscarCodConsecutivoGlobalesAsync(codConsecutivoGlobal);
            if (buscarCodConsecutivoGlobal != null)
            {
                throw new Exception($"El codigo de Consecutivo Global {buscarCodConsecutivoGlobal.CodConsecutivoGlobal} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new ConsecutivoGlobal
            {
                CodConsecutivoGlobal = request.CodConsecutivoGlobal,
                Descripcion = request.Descripcion,
                Activo = true,
                Longitud = request.Longitud,
                Entidad = request.Entidad,
                Documento = request.Documento,
                FormatoImpresionDetallado = request.FormatoImpresionDetallado,
                FormatoImpresionResumido = request.FormatoImpresionResumido,
                Mascara = request.Mascara,
                ValorInicial = request.ValorInicial,
                ValorFinal = request.ValorFinal,
                UltimoValor = request.UltimoValor,
                UltimoUsuario = userId,
                FechaHoraUlt = DateTime.Now,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoGlobal request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new ConsecutivoGlobal
            {
                Id = id,
                CodConsecutivoGlobal = request.CodConsecutivoGlobal,
                Descripcion = request.Descripcion,
                Activo = true,
                Longitud = request.Longitud,
                Entidad = request.Entidad,
                Documento = request.Documento,
                FormatoImpresionDetallado = request.FormatoImpresionDetallado,
                FormatoImpresionResumido = request.FormatoImpresionResumido,
                Mascara = request.Mascara,
                ValorInicial = request.ValorInicial,
                ValorFinal = request.ValorFinal,
                UltimoValor = request.UltimoValor,
                UltimoUsuario = userId,
                FechaHoraUlt = DateTime.Now,
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