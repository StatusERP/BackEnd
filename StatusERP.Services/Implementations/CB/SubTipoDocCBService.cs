using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CB.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CB;
using StatusERP.Dto.Response;
using StatusERP.Entities.CB.Tablas;
using StatusERP.Services.Interfaces.CB;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.CB;


public class SubTipoDocCBService : ISubTipoDocCBService
{
    private readonly ISubTipoDocCBRepository _repository;
    private readonly ILogger<SubTipoDocCBService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public SubTipoDocCBService(ISubTipoDocCBRepository repository, ILogger<SubTipoDocCBService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoSubTipoDocCB request, string userId, string tipo, int subTipo)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CB_SUBTDOCTSADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear subtipos de Documentos CB.");
                response.Success = false;
                return response;
            }

            var buscarSubTipoDocCB = await _repository.BuscarSubTipoDocCBAsync(tipo, subTipo);
            if (buscarSubTipoDocCB != null)
            {
                throw new Exception($"El subtipo {buscarSubTipoDocCB.SubTipo} ya existe para el tipo {buscarSubTipoDocCB.Tipo}.");
            }
            response.Result = await _repository.CreateAsync(new SubTipoDocCB
            {
                Tipo = request.Tipo,
                SubTipo = request.SubTipo,
                Descripcion = request.Descripcion,
                CentroCuentaId = request.CentroCuentaId,
                PaqueteId = request.PaqueteId,
                TipoPartidaId = request.TipoPartidaId,
                DocumentoGlobal = request.DocumentoGlobal,
                RubroCF = request.RubroCF,
                RubroPadre = request.RubroPadre,
                FlujoCaja = request.FlujoCaja,
                NaturalezaCF = request.NaturalezaCF,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CB_SUBTDOCTSDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar subtipos de Documentos CB.");
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

    public async Task<BaseResponseGeneric<ICollection<SubTipoDocCB>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<SubTipoDocCB>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CB_SUBTDOCTS", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar subtipos de Documentos CB");
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

    public async Task<BaseResponseGeneric<SubTipoDocCB>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<SubTipoDocCB>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new SubTipoDocCB();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSubTipoDocCB request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CB_SUBTDOCTSMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar subtipos de Documentos CB.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new SubTipoDocCB
            {
                Id = id,
                Tipo = request.Tipo,
                SubTipo = request.SubTipo,
                Descripcion = request.Descripcion,
                CentroCuentaId = request.CentroCuentaId,
                PaqueteId = request.PaqueteId,
                TipoPartidaId = request.TipoPartidaId,
                DocumentoGlobal = request.DocumentoGlobal,
                RubroCF = request.RubroCF,
                RubroPadre = request.RubroPadre,
                FlujoCaja = request.FlujoCaja,
                NaturalezaCF = request.NaturalezaCF,
                IsDeleted = false,
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
