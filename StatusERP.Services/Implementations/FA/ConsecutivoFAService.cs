using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class ConsecutivoFAService : IConsecutivoFAService
{
    private readonly IConsecutivoFARepository _repository;
    private readonly ILogger<ConsecutivoFAService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public ConsecutivoFAService(IConsecutivoFARepository repository, ILogger<ConsecutivoFAService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoFA request, string userId, string codConsecutivo)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_IMPADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Consecutivos de Facturación.");
                response.Success = false;
                return response;
            }

            var buscarCodConsecutivoFA = await _repository.BuscarCodConsecutivoFAAsync(codConsecutivo);
            if (buscarCodConsecutivoFA != null)
            {
                throw new Exception($"El código de consecutivo {buscarCodConsecutivoFA.CodConsecutivo} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new ConsecutivoFA
            {
                CodConsecutivo = request.CodConsecutivo,
                UsuarioUlt = request.UsuarioUlt,
                Descripcion = request.Descripcion,
                Tipo = request.Tipo,
                Longitud = request.Longitud,
                ValorConsecutivo = request.ValorConsecutivo,
                Mascara = request.Mascara,
                FechaHoraUlt = request.FechaHoraUlt,
                Formato = request.Formato,
                ValorMaximo = request.ValorMaximo,
                NumeroCopias = request.NumeroCopias,
                Original = request.Original,
                Copia1 = request.Copia1,
                Copia2 = request.Copia2,
                Copia3 = request.Copia3,
                Copia4 = request.Copia4,
                Copia5 = request.Copia5,
                Reimpresion = request.Reimpresion,
                Resolucion = request.Resolucion,
                Serie = request.Serie,
                DeConsRPT = request.DeConsRPT,
                ValorInicial = request.ValorInicial,
                DeCCRPT = request.DeCCRPT,
                MatriculaMercantil = request.MatriculaMercantil,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_IMPDEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Consecutivos de Facturación.");
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

    public async Task<BaseResponseGeneric<ICollection<ConsecutivoFA>>> GetAsync(string userId)
    {
        var response = new BaseResponseGeneric<ICollection<ConsecutivoFA>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_CONSE", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Consecutivos de Facturación.");
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

    public async Task<BaseResponseGeneric<ConsecutivoFA>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<ConsecutivoFA>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new ConsecutivoFA();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoFA request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_IMPMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Consecutivos de Facturación");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new ConsecutivoFA
            {
                Id = id,
                CodConsecutivo = request.CodConsecutivo,
                UsuarioUlt = request.UsuarioUlt,
                Descripcion = request.Descripcion,
                Tipo = request.Tipo,
                Longitud = request.Longitud,
                ValorConsecutivo = request.ValorConsecutivo,
                Mascara = request.Mascara,
                FechaHoraUlt = request.FechaHoraUlt,
                Formato = request.Formato,
                ValorMaximo = request.ValorMaximo,
                NumeroCopias = request.NumeroCopias,
                Original = request.Original,
                Copia1 = request.Copia1,
                Copia2 = request.Copia2,
                Copia3 = request.Copia3,
                Copia4 = request.Copia4,
                Copia5 = request.Copia5,
                Reimpresion = request.Reimpresion,
                Resolucion = request.Resolucion,
                Serie = request.Serie,
                DeConsRPT = request.DeConsRPT,
                ValorInicial = request.ValorInicial,
                DeCCRPT = request.DeCCRPT,
                MatriculaMercantil = request.MatriculaMercantil,
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