using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS;

public class DocTributarioService:IDocTributarioService
{
    private readonly IDocTributarioRepository _repository;
    private readonly ILogger<DocTributarioService> _logger;

    public DocTributarioService(IDocTributarioRepository repository,ILogger<DocTributarioService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<BaseResponseGeneric<ICollection<DocTributario>>> GetAsync(int page, int rows)
    {
        var response = new BaseResponseGeneric<ICollection<DocTributario>>();
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

    public async Task<BaseResponseGeneric<DocTributario>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<DocTributario>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new DocTributario();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoDocTributario request, string userId, string codDocTributario)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarCodDocTributario = await _repository.BuscarDocTributarioAsync(codDocTributario);
            if (buscarCodDocTributario != null)
            {
                throw new Exception($"El codigo de Documento Tributario {buscarCodDocTributario.CodDocTributario} ya Existe");
            }
            response.Result = await _repository.CreateAsync(new DocTributario
            {
                CodDocTributario = request.CodDocTributario,
                RazonSocial = request.razonSocial,
                Alias = request.Alias,
                Notas = request.Nota,
                DigitoVerificador = request.DigitoVerificador,
                Activo = true,
                TipoContribuyente = request.TipoContribuyente,
                NRC = request.Nrc,
                Giro = request.Giro,
                Categoria = request.Categoria,
                DUI = request.Dui,
                Pasaporte = request.Pasaporte,
                Carnet = request.Carnet,
                Otro = request.Otro,
                InfoLegal = request.infoLegal,
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocTributario request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            response.Result = await _repository.UpdateAsync(new DocTributario
            {
                Id = id,
                CodDocTributario = request.CodDocTributario,
                RazonSocial = request.razonSocial,
                Alias = request.Alias,
                Notas = request.Nota,
                DigitoVerificador = request.DigitoVerificador,
                Activo = true,
                TipoContribuyente = request.TipoContribuyente,
                NRC = request.Nrc,
                Giro = request.Giro,
                Categoria = request.Categoria,
                DUI = request.Dui,
                Pasaporte = request.Pasaporte,
                Carnet = request.Carnet,
                Otro = request.Otro,
                InfoLegal = request.infoLegal,
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