using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class EscalaDctoService : IEscalaDctoService
{
    private readonly IEscalaDctoRepository _repository;
    private readonly ILogger<EscalaDctoService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public EscalaDctoService(IEscalaDctoRepository repository, ILogger<EscalaDctoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoEscalaDcto request, string userId, int versionNivelId, int articuloId, int numEscalaDcto, int versionDcto)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_DES_ADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear escalas de descuento.");
                response.Success = false;
                return response;
            }

            var buscarNumEscalaDcto = await _repository.BuscarNumEscalaDctoAsync(versionNivelId, articuloId, numEscalaDcto, versionDcto) ;
            if (buscarNumEscalaDcto != null)
            {
                throw new Exception($"El número de escala de descuento {buscarNumEscalaDcto.NumEscalaDcto} ya existe para el artículo { buscarNumEscalaDcto.ArticuloId } .");
            }
            response.Result = await _repository.CreateAsync(new EscalaDcto
            {
                VersionNivelId = request.VersionNivelId,
                NumEscalaDcto = request.NumEscalaDcto,
                VersionDcto = request.VersionDcto,
                ArticuloId = request.ArticuloId,
                MinUnidFact = request.MinUnidFact,
                MaxUnidFact = request.MaxUnidFact,
                PorcDcto = request.PorcDcto,
                FechaInicioEsc = request.FechaInicioEsc,
                FechaFinEsc = request.FechaFinEsc,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ESCALA_DCTO", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar escalas de descuento.");
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

    public async Task<BaseResponseGeneric<ICollection<EscalaDcto>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<EscalaDcto>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ESCALA_DCTO", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar escalas de descuento.");
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

    public async Task<BaseResponseGeneric<EscalaDcto>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<EscalaDcto>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new EscalaDcto();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEscalaDcto request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_VNP_APR_DES_MOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar escalas de descuento.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new EscalaDcto
            {
                Id = id,
                VersionNivelId = request.VersionNivelId,
                NumEscalaDcto = request.NumEscalaDcto,
                VersionDcto = request.VersionDcto,
                ArticuloId = request.ArticuloId,
                MinUnidFact = request.MinUnidFact,
                MaxUnidFact = request.MaxUnidFact,
                PorcDcto = request.PorcDcto,
                FechaInicioEsc = request.FechaInicioEsc,
                FechaFinEsc = request.FechaFinEsc,
                FechaUltModif = DateTime.Now,
                UsuarioUltModif = userId,
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