using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Interfaces.CG;

namespace StatusERP.Services.Implementations.CG
{
    public class CuentaContableService : ICuentaContableService
    {
        private readonly ICuentaContableRepository _repository;
        private readonly ILogger<CuentaContableService> _logger;

        public CuentaContableService(ICuentaContableRepository repository, ILogger<CuentaContableService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCuentaContable request, string userId, string codCuentaContable)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarCodCuentaContable = await _repository.BuscarCodCuentaContableAsync(codCuentaContable);
                if (buscarCodCuentaContable != null)
                {
                    throw new Exception($"El codigo de cuenta contable {buscarCodCuentaContable.CodCuentaContable} ya existe");
                }
                response.Result = await _repository.CreateAsync(new CuentaContable
                {
                    CodCuentaContable = request.CodCuentaContable,
                    SeccionCuenta = request.SeccionCuenta,
                    Descripcion = request.Descripcion,
                    Tipo = request.Tipo,
                    TipoDetallado = request.TipoDetallado,
                    SaldoNormal = request.SaldoNormal,
                    Conversion = request.Conversion,
                    TipoCambio = request.TipoCambio,
                    AceptaDatos = request.AceptaDatos,
                    UsaCentroCosto  = request.UsaCentroCosto,
                    Notas = request.Notas,
                    UsoRestringido = request.UsoRestringido,
                    OrigenConversion = request.OrigenConversion,
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

        public async Task<BaseResponseGeneric<ICollection<CuentaContable>>> GetAsync(int page, int rows)
        {
            var response = new BaseResponseGeneric<ICollection<CuentaContable>>();
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

        public async Task<BaseResponseGeneric<CuentaContable>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<CuentaContable>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new CuentaContable();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCuentaContable request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                response.Result = await _repository.UpdateAsync(new CuentaContable
                {
                    Id = id,
                    CodCuentaContable = request.CodCuentaContable,
                    Descripcion = request.Descripcion,
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
    }
}