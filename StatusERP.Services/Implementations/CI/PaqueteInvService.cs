using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class PaqueteInvService : IPaqueteInvService
    {
        private readonly IPaqueteInvRepository _repository;
        private readonly ILogger<PaqueteInvService> _logger;
     
        public PaqueteInvService(IPaqueteInvRepository repository, ILogger<PaqueteInvService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPaqueteInv request, string userId, string codPaqueteInv)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                
                var buscarCodPaqueteInv = await _repository.BuscarCodPaqueteInvAsync(codPaqueteInv);
                if (buscarCodPaqueteInv != null)
                {
                    throw new Exception($"El paquete de inventario {buscarCodPaqueteInv.CodPaqueteInv} ya existe");
                }
                response.Result = await _repository.CreateAsync(new PaqueteInv
                {
                    CodPaqueteInv = request.CodPaqueteInv,
                    Descripcion = request.Descripcion,
                    UltimoUsuario = request.UltimoUsuario,
                    UsuarioCreador = request.UsuarioCreador,
                    FechaUltAcceso = request.FechaUltAcceso,
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

        public async Task<BaseResponseGeneric<ICollection<PaqueteInv>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<PaqueteInv>>();
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

        public async Task<BaseResponseGeneric<PaqueteInv>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<PaqueteInv>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new PaqueteInv();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPaqueteInv request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                response.Result = await _repository.UpdateAsync(new PaqueteInv
                {
                    Id = id,
                    CodPaqueteInv = request.CodPaqueteInv,
                    Descripcion = request.Descripcion,
                    UltimoUsuario = request.UltimoUsuario,
                    UsuarioCreador = request.UsuarioCreador,
                    FechaUltAcceso = request.FechaUltAcceso,
                    IsDeleted = false,
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


