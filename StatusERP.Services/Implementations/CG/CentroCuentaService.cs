using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Interfaces.CG;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.CG
{
    public class CentroCuentaService : ICentroCuentaService
    {
        private readonly ICentroCuentaRepository _repository;
        private readonly ILogger<CentroCuentaService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;


        public CentroCuentaService(ICentroCuentaRepository repository, ILogger<CentroCuentaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCentroCuenta request, string userId, int centroCostoId, int cuentaContableId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_CENTRO_CUENTA", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para asociar centros de costo con cuentas contables.");
                    response.Success = false;
                    return response;
                }

                var buscarCentroCuenta = await _repository.BuscarCentroCuentaAsync(centroCostoId, cuentaContableId);
                if (buscarCentroCuenta != null)
                {
                    throw new Exception($"El centro de costo {buscarCentroCuenta.CentroCostoId} ya está asociado a la cuenta contable {buscarCentroCuenta.CuentaContableId}.");
                }
                response.Result = await _repository.CreateAsync(new CentroCuenta
                {
                    CentroCostoId = request.CentroCostoId,
                    CuentaContableId = request.CuentaContableId,
                    CodCentroCosto = request.CodCentroCosto,
                    CodCuentaContable = request.CodCuentaContable,
                    Activo = request.Activo,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_CENTRO_CUENTA", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar asociaciones Centro-Cuenta.");
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

        public async Task<BaseResponseGeneric<ICollection<CentroCuenta>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<CentroCuenta>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_CENTRO_CUENTA", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar asociaciones Centro-Cuenta.");
                    response.Success = false;
                    return response;
                }


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

        public async Task<BaseResponseGeneric<CentroCuenta>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<CentroCuenta>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new CentroCuenta();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCentroCuenta request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CG_CENTRO_CUENTA", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar relaciones Centro-Cuenta.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new CentroCuenta
                {
                    Id = id,
                    CentroCostoId = request.CentroCostoId,
                    CuentaContableId = request.CuentaContableId,
                    CodCentroCosto = request.CodCentroCosto,
                    CodCuentaContable = request.CodCuentaContable,
                    Activo = request.Activo,
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
}