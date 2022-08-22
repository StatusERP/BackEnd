using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS
{
    public class MonedaService : IMonedaService
    {
        private readonly IMonedaRepository _repository;
        private readonly ILogger<MonedaService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public MonedaService(IMonedaRepository repository, ILogger<MonedaService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMoneda request, string userId, string codMoneda)

        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_MONEDAADD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear Monedas.");
                    response.Success = false;
                    return response;
                }

                var buscarMoneda = await _repository.BuscarCodMonedaAsync(codMoneda);
                if (buscarMoneda != null)
                {
                    throw new Exception($"El código de Moneda {buscarMoneda.CodMoneda} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new Moneda
                {
                    CodMoneda = request.CodMoneda,
                    Nombre = request.Nombre,
                    CodigoISO = request.CodigoISO,
                    Activa = request.Activa,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_MONEDADEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar Monedas.");
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

        public async Task<BaseResponseGeneric<ICollection<Moneda>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Moneda>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_MONEDAS", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar Monedas.");
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

        public async Task<BaseResponseGeneric<Moneda>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Moneda>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Moneda();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMoneda request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_MONEDAMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar Monedas.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new Moneda
                {
                    Id = id,
                    CodMoneda = request.CodMoneda,
                    Nombre = request.Nombre,
                    CodigoISO = request.CodigoISO,
                    Activa = request.Activa,
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