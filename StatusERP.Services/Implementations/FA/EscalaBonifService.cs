using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class EscalaBonifService : IEscalaBonifService
{
    private readonly IEscalaBonifRepository _repository;
    private readonly ILogger<EscalaBonifService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public EscalaBonifService(IEscalaBonifRepository repository, ILogger<EscalaBonifService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoEscalaBonif request, string userId, int versionNivelId, int articuloId, int numEscalaBonif, int versionBonif)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_BON_ADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear escalas de bonificaciones.");
                response.Success = false;
                return response;
            }

            var buscarNumEscalaBonif = await _repository.BuscarNumEscalaBonifAsync(versionNivelId, articuloId, numEscalaBonif, versionBonif) ;
            if (buscarNumEscalaBonif != null)
            {
                throw new Exception($"El número de escala de bonificaciones {buscarNumEscalaBonif.NumEscalaBonif} ya existe para el artículo { buscarNumEscalaBonif.ArticuloId } .");
            }
            response.Result = await _repository.CreateAsync(new EscalaBonif
            {
                VersionNivelId = request.VersionNivelId,
                NumEscalaBonif = request.NumEscalaBonif,
                VersionBonif = request.VersionBonif,
                ArticuloId = request.ArticuloId,
                ArticuloBonifId = request.ArticuloBonifId,
                MinArtFact = request.MinArtFact,
                MaxArtFact = request.MaxArtFact,
                UnidadesBonif = request.UnidadesBonif,
                FechaInicioEsc = request.FechaInicioEsc,
                FechaFinEsc = request.FechaFinEsc,
                FactorBonif = request.FactorBonif,
                FechaUltModif = request.FechaUltModif,
                UsuarioUltModif = request.UsuarioUltModif,
                IsDeleted = false,
                Updatedby = userId,
                UpdateDate = DateTime.Now,
                Createdby = userId,
                CreateDate = DateTime.Now
            }); ;
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ESCALA_BONIF", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar escalas de bonificaciones.");
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

    public async Task<BaseResponseGeneric<ICollection<EscalaBonif>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<EscalaBonif>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ESCALA_BONIF", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar escalas de bonificaciones.");
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

    public async Task<BaseResponseGeneric<EscalaBonif>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<EscalaBonif>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new EscalaBonif();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEscalaBonif request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_BON_MOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar escalas de bonificaciones.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new EscalaBonif
            {
                Id = id,
                VersionNivelId = request.VersionNivelId,
                NumEscalaBonif = request.NumEscalaBonif,
                VersionBonif = request.VersionBonif,
                ArticuloId = request.ArticuloId,
                ArticuloBonifId = request.ArticuloBonifId,
                MinArtFact = request.MinArtFact,
                MaxArtFact = request.MaxArtFact,
                UnidadesBonif = request.UnidadesBonif,
                FechaInicioEsc = request.FechaInicioEsc,
                FechaFinEsc = request.FechaFinEsc,
                FactorBonif = request.FactorBonif,
                FechaUltModif = request.FechaUltModif,
                UsuarioUltModif = request.UsuarioUltModif,
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