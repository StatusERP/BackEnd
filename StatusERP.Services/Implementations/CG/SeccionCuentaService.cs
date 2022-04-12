using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Services.Interfaces.CG;

namespace StatusERP.Services.Implementations.CG
{
    public class SeccionCuentaService : ISeccionCuentaService
    {
        private readonly ISeccionCuentaRepository _repository;
        private readonly ILogger<SeccionCuentaService> _logger;

        public SeccionCuentaService(ISeccionCuentaRepository repository, ILogger<SeccionCuentaService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoSeccionCuenta request, string userId, string codSeccionCuenta)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarCodSeccionCuenta = await _repository.BuscarCodSeccionCuentaAsync(codSeccionCuenta);
                if (buscarCodSeccionCuenta != null)
                {
                    throw new Exception($"El codigo de seccion {buscarCodSeccionCuenta.CodSeccionCuenta} ya existe");
                }
                response.Result = await _repository.CreateAsync(new SeccionCuenta
                {
                    CodSeccionCuenta = request.CodSeccionCuenta,
                    TipoSeccion = request.TipoSeccion,
                    Descripcion = request.Descripcion,
                    Acumulado = request.Acumulado,
                    Secuencia = request.Secuencia,
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

        public async Task<BaseResponseGeneric<ICollection<SeccionCuenta>>> GetAsync(int page, int rows)
        {
            var response = new BaseResponseGeneric<ICollection<SeccionCuenta>>();
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

        public async Task<BaseResponseGeneric<SeccionCuenta>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<SeccionCuenta>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new SeccionCuenta();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSeccionCuenta request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                response.Result = await _repository.UpdateAsync(new SeccionCuenta
                {
                    Id = id,
                    CodSeccionCuenta = request.CodSeccionCuenta,
                    TipoSeccion = request.TipoSeccion,
                    Descripcion = request.Descripcion,
                    Acumulado = request.Acumulado,
                    Secuencia = request.Secuencia,
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