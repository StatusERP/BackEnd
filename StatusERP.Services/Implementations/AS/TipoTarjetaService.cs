using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;


public class TipoTarjetaService : ITipoTarjetaService
{
    private readonly ITipoTarjetaRepository _repository;
    private readonly ILogger<TipoTarjetaService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public TipoTarjetaService(ITipoTarjetaRepository repository, ILogger<TipoTarjetaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoTarjeta request, string userId, string codTipoTarjeta)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_TIPO_TARJADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear tipos de Tarjeta.");
                response.Success = false;
                return response;
            }

            var buscarCodTipoTarjeta = await _repository.BuscarCodTipoTarjetaAsync(codTipoTarjeta);
            if (buscarCodTipoTarjeta != null)
            {
                throw new Exception($"El código de tipo de Tarjeta {buscarCodTipoTarjeta.CodTipoTarjeta} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new TipoTarjeta
            {
                CodTipoTarjeta = request.CodTipoTarjeta,
                TipoCobro= request.TipoCobro,
                AssemblyInvocation = request.AssemblyInvocation,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_TIPO_TARJDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar tipos de Tarjeta.");
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

    public async Task<BaseResponseGeneric<ICollection<TipoTarjeta>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<TipoTarjeta>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_TIPO_TARJ", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar tipos de Tarjeta.");
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

    public async Task<BaseResponseGeneric<TipoTarjeta>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<TipoTarjeta>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new TipoTarjeta();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoTarjeta request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_TIPO_TARJMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar tipos de Tarjeta.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new TipoTarjeta
            {
                Id = id,
                CodTipoTarjeta = request.CodTipoTarjeta,
                TipoCobro = request.TipoCobro,
                AssemblyInvocation = request.AssemblyInvocation,
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

