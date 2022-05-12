using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;

namespace StatusERP.Services.Implementations.CI
{
    public class TipoPagoService : ITipoPagoService
    {
        private readonly ITipoPagoRepository _repository;
        private readonly ILogger<TipoPagoService> _logger;
        //private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public TipoPagoService(ITipoPagoRepository repository, ILogger<TipoPagoService> logger)
        {
            _repository = repository;
            _logger = logger;
            //_privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPago request, string userId, string codTipoPago)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoPagoS", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para crear TipoPagos.");
                //    response.Success = false;
                //    return response;
                //}

                var buscarCodTipoPago = await _repository.BuscarCodTipoPagoAsync(codTipoPago);
                if (buscarCodTipoPago != null)
                {
                    throw new Exception($"El codigo de tipo de pago {buscarCodTipoPago.CodTipoPago} ya existe");
                }
                response.Result = await _repository.CreateAsync(new TipoPago
                {
                    CodTipoPago = request.CodTipoPago,
                    Descripcion  = request.Descripcion,
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
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoPagoSBORRA", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para eliminar TipoPagos.");
                //    response.Success = false;
                //    return response;
                //}


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

        public async Task<BaseResponseGeneric<ICollection<TipoPago>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<TipoPago>>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoPagoS", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para consultar TipoPagos.");
                //    response.Success = false;
                //    return response;
                //}


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

        public async Task<BaseResponseGeneric<TipoPago>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<TipoPago>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new TipoPago();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPago request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_TipoPagoSMOD", 9, userId);

                //if (buscarPrivilegio == null)
                //{
                //    response.Errors.Add($"No tiene privilegios para modificar TipoPagos.");
                //    response.Success = false;
                //    return response;
                //}


                response.Result = await _repository.UpdateAsync(new TipoPago
                {
                    Id = id,
                    CodTipoPago = request.CodTipoPago,
                    Descripcion  = request.Descripcion,
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