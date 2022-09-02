using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CC.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CC;
using StatusERP.Dto.Response;
using StatusERP.Entities.CC.Tablas;
using StatusERP.Services.Interfaces.CC;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.CC;


public class SubTipoDocCCService : ISubTipoDocCCService
{
    private readonly ISubTipoDocCCRepository _repository;
    private readonly ILogger<SubTipoDocCCService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public SubTipoDocCCService(ISubTipoDocCCRepository repository, ILogger<SubTipoDocCCService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoSubTipoDocCC request, string userId, string tipo, int subTipo)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_SUBTDOCTSADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear subtipos de documentos CC.");
                response.Success = false;
                return response;
            }

            var buscarSubTipoDocCC = await _repository.BuscarSubTipoDocCCAsync(tipo, subTipo);
            if (buscarSubTipoDocCC != null)
            {
                throw new Exception($"El subtipo {buscarSubTipoDocCC.Subtipo} ya existe para el tipo {buscarSubTipoDocCC.Tipo}.");
            }
            response.Result = await _repository.CreateAsync(new SubTipoDocCC
            {
                Tipo = request.Tipo,
                Subtipo = request.Subtipo,
                Descripcion = request.Descripcion,
                CalculaImp2 = request.CalculaImp2,
                DocumentoGlobal = request.DocumentoGlobal,
                ConceptoNC = request.ConceptoNC,
                ConceptoFAC = request.ConceptoFAC,
                ConceptoND = request.ConceptoND,
                TipoDoc = request.TipoDoc,
                TipoOperacFac = request.TipoOperacFac,
                TipoOperacNC = request.TipoOperacNC,
                TipoOperacND = request.TipoOperacND,
                CentroCuentaId = request.CentroCuentaId,
                ConsecutivoFacId = request.ConsecutivoFacId,
                PaqueteId = request.PaqueteId,
                SubTipoCBId = request.SubTipoCBId,
                TipoPartidaId = request.TipoPartidaId,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_SUBTDOCTSDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar subtipos de Documentos CC.");
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

    public async Task<BaseResponseGeneric<ICollection<SubTipoDocCC>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<SubTipoDocCC>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_SUBTDOCTS", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar subtipos de Documentos CC.");
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

    public async Task<BaseResponseGeneric<SubTipoDocCC>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<SubTipoDocCC>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new SubTipoDocCC();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSubTipoDocCC request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CC_SUBTDOCTSMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar subtipos de Documentos CC.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new SubTipoDocCC
            {
                Id = id,
                Tipo = request.Tipo,
                Subtipo = request.Subtipo,
                Descripcion = request.Descripcion,
                CalculaImp2 = request.CalculaImp2,
                DocumentoGlobal = request.DocumentoGlobal,
                ConceptoNC = request.ConceptoNC,
                ConceptoFAC = request.ConceptoFAC,
                ConceptoND = request.ConceptoND,
                TipoDoc = request.TipoDoc,
                TipoOperacFac = request.TipoOperacFac,
                TipoOperacNC = request.TipoOperacNC,
                TipoOperacND = request.TipoOperacND,
                CentroCuentaId = request.CentroCuentaId,
                ConsecutivoFacId = request.ConsecutivoFacId,
                PaqueteId = request.PaqueteId,
                SubTipoCBId = request.SubTipoCBId,
                TipoPartidaId = request.TipoPartidaId,
                Updatedby = userId,
                UpdateDate = DateTime.Now,
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